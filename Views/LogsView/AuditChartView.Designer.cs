using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class AuditChartView
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
            pnlMain = new AntdUI.Panel();
            pnlTimelineCard = new AntdUI.Panel();
            pnlTimelineScroll = new Panel();
            flpTimeline = new FlowLayoutPanel();
            pnlTimelineAxis = new Panel();
            lblAxisEnd = new AntdUI.Label();
            lblAxisMid = new AntdUI.Label();
            lblAxisStart = new AntdUI.Label();
            lblTimelineTitle = new AntdUI.Label();
            flpSummary = new FlowLayoutPanel();
            pnlHeader = new AntdUI.Panel();
            lblDescription = new AntdUI.Label();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlTimelineCard.SuspendLayout();
            pnlTimelineScroll.SuspendLayout();
            pnlTimelineAxis.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlTimelineCard);
            pnlMain.Controls.Add(flpSummary);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(42, 30, 42, 30);
            pnlMain.Size = new Size(1825, 975);
            pnlMain.TabIndex = 0;
            // 
            // pnlTimelineCard
            // 
            pnlTimelineCard.Controls.Add(pnlTimelineScroll);
            pnlTimelineCard.Controls.Add(pnlTimelineAxis);
            pnlTimelineCard.Controls.Add(lblTimelineTitle);
            pnlTimelineCard.Dock = DockStyle.Fill;
            pnlTimelineCard.Location = new Point(42, 150);
            pnlTimelineCard.Margin = new Padding(0, 20, 0, 0);
            pnlTimelineCard.Name = "pnlTimelineCard";
            pnlTimelineCard.Padding = new Padding(30, 24, 30, 24);
            pnlTimelineCard.Radius = 12;
            pnlTimelineCard.Size = new Size(1741, 795);
            pnlTimelineCard.TabIndex = 2;
            // 
            // pnlTimelineScroll
            // 
            pnlTimelineScroll.AutoScroll = true;
            pnlTimelineScroll.BackColor = Color.Transparent;
            pnlTimelineScroll.Controls.Add(flpTimeline);
            pnlTimelineScroll.Dock = DockStyle.Fill;
            pnlTimelineScroll.Location = new Point(30, 133);
            pnlTimelineScroll.Margin = new Padding(0);
            pnlTimelineScroll.Name = "pnlTimelineScroll";
            pnlTimelineScroll.Padding = new Padding(0, 8, 10, 8);
            pnlTimelineScroll.Size = new Size(1681, 638);
            pnlTimelineScroll.TabIndex = 2;
            // 
            // flpTimeline
            // 
            flpTimeline.AutoScroll = false;
            flpTimeline.BackColor = Color.Transparent;
            flpTimeline.Dock = DockStyle.Top;
            flpTimeline.FlowDirection = FlowDirection.TopDown;
            flpTimeline.Location = new Point(0, 8);
            flpTimeline.Margin = new Padding(0);
            flpTimeline.Name = "flpTimeline";
            flpTimeline.Padding = new Padding(0, 0, 16, 0);
            flpTimeline.Size = new Size(1671, 622);
            flpTimeline.TabIndex = 0;
            flpTimeline.WrapContents = false;
            // 
            // pnlTimelineAxis
            // 
            pnlTimelineAxis.BackColor = Color.Transparent;
            pnlTimelineAxis.Controls.Add(lblAxisEnd);
            pnlTimelineAxis.Controls.Add(lblAxisMid);
            pnlTimelineAxis.Controls.Add(lblAxisStart);
            pnlTimelineAxis.Dock = DockStyle.Top;
            pnlTimelineAxis.Location = new Point(30, 74);
            pnlTimelineAxis.Margin = new Padding(0, 16, 0, 0);
            pnlTimelineAxis.Name = "pnlTimelineAxis";
            pnlTimelineAxis.Padding = new Padding(12);
            pnlTimelineAxis.Size = new Size(1681, 59);
            pnlTimelineAxis.TabIndex = 1;
            // 
            // lblAxisEnd
            // 
            lblAxisEnd.Dock = DockStyle.Right;
            lblAxisEnd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAxisEnd.Location = new Point(1381, 12);
            lblAxisEnd.Margin = new Padding(0);
            lblAxisEnd.Name = "lblAxisEnd";
            lblAxisEnd.Size = new Size(288, 35);
            lblAxisEnd.TabIndex = 2;
            lblAxisEnd.Text = "Ket thuc";
            lblAxisEnd.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblAxisMid
            // 
            lblAxisMid.Font = new Font("Segoe UI", 9F);
            lblAxisMid.Location = new Point(296, 12);
            lblAxisMid.Margin = new Padding(0);
            lblAxisMid.Name = "lblAxisMid";
            lblAxisMid.Size = new Size(1085, 35);
            lblAxisMid.TabIndex = 1;
            lblAxisMid.Text = "Giua khoang thoi gian";
            lblAxisMid.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblAxisStart
            // 
            lblAxisStart.Dock = DockStyle.Left;
            lblAxisStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAxisStart.Location = new Point(12, 12);
            lblAxisStart.Margin = new Padding(0);
            lblAxisStart.Name = "lblAxisStart";
            lblAxisStart.Size = new Size(284, 35);
            lblAxisStart.TabIndex = 0;
            lblAxisStart.Text = "Bat dau";
            lblAxisStart.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTimelineTitle
            // 
            lblTimelineTitle.BackColor = Color.Transparent;
            lblTimelineTitle.Dock = DockStyle.Top;
            lblTimelineTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTimelineTitle.Location = new Point(30, 24);
            lblTimelineTitle.Margin = new Padding(0, 0, 0, 12);
            lblTimelineTitle.Name = "lblTimelineTitle";
            lblTimelineTitle.Size = new Size(1681, 50);
            lblTimelineTitle.TabIndex = 0;
            lblTimelineTitle.Text = "Timeline tien trinh";
            lblTimelineTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // flpSummary
            // 
            flpSummary.AutoScroll = true;
            flpSummary.BackColor = Color.Transparent;
            flpSummary.Dock = DockStyle.Fill;
            flpSummary.Location = new Point(42, 150);
            flpSummary.Margin = new Padding(0, 20, 0, 0);
            flpSummary.Name = "flpSummary";
            flpSummary.Padding = new Padding(0, 0, 0, 6);
            flpSummary.Size = new Size(1741, 795);
            flpSummary.TabIndex = 1;
            flpSummary.WrapContents = false;
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
            pnlHeader.Size = new Size(1741, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 11F);
            lblDescription.Location = new Point(0, 80);
            lblDescription.Margin = new Padding(0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1250, 40);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Chon thi sinh tu danh sach phong thi de xem bieu do timeline va cac canh bao duoc phat hien.";
            lblDescription.TextAlign = ContentAlignment.TopLeft;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(0, 0, 0, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(850, 75);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit chart";
            // 
            // AuditChartView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AuditChartView";
            Size = new Size(1825, 975);
            pnlMain.ResumeLayout(false);
            pnlTimelineCard.ResumeLayout(false);
            pnlTimelineScroll.ResumeLayout(false);
            pnlTimelineAxis.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Label lblTitle;
        private AntdUI.Label lblDescription;
        private FlowLayoutPanel flpSummary;
        private AntdUI.Panel pnlTimelineCard;
        private AntdUI.Label lblTimelineTitle;
        private Panel pnlTimelineScroll;
        private FlowLayoutPanel flpTimeline;
        private Panel pnlTimelineAxis;
        private AntdUI.Label lblAxisEnd;
        private AntdUI.Label lblAxisMid;
        private AntdUI.Label lblAxisStart;
    }
}
