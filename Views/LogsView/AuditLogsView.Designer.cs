using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    partial class AuditLogsView
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

        #region Component Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            tabsContent = new AntdUI.Tabs();
            tabPageChart = new AntdUI.TabPage();
            tabPageTextLog = new AntdUI.TabPage();
            pnlHeader = new AntdUI.Panel();
            lblTitle = new AntdUI.Label();
            pnlMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(tabsContent);
            pnlMain.Controls.Add(pnlHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(32, 24, 32, 24);
            pnlMain.Size = new Size(1825, 975);
            pnlMain.TabIndex = 0;
            // 
            // tabsContent
            // 
            tabsContent.Dock = DockStyle.Fill;
            tabsContent.Gap = 24;
            tabsContent.Location = new Point(32, 104);
            tabsContent.Name = "tabsContent";
            tabsContent.Pages.Add(tabPageChart);
            tabsContent.Pages.Add(tabPageTextLog);
            tabsContent.Size = new Size(1761, 847);
            tabsContent.TabIndex = 1;
            // 
            // tabPageChart
            // 
            tabPageChart.Dock = DockStyle.Fill;
            tabPageChart.Name = "tabPageChart";
            tabPageChart.Text = "Audit Chart";
            // 
            // tabPageTextLog
            // 
            tabPageTextLog.Dock = DockStyle.Fill;
            tabPageTextLog.Name = "tabPageTextLog";
            tabPageTextLog.Text = "Text Log";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(32, 24);
            pnlHeader.Margin = new Padding(0, 0, 0, 24);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(28, 16, 28, 16);
            pnlHeader.Radius = 12;
            pnlHeader.Size = new Size(1761, 80);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(28, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1705, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Name - Student Code";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AuditLogsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AuditLogsView";
            Size = new Size(1825, 975);
            pnlMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private AntdUI.Panel pnlHeader;
        private AntdUI.Label lblTitle;
        private AntdUI.Tabs tabsContent;
        private AntdUI.TabPage tabPageChart;
        private AntdUI.TabPage tabPageTextLog;
    }
}
