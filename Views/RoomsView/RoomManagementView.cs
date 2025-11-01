using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Rooms;
using computer_monitoring_desktop.Models.Repositories;
using computer_monitoring_desktop.Data;

namespace computer_monitoring_desktop.Views
{
    // Load sau khi người dung nhấn vào tab này (data đi từ form MainWindow.cs)
    public partial class RoomManagementView : UserControl
    {
        #region Private Fields
        
        private readonly IRoomRepository roomRepo;
        private List<ExamRoom> allRooms = new();
        private List<AuditAttempt> allAttempts = new();
        private ExamRoom? selectedRoom;
        
        // Pagination state
        private int contestantPageSize = 10;
        private int contestantCurrentPage = 1;
        
        #endregion

        #region Constructor
        
        public RoomManagementView()
            : this(new InMemoryRoomRepository())
        {
        }

        internal RoomManagementView(IRoomRepository repository)
        {
            roomRepo = repository ?? throw new ArgumentNullException(nameof(repository));

            InitializeComponent();
            
            InitializeRoomsTable();
            InitializeContestantsTable();
            BindEvents();
            LoadRooms();
        }
        
        #endregion

        #region Event Binding
        
        private void BindEvents()
        {
            // Pagination events
            pgnContestants.ValueChanged += PgnContestants_ValueChanged;
            pgnContestants.ShowSizeChanger = true;
            
            // Table events
            tblRooms.CellClick += TblRooms_CellClick;
            tblContestants.CellButtonClick += TblContestants_CellButtonClick;
        }
        
        #endregion

        #region Pagination Event Handlers
        
        private void PgnContestants_ValueChanged(object sender, PagePageEventArgs e)
        {
            contestantCurrentPage = e.Current;
            if (e.PageSize != contestantPageSize)
            {
                contestantPageSize = e.PageSize;
            }
            UpdateContestantsTable();
        }
        
        #endregion

        #region Table Initialization
        
        private void InitializeRoomsTable()
        {
            tblRooms.Columns = new ColumnCollection()
            {
                new Column("AccessCode", "Mã phòng") { Align = ColumnAlign.Left },
                new Column("Participants", "Thí sinh") { Align = ColumnAlign.Center }
            };
        }

        private void InitializeContestantsTable()
        {
            tblContestants.Columns = new ColumnCollection()
            {
                new Column("STT", "STT") { 
                    Align = ColumnAlign.Center,
                    Fixed = true
                },
                new Column("StudentCode", "MSSV") { Align = ColumnAlign.Center },
                new Column("StudentName", "Họ tên") { Align = ColumnAlign.Left },
                new Column("MachineName", "Máy trạm") { Align = ColumnAlign.Left },
                new Column("Actions", "Thao tác") {
                    Align = ColumnAlign.Center,
                    Fixed = true,
                    Render = (record, value, rowIndex) => new CellButton("ViewLog", "Xem Log", TTypeMini.Primary)
                }
            };
        }
        
        #endregion

        #region Data Loading Methods
        
        private void LoadRooms()
        {
            // Get rooms from repository
            allRooms = roomRepo.GetRooms().ToList();
            
            // Transform data for display
            var tableData = allRooms.Select(room => {
                var attemptCount = roomRepo.GetAttemptCount(room.Id);
                return new
                {
                    AccessCode = room.AccessCode,
                    Participants = $"{attemptCount}/{room.Capacity}",
                    Room = room
                };
            }).ToList();
            
            tblRooms.DataSource = tableData;
            lblRoomsTitle.Text = $"Phòng thi ({allRooms.Count})";
            
            if (allRooms.Count > 0)
            {
                // Auto-select first room
                selectedRoom = allRooms[0];
                LoadContestants(selectedRoom);
            }
            else
            {
                lblContestantsTitle.Text = "Thí sinh";
                allAttempts.Clear();
                UpdateContestantsTable();
            }
        }

        private void LoadContestants(ExamRoom room)
        {
            selectedRoom = room;
            lblContestantsTitle.Text = $"Thí sinh - {room.AccessCode}";
            
            // Get attempts from repository
            allAttempts = roomRepo.GetAttemptsByRoom(room.Id).ToList();
            
            // Setup pagination
            pgnContestants.Total = allAttempts.Count;
            pgnContestants.PageSize = contestantPageSize;
            pgnContestants.Current = 1;
            contestantCurrentPage = 1;
            
            UpdateContestantsTable();
        }

        private void UpdateContestantsTable()
        {
            if (allAttempts == null || allAttempts.Count == 0)
            {
                tblContestants.DataSource = null;
                return;
            }

            // Get current page of attempts using Skip/Take
            var pagedAttempts = allAttempts
                .Skip((contestantCurrentPage - 1) * contestantPageSize)
                .Take(contestantPageSize)
                .ToList();

            // Transform data with STT
            var tableData = pagedAttempts.Select((attempt, index) => new
            {
                STT = (contestantCurrentPage - 1) * contestantPageSize + index + 1,
                StudentCode = attempt.StudentCode,
                StudentName = attempt.StudentName,
                MachineName = attempt.MachineName,
                Attempt = attempt
            }).ToList();

            tblContestants.DataSource = tableData;
        }
        
        #endregion

        #region Table Click Handlers
        
        private void TblRooms_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Record == null) return;
            
            var recordType = e.Record.GetType();
            var roomProperty = recordType.GetProperty("Room");
            if (roomProperty != null)
            {
                var room = roomProperty.GetValue(e.Record) as ExamRoom;
                if (room != null)
                {
                    LoadContestants(room);
                }
            }
        }

        private void TblContestants_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            if (e.Record == null || e.Btn?.Id != "ViewLog") return;
            
            var recordType = e.Record.GetType();
            var attemptProperty = recordType.GetProperty("Attempt");
            if (attemptProperty != null)
            {
                var attempt = attemptProperty.GetValue(e.Record) as AuditAttempt;
                if (attempt != null)
                {
                    NavigateToLogs(attempt);
                }
            }
        }
        
        #endregion

        #region Navigation
        
        private void NavigateToLogs(AuditAttempt attempt)
        {
            if (FindForm() is MainWindow mainWindow)
            {
                mainWindow.BeginInvoke(new Action(() =>
                {
                    mainWindow.LoadAuditDetailView(attempt.Id);
                }));
            }
            else
            {
                AntdUI.Message.warn(FindForm(), "Không thể mở log chi tiết ngay bây giờ. Vui lòng thử lại.");
            }
        }
        
        #endregion
    }
}
