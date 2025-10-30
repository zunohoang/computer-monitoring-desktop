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
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(34, 40, 34, 40);
            pnlMain.Size = new Size(1460, 605);
            pnlMain.TabIndex = 0;
            // 
            // pnlContestsTable
            // 
            pnlContestsTable.AutoScroll = true;
            pnlContestsTable.BackColor = Color.White;
            pnlContestsTable.Controls.Add(pnlContestsContainer);
            pnlContestsTable.Controls.Add(pnlTableHeader);
            pnlContestsTable.Dock = DockStyle.Fill;
            pnlContestsTable.Location = new Point(34, 120);
            pnlContestsTable.Margin = new Padding(3, 4, 3, 4);
            pnlContestsTable.Name = "pnlContestsTable";
            pnlContestsTable.Size = new Size(1392, 445);
            pnlContestsTable.TabIndex = 1;
            // 
            // pnlContestsContainer
            // 
            pnlContestsContainer.AutoScroll = true;
            pnlContestsContainer.BackColor = Color.White;
            pnlContestsContainer.Dock = DockStyle.Fill;
            pnlContestsContainer.Location = new Point(0, 67);
            pnlContestsContainer.Name = "pnlContestsContainer";
            pnlContestsContainer.Size = new Size(1392, 378);
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
            pnlTableHeader.Margin = new Padding(3, 4, 3, 4);
            pnlTableHeader.MinimumSize = new Size(1600, 67);
            pnlTableHeader.Name = "pnlTableHeader";
            pnlTableHeader.Padding = new Padding(23, 20, 23, 20);
            pnlTableHeader.Size = new Size(1600, 67);
            pnlTableHeader.TabIndex = 0;
            // 
            // lblHeaderActions
            // 
            lblHeaderActions.BackColor = Color.Transparent;
            lblHeaderActions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderActions.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderActions.Location = new Point(1360, 20);
            lblHeaderActions.Margin = new Padding(3, 4, 3, 4);
            lblHeaderActions.Name = "lblHeaderActions";
            lblHeaderActions.Size = new Size(229, 27);
            lblHeaderActions.TabIndex = 6;
            lblHeaderActions.Text = "Thao tác";
            // 
            // lblHeaderStatus
            // 
            lblHeaderStatus.BackColor = Color.Transparent;
            lblHeaderStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStatus.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderStatus.Location = new Point(1223, 20);
            lblHeaderStatus.Margin = new Padding(3, 4, 3, 4);
            lblHeaderStatus.Name = "lblHeaderStatus";
            lblHeaderStatus.Size = new Size(114, 27);
            lblHeaderStatus.TabIndex = 5;
            lblHeaderStatus.Text = "Trạng thái";
            // 
            // lblHeaderEndTime
            // 
            lblHeaderEndTime.BackColor = Color.Transparent;
            lblHeaderEndTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderEndTime.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderEndTime.Location = new Point(994, 20);
            lblHeaderEndTime.Margin = new Padding(3, 4, 3, 4);
            lblHeaderEndTime.Name = "lblHeaderEndTime";
            lblHeaderEndTime.Size = new Size(206, 27);
            lblHeaderEndTime.TabIndex = 4;
            lblHeaderEndTime.Text = "Thời gian kết thúc";
            // 
            // lblHeaderStartTime
            // 
            lblHeaderStartTime.BackColor = Color.Transparent;
            lblHeaderStartTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderStartTime.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderStartTime.Location = new Point(766, 20);
            lblHeaderStartTime.Margin = new Padding(3, 4, 3, 4);
            lblHeaderStartTime.Name = "lblHeaderStartTime";
            lblHeaderStartTime.Size = new Size(206, 27);
            lblHeaderStartTime.TabIndex = 3;
            lblHeaderStartTime.Text = "Thời gian bắt đầu";
            // 
            // lblHeaderDescription
            // 
            lblHeaderDescription.BackColor = Color.Transparent;
            lblHeaderDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderDescription.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderDescription.Location = new Point(400, 20);
            lblHeaderDescription.Margin = new Padding(3, 4, 3, 4);
            lblHeaderDescription.Name = "lblHeaderDescription";
            lblHeaderDescription.Size = new Size(343, 27);
            lblHeaderDescription.TabIndex = 2;
            lblHeaderDescription.Text = "Mô tả";
            // 
            // lblHeaderName
            // 
            lblHeaderName.BackColor = Color.Transparent;
            lblHeaderName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderName.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderName.Location = new Point(91, 20);
            lblHeaderName.Margin = new Padding(3, 4, 3, 4);
            lblHeaderName.Name = "lblHeaderName";
            lblHeaderName.Size = new Size(286, 27);
            lblHeaderName.TabIndex = 1;
            lblHeaderName.Text = "Tên cuộc thi";
            // 
            // lblHeaderId
            // 
            lblHeaderId.BackColor = Color.Transparent;
            lblHeaderId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHeaderId.ForeColor = Color.FromArgb(32, 32, 32);
            lblHeaderId.Location = new Point(11, 20);
            lblHeaderId.Margin = new Padding(3, 4, 3, 4);
            lblHeaderId.Name = "lblHeaderId";
            lblHeaderId.Size = new Size(57, 27);
            lblHeaderId.TabIndex = 0;
            lblHeaderId.Text = "ID";
            // 
            // pnlHeader
            // 
            pnlHeader.Back = Color.Transparent;
            pnlHeader.Controls.Add(btnCreateContest);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(34, 40);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1392, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnCreateContest
            // 
            btnCreateContest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateContest.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreateContest.Location = new Point(1163, 13);
            btnCreateContest.Margin = new Padding(3, 4, 3, 4);
            btnCreateContest.Name = "btnCreateContest";
            btnCreateContest.Size = new Size(206, 53);
            btnCreateContest.TabIndex = 1;
            btnCreateContest.Text = "+ Tạo cuộc thi mới";
            btnCreateContest.Type = AntdUI.TTypeMini.Primary;
            btnCreateContest.Click += BtnCreateContest_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(32, 32, 32);
            lblTitle.Location = new Point(0, 13);
            lblTitle.Margin = new Padding(3, 4, 3, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Cuộc thi";
            // 
            // ContestView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ContestView";
            Size = new Size(1460, 605);
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
