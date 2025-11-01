using System.Drawing;
using System.Windows.Forms;
using AntdUI;

namespace computer_monitoring_desktop.Views
{
    partial class RoomManagementView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            pnlRooms = new AntdUI.Panel();
            tblRooms = new AntdUI.Table();
            lblRoomsTitle = new AntdUI.Label();
            pnlContestants = new AntdUI.Panel();
            pgnContestants = new AntdUI.Pagination();
            tblContestants = new AntdUI.Table();
            pnlContestantsHeader = new AntdUI.Panel();
            lblContestantsTitle = new AntdUI.Label();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlContestants.SuspendLayout();
            pnlContestantsHeader.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.FixedPanel = FixedPanel.Panel1;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            splitMain.Panel1MinSize = 300;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(pnlRooms);
            splitMain.Panel1.Padding = new Padding(24, 24, 8, 24);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(pnlContestants);
            splitMain.Panel2.Padding = new Padding(8, 24, 24, 24);
            splitMain.Size = new Size(1825, 975);
            splitMain.SplitterDistance = 374;
            splitMain.SplitterWidth = 16;
            splitMain.TabIndex = 0;
            // 
            // pnlRooms
            // 
            pnlRooms.BorderColor = Color.FromArgb(240, 240, 240);
            pnlRooms.BorderWidth = 1F;
            pnlRooms.Controls.Add(tblRooms);
            pnlRooms.Controls.Add(lblRoomsTitle);
            pnlRooms.Dock = DockStyle.Fill;
            pnlRooms.Location = new Point(24, 24);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Padding = new Padding(20);
            pnlRooms.Radius = 12;
            pnlRooms.Shadow = 4;
            pnlRooms.Size = new Size(342, 927);
            pnlRooms.TabIndex = 0;
            // 
            // tblRooms
            // 
            tblRooms.Bordered = true;
            tblRooms.Dock = DockStyle.Fill;
            tblRooms.EnableHeaderResizing = true;
            tblRooms.Gap = 8;
            tblRooms.Location = new Point(20, 68);
            tblRooms.Name = "tblRooms";
            tblRooms.RowSelectedFore = Color.Black;
            tblRooms.Size = new Size(310, 887);
            tblRooms.TabIndex = 1;
            // 
            // lblRoomsTitle
            // 
            lblRoomsTitle.BackColor = Color.Transparent;
            lblRoomsTitle.Dock = DockStyle.Top;
            lblRoomsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRoomsTitle.Location = new Point(20, 20);
            lblRoomsTitle.Name = "lblRoomsTitle";
            lblRoomsTitle.Padding = new Padding(0, 0, 0, 8);
            lblRoomsTitle.Size = new Size(310, 48);
            lblRoomsTitle.TabIndex = 0;
            lblRoomsTitle.Text = "Phòng thi";
            lblRoomsTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlContestants
            // 
            pnlContestants.BorderColor = Color.FromArgb(240, 240, 240);
            pnlContestants.BorderWidth = 1F;
            pnlContestants.Controls.Add(pgnContestants);
            pnlContestants.Controls.Add(tblContestants);
            pnlContestants.Controls.Add(pnlContestantsHeader);
            pnlContestants.Dock = DockStyle.Fill;
            pnlContestants.Location = new Point(8, 24);
            pnlContestants.Name = "pnlContestants";
            pnlContestants.Padding = new Padding(20);
            pnlContestants.Radius = 12;
            pnlContestants.Shadow = 4;
            pnlContestants.Size = new Size(1403, 927);
            pnlContestants.TabIndex = 1;
            // 
            // pgnContestants
            // 
            pgnContestants.Dock = DockStyle.Bottom;
            pgnContestants.Location = new Point(20, 905);
            pgnContestants.Name = "pgnContestants";
            pgnContestants.RightToLeft = RightToLeft.Yes;
            pgnContestants.ShowSizeChanger = true;
            pgnContestants.Size = new Size(1395, 50);
            pgnContestants.SizeChangerWidth = 50;
            pgnContestants.TabIndex = 2;
            // 
            // tblContestants
            // 
            tblContestants.Bordered = true;
            tblContestants.Dock = DockStyle.Fill;
            tblContestants.EnableHeaderResizing = true;
            tblContestants.Gap = 8;
            tblContestants.Location = new Point(20, 68);
            tblContestants.Name = "tblContestants";
            tblContestants.RowSelectedFore = Color.Black;
            tblContestants.Size = new Size(1395, 887);
            tblContestants.TabIndex = 1;
            // 
            // pnlContestantsHeader
            // 
            pnlContestantsHeader.BackColor = Color.Transparent;
            pnlContestantsHeader.Controls.Add(lblContestantsTitle);
            pnlContestantsHeader.Dock = DockStyle.Top;
            pnlContestantsHeader.Location = new Point(20, 20);
            pnlContestantsHeader.Name = "pnlContestantsHeader";
            pnlContestantsHeader.Padding = new Padding(0, 0, 0, 8);
            pnlContestantsHeader.Size = new Size(1395, 48);
            pnlContestantsHeader.TabIndex = 0;
            // 
            // lblContestantsTitle
            // 
            lblContestantsTitle.BackColor = Color.Transparent;
            lblContestantsTitle.Dock = DockStyle.Left;
            lblContestantsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblContestantsTitle.Location = new Point(0, 0);
            lblContestantsTitle.Name = "lblContestantsTitle";
            lblContestantsTitle.Size = new Size(600, 40);
            lblContestantsTitle.TabIndex = 0;
            lblContestantsTitle.Text = "Thí sinh";
            lblContestantsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoomManagementView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RoomManagementView";
            Size = new Size(1825, 975);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlContestants.ResumeLayout(false);
            pnlContestantsHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Main layout
        private SplitContainer splitMain;
        
        // Rooms panel (left side)
        private AntdUI.Panel pnlRooms;
        private AntdUI.Label lblRoomsTitle;
        private AntdUI.Table tblRooms;
        
        // Contestants panel (right side)
        private AntdUI.Panel pnlContestants;
        private AntdUI.Panel pnlContestantsHeader;
        private AntdUI.Label lblContestantsTitle;
        private AntdUI.Table tblContestants;
        private AntdUI.Pagination pgnContestants;
    }
}
