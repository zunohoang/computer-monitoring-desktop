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

namespace computer_monitoring_desktop.Views.Contests
{
    public partial class ContestDetailsView : UserControl
    {
        private List<ExamRoom> allRooms;
        private int pageSize = 10;
        private int currentPage = 1;

        public ContestDetailsView(string id, string contestName = null)
        {
            InitializeComponent();
            // Enable double buffering for pnlContestDetails to reduce flicker and lag
            typeof(AntdUI.Panel)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(pnlContestDetails, true, null);
            // Enable smooth scroll for spnContainer
            var prop = spnContainer.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (prop != null) prop.SetValue(spnContainer, true, null);
            
            // Handle statCardsTable resize for responsive wrapping
            statCardsTable.Resize += StatCardsTable_Resize;
            this.Load += (s, e) => AdjustStatCardsTableHeight();
            
            if (!string.IsNullOrEmpty(contestName))
                SetContestName(contestName);

            LoadContestDetails(id);
            LoadStatsAndParticipants(id);
            LoadRoomsTable();
        }

        private void StatCardsTable_Resize(object sender, EventArgs e)
        {
            AdjustStatCardsTableHeight();
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

        private void LoadStatsAndParticipants(string id)
        {
            var service = new ContestDetailsService();
            var details = service.GetContestDetailsById(id);
            if (details == null) return;

            lblStatRooms.Text = $"{details.TotalRooms}";
            lblStatCapacity.Text = $"{details.TotalCapacity}";
            lblStatCurrent.Text = $"{details.CurrentParticipants}";
            lblStatViolations.Text = $"{details.Violations}";

            // Participants table
            tblParticipants.Columns = new ColumnCollection() {
                new Column("STT", "STT") {
                    Render = (value, record, rowIndex) => (rowIndex + 1),
                    Fixed = true
                },
                new Column("StudentId", "Mã sinh viên", ColumnAlign.Center),
                new Column("Name", "Họ tên", ColumnAlign.Center),
                new Column("Action", "Thao tác", ColumnAlign.Center) {
                    Render = (value, record, rowIndex) => new CellButton("Delete", "Xóa", TTypeMini.Error),
                    Fixed = true
                }
            };
            if (details.Participants != null)
                tblParticipants.Binding(new BindingList<Participant>(details.Participants));
            pgnParticipants.Total = details.Participants?.Count ?? 0;
            pgnParticipants.PageSize = 10;
            pgnParticipants.Current = 1;
        }

        private void LoadContestDetails(string id)
        {
            var service = new ContestDetailsService();
            var details = service.GetContestDetailsById(id);
            if (details == null) return;

            lblContestIdValue.Text = details.Id;
            lblContestDescValue.Text = details.Description;
            lblContestStartValue.Text = details.StartTime;
            lblContestEndValue.Text = details.EndTime;
            lblContestCreatorValue.Text = details.Creator;
            lblContestCreatedValue.Text = details.CreatedAt;
            lblContestStatusValue.Text = details.Status;
        }

        public void SetContestName(string name)
        {
            lblContestName.Text = name;
        }

        private void LoadRoomsTable()
        {
            var service = new ContestDetailsService();
            var details = service.GetContestDetailsById("1");
            if (details == null || details.Rooms == null) return;

            tblRooms.Columns.Clear();
            tblRooms.FixedHeader = true;
            tblRooms.Bordered = true;
            tblRooms.AutoSizeColumnsMode = ColumnsMode.Auto;
            tblRooms.VisibleHeader = true;
            tblRooms.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tblRooms.RowSelectedFore = Color.Black;

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
                Render = (record, value, rowIndex) => {
                    var btn = new CellButton("Detail", "Chi tiết", TTypeMini.Primary)
                    {
                        Ghost = false,
                    };
                    return btn;
                }
            });

            tblRooms.DataSource = details.Rooms;
        }
    }
}