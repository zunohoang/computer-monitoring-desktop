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
            gridProcesses = new DataGridView();
            lblGridSubtitle = new AntdUI.Label();
            lblGridTitle = new AntdUI.Label();
            pnlHeader = new AntdUI.Panel();
            lblDescription = new AntdUI.Label();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProcesses).BeginInit();
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
            pnlMain.Padding = new Padding(42, 30, 42, 30);
            pnlMain.Size = new Size(1825, 975);
            pnlMain.TabIndex = 0;
            // 
            // pnlGridCard
            // 
            pnlGridCard.Back = Color.White;
            pnlGridCard.Controls.Add(gridProcesses);
            pnlGridCard.Controls.Add(lblGridSubtitle);
            pnlGridCard.Controls.Add(lblGridTitle);
            pnlGridCard.Dock = DockStyle.Fill;
            pnlGridCard.Location = new Point(42, 180);
            pnlGridCard.Margin = new Padding(0, 20, 0, 0);
            pnlGridCard.Name = "pnlGridCard";
            pnlGridCard.Padding = new Padding(30);
            pnlGridCard.Radius = 12;
            pnlGridCard.Size = new Size(1741, 765);
            pnlGridCard.TabIndex = 1;
            // 
            // gridProcesses
            // 
            gridProcesses.AllowUserToAddRows = false;
            gridProcesses.AllowUserToDeleteRows = false;
            gridProcesses.AllowUserToResizeRows = false;
            gridProcesses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridProcesses.BackgroundColor = Color.White;
            gridProcesses.BorderStyle = BorderStyle.None;
            gridProcesses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProcesses.Dock = DockStyle.Fill;
            gridProcesses.Location = new Point(30, 150);
            gridProcesses.Margin = new Padding(0);
            gridProcesses.MultiSelect = false;
            gridProcesses.Name = "gridProcesses";
            gridProcesses.RowHeadersVisible = false;
            gridProcesses.RowTemplate.Height = 36;
            gridProcesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProcesses.Size = new Size(1681, 585);
            gridProcesses.TabIndex = 2;
            // 
            // lblGridSubtitle
            // 
            lblGridSubtitle.BackColor = Color.Transparent;
            lblGridSubtitle.Dock = DockStyle.Top;
            lblGridSubtitle.Font = new Font("Segoe UI", 10F);
            lblGridSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblGridSubtitle.Location = new Point(30, 80);
            lblGridSubtitle.Margin = new Padding(0, 5, 0, 20);
            lblGridSubtitle.Name = "lblGridSubtitle";
            lblGridSubtitle.Size = new Size(1681, 70);
            lblGridSubtitle.TabIndex = 1;
            lblGridSubtitle.Text = "Thong tin tien trinh se duoc cap nhat theo tung thi sinh sau khi ban lua chon.";
            lblGridSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGridTitle
            // 
            lblGridTitle.BackColor = Color.Transparent;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblGridTitle.Location = new Point(30, 30);
            lblGridTitle.Margin = new Padding(0, 0, 0, 10);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(1681, 50);
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
            pnlHeader.Location = new Point(42, 30);
            pnlHeader.Margin = new Padding(0, 0, 0, 20);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(0, 0, 0, 20);
            pnlHeader.Size = new Size(1741, 150);
            pnlHeader.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescription.Location = new Point(0, 75);
            lblDescription.Margin = new Padding(0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1200, 55);
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
            lblTitle.Margin = new Padding(0, 0, 0, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Text log";
            // 
            // TextLogView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "TextLogView";
            Size = new Size(1825, 975);
            pnlMain.ResumeLayout(false);
            pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridProcesses).EndInit();
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
        private DataGridView gridProcesses;
    }
}
