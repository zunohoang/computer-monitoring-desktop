using AntdUI;

namespace computer_monitoring_desktop.Views.Contests
{
    partial class ContestDetailsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            statCardRooms = new AntdUI.Panel();
            lblStatRoomsIcon = new AntdUI.Label();
            lblStatRoomsTitle = new AntdUI.Label();
            lblStatRooms = new AntdUI.Label();
            statCardCapacity = new AntdUI.Panel();
            lblStatCapacityIcon = new AntdUI.Label();
            lblStatCapacityTitle = new AntdUI.Label();
            lblStatCapacity = new AntdUI.Label();
            statCardCurrent = new AntdUI.Panel();
            lblStatCurrentIcon = new AntdUI.Label();
            lblStatCurrentTitle = new AntdUI.Label();
            lblStatCurrent = new AntdUI.Label();
            statCardViolations = new AntdUI.Panel();
            lblStatViolationsIcon = new AntdUI.Label();
            lblStatViolationsTitle = new AntdUI.Label();
            lblStatViolations = new AntdUI.Label();
            // TableLayoutPanel for stat cards
            statCardsTable = new TableLayoutPanel();
            lblContestName = new AntdUI.Label();
            pnlContestInfo = new AntdUI.Panel();
            tblRooms = new Table();
            pgnRoomsTable = new Pagination();
            spnContainer = new StackPanel();
            pgnParticipants = new Pagination();
            tblParticipants = new Table();
            pnlParticipantsHeader = new AntdUI.Panel();
            lblParticipantsHeader = new AntdUI.Label();
            flpParticipantsButtons = new FlowPanel();
            btnDownloadTemplate = new AntdUI.Button();
            btnExportExcel = new AntdUI.Button();
            btnImportExcel = new AntdUI.Button();
            btnAddParticipant = new AntdUI.Button();
            pnlContestDetails = new AntdUI.Panel();
            tblContestDetails = new TableLayoutPanel();
            lblContestId = new AntdUI.Label();
            lblContestIdValue = new AntdUI.Label();
            lblContestStatusValue = new AntdUI.Label();
            lblContestDesc = new AntdUI.Label();
            lblContestDescValue = new AntdUI.Label();
            lblContestStart = new AntdUI.Label();
            lblContestStartValue = new AntdUI.Label();
            lblContestEnd = new AntdUI.Label();
            lblContestEndValue = new AntdUI.Label();
            lblContestCreator = new AntdUI.Label();
            lblContestCreatorValue = new AntdUI.Label();
            lblContestCreated = new AntdUI.Label();
            lblContestCreatedValue = new AntdUI.Label();
            lblContestStatus = new AntdUI.Label();
            statCardRooms.SuspendLayout();
            statCardCapacity.SuspendLayout();
            statCardCurrent.SuspendLayout();
            statCardViolations.SuspendLayout();
            // 
            pnlContestInfo.SuspendLayout();
            spnContainer.SuspendLayout();
            pnlParticipantsHeader.SuspendLayout();
            flpParticipantsButtons.SuspendLayout();
            pnlContestDetails.SuspendLayout();
            tblContestDetails.SuspendLayout();
            SuspendLayout();
            // 
            // statCardRooms
            // 
            statCardRooms.BorderColor = Color.FromArgb(240, 240, 240);
            statCardRooms.BorderWidth = 1F;
            statCardRooms.Controls.Add(lblStatRoomsIcon);
            statCardRooms.Controls.Add(lblStatRoomsTitle);
            statCardRooms.Controls.Add(lblStatRooms);
            statCardRooms.Location = new Point(98, 177);
            statCardRooms.Margin = new Padding(0, 0, 15, 0);
            statCardRooms.Name = "statCardRooms";
            statCardRooms.Padding = new Padding(20);
            statCardRooms.Radius = 8;
            statCardRooms.Shadow = 8;
            statCardRooms.MinimumSize = new Size(320, 177);
            statCardRooms.TabIndex = 0;
            // 
            // lblStatRoomsIcon
            // 
            lblStatRoomsIcon.BackColor = Color.Transparent;
            lblStatRoomsIcon.BadgeAlign = TAlign.TL;
            lblStatRoomsIcon.BadgeBack = Color.FromArgb(24, 144, 255);
            lblStatRoomsIcon.BadgeSize = 1F;
            lblStatRoomsIcon.BadgeSvg = "HomeOutlined";
            lblStatRoomsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStatRoomsIcon.Location = new Point(24, 24);
            lblStatRoomsIcon.Name = "lblStatRoomsIcon";
            lblStatRoomsIcon.Size = new Size(48, 48);
            lblStatRoomsIcon.TabIndex = 0;
            lblStatRoomsIcon.Text = "";
            // 
            // lblStatRoomsTitle
            // 
            lblStatRoomsTitle.BackColor = Color.Transparent;
            lblStatRoomsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStatRoomsTitle.ForeColor = Color.Gray;
            lblStatRoomsTitle.Location = new Point(80, 28);
            lblStatRoomsTitle.Name = "lblStatRoomsTitle";
            lblStatRoomsTitle.Size = new Size(220, 30);
            lblStatRoomsTitle.TabIndex = 1;
            lblStatRoomsTitle.Text = "Tổng số phòng thi";
            // 
            // lblStatRooms
            // 
            lblStatRooms.BackColor = Color.Transparent;
            lblStatRooms.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblStatRooms.ForeColor = Color.FromArgb(24, 144, 255);
            lblStatRooms.Location = new Point(24, 90);
            lblStatRooms.Name = "lblStatRooms";
            lblStatRooms.Size = new Size(292, 50);
            lblStatRooms.TabIndex = 2;
            // 
            // statCardCapacity
            // 
            statCardCapacity.BorderColor = Color.FromArgb(240, 240, 240);
            statCardCapacity.BorderWidth = 1F;
            statCardCapacity.Controls.Add(lblStatCapacityIcon);
            statCardCapacity.Controls.Add(lblStatCapacityTitle);
            statCardCapacity.Controls.Add(lblStatCapacity);
            statCardCapacity.Location = new Point(808, 0);
            statCardCapacity.Margin = new Padding(0, 0, 15, 0);
            statCardCapacity.Name = "statCardCapacity";
            statCardCapacity.Padding = new Padding(20);
            statCardCapacity.Radius = 8;
            statCardCapacity.Shadow = 8;
            statCardCapacity.MinimumSize = new Size(320, 177);
            statCardCapacity.TabIndex = 1;
            // 
            // lblStatCapacityIcon
            // 
            lblStatCapacityIcon.BackColor = Color.Transparent;
            lblStatCapacityIcon.BadgeAlign = TAlign.TL;
            lblStatCapacityIcon.BadgeBack = Color.FromArgb(82, 196, 26);
            lblStatCapacityIcon.BadgeSize = 1F;
            lblStatCapacityIcon.BadgeSvg = "TeamOutlined";
            lblStatCapacityIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStatCapacityIcon.Location = new Point(24, 24);
            lblStatCapacityIcon.Name = "lblStatCapacityIcon";
            lblStatCapacityIcon.Size = new Size(48, 48);
            lblStatCapacityIcon.TabIndex = 0;
            lblStatCapacityIcon.Text = "";
            // 
            // lblStatCapacityTitle
            // 
            lblStatCapacityTitle.BackColor = Color.Transparent;
            lblStatCapacityTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStatCapacityTitle.ForeColor = Color.Gray;
            lblStatCapacityTitle.Location = new Point(80, 28);
            lblStatCapacityTitle.Name = "lblStatCapacityTitle";
            lblStatCapacityTitle.Size = new Size(220, 30);
            lblStatCapacityTitle.TabIndex = 1;
            lblStatCapacityTitle.Text = "Tổng sức chứa";
            // 
            // lblStatCapacity
            // 
            lblStatCapacity.BackColor = Color.Transparent;
            lblStatCapacity.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblStatCapacity.ForeColor = Color.FromArgb(82, 196, 26);
            lblStatCapacity.Location = new Point(24, 90);
            lblStatCapacity.Name = "lblStatCapacity";
            lblStatCapacity.Size = new Size(292, 50);
            lblStatCapacity.TabIndex = 2;
            // 
            // statCardCurrent
            // 
            statCardCurrent.BorderColor = Color.FromArgb(240, 240, 240);
            statCardCurrent.BorderWidth = 1F;
            statCardCurrent.Controls.Add(lblStatCurrentIcon);
            statCardCurrent.Controls.Add(lblStatCurrentTitle);
            statCardCurrent.Controls.Add(lblStatCurrent);
            statCardCurrent.Location = new Point(453, 0);
            statCardCurrent.Margin = new Padding(0, 0, 15, 0);
            statCardCurrent.Name = "statCardCurrent";
            statCardCurrent.Padding = new Padding(20);
            statCardCurrent.Radius = 8;
            statCardCurrent.Shadow = 8;
            statCardCurrent.MinimumSize = new Size(320, 177);
            statCardCurrent.TabIndex = 2;
            // 
            // lblStatCurrentIcon
            // 
            lblStatCurrentIcon.BackColor = Color.Transparent;
            lblStatCurrentIcon.BadgeAlign = TAlign.TL;
            lblStatCurrentIcon.BadgeBack = Color.FromArgb(250, 140, 22);
            lblStatCurrentIcon.BadgeSize = 1F;
            lblStatCurrentIcon.BadgeSvg = "UserSwitchOutlined";
            lblStatCurrentIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStatCurrentIcon.Location = new Point(24, 24);
            lblStatCurrentIcon.Name = "lblStatCurrentIcon";
            lblStatCurrentIcon.Size = new Size(48, 48);
            lblStatCurrentIcon.TabIndex = 0;
            lblStatCurrentIcon.Text = "";
            // 
            // lblStatCurrentTitle
            // 
            lblStatCurrentTitle.BackColor = Color.Transparent;
            lblStatCurrentTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStatCurrentTitle.ForeColor = Color.Gray;
            lblStatCurrentTitle.Location = new Point(80, 28);
            lblStatCurrentTitle.Name = "lblStatCurrentTitle";
            lblStatCurrentTitle.Size = new Size(220, 30);
            lblStatCurrentTitle.TabIndex = 1;
            lblStatCurrentTitle.Text = "Thí sinh đang thi";
            // 
            // lblStatCurrent
            // 
            lblStatCurrent.BackColor = Color.Transparent;
            lblStatCurrent.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblStatCurrent.ForeColor = Color.FromArgb(250, 140, 22);
            lblStatCurrent.Location = new Point(24, 90);
            lblStatCurrent.Name = "lblStatCurrent";
            lblStatCurrent.Size = new Size(292, 50);
            lblStatCurrent.TabIndex = 2;
            // 
            // statCardViolations
            // 
            statCardViolations.BorderColor = Color.FromArgb(240, 240, 240);
            statCardViolations.BorderWidth = 1F;
            statCardViolations.Controls.Add(lblStatViolationsIcon);
            statCardViolations.Controls.Add(lblStatViolationsTitle);
            statCardViolations.Controls.Add(lblStatViolations);
            statCardViolations.Location = new Point(98, 0);
            statCardViolations.Margin = new Padding(0, 0, 15, 0);
            statCardViolations.Name = "statCardViolations";
            statCardViolations.Padding = new Padding(20);
            statCardViolations.Radius = 8;
            statCardViolations.Shadow = 8;
            statCardViolations.MinimumSize = new Size(320, 177);
            statCardViolations.TabIndex = 3;
            // 
            // lblStatViolationsIcon
            // 
            lblStatViolationsIcon.BackColor = Color.Transparent;
            lblStatViolationsIcon.BadgeAlign = TAlign.TL;
            lblStatViolationsIcon.BadgeBack = Color.FromArgb(255, 77, 79);
            lblStatViolationsIcon.BadgeSize = 1F;
            lblStatViolationsIcon.BadgeSvg = "WarningOutlined";
            lblStatViolationsIcon.Font = new Font("Microsoft Sans Serif", 24F);
            lblStatViolationsIcon.Location = new Point(24, 24);
            lblStatViolationsIcon.Name = "lblStatViolationsIcon";
            lblStatViolationsIcon.Size = new Size(48, 48);
            lblStatViolationsIcon.TabIndex = 0;
            lblStatViolationsIcon.Text = "";
            // 
            // lblStatViolationsTitle
            // 
            lblStatViolationsTitle.BackColor = Color.Transparent;
            lblStatViolationsTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            lblStatViolationsTitle.ForeColor = Color.Gray;
            lblStatViolationsTitle.Location = new Point(80, 28);
            lblStatViolationsTitle.Name = "lblStatViolationsTitle";
            lblStatViolationsTitle.Size = new Size(220, 30);
            lblStatViolationsTitle.TabIndex = 1;
            lblStatViolationsTitle.Text = "Tổng vi phạm";
            // 
            // lblStatViolations
            // 
            lblStatViolations.BackColor = Color.Transparent;
            lblStatViolations.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblStatViolations.ForeColor = Color.FromArgb(255, 77, 79);
            lblStatViolations.Location = new Point(24, 90);
            lblStatViolations.Name = "lblStatViolations";
            lblStatViolations.Size = new Size(292, 50);
            lblStatViolations.TabIndex = 2;
            // 
            // statCardsTable
            statCardsTable.ColumnCount = 4;
            statCardsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statCardsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statCardsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statCardsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statCardsTable.RowCount = 1;
            statCardsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statCardsTable.Dock = DockStyle.Fill;
            statCardsTable.Location = new Point(12, 304);
            statCardsTable.Margin = new Padding(0, 0, 0, 20);
            statCardsTable.Name = "statCardsTable";
            statCardsTable.Size = new Size(1262, 177);
            statCardsTable.TabIndex = 22;
            // Add stat cards to table
            statCardViolations.Dock = DockStyle.Fill;
            statCardCurrent.Dock = DockStyle.Fill;
            statCardCapacity.Dock = DockStyle.Fill;
            statCardRooms.Dock = DockStyle.Fill;
            statCardsTable.Controls.Add(statCardViolations, 0, 0);
            statCardsTable.Controls.Add(statCardCurrent, 1, 0);
            statCardsTable.Controls.Add(statCardCapacity, 2, 0);
            statCardsTable.Controls.Add(statCardRooms, 3, 0);
            // 
            // lblContestName
            // 
            lblContestName.AutoSizeMode = TAutoSize.Auto;
            lblContestName.Dock = DockStyle.Top;
            lblContestName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblContestName.Location = new Point(0, 0);
            lblContestName.Name = "lblContestName";
            lblContestName.Size = new Size(0, 36);
            lblContestName.TabIndex = 0;
            // 
            // pnlContestInfo
            // 
            pnlContestInfo.Controls.Add(lblContestName);
            pnlContestInfo.Location = new Point(15, 15);
            pnlContestInfo.Name = "pnlContestInfo";
            pnlContestInfo.Size = new Size(1256, 60);
            pnlContestInfo.TabIndex = 0;
            // 
            // tblRooms
            // 
            tblRooms.Bordered = true;
            tblRooms.Dock = DockStyle.Fill;
            tblRooms.Gap = 12;
            tblRooms.Location = new Point(15, 1082);
            tblRooms.MinimumSize = new Size(900, 0);
            tblRooms.Name = "tblRooms";
            tblRooms.RowSelectedFore = Color.Black;
            tblRooms.ScrollBarAvoidHeader = true;
            tblRooms.Size = new Size(1256, 250);
            tblRooms.TabIndex = 10;
            // 
            // pgnRoomsTable
            // 
            pgnRoomsTable.Dock = DockStyle.Bottom;
            pgnRoomsTable.Location = new Point(14, 1337);
            pgnRoomsTable.Margin = new Padding(2);
            pgnRoomsTable.Name = "pgnRoomsTable";
            pgnRoomsTable.RightToLeft = RightToLeft.Yes;
            pgnRoomsTable.Size = new Size(1258, 39);
            pgnRoomsTable.TabIndex = 10;
            // 
            // lblRoomsHeader
            // 
            lblRoomsHeader = new AntdUI.Label();
            lblRoomsHeader.AutoSizeMode = TAutoSize.Auto;
            lblRoomsHeader.Dock = DockStyle.Left;
            lblRoomsHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRoomsHeader.Name = "lblRoomsHeader";
            lblRoomsHeader.Padding = new Padding(8, 4, 0, 4);
            lblRoomsHeader.Size = new Size(350, 40);
            lblRoomsHeader.TabIndex = 0;
            lblRoomsHeader.Text = "Danh sách Phòng thi";
            // 
            // pnlRoomsHeader
            // 
            pnlRoomsHeader = new AntdUI.Panel();
            pnlRoomsHeader.BackColor = Color.Transparent;
            pnlRoomsHeader.Dock = DockStyle.Top;
            pnlRoomsHeader.Name = "pnlRoomsHeader";
            pnlRoomsHeader.Padding = new Padding(0, 8, 0, 8);
            pnlRoomsHeader.Size = new Size(1256, 48);
            pnlRoomsHeader.TabIndex = 30;
            pnlRoomsHeader.Controls.Add(lblRoomsHeader);
            // 
            // pgnParticipants
            // 
            pgnParticipants.Dock = DockStyle.Top;
            pgnParticipants.Location = new Point(15, 1037);
            pgnParticipants.Name = "pgnParticipants";
            pgnParticipants.RightToLeft = RightToLeft.Yes;
            pgnParticipants.Size = new Size(1256, 39);
            pgnParticipants.TabIndex = 21;
            // 
            // tblParticipants
            // 
            tblParticipants.Bordered = true;
            tblParticipants.Dock = DockStyle.Top;
            tblParticipants.Gap = 8;
            tblParticipants.Gaps = new Size(8, 8);
            tblParticipants.Location = new Point(15, 781);
            tblParticipants.Name = "tblParticipants";
            tblParticipants.Size = new Size(1256, 250);
            tblParticipants.TabIndex = 20;
            // 
            // pnlParticipantsHeader
            // 
            pnlParticipantsHeader.BackColor = Color.Transparent;
            pnlParticipantsHeader.Controls.Add(lblParticipantsHeader);
            pnlParticipantsHeader.Controls.Add(flpParticipantsButtons);
            pnlParticipantsHeader.Dock = DockStyle.Top;
            pnlParticipantsHeader.Location = new Point(15, 727);
            pnlParticipantsHeader.Name = "pnlParticipantsHeader";
            pnlParticipantsHeader.Padding = new Padding(0, 8, 0, 8);
            pnlParticipantsHeader.Size = new Size(1256, 48);
            pnlParticipantsHeader.TabIndex = 11;
            // 
            // lblParticipantsHeader
            // 
            lblParticipantsHeader.AutoSizeMode = TAutoSize.Auto;
            lblParticipantsHeader.Dock = DockStyle.Left;
            lblParticipantsHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblParticipantsHeader.Location = new Point(0, 8);
            lblParticipantsHeader.Name = "lblParticipantsHeader";
            lblParticipantsHeader.Padding = new Padding(8, 0, 0, 0);
            lblParticipantsHeader.Size = new Size(314, 24);
            lblParticipantsHeader.TabIndex = 0;
            lblParticipantsHeader.Text = "Danh sách Thí sinh được phép tham gia";
            // 
            // flpParticipantsButtons
            // 
            flpParticipantsButtons.Controls.Add(btnAddParticipant);
            flpParticipantsButtons.Controls.Add(btnImportExcel);
            flpParticipantsButtons.Controls.Add(btnExportExcel);
            flpParticipantsButtons.Controls.Add(btnDownloadTemplate);
            flpParticipantsButtons.Dock = DockStyle.Right;
            flpParticipantsButtons.Align = TAlignFlow.RightCenter;
            flpParticipantsButtons.Name = "flpParticipantsButtons";
            flpParticipantsButtons.Padding = new Padding(0, 0, 8, 0);
            flpParticipantsButtons.Size = new Size(500, 40);
            flpParticipantsButtons.MinimumSize = new Size(350, 40);
            flpParticipantsButtons.TabIndex = 1;
            // 
            // btnDownloadTemplate
            // 
            btnDownloadTemplate.Location = new Point(0, 0);
            btnDownloadTemplate.Margin = new Padding(0, 0, 8, 0);
            btnDownloadTemplate.Name = "btnDownloadTemplate";
            btnDownloadTemplate.AutoSize = true;
            btnDownloadTemplate.Size = new Size(120, 32);
            btnDownloadTemplate.MinimumSize = new Size(100, 32);
            btnDownloadTemplate.TabIndex = 0;
            btnDownloadTemplate.Text = "Tải file mẫu";
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(-8, 0);
            btnExportExcel.Margin = new Padding(0, 0, 8, 0);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.AutoSize = true;
            btnExportExcel.Size = new Size(100, 32);
            btnExportExcel.MinimumSize = new Size(90, 32);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.Type = TTypeMini.Success;
            // 
            // btnImportExcel
            // 
            btnImportExcel.Location = new Point(-8, 0);
            btnImportExcel.Margin = new Padding(0, 0, 8, 0);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.AutoSize = true;
            btnImportExcel.Size = new Size(110, 32);
            btnImportExcel.MinimumSize = new Size(90, 32);
            btnImportExcel.TabIndex = 2;
            btnImportExcel.Text = "Import Excel";
            btnExportExcel.Type = TTypeMini.Success;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Location = new Point(-4, 0);
            btnAddParticipant.BorderWidth = 1;
            btnAddParticipant.Margin = new Padding(0);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.AutoSize = true;
            btnAddParticipant.Size = new Size(120, 32);
            btnAddParticipant.MinimumSize = new Size(100, 32);
            btnAddParticipant.TabIndex = 3;
            btnAddParticipant.Text = "Thêm thí sinh";
            btnAddParticipant.Type = TTypeMini.Primary;
            // 
            // pnlContestDetails
            // 
            pnlContestDetails.BackColor = Color.Transparent;
            pnlContestDetails.Controls.Add(tblContestDetails);
            pnlContestDetails.Dock = DockStyle.Top;
            pnlContestDetails.Location = new Point(15, 81);
            pnlContestDetails.Name = "pnlContestDetails";
            pnlContestDetails.Size = new Size(1256, 220);
            pnlContestDetails.TabIndex = 1;
            // 
            // tblContestDetails
            // 
            tblContestDetails.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblContestDetails.ColumnCount = 4;
            tblContestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblContestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tblContestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tblContestDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            tblContestDetails.Controls.Add(lblContestId, 0, 0);
            tblContestDetails.Controls.Add(lblContestIdValue, 1, 0);
            tblContestDetails.Controls.Add(lblContestStatusValue, 3, 0);
            tblContestDetails.Controls.Add(lblContestDesc, 0, 1);
            tblContestDetails.Controls.Add(lblContestDescValue, 1, 1);
            tblContestDetails.Controls.Add(lblContestStart, 0, 2);
            tblContestDetails.Controls.Add(lblContestStartValue, 1, 2);
            tblContestDetails.Controls.Add(lblContestEnd, 2, 2);
            tblContestDetails.Controls.Add(lblContestEndValue, 3, 2);
            tblContestDetails.Controls.Add(lblContestCreator, 0, 3);
            tblContestDetails.Controls.Add(lblContestCreatorValue, 1, 3);
            tblContestDetails.Controls.Add(lblContestCreated, 2, 3);
            tblContestDetails.Controls.Add(lblContestCreatedValue, 3, 3);
            tblContestDetails.Controls.Add(lblContestStatus, 2, 0);
            tblContestDetails.Dock = DockStyle.Fill;
            tblContestDetails.Location = new Point(0, 0);
            tblContestDetails.Margin = new Padding(0);
            tblContestDetails.Name = "tblContestDetails";
            tblContestDetails.RowCount = 4;
            tblContestDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContestDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContestDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContestDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblContestDetails.Size = new Size(1256, 220);
            tblContestDetails.TabIndex = 0;
            // 
            // lblContestId
            // 
            lblContestId.AutoSizeMode = TAutoSize.Auto;
            lblContestId.Dock = DockStyle.Fill;
            lblContestId.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestId.Location = new Point(4, 4);
            lblContestId.Name = "lblContestId";
            lblContestId.Size = new Size(25, 25);
            lblContestId.TabIndex = 0;
            lblContestId.Text = "ID:";
            // 
            // lblContestIdValue
            // 
            lblContestIdValue.AutoSizeMode = TAutoSize.Auto;
            lblContestIdValue.Dock = DockStyle.Fill;
            lblContestIdValue.Font = new Font("Segoe UI", 11F);
            lblContestIdValue.Location = new Point(230, 4);
            lblContestIdValue.Name = "lblContestIdValue";
            lblContestIdValue.Size = new Size(0, 0);
            lblContestIdValue.TabIndex = 1;
            lblContestIdValue.Text = "";
            // 
            // lblContestStatusValue
            // 
            lblContestStatusValue.AutoSizeMode = TAutoSize.Auto;
            lblContestStatusValue.Dock = DockStyle.Top;
            lblContestStatusValue.Enabled = false;
            lblContestStatusValue.Font = new Font("Segoe UI", 10F);
            lblContestStatusValue.Location = new Point(857, 4);
            lblContestStatusValue.Name = "lblContestStatusValue";
            lblContestStatusValue.Padding = new Padding(4, 2, 4, 2);
            lblContestStatusValue.Size = new Size(8, 27);
            lblContestStatusValue.TabIndex = 3;
            // 
            // lblContestDesc
            // 
            lblContestDesc.AutoSizeMode = TAutoSize.Auto;
            lblContestDesc.Dock = DockStyle.Fill;
            lblContestDesc.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestDesc.Location = new Point(4, 45);
            lblContestDesc.Name = "lblContestDesc";
            lblContestDesc.Size = new Size(57, 25);
            lblContestDesc.TabIndex = 4;
            lblContestDesc.Text = "Mô tả:";
            // 
            // lblContestDescValue
            // 
            lblContestDescValue.BackColor = Color.White;
            tblContestDetails.SetColumnSpan(lblContestDescValue, 3);
            lblContestDescValue.Dock = DockStyle.Fill;
            lblContestDescValue.Font = new Font("Segoe UI", 11F);
            lblContestDescValue.Location = new Point(230, 45);
            lblContestDescValue.Name = "lblContestDescValue";
            lblContestDescValue.Size = new Size(1022, 34);
            lblContestDescValue.TabIndex = 5;
            lblContestDescValue.Text = "";
            // 
            // lblContestStart
            // 
            lblContestStart.AutoSizeMode = TAutoSize.Auto;
            lblContestStart.Dock = DockStyle.Fill;
            lblContestStart.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestStart.Location = new Point(4, 86);
            lblContestStart.Name = "lblContestStart";
            lblContestStart.Size = new Size(160, 25);
            lblContestStart.TabIndex = 6;
            lblContestStart.Text = "Thời gian bắt đầu:";
            // 
            // lblContestStartValue
            // 
            lblContestStartValue.AutoSizeMode = TAutoSize.Auto;
            lblContestStartValue.Dock = DockStyle.Fill;
            lblContestStartValue.Font = new Font("Segoe UI", 11F);
            lblContestStartValue.Location = new Point(230, 86);
            lblContestStartValue.Name = "lblContestStartValue";
            lblContestStartValue.Size = new Size(0, 0);
            lblContestStartValue.TabIndex = 7;
            lblContestStartValue.Text = "";
            // 
            // lblContestEnd
            // 
            lblContestEnd.AutoSizeMode = TAutoSize.Auto;
            lblContestEnd.Dock = DockStyle.Fill;
            lblContestEnd.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestEnd.Location = new Point(631, 86);
            lblContestEnd.Name = "lblContestEnd";
            lblContestEnd.Size = new Size(164, 25);
            lblContestEnd.TabIndex = 8;
            lblContestEnd.Text = "Thời gian kết thúc:";
            // 
            // lblContestEndValue
            // 
            lblContestEndValue.AutoSizeMode = TAutoSize.Auto;
            lblContestEndValue.Dock = DockStyle.Fill;
            lblContestEndValue.Font = new Font("Segoe UI", 11F);
            lblContestEndValue.Location = new Point(857, 86);
            lblContestEndValue.Name = "lblContestEndValue";
            lblContestEndValue.Size = new Size(0, 0);
            lblContestEndValue.TabIndex = 9;
            lblContestEndValue.Text = "";
            // 
            // lblContestCreator
            // 
            lblContestCreator.AutoSizeMode = TAutoSize.Auto;
            lblContestCreator.Dock = DockStyle.Fill;
            lblContestCreator.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestCreator.Location = new Point(4, 127);
            lblContestCreator.Name = "lblContestCreator";
            lblContestCreator.Size = new Size(95, 25);
            lblContestCreator.TabIndex = 10;
            lblContestCreator.Text = "Người tạo:";
            // 
            // lblContestCreatorValue
            // 
            lblContestCreatorValue.AutoSizeMode = TAutoSize.Auto;
            lblContestCreatorValue.Dock = DockStyle.Fill;
            lblContestCreatorValue.Font = new Font("Segoe UI", 11F);
            lblContestCreatorValue.Location = new Point(230, 127);
            lblContestCreatorValue.Name = "lblContestCreatorValue";
            lblContestCreatorValue.Size = new Size(0, 0);
            lblContestCreatorValue.TabIndex = 11;
            lblContestCreatorValue.Text = "";
            // 
            // lblContestCreated
            // 
            lblContestCreated.AutoSizeMode = TAutoSize.Auto;
            lblContestCreated.Dock = DockStyle.Fill;
            lblContestCreated.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestCreated.Location = new Point(631, 127);
            lblContestCreated.Name = "lblContestCreated";
            lblContestCreated.Size = new Size(85, 25);
            lblContestCreated.TabIndex = 12;
            lblContestCreated.Text = "Ngày tạo:";
            // 
            // lblContestCreatedValue
            // 
            lblContestCreatedValue.AutoSizeMode = TAutoSize.Auto;
            lblContestCreatedValue.Dock = DockStyle.Fill;
            lblContestCreatedValue.Font = new Font("Segoe UI", 11F);
            lblContestCreatedValue.Location = new Point(857, 127);
            lblContestCreatedValue.Name = "lblContestCreatedValue";
            lblContestCreatedValue.Size = new Size(0, 0);
            lblContestCreatedValue.TabIndex = 13;
            lblContestCreatedValue.Text = "";
            // 
            // lblContestStatus
            // 
            lblContestStatus.AutoSizeMode = TAutoSize.Auto;
            lblContestStatus.Dock = DockStyle.Fill;
            lblContestStatus.Font = new Font("Segoe UI", 11.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContestStatus.Location = new Point(631, 4);
            lblContestStatus.Name = "lblContestStatus";
            lblContestStatus.Size = new Size(95, 25);
            lblContestStatus.TabIndex = 2;
            lblContestStatus.Text = "Trạng thái:";
            // 
            // spnContainer
            // 
            spnContainer.AutoScroll = true;
            spnContainer.Controls.Add(pgnRoomsTable);
            spnContainer.Controls.Add(tblRooms);
            spnContainer.Controls.Add(pnlRoomsHeader);
            spnContainer.Controls.Add(pgnParticipants);
            spnContainer.Controls.Add(tblParticipants);
            spnContainer.Controls.Add(pnlParticipantsHeader);
            spnContainer.Controls.Add(statCardsTable);
            spnContainer.Controls.Add(pnlContestDetails);
            spnContainer.Controls.Add(pnlContestInfo);
            spnContainer.Dock = DockStyle.Fill;
            spnContainer.Location = new Point(0, 0);
            spnContainer.Margin = new Padding(24, 18, 24, 18);
            spnContainer.Name = "spnContainer";
            spnContainer.Padding = new Padding(12);
            spnContainer.Size = new Size(1306, 639);
            spnContainer.TabIndex = 12;
            spnContainer.Vertical = true;
            // 
            // ContestDetailsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(spnContainer);
            DoubleBuffered = true;
            Name = "ContestDetailsView";
            Size = new Size(1306, 639);
            statCardRooms.ResumeLayout(false);
            statCardCapacity.ResumeLayout(false);
            statCardCurrent.ResumeLayout(false);
            statCardViolations.ResumeLayout(false);
            // 
            pnlContestInfo.ResumeLayout(false);
            pnlContestInfo.PerformLayout();
            spnContainer.ResumeLayout(false);
            pnlParticipantsHeader.ResumeLayout(false);
            pnlParticipantsHeader.PerformLayout();
            flpParticipantsButtons.ResumeLayout(false);
            pnlContestDetails.ResumeLayout(false);
            tblContestDetails.ResumeLayout(false);
            tblContestDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnlAction;
        private AntdUI.Panel pnlRoomsHeader;
        private AntdUI.Label lblRoomsHeader;
        private AntdUI.Table tblRooms;
        private Pagination pgnRoomsTable;
        private StackPanel spnContainer;
        private AntdUI.Label lblContestName;
        private AntdUI.Panel pnlContestInfo;
        private AntdUI.Panel pnlContestDetails;
        private TableLayoutPanel tblContestDetails;
        private AntdUI.Label lblContestStatusValue;
        private AntdUI.Label lblContestId;
        private AntdUI.Label lblContestIdValue;
        private AntdUI.Label lblContestStatus;
        private AntdUI.Label lblContestDesc;
        private AntdUI.Label lblContestDescValue;
        private AntdUI.Label lblContestStart;
        private AntdUI.Label lblContestStartValue;
        private AntdUI.Label lblContestEnd;
        private AntdUI.Label lblContestEndValue;
        private AntdUI.Label lblContestCreator;
        private AntdUI.Label lblContestCreatorValue;
        private AntdUI.Label lblContestCreated;
        private AntdUI.Label lblContestCreatedValue;
        private Pagination pgnParticipants;
        private AntdUI.Table tblParticipants;
        private AntdUI.Panel statCardRooms;
        private AntdUI.Panel statCardCapacity;
        private AntdUI.Panel statCardCurrent;
        private AntdUI.Panel statCardViolations;
    private TableLayoutPanel statCardsTable;
        private AntdUI.Label lblStatRooms;
        private AntdUI.Label lblStatRoomsIcon;
        private AntdUI.Label lblStatRoomsTitle;
        private AntdUI.Label lblStatCapacity;
        private AntdUI.Label lblStatCapacityIcon;
        private AntdUI.Label lblStatCapacityTitle;
        private AntdUI.Label lblStatCurrent;
        private AntdUI.Label lblStatCurrentIcon;
        private AntdUI.Label lblStatCurrentTitle;
        private AntdUI.Label lblStatViolations;
        private AntdUI.Label lblStatViolationsIcon;
        private AntdUI.Label lblStatViolationsTitle;
        private AntdUI.Panel pnlParticipantsHeader;
        private AntdUI.Label lblParticipantsHeader;
        private AntdUI.FlowPanel flpParticipantsButtons;
        private AntdUI.Button btnDownloadTemplate;
        private AntdUI.Button btnExportExcel;
        private AntdUI.Button btnImportExcel;
        private AntdUI.Button btnAddParticipant;
    }
}
