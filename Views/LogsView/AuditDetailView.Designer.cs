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
            btnChart = new AntdUI.Button();
            btnBack = new AntdUI.Button();
            btnText = new AntdUI.Button();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
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
            pnlHeader.Back = Color.White;
            pnlHeader.Controls.Add(btnChart);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Controls.Add(btnText);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(32, 24);
            pnlHeader.Margin = new Padding(0, 0, 0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 24, 28, 24);
            pnlHeader.Radius = 12;
            pnlHeader.Size = new Size(1761, 56);
            pnlHeader.TabIndex = 0;
            // 
            // btnChart
            // 
            btnChart.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChart.Location = new Point(1641, 6);
            btnChart.Margin = new Padding(8, 0, 0, 0);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(120, 40);
            btnChart.TabIndex = 1;
            btnChart.Text = "Audit chart";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.IconSvg = "ArrowLeftOutlined";
            btnBack.Location = new Point(0, 0);
            btnBack.Margin = new Padding(0, 0, 0, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 44);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            // 
            // btnText
            // 
            btnText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnText.Location = new Point(1513, 6);
            btnText.Margin = new Padding(0);
            btnText.Name = "btnText";
            btnText.Size = new Size(120, 40);
            btnText.TabIndex = 0;
            btnText.Text = "Text log";
            btnText.Type = AntdUI.TTypeMini.Primary;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Button btnBack;
        private Panel pnlContentHost;
        private AntdUI.Button btnChart;
        private AntdUI.Button btnText;
    }
}
