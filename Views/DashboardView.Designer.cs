namespace computer_monitoring_desktop.Views.SubViews
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        private AntdUI.Label lblHeader;
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
        private System.Windows.Forms.Panel pnlViolationsContainer;
        private AntdUI.Label lblHeaderStudentId;
        private AntdUI.Label lblHeaderDescription;
        private AntdUI.Label lblHeaderSeverity;
        private AntdUI.Label lblHeaderStatus;
        private AntdUI.Label lblHeaderTime;

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
            lblHeader = new AntdUI.Label();
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
            pnlViolationsContainer = new Panel();
            pnlViolationsHeader = new AntdUI.Panel();
            lblHeaderStudentId = new AntdUI.Label();
            lblHeaderDescription = new AntdUI.Label();
            lblHeaderSeverity = new AntdUI.Label();
            lblHeaderStatus = new AntdUI.Label();
            lblHeaderTime = new AntdUI.Label();
            pnlStats = new AntdUI.FlowPanel();
            cardContests.SuspendLayout();
            cardStudents.SuspendLayout();
            cardPending.SuspendLayout();
            cardRooms.SuspendLayout();
            cardViolations.SuspendLayout();
            pnlViolationsTable.SuspendLayout();
            pnlViolationsHeader.SuspendLayout();
            pnlStats.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblHeader.Location = new Point(27, 31);
            lblHeader.Margin = new Padding(4, 5, 4, 5);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1259, 62);
            lblHeader.TabIndex = 3;
            lblHeader.Text = "Dashboard";
            // 
            // cardContests
            // 
            cardContests.Back = Color.White;
            cardContests.BorderColor = Color.FromArgb(240, 240, 240);
            cardContests.BorderWidth = 1F;
            cardContests.Controls.Add(lblContestsTitle);
            cardContests.Controls.Add(lblRoomsIcon);
            cardContests.Controls.Add(lblContestsValue);
            cardContests.Location = new Point(629, 0);
            cardContests.Margin = new Padding(0, 0, 15, 0);
            cardContests.Name = "cardContests";
            cardContests.Padding = new Padding(27, 31, 27, 31);
            cardContests.Radius = 8;
            cardContests.Shadow = 8;
            cardContests.Size = new Size(260, 177);
            cardContests.TabIndex = 0;
            // 
            // lblContestsTitle
            // 
            lblContestsTitle.BackColor = Color.Transparent;
            lblContestsTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContestsTitle.ForeColor = Color.Gray;
            lblContestsTitle.Location = new Point(78, 31);
            lblContestsTitle.Margin = new Padding(4, 5, 4, 5);
            lblContestsTitle.Name = "lblContestsTitle";
            lblContestsTitle.Size = new Size(216, 62);
            lblContestsTitle.TabIndex = 1;
            lblContestsTitle.Text = "Cuộc thi diễn ra";
            // 
            // lblRoomsIcon
            // 
            lblRoomsIcon.BackColor = Color.Transparent;
            lblRoomsIcon.BadgeBack = Color.FromArgb(82, 196, 26);
            lblRoomsIcon.BadgeSize = 1F;
            lblRoomsIcon.BadgeSvg = "TrophyOutlined";
            lblRoomsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblRoomsIcon.Location = new Point(17, 31);
            lblRoomsIcon.Margin = new Padding(4, 5, 4, 5);
            lblRoomsIcon.Name = "lblRoomsIcon";
            lblRoomsIcon.Size = new Size(53, 62);
            lblRoomsIcon.TabIndex = 0;
            lblRoomsIcon.Text = "";
            // 
            // lblContestsValue
            // 
            lblContestsValue.BackColor = Color.Transparent;
            lblContestsValue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblContestsValue.ForeColor = Color.FromArgb(82, 196, 26);
            lblContestsValue.Location = new Point(27, 92);
            lblContestsValue.Margin = new Padding(4, 5, 4, 5);
            lblContestsValue.Name = "lblContestsValue";
            lblContestsValue.Size = new Size(264, 54);
            lblContestsValue.TabIndex = 2;
            lblContestsValue.Text = "0";
            // 
            // lblContestsIcon
            // 
            lblContestsIcon.BackColor = Color.Transparent;
            lblContestsIcon.BadgeBack = Color.Black;
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
            // lblStudentsIcon
            // 
            lblStudentsIcon.BackColor = Color.Transparent;
            lblStudentsIcon.BadgeBack = Color.FromArgb(24, 144, 255);
            lblStudentsIcon.BadgeSize = 1F;
            lblStudentsIcon.BadgeSvg = "UserOutlined";
            lblStudentsIcon.ColorExtend = "";
            lblStudentsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStudentsIcon.Location = new Point(27, 31);
            lblStudentsIcon.Margin = new Padding(4, 5, 4, 5);
            lblStudentsIcon.Name = "lblStudentsIcon";
            lblStudentsIcon.PrefixSvg = "";
            lblStudentsIcon.Size = new Size(53, 62);
            lblStudentsIcon.TabIndex = 0;
            lblStudentsIcon.Text = "";
            // 
            // lblStudentsTitle
            // 
            lblStudentsTitle.BackColor = Color.Transparent;
            lblStudentsTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentsTitle.ForeColor = Color.Gray;
            lblStudentsTitle.Location = new Point(93, 31);
            lblStudentsTitle.Margin = new Padding(4, 5, 4, 5);
            lblStudentsTitle.Name = "lblStudentsTitle";
            lblStudentsTitle.Size = new Size(215, 62);
            lblStudentsTitle.TabIndex = 1;
            lblStudentsTitle.Text = "Thí sinh đang thi";
            // 
            // lblStudentsValue
            // 
            lblStudentsValue.BackColor = Color.Transparent;
            lblStudentsValue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblStudentsValue.ForeColor = Color.FromArgb(24, 144, 255);
            lblStudentsValue.Location = new Point(27, 92);
            lblStudentsValue.Margin = new Padding(4, 5, 4, 5);
            lblStudentsValue.Name = "lblStudentsValue";
            lblStudentsValue.Size = new Size(267, 54);
            lblStudentsValue.TabIndex = 2;
            lblStudentsValue.Text = "1 / 7";
            // 
            // cardPending
            // 
            cardPending.Back = Color.White;
            cardPending.BorderColor = Color.FromArgb(240, 240, 240);
            cardPending.BorderWidth = 1F;
            cardPending.Controls.Add(lblPendingIcon);
            cardPending.Controls.Add(lblPendingTitle);
            cardPending.Controls.Add(lblPendingValue);
            cardPending.Location = new Point(354, 0);
            cardPending.Margin = new Padding(0, 0, 15, 0);
            cardPending.Name = "cardPending";
            cardPending.Padding = new Padding(27, 31, 27, 31);
            cardPending.Radius = 8;
            cardPending.Shadow = 8;
            cardPending.Size = new Size(260, 177);
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
            lblPendingIcon.Location = new Point(27, 31);
            lblPendingIcon.Margin = new Padding(4, 5, 4, 5);
            lblPendingIcon.Name = "lblPendingIcon";
            lblPendingIcon.PrefixSvg = "";
            lblPendingIcon.Size = new Size(53, 62);
            lblPendingIcon.TabIndex = 0;
            lblPendingIcon.Text = "";
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.BackColor = Color.Transparent;
            lblPendingTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPendingTitle.ForeColor = Color.Gray;
            lblPendingTitle.Location = new Point(88, 31);
            lblPendingTitle.Margin = new Padding(4, 5, 4, 5);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(206, 62);
            lblPendingTitle.TabIndex = 1;
            lblPendingTitle.Text = "Chờ duyệt";
            // 
            // lblPendingValue
            // 
            lblPendingValue.BackColor = Color.Transparent;
            lblPendingValue.BadgeBack = Color.FromArgb(250, 173, 20);
            lblPendingValue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblPendingValue.ForeColor = Color.FromArgb(250, 173, 20);
            lblPendingValue.Location = new Point(27, 92);
            lblPendingValue.Margin = new Padding(4, 5, 4, 5);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(267, 54);
            lblPendingValue.TabIndex = 2;
            lblPendingValue.Text = "2";
            // 
            // cardRooms
            // 
            cardRooms.Back = Color.White;
            cardRooms.BorderColor = Color.FromArgb(240, 240, 240);
            cardRooms.BorderWidth = 1F;
            cardRooms.Controls.Add(lblContestsIcon);
            cardRooms.Controls.Add(lblRoomsTitle);
            cardRooms.Controls.Add(lblRoomsValue);
            cardRooms.Location = new Point(79, 177);
            cardRooms.Margin = new Padding(0, 0, 15, 0);
            cardRooms.Name = "cardRooms";
            cardRooms.Padding = new Padding(27, 31, 27, 31);
            cardRooms.Radius = 8;
            cardRooms.Shadow = 8;
            cardRooms.Size = new Size(260, 177);
            cardRooms.TabIndex = 0;
            // 
            // lblRoomsTitle
            // 
            lblRoomsTitle.BackColor = Color.Transparent;
            lblRoomsTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomsTitle.ForeColor = Color.Gray;
            lblRoomsTitle.Location = new Point(96, 48);
            lblRoomsTitle.Margin = new Padding(4, 5, 4, 5);
            lblRoomsTitle.Name = "lblRoomsTitle";
            lblRoomsTitle.Size = new Size(206, 31);
            lblRoomsTitle.TabIndex = 1;
            lblRoomsTitle.Text = "Tổng số phòng thi";
            // 
            // lblRoomsValue
            // 
            lblRoomsValue.BackColor = Color.Transparent;
            lblRoomsValue.BadgeBack = Color.Black;
            lblRoomsValue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblRoomsValue.ForeColor = Color.Black;
            lblRoomsValue.Location = new Point(27, 92);
            lblRoomsValue.Margin = new Padding(4, 5, 4, 5);
            lblRoomsValue.Name = "lblRoomsValue";
            lblRoomsValue.Size = new Size(267, 54);
            lblRoomsValue.TabIndex = 2;
            lblRoomsValue.Text = "3";
            // 
            // cardViolations
            // 
            cardViolations.Back = Color.White;
            cardViolations.BorderColor = Color.FromArgb(240, 240, 240);
            cardViolations.BorderWidth = 1F;
            cardViolations.Controls.Add(lblViolationsIcon);
            cardViolations.Controls.Add(lblViolationsTitle);
            cardViolations.Controls.Add(lblViolationsValue);
            cardViolations.Location = new Point(904, 0);
            cardViolations.Margin = new Padding(0, 0, 15, 0);
            cardViolations.Name = "cardViolations";
            cardViolations.Padding = new Padding(27, 31, 27, 31);
            cardViolations.Radius = 8;
            cardViolations.Shadow = 8;
            cardViolations.Size = new Size(260, 177);
            cardViolations.TabIndex = 3;
            // 
            // lblViolationsIcon
            // 
            lblViolationsIcon.BackColor = Color.Transparent;
            lblViolationsIcon.BadgeSize = 1F;
            lblViolationsIcon.BadgeSvg = "FileOutlined";
            lblViolationsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblViolationsIcon.Location = new Point(27, 31);
            lblViolationsIcon.Margin = new Padding(4, 5, 4, 5);
            lblViolationsIcon.Name = "lblViolationsIcon";
            lblViolationsIcon.Size = new Size(53, 62);
            lblViolationsIcon.TabIndex = 0;
            lblViolationsIcon.Text = "";
            // 
            // lblViolationsTitle
            // 
            lblViolationsTitle.BackColor = Color.Transparent;
            lblViolationsTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViolationsTitle.ForeColor = Color.Gray;
            lblViolationsTitle.Location = new Point(88, 31);
            lblViolationsTitle.Margin = new Padding(4, 5, 4, 5);
            lblViolationsTitle.Name = "lblViolationsTitle";
            lblViolationsTitle.Size = new Size(216, 62);
            lblViolationsTitle.TabIndex = 1;
            lblViolationsTitle.Text = "Vi phạm chưa xử lí";
            // 
            // lblViolationsValue
            // 
            lblViolationsValue.BackColor = Color.Transparent;
            lblViolationsValue.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            lblViolationsValue.ForeColor = Color.FromArgb(255, 77, 79);
            lblViolationsValue.Location = new Point(27, 92);
            lblViolationsValue.Margin = new Padding(4, 5, 4, 5);
            lblViolationsValue.Name = "lblViolationsValue";
            lblViolationsValue.Size = new Size(264, 54);
            lblViolationsValue.TabIndex = 2;
            lblViolationsValue.Text = "2 / 3";
            // 
            // pnlViolationsTable
            // 
            pnlViolationsTable.Back = Color.White;
            pnlViolationsTable.BorderColor = Color.FromArgb(240, 240, 240);
            pnlViolationsTable.BorderWidth = 1F;
            pnlViolationsTable.Controls.Add(pnlViolationsContainer);
            pnlViolationsTable.Controls.Add(pnlViolationsHeader);
            pnlViolationsTable.Dock = DockStyle.Bottom;
            pnlViolationsTable.Location = new Point(27, 454);
            pnlViolationsTable.Margin = new Padding(4, 5, 4, 5);
            pnlViolationsTable.Name = "pnlViolationsTable";
            pnlViolationsTable.Padding = new Padding(27, 31, 27, 31);
            pnlViolationsTable.Radius = 8;
            pnlViolationsTable.Shadow = 8;
            pnlViolationsTable.Size = new Size(1259, 438);
            pnlViolationsTable.TabIndex = 0;
            // 
            // pnlViolationsContainer
            // 
            pnlViolationsContainer.AutoScroll = true;
            pnlViolationsContainer.BackColor = Color.White;
            pnlViolationsContainer.Dock = DockStyle.Fill;
            pnlViolationsContainer.Location = new Point(39, 105);
            pnlViolationsContainer.Margin = new Padding(4, 5, 4, 5);
            pnlViolationsContainer.Name = "pnlViolationsContainer";
            pnlViolationsContainer.Size = new Size(1181, 290);
            pnlViolationsContainer.TabIndex = 0;
            // 
            // pnlViolationsHeader
            // 
            pnlViolationsHeader.Back = Color.FromArgb(250, 250, 250);
            pnlViolationsHeader.Controls.Add(lblHeaderStudentId);
            pnlViolationsHeader.Controls.Add(lblHeaderDescription);
            pnlViolationsHeader.Controls.Add(lblHeaderSeverity);
            pnlViolationsHeader.Controls.Add(lblHeaderStatus);
            pnlViolationsHeader.Controls.Add(lblHeaderTime);
            pnlViolationsHeader.Dock = DockStyle.Top;
            pnlViolationsHeader.Location = new Point(39, 43);
            pnlViolationsHeader.Margin = new Padding(4, 5, 4, 5);
            pnlViolationsHeader.Name = "pnlViolationsHeader";
            pnlViolationsHeader.Size = new Size(1181, 62);
            pnlViolationsHeader.TabIndex = 1;
            // 
            // lblHeaderStudentId
            // 
            lblHeaderStudentId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblHeaderStudentId.Location = new Point(13, 15);
            lblHeaderStudentId.Margin = new Padding(4, 5, 4, 5);
            lblHeaderStudentId.Name = "lblHeaderStudentId";
            lblHeaderStudentId.Size = new Size(133, 31);
            lblHeaderStudentId.TabIndex = 0;
            lblHeaderStudentId.Text = "Mã SV";
            // 
            // lblHeaderDescription
            // 
            lblHeaderDescription.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblHeaderDescription.Location = new Point(160, 15);
            lblHeaderDescription.Margin = new Padding(4, 5, 4, 5);
            lblHeaderDescription.Name = "lblHeaderDescription";
            lblHeaderDescription.Size = new Size(373, 31);
            lblHeaderDescription.TabIndex = 1;
            lblHeaderDescription.Text = "Mô tả";
            // 
            // lblHeaderSeverity
            // 
            lblHeaderSeverity.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblHeaderSeverity.Location = new Point(547, 15);
            lblHeaderSeverity.Margin = new Padding(4, 5, 4, 5);
            lblHeaderSeverity.Name = "lblHeaderSeverity";
            lblHeaderSeverity.Size = new Size(120, 31);
            lblHeaderSeverity.TabIndex = 2;
            lblHeaderSeverity.Text = "Mức độ";
            // 
            // lblHeaderStatus
            // 
            lblHeaderStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblHeaderStatus.Location = new Point(680, 15);
            lblHeaderStatus.Margin = new Padding(4, 5, 4, 5);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(147, 31);
            lblHeaderStatus.TabIndex = 3;
            lblHeaderStatus.Text = "Trạng thái";
            // 
            // lblHeaderTime
            // 
            lblHeaderTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblHeaderTime.Location = new Point(840, 15);
            lblHeaderTime.Margin = new Padding(4, 5, 4, 5);
            lblHeaderTime.Name = "lblHeaderTime";
            lblHeaderTime.Size = new Size(240, 31);
            lblHeaderTime.TabIndex = 4;
            lblHeaderTime.Text = "Thời gian";
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(cardRooms);
            pnlStats.Controls.Add(cardViolations);
            pnlStats.Controls.Add(cardContests);
            pnlStats.Controls.Add(cardPending);
            pnlStats.Controls.Add(cardStudents);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(27, 93);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(1259, 392);
            pnlStats.TabIndex = 2;
            pnlStats.Text = "flowPanel1";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(240, 242, 245);
            Controls.Add(pnlStats);
            Controls.Add(pnlViolationsTable);
            Controls.Add(lblHeader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardView";
            Padding = new Padding(27, 31, 27, 31);
            Size = new Size(1313, 505);
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
    }
}
