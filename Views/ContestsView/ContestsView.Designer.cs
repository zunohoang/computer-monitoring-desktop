using AntdUI;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

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
            pnlMain = new AntdUI.Panel();
            pnlContestsTable = new AntdUI.Panel();
            pnlContestsContainer = new AntdUI.Panel();
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
            pnlMain.BackColor = Color.FromArgb(250, 250, 250);
            pnlMain.Controls.Add(pnlContestsTable);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(4, 6, 4, 6);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(51, 60, 51, 60);
            pnlMain.Size = new Size(2190, 908);
            pnlMain.TabIndex = 0;
            // 
            // pnlContestsTable
            // 
            pnlContestsTable.BackColor = Color.White;
            pnlContestsTable.Controls.Add(pnlContestsContainer);
            pnlContestsTable.Controls.Add(pnlTableHeader);
            pnlContestsTable.Dock = DockStyle.Fill;
            pnlContestsTable.Location = new Point(51, 180);
            pnlContestsTable.Margin = new Padding(4, 6, 4, 6);
            pnlContestsTable.MinimumSize = new Size(2625, 668);
            pnlContestsTable.Name = "pnlContestsTable";
            pnlContestsTable.Size = new Size(2625, 668);
            pnlContestsTable.TabIndex = 1;
            // 
            // pnlContestsContainer
            // 
            pnlContestsContainer.BackColor = Color.White;
            pnlContestsContainer.Dock = DockStyle.Fill;
            pnlContestsContainer.Location = new Point(0, 100);
            pnlContestsContainer.Margin = new Padding(4, 4, 4, 4);
            pnlContestsContainer.Name = "pnlContestsContainer";
            pnlContestsContainer.Size = new Size(2625, 568);
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
            pnlTableHeader.Margin = new Padding(4, 6, 4, 6);
            pnlTableHeader.MinimumSize = new Size(2625, 100);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Padding = new Padding(34, 30, 34, 30);
            pnlTableHeader.Size = new Size(2625, 100);
            pnlTableHeader.TabIndex = 0;
            // 
            // lblHeaderActions
            // 
            lblHeaderActions.BackColor = Color.Transparent;
            lblHeaderActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderActions.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderActions.Location = new Point(2040, 30);
            lblHeaderActions.Margin = new Padding(4, 6, 4, 6);
            lblHeaderActions.Name = "lblHeaderActions";
            lblHeaderActions.Size = new Size(344, 40);
            lblHeaderActions.TabIndex = 6;
            lblHeaderActions.Text = "Thao tác";
            // 
            // lblHeaderStatus
            // 
            lblHeaderStatus.BackColor = Color.Transparent;
            lblHeaderStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStatus.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderStatus.Location = new Point(1834, 30);
            lblHeaderStatus.Margin = new Padding(4, 6, 4, 6);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(171, 40);
            lblHeaderStatus.TabIndex = 5;
            lblHeaderStatus.Text = "Trạng thái";
            // 
            // lblHeaderEndTime
            // 
            lblHeaderEndTime.BackColor = Color.Transparent;
            lblHeaderEndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderEndTime.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderEndTime.Location = new Point(1491, 30);
            lblHeaderEndTime.Margin = new Padding(4, 6, 4, 6);
            lblHeaderEndTime.Name = "lblHeaderEndTime";
            lblHeaderEndTime.Size = new Size(309, 40);
            lblHeaderEndTime.TabIndex = 4;
            lblHeaderEndTime.Text = "Thời gian kết thúc";
            // 
            // lblHeaderStartTime
            // 
            lblHeaderStartTime.BackColor = Color.Transparent;
            lblHeaderStartTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStartTime.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderStartTime.Location = new Point(1149, 30);
            lblHeaderStartTime.Margin = new Padding(4, 6, 4, 6);
            lblHeaderStartTime.Name = "lblHeaderStartTime";
            lblHeaderStartTime.Size = new Size(309, 40);
            lblHeaderStartTime.TabIndex = 3;
            lblHeaderStartTime.Text = "Thời gian bắt đầu";
            // 
            // lblHeaderDescription
            // 
            lblHeaderDescription.BackColor = Color.Transparent;
            lblHeaderDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderDescription.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderDescription.Location = new Point(600, 30);
            lblHeaderDescription.Margin = new Padding(4, 6, 4, 6);
            lblHeaderDescription.Name = "lblHeaderDescription";
            lblHeaderDescription.Size = new Size(514, 40);
            lblHeaderDescription.TabIndex = 2;
            lblHeaderDescription.Text = "Mô tả";
            // 
            // lblHeaderName
            // 
            lblHeaderName.BackColor = Color.Transparent;
            lblHeaderName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderName.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderName.Location = new Point(136, 30);
            lblHeaderName.Margin = new Padding(4, 6, 4, 6);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(429, 40);
            lblHeaderName.TabIndex = 1;
            lblHeaderName.Text = "Tên cuộc thi";
            // 
            // lblHeaderId
            // 
            lblHeaderId.BackColor = Color.Transparent;
            lblHeaderId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderId.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderId.Location = new Point(16, 30);
            lblHeaderId.Margin = new Padding(4, 6, 4, 6);
            lblHeaderId.Name = "lblHeaderId";
            lblHeaderId.Size = new Size(86, 40);
            lblHeaderId.TabIndex = 0;
            lblHeaderId.Text = "ID";
            // 
            // pnlHeader
            // 
            pnlHeader.Back = Color.Transparent;
            pnlHeader.Controls.Add(btnCreateContest);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(51, 60);
            pnlHeader.Margin = new Padding(4, 6, 4, 6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(2088, 120);
            pnlHeader.TabIndex = 0;
            // 
            // btnCreateContest
            // 
            btnCreateContest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateContest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreateContest.Location = new Point(1744, 20);
            btnCreateContest.Margin = new Padding(4, 6, 4, 6);
            btnCreateContest.Name = "btnCreateContest";
            btnCreateContest.Size = new Size(309, 80);
            btnCreateContest.TabIndex = 1;
            btnCreateContest.Text = "+ Tạo cuộc thi mới";
            btnCreateContest.Type = AntdUI.TTypeMini.Primary;
            btnCreateContest.Click += BtnCreateContest_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(32, 32, 32);
            lblTitle.Location = new Point(0, 20);
            lblTitle.Margin = new Padding(4, 6, 4, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(514, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Cuộc thi";
            // 
            // ContestView
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 6, 4, 6);
            Name = "ContestView";
            Size = new Size(2190, 908);
            pnlMain.ResumeLayout(false);
            pnlContestsTable.ResumeLayout(false);
            pnlTableHeader.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Button btnCreateContest;
        private AntdUI.Label lblTitle;
        private AntdUI.Panel pnlContestsTable;
        private AntdUI.Panel pnlContestsContainer;
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