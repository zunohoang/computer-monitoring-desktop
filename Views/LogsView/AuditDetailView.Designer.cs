using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class AuditDetailView
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
            pnlContentHost = new Panel();
            pnlHeader = new AntdUI.Panel();
            btnBack = new AntdUI.Button();
            flowPanel1 = new AntdUI.FlowPanel();
            btnText = new AntdUI.Button();
            btnChart = new AntdUI.Button();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            flowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(245, 247, 250);
            pnlMain.Controls.Add(pnlContentHost);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(32, 24, 32, 24);
            pnlMain.Size = new Size(1825, 975);
            pnlMain.TabIndex = 0;
            // 
            // pnlContentHost
            // 
            pnlContentHost.BackColor = Color.White;
            pnlContentHost.Dock = DockStyle.Fill;
            pnlContentHost.Location = new Point(32, 80);
            pnlContentHost.Margin = new Padding(0);
            pnlContentHost.Name = "pnlContentHost";
            pnlContentHost.Padding = new Padding(16);
            pnlContentHost.Size = new Size(1761, 871);
            pnlContentHost.TabIndex = 2;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(248, 249, 251);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Controls.Add(flowPanel1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(32, 24);
            pnlHeader.Margin = new Padding(0, 0, 0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 24, 28, 24);
            pnlHeader.Radius = 0;
            pnlHeader.Size = new Size(1761, 56);
            pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BorderWidth = 1F;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.IconSvg = "ArrowLeftOutlined";
            btnBack.Location = new Point(44, 0);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 56);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            // 
            // flowPanel1
            // 
            flowPanel1.Align = AntdUI.TAlignFlow.RightCenter;
            flowPanel1.Anchor = AnchorStyles.Right;
            flowPanel1.BackColor = Color.White;
            flowPanel1.Controls.Add(btnText);
            flowPanel1.Controls.Add(btnChart);
            flowPanel1.Location = new Point(1394, 3);
            flowPanel1.Name = "flowPanel1";
            flowPanel1.Size = new Size(336, 53);
            flowPanel1.TabIndex = 2;
            flowPanel1.Text = "flowPanel1";
            // 
            // btnText
            // 
            btnText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnText.IconSvg = "FileTextOutlined";
            btnText.Location = new Point(2, 0);
            btnText.Margin = new Padding(0);
            btnText.Name = "btnText";
            btnText.Size = new Size(165, 56);
            btnText.TabIndex = 0;
            btnText.Text = "Text log";
            btnText.Type = AntdUI.TTypeMini.Primary;
            // 
            // btnChart
            // 
            btnChart.BorderWidth = 1F;
            btnChart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChart.IconSvg = "BarChartOutlined";
            flowPanel1.SetIndex(btnChart, 4);
            btnChart.Location = new Point(167, 0);
            btnChart.Margin = new Padding(0);
            btnChart.Name = "btnChart";
            btnChart.Padding = new Padding(3, 0, 3, 0);
            btnChart.Size = new Size(169, 56);
            btnChart.TabIndex = 1;
            btnChart.Text = "Audit chart";
            // 
            // AuditDetailView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AuditDetailView";
            Size = new Size(1825, 975);
            pnlMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            flowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Button btnBack;
        private Panel pnlContentHost;
        private AntdUI.Button btnChart;
        private AntdUI.Button btnText;
        private AntdUI.FlowPanel flowPanel1;
    }
}
