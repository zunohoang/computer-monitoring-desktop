using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class AuditLogView
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
            components = new System.ComponentModel.Container();
            pnlMain = new Panel();
            pnlLogsCard = new AntdUI.Panel();
            flpLogs = new FlowLayoutPanel();
            lblLogsTitle = new AntdUI.Label();
            pnlProcessesCard = new AntdUI.Panel();
            flpProcesses = new Panel();
            lblProcessesSubtitle = new AntdUI.Label();
            lblProcessesTitle = new AntdUI.Label();
            pnlHeader = new AntdUI.Panel();
            lblDescription = new AntdUI.Label();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlLogsCard.SuspendLayout();
            pnlProcessesCard.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.AutoScroll = true;
            pnlMain.BackColor = Color.FromArgb(250, 250, 250);
            pnlMain.Controls.Add(pnlLogsCard);
            pnlMain.Controls.Add(pnlProcessesCard);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(34, 24, 34, 24);
            pnlMain.Size = new Size(1460, 780);
            pnlMain.TabIndex = 0;
            // 
            // pnlLogsCard
            // 
            pnlLogsCard.Back = Color.White;
            pnlLogsCard.Controls.Add(flpLogs);
            pnlLogsCard.Controls.Add(lblLogsTitle);
            pnlLogsCard.Dock = DockStyle.Fill;
            pnlLogsCard.Location = new Point(34, 424);
            pnlLogsCard.Margin = new Padding(0);
            pnlLogsCard.Name = "pnlLogsCard";
            pnlLogsCard.Padding = new Padding(24, 24, 24, 24);
            pnlLogsCard.Radius = 12;
            pnlLogsCard.Size = new Size(1392, 332);
            pnlLogsCard.TabIndex = 2;
            // 
            // flpLogs
            // 
            flpLogs.AutoScroll = true;
            flpLogs.BackColor = Color.Transparent;
            flpLogs.Dock = DockStyle.Fill;
            flpLogs.FlowDirection = FlowDirection.TopDown;
            flpLogs.Location = new Point(24, 64);
            flpLogs.Margin = new Padding(0);
            flpLogs.Name = "flpLogs";
            flpLogs.Padding = new Padding(0, 0, 8, 0);
            flpLogs.Size = new Size(1344, 244);
            flpLogs.TabIndex = 2;
            flpLogs.WrapContents = false;
            // 
            // lblLogsTitle
            // 
            lblLogsTitle.BackColor = Color.Transparent;
            lblLogsTitle.Dock = DockStyle.Top;
            lblLogsTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblLogsTitle.Location = new Point(24, 24);
            lblLogsTitle.Margin = new Padding(0, 0, 0, 12);
            lblLogsTitle.Name = "lblLogsTitle";
            lblLogsTitle.Size = new Size(1344, 40);
            lblLogsTitle.TabIndex = 1;
            lblLogsTitle.Text = "Hoạt động đã ghi nhận";
            lblLogsTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlProcessesCard
            // 
            pnlProcessesCard.Back = Color.White;
            pnlProcessesCard.Controls.Add(flpProcesses);
            pnlProcessesCard.Controls.Add(lblProcessesSubtitle);
            pnlProcessesCard.Controls.Add(lblProcessesTitle);
            pnlProcessesCard.Dock = DockStyle.Top;
            pnlProcessesCard.Location = new Point(34, 144);
            pnlProcessesCard.Margin = new Padding(0, 16, 0, 0);
            pnlProcessesCard.Name = "pnlProcessesCard";
            pnlProcessesCard.Padding = new Padding(24, 24, 24, 24);
            pnlProcessesCard.Radius = 12;
            pnlProcessesCard.Size = new Size(1392, 280);
            pnlProcessesCard.TabIndex = 1;
            // 
            // flpProcesses
            // 
            flpProcesses.AutoScroll = true;
            flpProcesses.BackColor = Color.Transparent;
            flpProcesses.Dock = DockStyle.Fill;
            flpProcesses.Location = new Point(24, 96);
            flpProcesses.Margin = new Padding(0);
            flpProcesses.Name = "flpProcesses";
            flpProcesses.Padding = new Padding(0, 0, 8, 0);
            flpProcesses.Size = new Size(1344, 160);
            flpProcesses.TabIndex = 2;
            // 
            // lblProcessesSubtitle
            // 
            lblProcessesSubtitle.BackColor = Color.Transparent;
            lblProcessesSubtitle.Dock = DockStyle.Top;
            lblProcessesSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblProcessesSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblProcessesSubtitle.Location = new Point(24, 64);
            lblProcessesSubtitle.Margin = new Padding(0, 4, 0, 16);
            lblProcessesSubtitle.Name = "lblProcessesSubtitle";
            lblProcessesSubtitle.Size = new Size(1344, 32);
            lblProcessesSubtitle.TabIndex = 1;
            lblProcessesSubtitle.Text = "Danh sách tiến trình trên máy, kèm trạng thái và thời điểm bắt đầu / kết thúc.";
            lblProcessesSubtitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblProcessesTitle
            // 
            lblProcessesTitle.BackColor = Color.Transparent;
            lblProcessesTitle.Dock = DockStyle.Top;
            lblProcessesTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblProcessesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblProcessesTitle.Location = new Point(24, 24);
            lblProcessesTitle.Margin = new Padding(0, 0, 0, 8);
            lblProcessesTitle.Name = "lblProcessesTitle";
            lblProcessesTitle.Size = new Size(1344, 40);
            lblProcessesTitle.TabIndex = 0;
            lblProcessesTitle.Text = "Tiến trình đang theo dõi";
            lblProcessesTitle.TextAlign = ContentAlignment.BottomLeft;
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
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescription.Location = new Point(0, 60);
            lblDescription.Margin = new Padding(0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(840, 44);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Thông tin giúp người quản trị biết máy đang mở những tiến trình nào, tiến trình nào đã kết thúc và các hoạt động đáng chú ý.";
            lblDescription.TextAlign = ContentAlignment.TopLeft;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0, 0, 0, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(560, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Giám sát tiến trình (mock)";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AuditLogView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuditLogView";
            Size = new Size(1460, 780);
            pnlMain.ResumeLayout(false);
            pnlLogsCard.ResumeLayout(false);
            pnlProcessesCard.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Label lblTitle;
        private AntdUI.Label lblDescription;
        private AntdUI.Panel pnlProcessesCard;
        private AntdUI.Label lblProcessesTitle;
        private AntdUI.Label lblProcessesSubtitle;
        private Panel flpProcesses;
        private AntdUI.Panel pnlLogsCard;
        private AntdUI.Label lblLogsTitle;
        private FlowLayoutPanel flpLogs;
    }
}
