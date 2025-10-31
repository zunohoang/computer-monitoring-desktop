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
using computer_monitoring_desktop.Services;

namespace computer_monitoring_desktop.Views.Contests
{
    public partial class ContestDetailsView : UserControl
    {
        private List<Room> allRooms;
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
            if (!string.IsNullOrEmpty(contestName))
                SetContestName(contestName);

            LoadContestDetails(id);
            LoadStatsAndParticipants(id);
            LoadRoomsTable();
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
            tblRooms.Columns.Add(new Column("RoomCode", "Mã phòng") { Align = ColumnAlign.Left });
            tblRooms.Columns.Add(new Column("Capacity", "Sức chứa") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("CurrentParticipants", "Số thí sinh") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("ApprovalMode", "Chế độ duyệt") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("RegisterTime", "Thời gian đăng ký") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("ExamTime", "Thời gian thi") { Align = ColumnAlign.Center });
            tblRooms.Columns.Add(new Column("Actions", "Thao tác") {
                Align = ColumnAlign.Center,
                Render = (record, value, rowIndex) => {
                    var btn = new CellButton("Detail", "Chi tiết", TTypeMini.Primary) {
                        Ghost = false,
                    };
                    return btn;
                }
            });

            var rooms = details.Rooms.Select((r, idx) => new {
                Id = (idx + 1).ToString(),
                r.RoomCode,
                r.Capacity,
                r.CurrentParticipants,
                r.ApprovalMode,
                r.RegisterTime,
                r.ExamTime,

            }).ToList();

            tblRooms.DataSource = rooms;
        }
    }
}
