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
            tblContests = new Table();
            pgnContests = new Pagination();
            pnlHeader = new AntdUI.Panel();
            btnCreateContest = new AntdUI.Button();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlContestsTable.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
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
            pnlContestsTable.Controls.Add(tblContests);
            pnlContestsTable.Controls.Add(pgnContests);
            pnlContestsTable.Dock = DockStyle.Top;
            pnlContestsTable.Location = new Point(34, 120);
            pnlContestsTable.Margin = new Padding(3, 4, 3, 4);
            pnlContestsTable.Name = "pnlContestsTable";
            pnlContestsTable.Padding = new Padding(13);
            pnlContestsTable.Size = new Size(1392, 365);
            pnlContestsTable.TabIndex = 1;
            // 
            // tblContests
            // 
            tblContests.Bordered = true;
            tblContests.Dock = DockStyle.Fill;
            tblContests.EnableHeaderResizing = true;
            tblContests.Gap = 12;
            tblContests.Location = new Point(13, 13);
            tblContests.Margin = new Padding(2);
            tblContests.Name = "tblContests";
            tblContests.Size = new Size(1366, 306);
            tblContests.TabIndex = 0;
            // 
            // pgnContests
            // 
            pgnContests.Dock = DockStyle.Bottom;
            pgnContests.Location = new Point(13, 319);
            pgnContests.Margin = new Padding(2);
            pgnContests.Name = "pgnContests";
            pgnContests.PageSize = 5;
            pgnContests.RightToLeft = RightToLeft.Yes;
            pgnContests.ShowSizeChanger = true;
            pgnContests.Size = new Size(1366, 50);
            pgnContests.SizeChangerWidth = 50;
            pgnContests.TabIndex = 1;
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
            btnCreateContest.Type = TTypeMini.Primary;
            btnCreateContest.Click += BtnCreateContest_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
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
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Button btnCreateContest;
        private AntdUI.Label lblTitle;
        private AntdUI.Panel pnlContestsTable;
        private AntdUI.Table tblContests;
        private AntdUI.Pagination pgnContests;
    }
}