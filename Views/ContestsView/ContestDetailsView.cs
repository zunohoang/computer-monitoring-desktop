using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Models;
using computer_monitoring_desktop.Models.Contest;
using computer_monitoring_desktop.Models.Rooms;
using computer_monitoring_desktop.Services;
using computer_monitoring_desktop.Data;

namespace computer_monitoring_desktop.Views.Contests
{
    public partial class ContestDetailsView : UserControl
    {
        private List<ExamRoom> allRooms;
        private List<Participant> allParticipants;
        private string currentContestId;
        private int participantPageSize = 10;
        private int participantCurrentPage = 1;
        private int roomPageSize = 10;
        private int roomCurrentPage = 1;

        public ContestDetailsView(string id, string contestName = null)
        {
            InitializeComponent();
            
            currentContestId = id;
            
            if (!string.IsNullOrEmpty(contestName))
                SetContestName(contestName);

            LoadContestDetails(id);
            LoadStatsAndParticipants(id);
            LoadRoomsTable();
            BindEvent();
        }
        private void AdjustStatCardsTableHeight()
        {
            if (statCardsTable == null || statCardsTable.Controls.Count == 0) return;

            int cardWidth = 300;
            int cardHeight = 177;
            int gap = 16;
            int margin = 15;
            int availableWidth = statCardsTable.Width;
            int cardsPerRow = Math.Max(1, (availableWidth + gap) / (cardWidth + margin + gap));
            int totalRows = (int)Math.Ceiling((double)statCardsTable.Controls.Count / cardsPerRow);
            int totalHeight = totalRows * cardHeight + (totalRows - 1) * gap;

            statCardsTable.Height = totalHeight;
        }

        private void StatCardsTable_Resize(object sender, EventArgs e)
        {
            AdjustStatCardsTableHeight();
        }

        private void BindEvent()
        {
            // Resize event for stat cards
            statCardsTable.Resize += StatCardsTable_Resize;
            this.Load += (s, e) => AdjustStatCardsTableHeight();

            // Participants pagination events
            pgnParticipants.ValueChanged += PgnParticipants_ValueChanged;
            pgnParticipants.ShowSizeChanger = true;

            // Rooms pagination events
            pgnRoomsTable.ValueChanged += PgnRoomsTable_ValueChanged;
            pgnRoomsTable.ShowSizeChanger = true;

            // Room table button click event (if needed in future)
            // tblRooms.CellButtonClick += TblRooms_CellButtonClick;
        }

        private void PgnParticipants_ValueChanged(object sender, PagePageEventArgs e)
        {
            participantCurrentPage = e.Current;
            if (e.PageSize != participantPageSize)
            {
                participantPageSize = e.PageSize;
            }
            UpdateParticipantsTable();
        }

        private void PgnRoomsTable_ValueChanged(object sender, PagePageEventArgs e)
        {
            roomCurrentPage = e.Current;
            if (e.PageSize != roomPageSize)
            {
                roomPageSize = e.PageSize;
            }
            UpdateRoomsTable();
        }

        

        private void LoadStatsAndParticipants(string id)
        {
            var contestDetails = DataClass.ContestDetailsList.FirstOrDefault(c => c.Id == id);
            if (contestDetails == null) return;

            // Load stats from ContestDetails
            lblStatRooms.Text = $"{contestDetails.TotalRooms}";
            lblStatCapacity.Text = $"{contestDetails.TotalCapacity}";
            lblStatCurrent.Text = $"{contestDetails.CurrentParticipants}";
            lblStatViolations.Text = $"{contestDetails.Violations}";

            // Store all participants
            allParticipants = contestDetails.Participants ?? new List<Participant>();

            // Participants table
            tblParticipants.Columns = new ColumnCollection() {
                new Column("STT", "STT") {
                    Render = (value, record, rowIndex) => ((participantCurrentPage - 1) * participantPageSize + rowIndex + 1),
                    Fixed = true
                },
                new Column("StudentId", "Mã sinh viên", ColumnAlign.Center),
                new Column("Name", "Họ tên", ColumnAlign.Center),
                new Column("Action", "Thao tác", ColumnAlign.Center) {
                    Fixed = true,
                    Render = (value, record, rowIndex) => new CellButton("Delete", "Xóa", TTypeMini.Error),
                }
            };
            
            pgnParticipants.Total = allParticipants.Count;
            pgnParticipants.PageSize = participantPageSize;
            pgnParticipants.Current = 1;
            
            UpdateParticipantsTable();
        }

        

        private void UpdateParticipantsTable()
        {
            if (allParticipants == null) return;

            var pagedParticipants = allParticipants
                .Skip((participantCurrentPage - 1) * participantPageSize)
                .Take(participantPageSize)
                .ToList();

            tblParticipants.DataSource = pagedParticipants;
        }

        private void LoadContestDetails(string id)
        {
            var contestDetails = DataClass.ContestDetailsList.FirstOrDefault(c => c.Id == id);
            if (contestDetails == null) return;

            lblContestIdValue.Text = contestDetails.Id;
            lblContestDescValue.Text = contestDetails.Description;
            lblContestStartValue.Text = contestDetails.StartTime;
            lblContestEndValue.Text = contestDetails.EndTime;
            lblContestCreatorValue.Text = contestDetails.Creator;
            lblContestCreatedValue.Text = contestDetails.CreatedAt;
            lblContestStatusValue.Text = contestDetails.Status;
        }

        public void SetContestName(string name)
        {
            lblContestName.Text = name;
        }

        private void LoadRoomsTable()
        {
            // Store all rooms
            allRooms = DataClass.ExamRooms.ToList();

            tblRooms.Columns.Clear();
            tblRooms.FixedHeader = true;
            tblRooms.Bordered = true;
            tblRooms.AutoSizeColumnsMode = ColumnsMode.Auto;
            tblRooms.VisibleHeader = true;
            tblRooms.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tblRooms.RowSelectedFore = Color.Black;

            tblRooms.Columns.Add(new Column("STT", "STT") { 
                Align = ColumnAlign.Center,
                Fixed = true
            });
            tblRooms.Columns.Add(new Column("Id", "ID") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("AccessCode", "Mã phòng") { Align = ColumnAlign.Left });
            tblRooms.Columns.Add(new Column("Name", "Tên phòng") { Align = ColumnAlign.Left });
            tblRooms.Columns.Add(new Column("Capacity", "Sức chứa") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("AutoApprove", "Chế độ duyệt") { 
                Align = ColumnAlign.Center,
                Render = (record, value, rowIndex) => {
                    bool autoApprove = value is bool b && b;
                    return autoApprove ? "Tự động" : "Thủ công";
                }
            });
            tblRooms.Columns.Add(new Column("ContestName", "Cuộc thi") { Align = ColumnAlign.Left });
            tblRooms.Columns.Add(new Column("Actions", "Thao tác")
            {
                Align = ColumnAlign.Center,
                Fixed = true,
                Render = (record, value, rowIndex) => {
                    var btn = new CellButton("Detail", "Chi tiết", TTypeMini.Primary)
                    {
                        Ghost = false,
                    };
                    return btn;
                }
            });

            pgnRoomsTable.Total = allRooms.Count;
            pgnRoomsTable.PageSize = roomPageSize;
            pgnRoomsTable.Current = 1;

            UpdateRoomsTable();
        }

        private void UpdateRoomsTable()
        {
            if (allRooms == null) return;

            var pagedRooms = allRooms
                .Skip((roomCurrentPage - 1) * roomPageSize)
                .Take(roomPageSize)
                .ToList();

            // Transform data with STT
            var tableData = pagedRooms.Select((room, index) => new
            {
                STT = (roomCurrentPage - 1) * roomPageSize + index + 1,
                Id = room.Id,
                AccessCode = room.AccessCode,
                Name = room.Name,
                Capacity = room.Capacity,
                AutoApprove = room.AutoApprove,
                ContestName = room.ContestName,
                Room = room
            }).ToList();

            tblRooms.DataSource = tableData;
        }
    }
}