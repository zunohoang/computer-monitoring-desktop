using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Repositories.Room;
using computer_monitoring_desktop.Models.Rooms;
using computer_monitoring_desktop.Services.RoomServices;

namespace computer_monitoring_desktop.Views
{
    // Load sau khi người dung nhấn vào tab này (data đi từ form MainWindow.cs)
    public partial class RoomManagementView : UserControl
    {
        private readonly IRoomService roomService;
        private List<ExamRoom> rooms = new();
        private ExamRoom? selectedRoom;
        private AuditAttempt? selectedAttempt;

        public RoomManagementView() : this(new RoomService()) { }

        public RoomManagementView(IRoomService service)
        {
            roomService = service ?? throw new ArgumentNullException(nameof(service));

            InitializeComponent();

            lstRooms.FormattingEnabled = true;
            lstRooms.DisplayMember = nameof(ExamRoom.AccessCode);
            lstRooms.ValueMember = nameof(ExamRoom.Id);

            lstRooms.Format += LstRooms_Format;
            lstRooms.SelectedIndexChanged += LstRooms_SelectedIndexChanged;

            lvContestants.ItemSelectionChanged += LvContestants_ItemSelectionChanged;
            lvContestants.ItemActivate += (_, __) =>
            {
                if (lvContestants.SelectedItems.Count > 0 && lvContestants.SelectedItems[0].Tag is AuditAttempt attempt)
                {
                    NavigateToLogs(attempt);
                }
            };

            LoadRooms();
        }

        private void LoadRooms()
        {
            rooms = roomService.GetRooms().ToList();
            lstRooms.DataSource = rooms;
            lblRoomsTitle.Text = $"Phòng thi ({rooms.Count})";
            lblHint.Text = "Chọn thí sinh để mở màn hình log chi tiết. Nhấn nút back để quay lại.";

            if (rooms.Count > 0)
            {
                lstRooms.SelectedIndex = 0;
            }
            else
            {
                lblContestantsTitle.Text = "Thí sinh";
                ResetDetails("Chưa có phòng thi");
            }
        }

        private void LstRooms_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is ExamRoom room)
            {
                var attemptCount = roomService.GetAttemptCount(room.Id);
                e.Value = $"{room.AccessCode} ({attemptCount}/{room.Capacity})";
            }
        }

        private void LstRooms_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstRooms.SelectedItem is not ExamRoom room)
            {
                selectedRoom = null;
                lvContestants.Items.Clear();
                ResetDetails("Chưa chọn phòng thi");
                return;
            }

            selectedRoom = room;
            lblRoomsTitle.Text = $"Phòng thi ({rooms.Count})";
            lblContestantsTitle.Text = $"Thí sinh - {room.AccessCode}";

            LoadContestants(room);
        }

        private void LoadContestants(ExamRoom room)
        {
            lvContestants.BeginUpdate();
            lvContestants.Items.Clear();

            var attempts = roomService.GetAttemptsByRoom(room.Id);

            foreach (var attempt in attempts)
            {
                var item = new ListViewItem(attempt.StudentCode) { Tag = attempt };
                item.SubItems.Add(attempt.StudentName);
                item.SubItems.Add(attempt.MachineName);
                lvContestants.Items.Add(item);
            }

            lvContestants.EndUpdate();

            var attemptCount = attempts.Count;
            lblHint.Text = attemptCount > 0
                ? $"Phòng {room.AccessCode}: {attemptCount}/{room.Capacity} thí sinh. Chọn một dòng để xem log chi tiết."
                : "Phòng này chưa có thí sinh nào tham gia.";

            selectedAttempt = null;
        }

        private void LvContestants_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && e.Item.Tag is AuditAttempt attempt)
            {
                NavigateToLogs(attempt);
            }
        }

        private void NavigateToLogs(AuditAttempt attempt)
        {
            selectedAttempt = attempt;
            if (FindForm() is MainWindow mainWindow)
            {
                mainWindow.BeginInvoke(new Action(() =>
                {
                    mainWindow.LoadAuditDetailView(attempt);
                }));
            }
            else
            {
                AntdUI.Message.warn(FindForm(), "Không thể mở log chi tiết ngay bây giờ. Vui lòng thử lại.");
            }
        }

        private void ResetDetails(string message)
        {
            lblHint.Text = message;
            selectedAttempt = null;
        }
    }
}
