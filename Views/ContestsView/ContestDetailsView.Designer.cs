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
            statCardsTable = new FlowPanel();
            lblContestName = new AntdUI.Label();
            pnlContestInfo = new AntdUI.Panel();
            tblRooms = new Table();
            pgnRoomsTable = new Pagination();
            spnContainer = new StackPanel();
            pnlRoomsHeader = new AntdUI.Panel();
            lblRoomsHeader = new AntdUI.Label();
            pgnParticipants = new Pagination();
            tblParticipants = new Table();
            pnlParticipantsHeader = new AntdUI.Panel();
            lblParticipantsHeader = new AntdUI.Label();
            flpParticipantsButtons = new FlowPanel();
            btnAddParticipant = new AntdUI.Button();
            btnImportExcel = new AntdUI.Button();
            btnExportExcel = new AntdUI.Button();
            btnDownloadTemplate = new AntdUI.Button();
            pnlContestDetails = new AntdUI.Panel();
            lblContestCreatedValue = new AntdUI.Label();
            lblContestCreated = new AntdUI.Label();
            lblContestCreatorValue = new AntdUI.Label();
            lblContestCreator = new AntdUI.Label();
            lblContestEndValue = new AntdUI.Label();
            lblContestEnd = new AntdUI.Label();
            lblContestStartValue = new AntdUI.Label();
            lblContestStart = new AntdUI.Label();
            lblContestDescValue = new AntdUI.Label();
            lblContestDesc = new AntdUI.Label();
            lblContestStatusValue = new AntdUI.Label();
            lblContestStatus = new AntdUI.Label();
            lblContestIdValue = new AntdUI.Label();
            lblContestId = new AntdUI.Label();
            statCardRooms.SuspendLayout();
            statCardCapacity.SuspendLayout();
            statCardCurrent.SuspendLayout();
            statCardViolations.SuspendLayout();
            statCardsTable.SuspendLayout();
            pnlContestInfo.SuspendLayout();
            spnContainer.SuspendLayout();
            pnlRoomsHeader.SuspendLayout();
            pnlParticipantsHeader.SuspendLayout();
            flpParticipantsButtons.SuspendLayout();
            pnlContestDetails.SuspendLayout();
            SuspendLayout();
            // 
            // statCardRooms
            // 
            statCardRooms.BorderColor = Color.FromArgb(240, 240, 240);
            statCardRooms.BorderWidth = 1F;
            statCardRooms.Controls.Add(lblStatRoomsIcon);
            statCardRooms.Controls.Add(lblStatRoomsTitle);
            statCardRooms.Controls.Add(lblStatRooms);
            statCardRooms.Margin = new Padding(0, 0, 15, 0);
            statCardRooms.MinimumSize = new Size(280, 177);
            statCardRooms.Name = "statCardRooms";
            statCardRooms.Padding = new Padding(20);
            statCardRooms.Radius = 8;
            statCardRooms.Shadow = 8;
            statCardRooms.Size = new Size(300, 177);
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
            statCardCapacity.Margin = new Padding(0, 0, 15, 0);
            statCardCapacity.MinimumSize = new Size(280, 177);
            statCardCapacity.Name = "statCardCapacity";
            statCardCapacity.Padding = new Padding(20);
            statCardCapacity.Radius = 8;
            statCardCapacity.Shadow = 8;
            statCardCapacity.Size = new Size(300, 177);
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
            statCardCurrent.Margin = new Padding(0, 0, 15, 0);
            statCardCurrent.MinimumSize = new Size(280, 177);
            statCardCurrent.Name = "statCardCurrent";
            statCardCurrent.Padding = new Padding(20);
            statCardCurrent.Radius = 8;
            statCardCurrent.Shadow = 8;
            statCardCurrent.Size = new Size(300, 177);
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
            statCardViolations.Margin = new Padding(0, 0, 15, 0);
            statCardViolations.MinimumSize = new Size(280, 177);
            statCardViolations.Name = "statCardViolations";
            statCardViolations.Padding = new Padding(20);
            statCardViolations.Radius = 8;
            statCardViolations.Shadow = 8;
            statCardViolations.Size = new Size(300, 177);
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
            // 
            statCardsTable.Controls.Add(statCardViolations);
            statCardsTable.Controls.Add(statCardCurrent);
            statCardsTable.Controls.Add(statCardCapacity);
            statCardsTable.Controls.Add(statCardRooms);
            statCardsTable.AutoSize = true;
            statCardsTable.Dock = DockStyle.Top;
            statCardsTable.Gap = 16;
            statCardsTable.Location = new Point(12, 308);
            statCardsTable.Margin = new Padding(0, 0, 0, 20);
            statCardsTable.MinimumSize = new Size(0, 177);
            statCardsTable.Name = "statCardsTable";
            statCardsTable.Size = new Size(1262, 177);
            statCardsTable.TabIndex = 22;
            // 
            // lblContestName
            // 
            lblContestName.Dock = DockStyle.Top;
            lblContestName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblContestName.ForeColor = Color.FromArgb(24, 24, 24);
            lblContestName.Location = new Point(27, 7);
            lblContestName.Name = "lblContestName";
            lblContestName.Size = new Size(1208, 40);
            lblContestName.TabIndex = 0;
            lblContestName.TextAlign = ContentAlignment.TopLeft;
            // 
            // pnlContestInfo
            // 
            pnlContestInfo.Back = Color.White;
            pnlContestInfo.BackColor = Color.Transparent;
            pnlContestInfo.BorderColor = Color.FromArgb(240, 240, 240);
            pnlContestInfo.BorderWidth = 1F;
            pnlContestInfo.Controls.Add(lblContestName);
            pnlContestInfo.Dock = DockStyle.Top;
            pnlContestInfo.Location = new Point(12, 12);
            pnlContestInfo.Margin = new Padding(0, 0, 0, 16);
            pnlContestInfo.MinimumSize = new Size(0, 60);
            pnlContestInfo.Name = "pnlContestInfo";
            pnlContestInfo.Padding = new Padding(20, 0, 20, 16);
            pnlContestInfo.Radius = 12;
            pnlContestInfo.Shadow = 4;
            pnlContestInfo.Size = new Size(1262, 60);
            pnlContestInfo.TabIndex = 0;
            // 
            // tblRooms
            // 
            tblRooms.Bordered = true;
            tblRooms.Dock = DockStyle.Fill;
            tblRooms.Gap = 12;
            tblRooms.Location = new Point(15, 929);
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
            pgnRoomsTable.Location = new Point(14, 1184);
            pgnRoomsTable.Margin = new Padding(2);
            pgnRoomsTable.Name = "pgnRoomsTable";
            pgnRoomsTable.RightToLeft = RightToLeft.Yes;
            pgnRoomsTable.Size = new Size(1258, 39);
            pgnRoomsTable.TabIndex = 10;
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
            // pnlRoomsHeader
            // 
            pnlRoomsHeader.BackColor = Color.Transparent;
            pnlRoomsHeader.Controls.Add(lblRoomsHeader);
            pnlRoomsHeader.Dock = DockStyle.Top;
            pnlRoomsHeader.Location = new Point(15, 875);
            pnlRoomsHeader.Name = "pnlRoomsHeader";
            pnlRoomsHeader.Padding = new Padding(0, 8, 0, 8);
            pnlRoomsHeader.Size = new Size(1256, 48);
            pnlRoomsHeader.TabIndex = 30;
            // 
            // lblRoomsHeader
            // 
            lblRoomsHeader.AutoSizeMode = TAutoSize.Auto;
            lblRoomsHeader.Dock = DockStyle.Left;
            lblRoomsHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRoomsHeader.Location = new Point(0, 8);
            lblRoomsHeader.Name = "lblRoomsHeader";
            lblRoomsHeader.Padding = new Padding(8, 4, 0, 4);
            lblRoomsHeader.Size = new Size(235, 40);
            lblRoomsHeader.TabIndex = 0;
            lblRoomsHeader.Text = "Danh sách Phòng thi";
            // 
            // pgnParticipants
            // 
            pgnParticipants.Dock = DockStyle.Top;
            pgnParticipants.Location = new Point(15, 830);
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
            tblParticipants.Location = new Point(15, 574);
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
            pnlParticipantsHeader.Location = new Point(15, 508);
            pnlParticipantsHeader.Name = "pnlParticipantsHeader";
            pnlParticipantsHeader.Padding = new Padding(0, 8, 0, 8);
            pnlParticipantsHeader.Size = new Size(1256, 60);
            pnlParticipantsHeader.TabIndex = 11;
            // 
            // lblParticipantsHeader
            // 
            lblParticipantsHeader.Dock = DockStyle.Left;
            lblParticipantsHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblParticipantsHeader.Location = new Point(0, 8);
            lblParticipantsHeader.Name = "lblParticipantsHeader";
            lblParticipantsHeader.Padding = new Padding(8, 0, 0, 0);
            lblParticipantsHeader.Size = new Size(447, 44);
            lblParticipantsHeader.TabIndex = 0;
            lblParticipantsHeader.Text = "Danh sách Thí sinh được phép tham gia";
            // 
            // flpParticipantsButtons
            // 
            flpParticipantsButtons.Align = TAlignFlow.RightCenter;
            flpParticipantsButtons.Controls.Add(btnAddParticipant);
            flpParticipantsButtons.Controls.Add(btnImportExcel);
            flpParticipantsButtons.Controls.Add(btnExportExcel);
            flpParticipantsButtons.Controls.Add(btnDownloadTemplate);
            flpParticipantsButtons.Dock = DockStyle.Fill;
            flpParticipantsButtons.Location = new Point(0, 8);
            flpParticipantsButtons.MinimumSize = new Size(350, 40);
            flpParticipantsButtons.Name = "flpParticipantsButtons";
            flpParticipantsButtons.Padding = new Padding(0, 0, 8, 0);
            flpParticipantsButtons.Size = new Size(1256, 44);
            flpParticipantsButtons.TabIndex = 1;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.AutoSizeMode = TAutoSize.Auto;
            btnAddParticipant.BorderWidth = 1F;
            btnAddParticipant.Location = new Point(1128, 0);
            btnAddParticipant.Margin = new Padding(0);
            btnAddParticipant.MinimumSize = new Size(100, 32);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(120, 45);
            btnAddParticipant.TabIndex = 3;
            btnAddParticipant.Text = "Thêm thí sinh";
            btnAddParticipant.Type = TTypeMini.Primary;
            // 
            // btnImportExcel
            // 
            btnImportExcel.AutoSizeMode = TAutoSize.Auto;
            btnImportExcel.Location = new Point(1008, 0);
            btnImportExcel.Margin = new Padding(0, 0, 8, 0);
            btnImportExcel.MinimumSize = new Size(90, 32);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(112, 45);
            btnImportExcel.TabIndex = 2;
            btnImportExcel.Text = "Import Excel";
            // 
            // btnExportExcel
            // 
            btnExportExcel.AutoSizeMode = TAutoSize.Auto;
            btnExportExcel.Location = new Point(902, 0);
            btnExportExcel.Margin = new Padding(0, 0, 8, 0);
            btnExportExcel.MinimumSize = new Size(90, 32);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(98, 45);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.Type = TTypeMini.Success;
            // 
            // btnDownloadTemplate
            // 
            btnDownloadTemplate.AutoSizeMode = TAutoSize.Auto;
            btnDownloadTemplate.Location = new Point(787, 0);
            btnDownloadTemplate.Margin = new Padding(0, 0, 8, 0);
            btnDownloadTemplate.MinimumSize = new Size(100, 32);
            btnDownloadTemplate.Name = "btnDownloadTemplate";
            btnDownloadTemplate.Size = new Size(107, 45);
            btnDownloadTemplate.TabIndex = 0;
            btnDownloadTemplate.Text = "Tải file mẫu";
            // 
            // pnlContestDetails
            // 
            pnlContestDetails.Back = Color.White;
            pnlContestDetails.BackColor = Color.Transparent;
            pnlContestDetails.BorderColor = Color.FromArgb(240, 240, 240);
            pnlContestDetails.BorderWidth = 1F;
            pnlContestDetails.Controls.Add(lblContestCreatedValue);
            pnlContestDetails.Controls.Add(lblContestCreated);
            pnlContestDetails.Controls.Add(lblContestCreatorValue);
            pnlContestDetails.Controls.Add(lblContestCreator);
            pnlContestDetails.Controls.Add(lblContestEndValue);
            pnlContestDetails.Controls.Add(lblContestEnd);
            pnlContestDetails.Controls.Add(lblContestStartValue);
            pnlContestDetails.Controls.Add(lblContestStart);
            pnlContestDetails.Controls.Add(lblContestDescValue);
            pnlContestDetails.Controls.Add(lblContestDesc);
            pnlContestDetails.Controls.Add(lblContestStatusValue);
            pnlContestDetails.Controls.Add(lblContestStatus);
            pnlContestDetails.Controls.Add(lblContestIdValue);
            pnlContestDetails.Controls.Add(lblContestId);
            pnlContestDetails.Dock = DockStyle.Top;
            pnlContestDetails.Location = new Point(12, 88);
            pnlContestDetails.Margin = new Padding(0, 0, 0, 20);
            pnlContestDetails.Name = "pnlContestDetails";
            pnlContestDetails.Padding = new Padding(24);
            pnlContestDetails.Radius = 12;
            pnlContestDetails.Shadow = 4;
            pnlContestDetails.Size = new Size(1262, 200);
            pnlContestDetails.TabIndex = 1;
            // 
            // lblContestCreatedValue
            // 
            lblContestCreatedValue.Font = new Font("Segoe UI", 10F);
            lblContestCreatedValue.Location = new Point(456, 144);
            lblContestCreatedValue.Name = "lblContestCreatedValue";
            lblContestCreatedValue.Size = new Size(200, 28);
            lblContestCreatedValue.TabIndex = 13;
            // 
            // lblContestCreated
            // 
            lblContestCreated.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestCreated.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestCreated.Location = new Point(350, 144);
            lblContestCreated.Name = "lblContestCreated";
            lblContestCreated.Size = new Size(100, 28);
            lblContestCreated.TabIndex = 12;
            lblContestCreated.Text = "Ngày tạo:";
            // 
            // lblContestCreatorValue
            // 
            lblContestCreatorValue.Font = new Font("Segoe UI", 10F);
            lblContestCreatorValue.Location = new Point(130, 144);
            lblContestCreatorValue.Name = "lblContestCreatorValue";
            lblContestCreatorValue.Size = new Size(200, 28);
            lblContestCreatorValue.TabIndex = 11;
            // 
            // lblContestCreator
            // 
            lblContestCreator.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestCreator.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestCreator.Location = new Point(24, 144);
            lblContestCreator.Name = "lblContestCreator";
            lblContestCreator.Size = new Size(100, 28);
            lblContestCreator.TabIndex = 10;
            lblContestCreator.Text = "Người tạo:";
            // 
            // lblContestEndValue
            // 
            lblContestEndValue.Font = new Font("Segoe UI", 10F);
            lblContestEndValue.Location = new Point(456, 104);
            lblContestEndValue.Name = "lblContestEndValue";
            lblContestEndValue.Size = new Size(200, 28);
            lblContestEndValue.TabIndex = 9;
            // 
            // lblContestEnd
            // 
            lblContestEnd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestEnd.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestEnd.Location = new Point(350, 104);
            lblContestEnd.Name = "lblContestEnd";
            lblContestEnd.Size = new Size(100, 28);
            lblContestEnd.TabIndex = 8;
            lblContestEnd.Text = "Kết thúc:";
            // 
            // lblContestStartValue
            // 
            lblContestStartValue.Font = new Font("Segoe UI", 10F);
            lblContestStartValue.Location = new Point(130, 104);
            lblContestStartValue.Name = "lblContestStartValue";
            lblContestStartValue.Size = new Size(200, 28);
            lblContestStartValue.TabIndex = 7;
            // 
            // lblContestStart
            // 
            lblContestStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestStart.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestStart.Location = new Point(24, 104);
            lblContestStart.Name = "lblContestStart";
            lblContestStart.Size = new Size(100, 28);
            lblContestStart.TabIndex = 6;
            lblContestStart.Text = "Bắt đầu:";
            // 
            // lblContestDescValue
            // 
            lblContestDescValue.Font = new Font("Segoe UI", 10F);
            lblContestDescValue.Location = new Point(130, 64);
            lblContestDescValue.Name = "lblContestDescValue";
            lblContestDescValue.Size = new Size(1050, 28);
            lblContestDescValue.TabIndex = 5;
            // 
            // lblContestDesc
            // 
            lblContestDesc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestDesc.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestDesc.Location = new Point(24, 64);
            lblContestDesc.Name = "lblContestDesc";
            lblContestDesc.Size = new Size(100, 28);
            lblContestDesc.TabIndex = 4;
            lblContestDesc.Text = "Mô tả:";
            // 
            // lblContestStatusValue
            // 
            lblContestStatusValue.BackColor = Color.FromArgb(230, 247, 255);
            lblContestStatusValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContestStatusValue.ForeColor = Color.FromArgb(24, 144, 255);
            lblContestStatusValue.Location = new Point(456, 24);
            lblContestStatusValue.Name = "lblContestStatusValue";
            lblContestStatusValue.Padding = new Padding(12, 4, 12, 4);
            lblContestStatusValue.Size = new Size(150, 28);
            lblContestStatusValue.TabIndex = 3;
            lblContestStatusValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblContestStatus
            // 
            lblContestStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestStatus.Location = new Point(350, 24);
            lblContestStatus.Name = "lblContestStatus";
            lblContestStatus.Size = new Size(100, 28);
            lblContestStatus.TabIndex = 2;
            lblContestStatus.Text = "Trạng thái:";
            // 
            // lblContestIdValue
            // 
            lblContestIdValue.Font = new Font("Segoe UI", 10F);
            lblContestIdValue.Location = new Point(130, 24);
            lblContestIdValue.Name = "lblContestIdValue";
            lblContestIdValue.Size = new Size(200, 28);
            lblContestIdValue.TabIndex = 1;
            // 
            // lblContestId
            // 
            lblContestId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblContestId.ForeColor = Color.FromArgb(64, 64, 64);
            lblContestId.Location = new Point(24, 24);
            lblContestId.Name = "lblContestId";
            lblContestId.Size = new Size(100, 28);
            lblContestId.TabIndex = 0;
            lblContestId.Text = "ID:";
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
            statCardsTable.ResumeLayout(false);
            pnlContestInfo.ResumeLayout(false);
            spnContainer.ResumeLayout(false);
            pnlRoomsHeader.ResumeLayout(false);
            pnlRoomsHeader.PerformLayout();
            pnlParticipantsHeader.ResumeLayout(false);
            flpParticipantsButtons.ResumeLayout(false);
            flpParticipantsButtons.PerformLayout();
            pnlContestDetails.ResumeLayout(false);
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
        private AntdUI.FlowPanel statCardsTable;
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