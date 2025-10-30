using System;
using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.SubViews
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            // Mock data - replace with actual data later
            lblContestsValue.Text = "0";
            lblStudentsValue.Text = "1 / 7";
            lblPendingValue.Text = "2";
            lblViolationsValue.Text = "2 / 3";
            lblRoomsValue.Text = "3";

            // Add sample violations data
            AddViolationRow("20210001", "Sinh viên 20210001 mở ứng ...", "Cao", "Đã xử lý", "08:20:00 20/10/2024", Color.FromArgb(255, 220, 220), Color.FromArgb(220, 255, 220));
            AddViolationRow("20210002", "Sinh viên 20210002 truy cập ...", "Trung bình", "Chưa xử lý", "08:15:00 20/10/2024", Color.FromArgb(255, 245, 220), Color.FromArgb(255, 245, 220));
            AddViolationRow("20210003", "Sinh viên 20210003 có hoạt d...", "Thấp", "Chưa xử lý", "09:00:00 20/10/2024", Color.FromArgb(220, 235, 255), Color.FromArgb(255, 245, 220));
        }

        private void AddViolationRow(string studentId, string description, string severity, string status, string time, Color severityBgColor, Color statusBgColor)
        {
            var rowPanel = new AntdUI.Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                Padding = new Padding(20, 10, 20, 10)
            };

            // Student ID
            var lblId = new AntdUI.Label
            {
                Text = studentId,
                Location = new Point(20, 25),
                Size = new Size(100, 20),
                Font = new Font("Segoe UI", 9F)
            };

            // Description
            var lblDesc = new AntdUI.Label
            {
                Text = description,
                Location = new Point(140, 25),
                Size = new Size(280, 20),
                Font = new Font("Segoe UI", 9F)
            };

            // Severity badge
            var pnlSeverity = new AntdUI.Panel
            {
                Location = new Point(560, 18),
                Size = new Size(90, 34),
                Radius = 6,
                Back = severityBgColor
            };
            var lblSeverity = new AntdUI.Label
            {
                Text = severity,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(100, 60, 0)
            };
            pnlSeverity.Controls.Add(lblSeverity);

            // Status badge
            var pnlStatus = new AntdUI.Panel
            {
                Location = new Point(700, 18),
                Size = new Size(110, 34),
                Radius = 6,
                Back = statusBgColor
            };
            var lblStatus = new AntdUI.Label
            {
                Text = status,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = status == "Đã xử lý" ? Color.FromArgb(0, 100, 0) : Color.FromArgb(150, 100, 0)
            };
            pnlStatus.Controls.Add(lblStatus);

            // Time
            var lblTime = new AntdUI.Label
            {
                Text = time,
                Location = new Point(900, 25),
                Size = new Size(180, 20),
                Font = new Font("Segoe UI", 9F)
            };

            rowPanel.Controls.Add(lblId);
            rowPanel.Controls.Add(lblDesc);
            rowPanel.Controls.Add(pnlSeverity);
            rowPanel.Controls.Add(pnlStatus);
            rowPanel.Controls.Add(lblTime);

            pnlViolationsContainer.Controls.Add(rowPanel);
            rowPanel.BringToFront();
        }


    }
}
