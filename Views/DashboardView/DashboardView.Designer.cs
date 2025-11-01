namespace computer_monitoring_desktop.Views.SubViews
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

       

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlMain = new AntdUI.Panel();
            pnlHeader = new AntdUI.Panel();
            lblTitle = new AntdUI.Label();
            pnlViolationsHeader = new AntdUI.Panel();
            lblViolationsTableTitle = new AntdUI.Label();
            cardContests = new AntdUI.Panel();
            lblContestsTitle = new AntdUI.Label();
            lblRoomsIcon = new AntdUI.Label();
            lblContestsValue = new AntdUI.Label();
            lblContestsIcon = new AntdUI.Label();
            cardStudents = new AntdUI.Panel();
            lblStudentsIcon = new AntdUI.Label();
            lblStudentsTitle = new AntdUI.Label();
            lblStudentsValue = new AntdUI.Label();
            cardPending = new AntdUI.Panel();
            lblPendingIcon = new AntdUI.Label();
            lblPendingTitle = new AntdUI.Label();
            lblPendingValue = new AntdUI.Label();
            cardRooms = new AntdUI.Panel();
            lblRoomsTitle = new AntdUI.Label();
            lblRoomsValue = new AntdUI.Label();
            cardViolations = new AntdUI.Panel();
            lblViolationsIcon = new AntdUI.Label();
            lblViolationsTitle = new AntdUI.Label();
            lblViolationsValue = new AntdUI.Label();
            pnlViolationsTable = new AntdUI.Panel();
            tblViolations = new AntdUI.Table();
            pgnViolations = new AntdUI.Pagination();
            pnlStats = new AntdUI.FlowPanel();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlViolationsHeader.SuspendLayout();
            cardContests.SuspendLayout();
            cardStudents.SuspendLayout();
            cardPending.SuspendLayout();
            cardRooms.SuspendLayout();
            cardViolations.SuspendLayout();
            pnlViolationsTable.SuspendLayout();
            pnlStats.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlViolationsTable);
            pnlMain.Controls.Add(pnlStats);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(34, 40, 34, 40);
            pnlMain.Size = new Size(1313, 505);
            pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            pnlHeader.Back = Color.Transparent;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(34, 40);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1245, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 13);
            lblTitle.Margin = new Padding(3, 4, 3, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard";
            // 
            // cardContests
            // 
            cardContests.BorderColor = Color.FromArgb(240, 240, 240);
            cardContests.BorderWidth = 1F;
            cardContests.Controls.Add(lblContestsTitle);
            cardContests.Controls.Add(lblContestsIcon);
            cardContests.Controls.Add(lblContestsValue);
            cardContests.Margin = new Padding(0, 0, 15, 0);
            cardContests.MinimumSize = new Size(280, 177);
            cardContests.Name = "cardContests";
            cardContests.Padding = new Padding(20);
            cardContests.Radius = 8;
            cardContests.Shadow = 8;
            cardContests.Size = new Size(300, 177);
            cardContests.TabIndex = 0;
            // 
            // lblContestsIcon
            // 
            lblContestsIcon.BackColor = Color.Transparent;
            lblContestsIcon.BadgeAlign  = AntdUI.TAlign.TL;
            lblContestsIcon.BadgeBack = Color.FromArgb(82, 196, 26);
            lblContestsIcon.BadgeSize = 1F;
            lblContestsIcon.BadgeSvg = "TrophyOutlined";
            lblContestsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblContestsIcon.Location = new Point(24, 24);
            lblContestsIcon.Name = "lblContestsIcon";
            lblContestsIcon.Size = new Size(48, 48);
            lblContestsIcon.TabIndex = 0;
            lblContestsIcon.Text = "";
            // 
            // lblContestsTitle
            // 
            lblContestsTitle.BackColor = Color.Transparent;
            lblContestsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblContestsTitle.Location = new Point(80, 28);
            lblContestsTitle.Name = "lblContestsTitle";
            lblContestsTitle.Size = new Size(220, 30);
            lblContestsTitle.TabIndex = 1;
            lblContestsTitle.Text = "Cuộc thi diễn ra";
            // 
            // lblContestsValue
            // 
            lblContestsValue.BackColor = Color.Transparent;
            lblContestsValue.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblContestsValue.ForeColor = Color.FromArgb(82, 196, 26);
            lblContestsValue.Location = new Point(24, 90);
            lblContestsValue.Name = "lblContestsValue";
            lblContestsValue.Size = new Size(292, 50);
            lblContestsValue.TabIndex = 2;
            // 
            // lblContestsIcon
            // 
            lblContestsIcon.BackColor = Color.Transparent;
            lblContestsIcon.BadgeBack = Color.FromArgb(82, 196, 26);
            lblContestsIcon.BadgeSize = 1F;
            lblContestsIcon.BadgeSvg = "DesktopOutlined";
            lblContestsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblContestsIcon.Location = new Point(27, 31);
            lblContestsIcon.Margin = new Padding(4, 5, 4, 5);
            lblContestsIcon.Name = "lblContestsIcon";
            lblContestsIcon.Size = new Size(53, 62);
            lblContestsIcon.TabIndex = 0;
            lblContestsIcon.Text = "";
            // 
            // cardStudents
            // 
            cardStudents.BorderColor = Color.FromArgb(240, 240, 240);
            cardStudents.BorderWidth = 1F;
            cardStudents.Controls.Add(lblStudentsIcon);
            cardStudents.Controls.Add(lblStudentsTitle);
            cardStudents.Controls.Add(lblStudentsValue);
            cardStudents.Margin = new Padding(0, 0, 15, 0);
            cardStudents.MinimumSize = new Size(280, 177);
            cardStudents.Name = "cardStudents";
            cardStudents.Padding = new Padding(20);
            cardStudents.Radius = 8;
            cardStudents.Shadow = 8;
            cardStudents.Size = new Size(300, 177);
            cardStudents.TabIndex = 1;
            // 
            // lblStudentsIcon
            // 
            lblStudentsIcon.BackColor = Color.Transparent;
            lblStudentsIcon.BadgeAlign = AntdUI.TAlign.TL;
            lblStudentsIcon.BadgeBack = Color.FromArgb(24, 144, 255);
            lblStudentsIcon.BadgeSize = 1F;
            lblStudentsIcon.BadgeSvg = "UserOutlined";
            lblStudentsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStudentsIcon.Location = new Point(24, 24);
            lblStudentsIcon.Name = "lblStudentsIcon";
            lblStudentsIcon.Size = new Size(48, 48);
            lblStudentsIcon.TabIndex = 0;
            lblStudentsIcon.Text = "";
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.BackColor = Color.Transparent;
            lblStudentsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStudentsTitle.Location = new Point(80, 28);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(220, 30);
            lblStudentsTitle.TabIndex = 1;
            lblStudentsTitle.Text = "Thí sinh đang thi";
            // 
            // lblStudentsValue
            // 
            lblStudentsValue.BackColor = Color.Transparent;
            lblStudentsValue.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblStudentsValue.ForeColor = Color.FromArgb(24, 144, 255);
            lblStudentsValue.Location = new Point(24, 90);
            lblStudentsValue.Name = "lblStudentsValue";
            lblStudentsValue.Size = new Size(292, 50);
            lblStudentsValue.TabIndex = 2;
            // 
            // cardPending
            // 
            cardPending.BorderColor = Color.FromArgb(240, 240, 240);
            cardPending.BorderWidth = 1F;
            cardPending.Controls.Add(lblPendingIcon);
            cardPending.Controls.Add(lblPendingTitle);
            cardPending.Controls.Add(lblPendingValue);
            cardPending.Margin = new Padding(0, 0, 15, 0);
            cardPending.MinimumSize = new Size(280, 177);
            cardPending.Name = "cardPending";
            cardPending.Padding = new Padding(20);
            cardPending.Radius = 8;
            cardPending.Shadow = 8;
            cardPending.Size = new Size(300, 177);
            cardPending.TabIndex = 2;
            // 
            // lblPendingIcon
            // 
            lblPendingIcon.BackColor = Color.Transparent;
            lblPendingIcon.BadgeAlign = AntdUI.TAlign.TL;
            lblPendingIcon.BadgeBack = Color.FromArgb(250, 173, 20);
            lblPendingIcon.BadgeSize = 1F;
            lblPendingIcon.BadgeSvg = "AuditOutlined";
            lblPendingIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblPendingIcon.Location = new Point(24, 24);
            lblPendingIcon.Name = "lblPendingIcon";
            lblPendingIcon.Size = new Size(48, 48);
            lblPendingIcon.TabIndex = 0;
            lblPendingIcon.Text = "";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.BackColor = Color.Transparent;
            lblPendingTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblPendingTitle.Location = new Point(80, 28);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(220, 30);
            lblPendingTitle.TabIndex = 1;
            lblPendingTitle.Text = "Chờ duyệt";
            // 
            // lblPendingValue
            // 
            lblPendingValue.BackColor = Color.Transparent;
            lblPendingValue.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblPendingValue.ForeColor = Color.FromArgb(250, 173, 20);
            lblPendingValue.Location = new Point(24, 90);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(292, 50);
            lblPendingValue.TabIndex = 2;
            // 
            // cardRooms
            // 
            cardRooms.BorderColor = Color.FromArgb(240, 240, 240);
            cardRooms.BorderWidth = 1F;
            cardRooms.Controls.Add(lblRoomsIcon);
            cardRooms.Controls.Add(lblRoomsTitle);
            cardRooms.Controls.Add(lblRoomsValue);
            cardRooms.Margin = new Padding(0, 0, 15, 0);
            cardRooms.MinimumSize = new Size(280, 177);
            cardRooms.Name = "cardRooms";
            cardRooms.Padding = new Padding(20);
            cardRooms.Radius = 8;
            cardRooms.Shadow = 8;
            cardRooms.Size = new Size(300, 177);
            cardRooms.TabIndex = 3;
            // 
            // lblRoomsIcon
            // 
            lblRoomsIcon.BackColor = Color.Transparent;
            lblRoomsIcon.BadgeAlign = AntdUI.TAlign.TL;
            lblRoomsIcon.BadgeBack = Color.FromArgb(114, 46, 209);
            lblRoomsIcon.BadgeSize = 1F;
            lblRoomsIcon.BadgeSvg = "HomeOutlined";
            lblRoomsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblRoomsIcon.Location = new Point(24, 24);
            lblRoomsIcon.Name = "lblRoomsIcon";
            lblRoomsIcon.Size = new Size(48, 48);
            lblRoomsIcon.TabIndex = 0;
            lblRoomsIcon.Text = "";
            // 
            // lblRoomsTitle
            // 
            lblRoomsTitle.BackColor = Color.Transparent;
            lblRoomsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblRoomsTitle.Location = new Point(80, 28);
            lblRoomsTitle.Name = "lblRoomsTitle";
            lblRoomsTitle.Size = new Size(220, 30);
            lblRoomsTitle.TabIndex = 1;
            lblRoomsTitle.Text = "Tổng số phòng thi";
            // 
            // lblRoomsValue
            // 
            lblRoomsValue.BackColor = Color.Transparent;
            lblRoomsValue.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblRoomsValue.ForeColor = Color.FromArgb(114, 46, 209);
            lblRoomsValue.Location = new Point(24, 90);
            lblRoomsValue.Name = "lblRoomsValue";
            lblRoomsValue.Size = new Size(292, 50);
            lblRoomsValue.TabIndex = 2;
            // 
            // cardViolations
            // 
            cardViolations.BorderColor = Color.FromArgb(240, 240, 240);
            cardViolations.BorderWidth = 1F;
            cardViolations.Controls.Add(lblViolationsIcon);
            cardViolations.Controls.Add(lblViolationsTitle);
            cardViolations.Controls.Add(lblViolationsValue);
            cardViolations.Margin = new Padding(0, 0, 15, 0);
            cardViolations.MinimumSize = new Size(280, 177);
            cardViolations.Name = "cardViolations";
            cardViolations.Padding = new Padding(20);
            cardViolations.Radius = 8;
            cardViolations.Shadow = 8;
            cardViolations.Size = new Size(300, 177);
            cardViolations.TabIndex = 4;
            // 
            // lblViolationsIcon
            // 
            lblViolationsIcon.BackColor = Color.Transparent;
            lblViolationsIcon.BadgeAlign = AntdUI.TAlign.TL;
            lblViolationsIcon.BadgeBack = Color.FromArgb(255, 77, 79);
            lblViolationsIcon.BadgeSize = 1F;
            lblViolationsIcon.BadgeSvg = "WarningOutlined";
            lblViolationsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblViolationsIcon.Location = new Point(24, 24);
            lblViolationsIcon.Name = "lblViolationsIcon";
            lblViolationsIcon.Size = new Size(48, 48);
            lblViolationsIcon.TabIndex = 0;
            lblViolationsIcon.Text = "";
            // 
            // lblViolationsTitle
            // 
            lblViolationsTitle.BackColor = Color.Transparent;
            lblViolationsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblViolationsTitle.Location = new Point(80, 28);
            lblViolationsTitle.Name = "lblViolationsTitle";
            lblViolationsTitle.Size = new Size(220, 30);
            lblViolationsTitle.TabIndex = 1;
            lblViolationsTitle.Text = "Vi phạm chưa xử lí";
            // 
            // lblViolationsValue
            // 
            lblViolationsValue.BackColor = Color.Transparent;
            lblViolationsValue.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblViolationsValue.ForeColor = Color.FromArgb(255, 77, 79);
            lblViolationsValue.Location = new Point(24, 90);
            lblViolationsValue.Name = "lblViolationsValue";
            lblViolationsValue.Size = new Size(292, 50);
            lblViolationsValue.TabIndex = 2;
            lblViolationsValue.Text = "2 / 3";
            // 
            // pnlViolationsTable
            // 
            pnlViolationsTable.Controls.Add(tblViolations);
            pnlViolationsTable.Controls.Add(pgnViolations);
            pnlViolationsTable.Controls.Add(pnlViolationsHeader);
            pnlViolationsTable.Dock = DockStyle.Top;
            pnlViolationsTable.Location = new Point(34, 320);
            pnlViolationsTable.Margin = new Padding(3, 4, 3, 4);
            pnlViolationsTable.Name = "pnlViolationsTable";
            pnlViolationsTable.Padding = new Padding(13);
            pnlViolationsTable.Size = new Size(1245, 365);
            pnlViolationsTable.TabIndex = 2;
            // 
            // pnlViolationsHeader
            // 
            pnlViolationsHeader.Back = Color.Transparent;
            pnlViolationsHeader.Controls.Add(lblViolationsTableTitle);
            pnlViolationsHeader.Dock = DockStyle.Top;
            pnlViolationsHeader.Location = new Point(13, 13);
            pnlViolationsHeader.Name = "pnlViolationsHeader";
            pnlViolationsHeader.Size = new Size(1219, 50);
            pnlViolationsHeader.TabIndex = 2;
            // 
            // lblViolationsTableTitle
            // 
            lblViolationsTableTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblViolationsTableTitle.Location = new Point(0, 10);
            lblViolationsTableTitle.Name = "lblViolationsTableTitle";
            lblViolationsTableTitle.Size = new Size(300, 35);
            lblViolationsTableTitle.TabIndex = 0;
            lblViolationsTableTitle.Text = "Danh sách vi phạm";
            // 
            // tblViolations
            // 
            tblViolations.Bordered = true;
            tblViolations.Dock = DockStyle.Fill;
            tblViolations.EnableHeaderResizing = true;
            tblViolations.Gap = 12;
            tblViolations.Location = new Point(13, 63);
            tblViolations.Margin = new Padding(2);
            tblViolations.Name = "tblViolations";
            tblViolations.Size = new Size(1219, 256);
            tblViolations.TabIndex = 0;
            // 
            // pgnViolations
            // 
            pgnViolations.Dock = DockStyle.Bottom;
            pgnViolations.Location = new Point(13, 319);
            pgnViolations.Margin = new Padding(2);
            pgnViolations.Name = "pgnViolations";
            pgnViolations.PageSize = 5;
            pgnViolations.RightToLeft = RightToLeft.Yes;
            pgnViolations.ShowSizeChanger = true;
            pgnViolations.Size = new Size(1219, 50);
            pgnViolations.SizeChangerWidth = 50;
            pgnViolations.TabIndex = 1;
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(cardViolations);
            pnlStats.Controls.Add(cardRooms);
            pnlStats.Controls.Add(cardContests);
            pnlStats.Controls.Add(cardPending);
            pnlStats.Controls.Add(cardStudents);
            pnlStats.AutoSize = true;
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Gap = 16;
            pnlStats.Location = new Point(34, 120);
            pnlStats.Margin = new Padding(0, 0, 0, 20);
            pnlStats.MinimumSize = new Size(0, 177);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1245, 177);
            pnlStats.TabIndex = 1;
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardView";
            Size = new Size(1313, 505);
            pnlMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            cardContests.ResumeLayout(false);
            cardStudents.ResumeLayout(false);
            cardPending.ResumeLayout(false);
            cardRooms.ResumeLayout(false);
            cardViolations.ResumeLayout(false);
            pnlViolationsTable.ResumeLayout(false);
            pnlViolationsHeader.ResumeLayout(false);
            pnlStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        


        private AntdUI.FlowPanel pnlStats;
        private AntdUI.Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Label lblTitle;
        private AntdUI.Panel cardContests;
        private AntdUI.Panel cardStudents;
        private AntdUI.Panel cardPending;
        private AntdUI.Panel cardRooms;
        private AntdUI.Panel cardViolations;


        // Stat card labels
        private AntdUI.Label lblContestsTitle;
        private AntdUI.Label lblContestsValue;
        private AntdUI.Label lblContestsIcon;
        private AntdUI.Label lblStudentsTitle;
        private AntdUI.Label lblStudentsValue;
        private AntdUI.Label lblStudentsIcon;
        private AntdUI.Label lblPendingTitle;
        private AntdUI.Label lblPendingValue;
        private AntdUI.Label lblPendingIcon;
        private AntdUI.Label lblRoomsTitle;
        private AntdUI.Label lblRoomsValue;
        private AntdUI.Label lblRoomsIcon;
        private AntdUI.Label lblViolationsTitle;
        private AntdUI.Label lblViolationsValue;
        private AntdUI.Label lblViolationsIcon;

        // Violations table
        private AntdUI.Panel pnlViolationsTable;
        private AntdUI.Panel pnlViolationsHeader;
        private AntdUI.Label lblViolationsTableTitle;
        private AntdUI.Table tblViolations;
        private AntdUI.Pagination pgnViolations;
    }
}
