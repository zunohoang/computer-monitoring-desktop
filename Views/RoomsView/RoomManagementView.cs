using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Rooms;

namespace computer_monitoring_desktop.Views
{
    public partial class RoomManagementView : UserControl
    {
        private List<ExamRoom> rooms = new();
        private ExamRoom? selectedRoom;
        private AuditAttempt? selectedAttempt;

        public RoomManagementView()
        {
            InitializeComponent();

            lstRooms.FormattingEnabled = true;
            lstRooms.DisplayMember = nameof(ExamRoom.AccessCode);
            lstRooms.ValueMember = nameof(ExamRoom.Id);
            lstRooms.Format += LstRooms_Format;
            lstRooms.SelectedIndexChanged += LstRooms_SelectedIndexChanged;

            lvContestants.ItemSelectionChanged += LvContestants_ItemSelectionChanged;
            lvContestants.ItemActivate += (_, __) =>
            {
                if (lvContestants.SelectedItems.Count > 0 &&
                    lvContestants.SelectedItems[0].Tag is AuditAttempt attempt)
                {
                    NavigateToLogs(attempt);
                }
            };

            LoadRooms();
        }

        private void LoadRooms()
        {
            rooms = RoomMockModel.Rooms.ToList();
            lstRooms.DataSource = rooms;
            lblRoomsTitle.Text = $"Phong thi ({rooms.Count})";
            lblHint.Text = "Chon thi sinh de mo man hinh log chi tiet. Nhan nut Back de quay lai.";

            if (rooms.Count > 0)
            {
                lstRooms.SelectedIndex = 0;
            }
            else
            {
                lblContestantsTitle.Text = "Thi sinh";
                ResetDetails("Chua co phong thi");
            }
        }

        private void LstRooms_Format(object? sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is ExamRoom room)
            {
                var attemptCount = RoomMockModel.GetAttemptCount(room.Id);
                e.Value = $"{room.AccessCode} ({attemptCount}/{room.Capacity})";
            }
        }

        private void LstRooms_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstRooms.SelectedItem is not ExamRoom room)
            {
                selectedRoom = null;
                lvContestants.Items.Clear();
                ResetDetails("Chua chon phong thi");
                return;
            }

            selectedRoom = room;
            lblRoomsTitle.Text = $"Phong thi ({rooms.Count})";
            lblContestantsTitle.Text = $"Thi sinh - {room.AccessCode}";

            LoadContestants(room);
        }

        private void LoadContestants(ExamRoom room)
        {
            lvContestants.BeginUpdate();
            lvContestants.Items.Clear();

            var attempts = AuditMockModel.GetAttemptsByRoom(room.Id);
            foreach (var attempt in attempts)
            {
                var item = new ListViewItem(attempt.StudentCode)
                {
                    Tag = attempt
                };
                item.SubItems.Add(attempt.StudentName);
                item.SubItems.Add(attempt.MachineName);
                lvContestants.Items.Add(item);
            }

            lvContestants.EndUpdate();

            var attemptCount = attempts.Count;
            lblHint.Text = attemptCount > 0
                ? $"Phong {room.AccessCode}: {attemptCount}/{room.Capacity} thi sinh. Chon mot dong de xem log chi tiet."
                : "Phong nay chua co thi sinh nao tham gia.";
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
                    mainWindow.LoadAuditDetailView(attempt.Id);
                }));
            }
            else
            {
                AntdUI.Message.warn(FindForm(), "Khong the mo log chi tiet ngay bay gio. Vui long thu lai.");
            }
        }

        private void ResetDetails(string message)
        {
            lblHint.Text = message;
            selectedAttempt = null;
        }
    }
}
