using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class TextLogView
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
            pnlMain = new Panel();
            pnlGridCard = new AntdUI.Panel();
            tblProcesses = new AntdUI.Table();
            lblGridSubtitle = new AntdUI.Label();
            lblGridTitle = new AntdUI.Label();
            pnlHeader = new AntdUI.Panel();
            lblDescription = new AntdUI.Label();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlGridCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(250, 250, 250);
            pnlMain.Controls.Add(pnlGridCard);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(34, 24, 34, 24);
            pnlMain.Size = new Size(1460, 780);
            pnlMain.TabIndex = 0;
            // 
            // pnlGridCard
            // 
            pnlGridCard.Back = Color.White;
            pnlGridCard.Controls.Add(tblProcesses);
            pnlGridCard.Controls.Add(lblGridSubtitle);
            pnlGridCard.Controls.Add(lblGridTitle);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(34, 144);
            pnlGridCard.Margin = new Padding(0, 16, 0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(24);
            pnlGridCard.Radius = 12;
            pnlGridCard.Size = new Size(1392, 612);
            pnlGridCard.TabIndex = 1;
            // 
            // tblProcesses
            // 
            tblProcesses.Dock = DockStyle.Fill;
            tblProcesses.Gap = 12;
            tblProcesses.Location = new Point(24, 120);
            tblProcesses.Margin = new Padding(0);
            tblProcesses.Name = "tblProcesses";
            tblProcesses.ScrollBarAvoidHeader = true;
            tblProcesses.Size = new Size(1344, 468);
            tblProcesses.TabIndex = 2;
            // 
            // lblGridSubtitle
            // 
            lblGridSubtitle.BackColor = Color.Transparent;
            lblGridSubtitle.Dock = DockStyle.Top;
            lblGridSubtitle.Font = new Font("Segoe UI", 10F);
            lblGridSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblGridSubtitle.Location = new Point(24, 64);
            lblGridSubtitle.Margin = new Padding(0, 4, 0, 16);
            lblGridSubtitle.Name = "lblGridSubtitle";
            lblGridSubtitle.Size = new Size(1344, 56);
            lblGridSubtitle.TabIndex = 1;
            lblGridSubtitle.Text = "Thong tin tien trinh se duoc cap nhat theo tung thi sinh sau khi ban lua chon.";
            // 
            // lblGridTitle
            // 
            lblGridTitle.BackColor = Color.Transparent;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(24, 24);
            lblGridTitle.Margin = new Padding(0, 0, 0, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(1344, 40);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Tien trinh dang theo doi";
            lblGridTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlHeader
            // 
            pnlHeader.Back = Color.Transparent;
            pnlHeader.Controls.Add(lblDescription);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(34, 24);
            pnlHeader.Margin = new Padding(0, 0, 0, 16);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 0, 16);
            pnlHeader.Size = new Size(1392, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescription.Location = new Point(0, 60);
            lblDescription.Margin = new Padding(0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(960, 44);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Chon thi sinh trong danh sach de xem chi tiet text log va bieu do audit.";
            lblDescription.TextAlign = ContentAlignment.TopLeft;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0, 0, 0, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Text log";
            // 
            // TextLogView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TextLogView";
            Size = new Size(1460, 780);
            pnlMain.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Label lblTitle;
        private AntdUI.Label lblDescription;
        private AntdUI.Panel pnlGridCard;
        private AntdUI.Label lblGridTitle;
        private AntdUI.Label lblGridSubtitle;
        private AntdUI.Table tblProcesses;
    }
}
