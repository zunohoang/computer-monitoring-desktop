using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class ContestView
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlMain = new Panel();
            pnlContestsTable = new Panel();
            pnlContestsContainer = new Panel();
            pnlTableHeader = new AntdUI.Panel();
            lblHeaderActions = new AntdUI.Label();
            lblHeaderStatus = new AntdUI.Label();
            lblHeaderEndTime = new AntdUI.Label();
            lblHeaderStartTime = new AntdUI.Label();
            lblHeaderDescription = new AntdUI.Label();
            lblHeaderName = new AntdUI.Label();
            lblHeaderId = new AntdUI.Label();
            pnlHeader = new AntdUI.Panel();
            btnCreateContest = new AntdUI.Button();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlContestsTable.SuspendLayout();
            pnlTableHeader.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(250, 250, 250);
            pnlMain.Controls.Add(pnlContestsTable);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(42, 50, 42, 50);
            pnlMain.Size = new Size(1825, 756);
========
            pnlMain.Margin = new Padding(4, 6, 4, 6);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(51, 60, 51, 60);
            pnlMain.Size = new Size(2190, 908);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlMain.TabIndex = 0;
            // 
            // pnlContestsTable
            // 
            pnlContestsTable.AutoScroll = true;
            pnlContestsTable.BackColor = Color.White;
            pnlContestsTable.Controls.Add(pnlContestsContainer);
            pnlContestsTable.Controls.Add(pnlTableHeader);
            pnlContestsTable.Dock = DockStyle.Fill;
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            pnlContestsTable.Location = new Point(42, 150);
            pnlContestsTable.Margin = new Padding(4, 5, 4, 5);
            pnlContestsTable.Name = "pnlContestsTable";
            pnlContestsTable.Size = new Size(1741, 556);
========
            pnlContestsTable.Location = new Point(51, 180);
            pnlContestsTable.Margin = new Padding(4, 6, 4, 6);
            pnlContestsTable.MinimumSize = new Size(2625, 668);
            pnlContestsTable.Name = "pnlContestsTable";
            pnlContestsTable.Size = new Size(2625, 668);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlContestsTable.TabIndex = 1;
            // 
            // pnlContestsContainer
            // 
            pnlContestsContainer.AutoScroll = true;
            pnlContestsContainer.BackColor = Color.White;
            pnlContestsContainer.Dock = DockStyle.Fill;
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            pnlContestsContainer.Location = new Point(0, 84);
            pnlContestsContainer.Margin = new Padding(4);
            pnlContestsContainer.Name = "pnlContestsContainer";
            pnlContestsContainer.Size = new Size(1741, 472);
========
            pnlContestsContainer.Location = new Point(0, 100);
            pnlContestsContainer.Margin = new Padding(4, 4, 4, 4);
            pnlContestsContainer.Name = "pnlContestsContainer";
            pnlContestsContainer.Size = new Size(2625, 568);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlContestsContainer.TabIndex = 1;
            // 
            // pnlTableHeader
            // 
            pnlTableHeader.Back = Color.FromArgb(250, 250, 250);
            pnlTableHeader.BorderColor = Color.FromArgb(240, 240, 240);
            pnlTableHeader.BorderWidth = 1F;
            pnlTableHeader.Controls.Add(lblHeaderActions);
            pnlTableHeader.Controls.Add(lblHeaderStatus);
            pnlTableHeader.Controls.Add(lblHeaderEndTime);
            pnlTableHeader.Controls.Add(lblHeaderStartTime);
            pnlTableHeader.Controls.Add(lblHeaderDescription);
            pnlTableHeader.Controls.Add(lblHeaderName);
            pnlTableHeader.Controls.Add(lblHeaderId);
            pnlTableHeader.Dock = DockStyle.Top;
            pnlTableHeader.Location = new Point(0, 0);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            pnlTableHeader.Margin = new Padding(4, 5, 4, 5);
            pnlTableHeader.MinimumSize = new Size(2000, 84);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Padding = new Padding(29, 25, 29, 25);
            pnlTableHeader.Size = new Size(2000, 84);
========
            pnlTableHeader.Margin = new Padding(4, 6, 4, 6);
            pnlTableHeader.MinimumSize = new Size(2625, 100);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Padding = new Padding(34, 30, 34, 30);
            pnlTableHeader.Size = new Size(2625, 100);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlTableHeader.TabIndex = 0;
            // 
            // lblHeaderActions
            // 
            lblHeaderActions.BackColor = Color.Transparent;
            lblHeaderActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderActions.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderActions.Location = new Point(1700, 25);
            lblHeaderActions.Margin = new Padding(4, 5, 4, 5);
            lblHeaderActions.Name = "lblHeaderActions";
            lblHeaderActions.Size = new Size(286, 34);
========
            lblHeaderActions.Location = new Point(2040, 30);
            lblHeaderActions.Margin = new Padding(4, 6, 4, 6);
            lblHeaderActions.Name = "lblHeaderActions";
            lblHeaderActions.Size = new Size(344, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderActions.TabIndex = 6;
            lblHeaderActions.Text = "Thao tác";
            // 
            // lblHeaderStatus
            // 
            lblHeaderStatus.BackColor = Color.Transparent;
            lblHeaderStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStatus.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderStatus.Location = new Point(1529, 25);
            lblHeaderStatus.Margin = new Padding(4, 5, 4, 5);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(142, 34);
========
            lblHeaderStatus.Location = new Point(1834, 30);
            lblHeaderStatus.Margin = new Padding(4, 6, 4, 6);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(171, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderStatus.TabIndex = 5;
            lblHeaderStatus.Text = "Trạng thái";
            // 
            // lblHeaderEndTime
            // 
            lblHeaderEndTime.BackColor = Color.Transparent;
            lblHeaderEndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderEndTime.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderEndTime.Location = new Point(1242, 25);
            lblHeaderEndTime.Margin = new Padding(4, 5, 4, 5);
            lblHeaderEndTime.Name = "lblHeaderEndTime";
            lblHeaderEndTime.Size = new Size(258, 34);
========
            lblHeaderEndTime.Location = new Point(1491, 30);
            lblHeaderEndTime.Margin = new Padding(4, 6, 4, 6);
            lblHeaderEndTime.Name = "lblHeaderEndTime";
            lblHeaderEndTime.Size = new Size(309, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderEndTime.TabIndex = 4;
            lblHeaderEndTime.Text = "Thời gian kết thúc";
            // 
            // lblHeaderStartTime
            // 
            lblHeaderStartTime.BackColor = Color.Transparent;
            lblHeaderStartTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStartTime.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderStartTime.Location = new Point(958, 25);
            lblHeaderStartTime.Margin = new Padding(4, 5, 4, 5);
            lblHeaderStartTime.Name = "lblHeaderStartTime";
            lblHeaderStartTime.Size = new Size(258, 34);
========
            lblHeaderStartTime.Location = new Point(1149, 30);
            lblHeaderStartTime.Margin = new Padding(4, 6, 4, 6);
            lblHeaderStartTime.Name = "lblHeaderStartTime";
            lblHeaderStartTime.Size = new Size(309, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderStartTime.TabIndex = 3;
            lblHeaderStartTime.Text = "Thời gian bắt đầu";
            // 
            // lblHeaderDescription
            // 
            lblHeaderDescription.BackColor = Color.Transparent;
            lblHeaderDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderDescription.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderDescription.Location = new Point(500, 25);
            lblHeaderDescription.Margin = new Padding(4, 5, 4, 5);
            lblHeaderDescription.Name = "lblHeaderDescription";
            lblHeaderDescription.Size = new Size(429, 34);
========
            lblHeaderDescription.Location = new Point(600, 30);
            lblHeaderDescription.Margin = new Padding(4, 6, 4, 6);
            lblHeaderDescription.Name = "lblHeaderDescription";
            lblHeaderDescription.Size = new Size(514, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderDescription.TabIndex = 2;
            lblHeaderDescription.Text = "Mô tả";
            // 
            // lblHeaderName
            // 
            lblHeaderName.BackColor = Color.Transparent;
            lblHeaderName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderName.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderName.Location = new Point(114, 25);
            lblHeaderName.Margin = new Padding(4, 5, 4, 5);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(358, 34);
========
            lblHeaderName.Location = new Point(136, 30);
            lblHeaderName.Margin = new Padding(4, 6, 4, 6);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(429, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderName.TabIndex = 1;
            lblHeaderName.Text = "Tên cuộc thi";
            // 
            // lblHeaderId
            // 
            lblHeaderId.BackColor = Color.Transparent;
            lblHeaderId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderId.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblHeaderId.Location = new Point(14, 25);
            lblHeaderId.Margin = new Padding(4, 5, 4, 5);
            lblHeaderId.Name = "lblHeaderId";
            lblHeaderId.Size = new Size(71, 34);
========
            lblHeaderId.Location = new Point(16, 30);
            lblHeaderId.Margin = new Padding(4, 6, 4, 6);
            lblHeaderId.Name = "lblHeaderId";
            lblHeaderId.Size = new Size(86, 40);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblHeaderId.TabIndex = 0;
            lblHeaderId.Text = "ID";
            // 
            // pnlHeader
            // 
            pnlHeader.Back = Color.Transparent;
            pnlHeader.Controls.Add(btnCreateContest);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            pnlHeader.Location = new Point(42, 50);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1741, 100);
========
            pnlHeader.Location = new Point(51, 60);
            pnlHeader.Margin = new Padding(4, 6, 4, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(2088, 120);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlHeader.TabIndex = 0;
            // 
            // btnCreateContest
            // 
            btnCreateContest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateContest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            btnCreateContest.Location = new Point(1455, 16);
            btnCreateContest.Margin = new Padding(4, 5, 4, 5);
            btnCreateContest.Name = "btnCreateContest";
            btnCreateContest.Size = new Size(258, 66);
========
            btnCreateContest.Location = new Point(1744, 20);
            btnCreateContest.Margin = new Padding(4, 6, 4, 6);
            btnCreateContest.Name = "btnCreateContest";
            btnCreateContest.Size = new Size(309, 80);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            btnCreateContest.TabIndex = 1;
            btnCreateContest.Text = "+ Tạo cuộc thi mới";
            btnCreateContest.Type = AntdUI.TTypeMini.Primary;
            btnCreateContest.Click += BtnCreateContest_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(32, 32, 32);
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            lblTitle.Location = new Point(0, 16);
            lblTitle.Margin = new Padding(4, 5, 4, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(429, 66);
========
            lblTitle.Location = new Point(0, 20);
            lblTitle.Margin = new Padding(4, 6, 4, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(514, 80);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Cuộc thi";
            // 
            // ContestView
            // 
<<<<<<<< HEAD:Views/ContestsView/ContestView.Designer.cs
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ContestView";
            Size = new Size(1825, 756);
========
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 6, 4, 6);
            Name = "ContestView";
            Size = new Size(2190, 908);
>>>>>>>> feat/auth:Views/Contests/ContestView.Designer.cs
            pnlMain.ResumeLayout(false);
            pnlContestsTable.ResumeLayout(false);
            pnlTableHeader.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Button btnCreateContest;
        private AntdUI.Label lblTitle;
        private Panel pnlContestsTable;
        private Panel pnlContestsContainer;
        private AntdUI.Panel pnlTableHeader;
        private AntdUI.Label lblHeaderActions;
        private AntdUI.Label lblHeaderStatus;
        private AntdUI.Label lblHeaderEndTime;
        private AntdUI.Label lblHeaderStartTime;
        private AntdUI.Label lblHeaderDescription;
        private AntdUI.Label lblHeaderName;
        private AntdUI.Label lblHeaderId;
    }
}
