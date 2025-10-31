using System.Drawing;
using System.Windows.Forms;

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
            tblMain = new TableLayoutPanel();
            pnlRooms = new AntdUI.Panel();
            lstRooms = new ListBox();
            lblRoomsTitle = new AntdUI.Label();
            pnlContestants = new AntdUI.Panel();
            lblHint = new AntdUI.Label();
            lvContestants = new ListView();
            columnHeaderStudentCode = new ColumnHeader();
            columnHeaderStudentName = new ColumnHeader();
            columnHeaderMachine = new ColumnHeader();
            lblContestantsTitle = new AntdUI.Label();
            tblMain.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlContestants.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 280F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlRooms, 0, 0);
            tblMain.Controls.Add(pnlContestants, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(0);
            tblMain.Name = "tblMain";
            tblMain.Padding = new Padding(24);
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1825, 975);
            tblMain.TabIndex = 0;
            // 
            // pnlRooms
            // 
            pnlRooms.Back = Color.White;
            pnlRooms.Controls.Add(lstRooms);
            pnlRooms.Controls.Add(lblRoomsTitle);
            pnlRooms.Dock = DockStyle.Fill;
            pnlRooms.Margin = new Padding(0, 0, 16, 0);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Padding = new Padding(22);
            pnlRooms.Radius = 12;
            pnlRooms.Size = new Size(280, 927);
            pnlRooms.TabIndex = 0;
            // 
            // lstRooms
            // 
            lstRooms.BackColor = Color.White;
            lstRooms.BorderStyle = BorderStyle.None;
            lstRooms.Dock = DockStyle.Fill;
            lstRooms.Font = new Font("Segoe UI", 10F);
            lstRooms.ForeColor = Color.FromArgb(51, 65, 85);
            lstRooms.FormattingEnabled = true;
            lstRooms.IntegralHeight = false;
            lstRooms.ItemHeight = 28;
            lstRooms.Location = new Point(22, 86);
            lstRooms.Margin = new Padding(0);
            lstRooms.Name = "lstRooms";
            lstRooms.Size = new Size(236, 819);
            lstRooms.TabIndex = 1;
            // 
            // lblRoomsTitle
            // 
            lblRoomsTitle.BackColor = Color.Transparent;
            lblRoomsTitle.Dock = DockStyle.Top;
            lblRoomsTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblRoomsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblRoomsTitle.Location = new Point(22, 22);
            lblRoomsTitle.Margin = new Padding(0, 0, 0, 12);
            lblRoomsTitle.Name = "lblRoomsTitle";
            lblRoomsTitle.Size = new Size(236, 64);
            lblRoomsTitle.TabIndex = 0;
            lblRoomsTitle.Text = "Phòng thi";
            lblRoomsTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlContestants
            // 
            pnlContestants.Back = Color.White;
            pnlContestants.Controls.Add(lblHint);
            pnlContestants.Controls.Add(lvContestants);
            pnlContestants.Controls.Add(lblContestantsTitle);
            pnlContestants.Dock = DockStyle.Fill;
            pnlContestants.Margin = new Padding(0);
            pnlContestants.Name = "pnlContestants";
            pnlContestants.Padding = new Padding(26);
            pnlContestants.Radius = 12;
            pnlContestants.Size = new Size(1521, 927);
            pnlContestants.TabIndex = 1;
            // 
            // lblHint
            // 
            lblHint.BackColor = Color.Transparent;
            lblHint.Dock = DockStyle.Bottom;
            lblHint.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblHint.ForeColor = Color.FromArgb(100, 116, 139);
            lblHint.Location = new Point(26, 861);
            lblHint.Margin = new Padding(0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(1469, 40);
            lblHint.TabIndex = 2;
            lblHint.Text = "Chọn thí sinh để mở màn hình log chi tiết. Nhấn nút Back trên màn hình log để quay lại đây.";
            lblHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvContestants
            // 
            lvContestants.BorderStyle = BorderStyle.None;
            lvContestants.Columns.AddRange(new ColumnHeader[] { columnHeaderStudentCode, columnHeaderStudentName, columnHeaderMachine });
            lvContestants.Dock = DockStyle.Fill;
            lvContestants.Font = new Font("Segoe UI", 10F);
            lvContestants.FullRowSelect = true;
            lvContestants.HideSelection = false;
            lvContestants.Location = new Point(26, 94);
            lvContestants.Margin = new Padding(0);
            lvContestants.MultiSelect = false;
            lvContestants.Name = "lvContestants";
            lvContestants.Size = new Size(1469, 807);
            lvContestants.TabIndex = 1;
            lvContestants.UseCompatibleStateImageBehavior = false;
            lvContestants.View = View.Details;
            // 
            // columnHeaderStudentCode
            // 
            columnHeaderStudentCode.Text = "MSSV";
            columnHeaderStudentCode.Width = 160;
            // 
            // columnHeaderStudentName
            // 
            columnHeaderStudentName.Text = "Họ tên";
            columnHeaderStudentName.Width = 260;
            // 
            // columnHeaderMachine
            // 
            columnHeaderMachine.Text = "Máy trạm";
            columnHeaderMachine.Width = 160;
            // 
            // lblContestantsTitle
            // 
            lblContestantsTitle.BackColor = Color.Transparent;
            lblContestantsTitle.Dock = DockStyle.Top;
            lblContestantsTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblContestantsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblContestantsTitle.Location = new Point(26, 26);
            lblContestantsTitle.Margin = new Padding(0, 0, 0, 12);
            lblContestantsTitle.Name = "lblContestantsTitle";
            lblContestantsTitle.Size = new Size(1469, 68);
            lblContestantsTitle.TabIndex = 0;
            lblContestantsTitle.Text = "Thí sinh";
            lblContestantsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RoomManagementView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(tblMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RoomManagementView";
            Size = new Size(1825, 975);
            tblMain.ResumeLayout(false);
            pnlRooms.ResumeLayout(false);
            pnlContestants.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private AntdUI.Panel pnlRooms;
        private ListBox lstRooms;
        private AntdUI.Label lblRoomsTitle;
        private AntdUI.Panel pnlContestants;
        private AntdUI.Label lblContestantsTitle;
        private ListView lvContestants;
        private ColumnHeader columnHeaderStudentCode;
        private ColumnHeader columnHeaderStudentName;
        private ColumnHeader columnHeaderMachine;
        private AntdUI.Label lblHint;
    }
}
