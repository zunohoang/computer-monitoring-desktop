namespace computer_monitoring_desktop.Views.Settings
{
    partial class SettingsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleLine styleLine1 = new AntdUI.Tabs.StyleLine();
            pnl_main = new AntdUI.Panel();
            pnl_content = new AntdUI.Panel();
            panel1 = new AntdUI.Panel();
            tab_setting = new AntdUI.Tabs();
            tbp_blacklist = new AntdUI.TabPage();
            tbp_warning = new AntdUI.TabPage();
            tbp_user = new AntdUI.TabPage();
            phd_title = new AntdUI.PageHeader();
            pnl_main.SuspendLayout();
            pnl_content.SuspendLayout();
            panel1.SuspendLayout();
            tab_setting.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(pnl_content);
            pnl_main.Controls.Add(phd_title);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1920, 1080);
            pnl_main.TabIndex = 0;
            pnl_main.Text = "panel1";
            // 
            // pnl_content
            // 
            pnl_content.Controls.Add(panel1);
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(0, 122);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(1920, 958);
            pnl_content.TabIndex = 1;
            pnl_content.Text = "panel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tab_setting);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 958);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // tab_setting
            // 
            tab_setting.BackColor = Color.White;
            tab_setting.Controls.Add(tbp_blacklist);
            tab_setting.Controls.Add(tbp_warning);
            tab_setting.Controls.Add(tbp_user);
            tab_setting.Dock = DockStyle.Fill;
            tab_setting.Location = new Point(0, 0);
            tab_setting.Name = "tab_setting";
            tab_setting.Pages.Add(tbp_blacklist);
            tab_setting.Pages.Add(tbp_warning);
            tab_setting.Pages.Add(tbp_user);
            tab_setting.Size = new Size(1920, 958);
            tab_setting.Style = styleLine1;
            tab_setting.TabIndex = 1;
            // 
            // tbp_blacklist
            // 
            tbp_blacklist.Dock = DockStyle.Fill;
            tbp_blacklist.Location = new Point(0, 66);
            tbp_blacklist.Name = "tbp_blacklist";
            tbp_blacklist.Showed = true;
            tbp_blacklist.Size = new Size(1920, 892);
            tbp_blacklist.TabIndex = 0;
            tbp_blacklist.Text = "Danh sách đen";
            // 
            // tbp_warning
            // 
            tbp_warning.Dock = DockStyle.Fill;
            tbp_warning.Location = new Point(0, 66);
            tbp_warning.Name = "tbp_warning";
            tbp_warning.Size = new Size(1920, 892);
            tbp_warning.TabIndex = 1;
            tbp_warning.Text = "Cảnh báo";
            // 
            // tbp_user
            // 
            tbp_user.Dock = DockStyle.Fill;
            tbp_user.Location = new Point(0, 66);
            tbp_user.Name = "tbp_user";
            tbp_user.Size = new Size(1920, 892);
            tbp_user.TabIndex = 2;
            tbp_user.Text = "Người dùng";
            // 
            // phd_title
            // 
            phd_title.BackColor = Color.White;
            phd_title.Dock = DockStyle.Top;
            phd_title.Location = new Point(0, 0);
            phd_title.Name = "phd_title";
            phd_title.Size = new Size(1920, 122);
            phd_title.TabIndex = 0;
            phd_title.Text = "Cài đặt hệ thống";
            // 
            // SettingsView
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_main);
            Name = "SettingsView";
            Size = new Size(1920, 1080);
            pnl_main.ResumeLayout(false);
            pnl_content.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tab_setting.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnl_main;
        private AntdUI.PageHeader phd_title;
        private AntdUI.Panel pnl_content;
        private AntdUI.Panel panel1;
        private AntdUI.Tabs tab_setting;
        private AntdUI.TabPage tbp_blacklist;
        private AntdUI.TabPage tbp_warning;
        private AntdUI.TabPage tbp_user;
    }
}