using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;

namespace computer_monitoring_desktop.Views
{
    public partial class ContestDetailsView : UserControl
    {
        private string contestId;
        private System.Windows.Forms.Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;

        public ContestDetailsView(string id)
        {
            InitializeComponent();
            contestId = id;
            InitializeCustomComponents();
            LoadContestDetails();
        }

        private void InitializeCustomComponents()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(240, 242, 245);
            this.Padding = new Padding(20);

            // Main container - use WinForms Panel for AutoScroll support
            pnlMain = new System.Windows.Forms.Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.Transparent
            };

            // Header with back button and title
            pnlHeader = new AntdUI.Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Back = Color.Transparent
            };

            var btnBack = new AntdUI.Button
            {
                Text = "← Quay lại danh sách cuộc thi",
                Type = TTypeMini.Default,
                Ghost = true,
                Location = new Point(0, 10),
                Size = new Size(200, 40),
                Font = new Font("Segoe UI", 10F)
            };
            btnBack.Click += BtnBack_Click;
            pnlHeader.Controls.Add(btnBack);

            // Content panel - use WinForms Panel for AutoScroll support
            pnlContent = new System.Windows.Forms.Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                AutoScroll = true
            };

            pnlMain.Controls.Add(pnlContent);
            pnlMain.Controls.Add(pnlHeader);
            this.Controls.Add(pnlMain);
        }

        private void LoadContestDetails()
        {
            int yPos = 10;

            // Contest title
            var lblTitle = new AntdUI.Label
            {
                Text = "Kỳ thi Olympic Tin học 2024",
                Location = new Point(20, yPos),
                Size = new Size(800, 35),
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 33, 33),
                BackColor = Color.Transparent
            };
            pnlContent.Controls.Add(lblTitle);
            yPos += 50;

            // Info panel
            var pnlInfo = CreateInfoPanel(yPos);
            pnlContent.Controls.Add(pnlInfo);
            yPos += pnlInfo.Height + 20;

            // Statistics cards
            var pnlStatsCards = CreateStatisticsCards(yPos);
            pnlContent.Controls.Add(pnlStatsCards);
            yPos += 120;

            // Participants table
            var pnlParticipantsSection = CreateParticipantsTable(yPos);
            pnlContent.Controls.Add(pnlParticipantsSection);
            yPos += pnlParticipantsSection.Height + 20;

            // Rooms table
            var pnlRoomsSection = CreateRoomsTable(yPos);
            pnlContent.Controls.Add(pnlRoomsSection);
        }

        private AntdUI.Panel CreateInfoPanel(int yPos)
        {
            var panel = new AntdUI.Panel
            {
                Location = new Point(20, yPos),
                Size = new Size(1200, 180),
                Back = Color.White,
                Shadow = 5,
                Radius = 8
            };

            int col1X = 20;
            int col2X = 420;
            int row1Y = 20;
            int row2Y = 70;
            int row3Y = 120;

            // ID
            AddInfoField(panel, "ID", "1", col1X, row1Y);
            AddInfoField(panel, "Trạng thái", "Đang hoạt động", col2X, row1Y, Color.Green);

            // Description
            AddInfoField(panel, "Mô tả", "Kỳ thi Olympic Tin học dành cho sinh viên toàn quốc lần thứ 32", col1X, row2Y, Color.Black, 750);

            // Dates
            AddInfoField(panel, "Thời gian bắt đầu", "08:00:00 20/10/2024", col1X, row3Y);
            AddInfoField(panel, "Thời gian kết thúc", "12:00:00 20/10/2024", col2X, row3Y);

            // Creator and Update date
            AddInfoField(panel, "Người tạo", "Nguyễn Văn Admin", col1X + 600, row3Y);
            AddInfoField(panel, "Ngày tạo", "10:00:00 1/10/2024", col2X + 400, row3Y);

            return panel;
        }

        private void AddInfoField(AntdUI.Panel parent, string label, string value, int x, int y, Color? valueColor = null, int maxWidth = 300)
        {
            var lblLabel = new AntdUI.Label
            {
                Text = label,
                Location = new Point(x, y),
                Size = new Size(150, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblLabel);

            var lblValue = new AntdUI.Label
            {
                Text = value,
                Location = new Point(x, y + 20),
                Size = new Size(maxWidth, 30),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = valueColor ?? Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblValue);
        }

        private AntdUI.Panel CreateStatisticsCards(int yPos)
        {
            var panel = new AntdUI.Panel
            {
                Location = new Point(20, yPos),
                Size = new Size(1200, 180),
                Back = Color.Transparent
            };

            // Horizontal layout for 4 cards
            int cardWidth = 260;
            int cardSpacing = 20;
            int startX = 0;

            // Card 1: Tổng số phòng thi
            var card1 = CreateStatCardDashboardStyle("Tổng số phòng thi", "2", "TrophyOutlined", Color.FromArgb(82, 196, 26), Color.FromArgb(82, 196, 26), startX);
            panel.Controls.Add(card1);
            startX += cardWidth + cardSpacing;

            // Card 2: Tổng cục chửa
            var card2 = CreateStatCardDashboardStyle("Tổng cục chửa", "55 người", "UserOutlined", Color.FromArgb(24, 144, 255), Color.FromArgb(24, 144, 255), startX);
            panel.Controls.Add(card2);
            startX += cardWidth + cardSpacing;

            // Card 3: Thí sinh đang thi
            var card3 = CreateStatCardDashboardStyle("Thí sinh đang thi", "1/6", "AuditOutlined", Color.FromArgb(250, 173, 20), Color.FromArgb(250, 173, 20), startX);
            panel.Controls.Add(card3);
            startX += cardWidth + cardSpacing;

            // Card 4: Tổng vi phạm
            var card4 = CreateStatCardDashboardStyle("Tổng vi phạm", "3", "FileOutlined", Color.FromArgb(255, 77, 79), Color.FromArgb(255, 77, 79), startX);
            panel.Controls.Add(card4);

            return panel;
        }

        // Helper to create a dashboard-style card (reused from DashboardView)
        private AntdUI.Panel CreateStatCardDashboardStyle(string title, string value, string iconSvg, Color iconColor, Color valueColor, int x)
        {
            var card = new AntdUI.Panel
            {
                Location = new Point(x, 0),
                Size = new Size(260, 120),
                Back = Color.White,
                BorderColor = Color.FromArgb(240, 240, 240),
                BorderWidth = 1F,
                Radius = 8,
                Shadow = 8,
                Padding = new Padding(20, 20, 20, 20)
            };

            var lblIcon = new AntdUI.Label
            {
                BackColor = Color.Transparent,
                BadgeBack = iconColor,
                BadgeSize = 1F,
                BadgeSvg = iconSvg,
                Font = new Font("Microsoft Sans Serif", 24F),
                Location = new Point(10, 10),
                Size = new Size(53, 62),
                Text = ""
            };
            card.Controls.Add(lblIcon);

            var lblTitle = new AntdUI.Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(70, 10),
                Size = new Size(170, 30),
                Text = title
            };
            card.Controls.Add(lblTitle);

            var lblValue = new AntdUI.Label
            {
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold),
                ForeColor = valueColor,
                Location = new Point(20, 55),
                Size = new Size(220, 54),
                Text = value
            };
            card.Controls.Add(lblValue);

            return card;
        }

        private void CreateStatCard(AntdUI.Panel parent, string title, string value, Color iconColor, int xOffset)
        {
            var card = new AntdUI.Panel
            {
                Location = new Point(xOffset, 0),
                Size = new Size(290, 90),
                Back = Color.White,
                Shadow = 5,
                Radius = 8
            };

            var lblTitle = new AntdUI.Label
            {
                Text = title,
                Location = new Point(15, 15),
                Size = new Size(200, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Gray,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblTitle);

            var lblValue = new AntdUI.Label
            {
                Text = value,
                Location = new Point(15, 40),
                Size = new Size(200, 30),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = iconColor,
                BackColor = Color.Transparent
            };
            card.Controls.Add(lblValue);

            parent.Controls.Add(card);
        }

        private AntdUI.Panel CreateParticipantsTable(int yPos)
        {
            var panel = new AntdUI.Panel
            {
                Location = new Point(20, yPos),
                Size = new Size(1200, 350),
                Back = Color.White,
                Shadow = 5,
                Radius = 8,
                Padding = new Padding(20)
            };

            // Title and actions
            var lblTitle = new AntdUI.Label
            {
                Text = "Danh sách Thí sinh được phép tham gia",
                Location = new Point(0, 0),
                Size = new Size(400, 25),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblTitle);

            var btnDownload = new AntdUI.Button
            {
                Text = "⬇ Tải file mẫu",
                Type = TTypeMini.Default,
                Location = new Point(830, -8),
                Size = new Size(110, 32),
                Font = new Font("Segoe UI", 9F)
            };
            panel.Controls.Add(btnDownload);

            var btnExportExcel = new AntdUI.Button
            {
                Text = "📊 Xuất Excel",
                Type = TTypeMini.Default,
                Location = new Point(950, -8),
                Size = new Size(110, 32),
                Font = new Font("Segoe UI", 9F)
            };
            panel.Controls.Add(btnExportExcel);

            var btnImportExcel = new AntdUI.Button
            {
                Text = "📥 Import Excel",
                Type = TTypeMini.Primary,
                Location = new Point(1070, -8),
                Size = new Size(110, 32),
                Font = new Font("Segoe UI", 9F)
            };
            panel.Controls.Add(btnImportExcel);

            var btnAddStudent = new AntdUI.Button
            {
                Text = "+ Thêm thí sinh",
                Type = TTypeMini.Primary,
                Location = new Point(980, 12),
                Size = new Size(120, 32),
                Font = new Font("Segoe UI", 9F)
            };
            panel.Controls.Add(btnAddStudent);

            // Table header
            var pnlTableHeader = new AntdUI.Panel
            {
                Location = new Point(20, 55),
                Size = new Size(1160, 40),
                Back = Color.FromArgb(250, 250, 250)
            };

            AddTableHeaderLabel(pnlTableHeader, "STT", 10, 140);
            AddTableHeaderLabel(pnlTableHeader, "Mã sinh viên", 150, 200);
            AddTableHeaderLabel(pnlTableHeader, "Họ tên", 350, 300);
            AddTableHeaderLabel(pnlTableHeader, "Thao tác", 950, 200);

            panel.Controls.Add(pnlTableHeader);

            // Table rows
            string[][] participants = new string[][]
            {
                new string[] { "1", "2U2100001", "Nguyễn Văn A" },
                new string[] { "2", "20210002", "Trần Thị B" },
                new string[] { "3", "2U2100011", "Lê Văn C" },
                new string[] { "4", "20210004", "Hoàng Văn E" },
                new string[] { "5", "2U2100015", "Vũ Thị F" },
                new string[] { "6", "20210006", "Đặng Văn G" }
            };

            int rowY = 100;
            foreach (var participant in participants)
            {
                AddParticipantRow(panel, participant[0], participant[1], participant[2], rowY);
                rowY += 40;
            }

            return panel;
        }

        private void AddTableHeaderLabel(AntdUI.Panel parent, string text, int x, int width)
        {
            var lbl = new AntdUI.Label
            {
                Text = text,
                Location = new Point(x, 10),
                Size = new Size(width, 20),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 100, 100),
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lbl);
        }

        private void AddParticipantRow(AntdUI.Panel parent, string stt, string studentId, string name, int y)
        {
            var lblStt = new AntdUI.Label
            {
                Text = stt,
                Location = new Point(30, y),
                Size = new Size(140, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblStt);

            var lblStudentId = new AntdUI.Label
            {
                Text = studentId,
                Location = new Point(170, y),
                Size = new Size(200, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblStudentId);

            var lblName = new AntdUI.Label
            {
                Text = name,
                Location = new Point(370, y),
                Size = new Size(300, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblName);

            var btnDelete = new AntdUI.Button
            {
                Text = "🗑 Xóa",
                Type = TTypeMini.Error,
                Ghost = true,
                Location = new Point(970, y - 5),
                Size = new Size(70, 28),
                Font = new Font("Segoe UI", 8F)
            };
            parent.Controls.Add(btnDelete);
        }

        private AntdUI.Panel CreateRoomsTable(int yPos)
        {
            var panel = new AntdUI.Panel
            {
                Location = new Point(20, yPos),
                Size = new Size(1200, 350),
                Back = Color.White,
                Shadow = 5,
                Radius = 8,
                Padding = new Padding(20)
            };

            // Title
            var lblTitle = new AntdUI.Label
            {
                Text = "Danh sách Phòng thi",
                Location = new Point(0, 0),
                Size = new Size(400, 25),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            panel.Controls.Add(lblTitle);

            // Table header
            var pnlTableHeader = new AntdUI.Panel
            {
                Location = new Point(0, 40),
                Size = new Size(1160, 40),
                Back = Color.FromArgb(250, 250, 250)
            };

            AddTableHeaderLabel(pnlTableHeader, "ID", 10, 100);
            AddTableHeaderLabel(pnlTableHeader, "Mã phòng", 110, 150);
            AddTableHeaderLabel(pnlTableHeader, "Sức chứa", 260, 120);
            AddTableHeaderLabel(pnlTableHeader, "Số thí sinh", 380, 150);
            AddTableHeaderLabel(pnlTableHeader, "Chế độ duyệt", 530, 150);
            AddTableHeaderLabel(pnlTableHeader, "Thời gian đăng ký", 680, 180);
            AddTableHeaderLabel(pnlTableHeader, "Thời gian thi", 860, 200);
            AddTableHeaderLabel(pnlTableHeader, "Thao tác", 1060, 100);

            panel.Controls.Add(pnlTableHeader);

            // Table rows
            AddRoomRow(panel, "1", "ROOM001", "30", "2/30 (7%)", "Tự động", "10/10/2024\n06/10/2024", "20/10/2024 08:00\n20/10/2024 12:00", "Chi tiết", 85);
            AddRoomRow(panel, "2", "ROOM002", "25", "4/25 (16%)", "Thủ công", "15/10/2024\n08/10/2024", "20/10/2024 08:00\n20/10/2024 12:00", "Chi tiết", 145);

            return panel;
        }

        private void AddRoomRow(AntdUI.Panel parent, string id, string roomCode, string capacity, string students, string mode, string regTime, string examTime, string action, int y)
        {
            var lblId = new AntdUI.Label
            {
                Text = id,
                Location = new Point(30, y),
                Size = new Size(100, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblId);

            var lblRoomCode = new AntdUI.Label
            {
                Text = roomCode,
                Location = new Point(130, y),
                Size = new Size(150, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Blue,
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblRoomCode);

            var lblCapacity = new AntdUI.Label
            {
                Text = capacity,
                Location = new Point(280, y),
                Size = new Size(120, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblCapacity);

            var lblStudents = new AntdUI.Label
            {
                Text = students,
                Location = new Point(400, y),
                Size = new Size(150, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblStudents);

            var lblMode = new AntdUI.Label
            {
                Text = mode,
                Location = new Point(550, y),
                Size = new Size(150, 20),
                Font = new Font("Segoe UI", 9F),
                ForeColor = mode == "Tự động" ? Color.Green : Color.Orange,
                BackColor = mode == "Tự động" ? Color.FromArgb(230, 255, 230) : Color.FromArgb(255, 245, 230),
                TextAlign = ContentAlignment.MiddleCenter
            };
            parent.Controls.Add(lblMode);

            var lblRegTime = new AntdUI.Label
            {
                Text = regTime,
                Location = new Point(700, y - 5),
                Size = new Size(180, 40),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblRegTime);

            var lblExamTime = new AntdUI.Label
            {
                Text = examTime,
                Location = new Point(880, y - 5),
                Size = new Size(200, 40),
                Font = new Font("Segoe UI", 8F),
                ForeColor = Color.Black,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(lblExamTime);

            var btnDetail = new AntdUI.Button
            {
                Text = "📊 Chi tiết",
                Type = TTypeMini.Primary,
                Ghost = true,
                Location = new Point(1080, y - 5),
                Size = new Size(80, 28),
                Font = new Font("Segoe UI", 8F)
            };
            parent.Controls.Add(btnDetail);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to ContestView
            var mainWindow = this.FindForm() as MainWindow;
            if (mainWindow != null)
            {
                mainWindow.LoadContestView();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Name = "ContestDetailsView";
            this.Size = new Size(1400, 900);
            this.ResumeLayout(false);
        }
    }
}
