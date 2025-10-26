namespace computer_monitoring_desktop.Views
{
    partial class MainWindow
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
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            titlebar = new AntdUI.PageHeader();
            btnSettings = new AntdUI.Button();
            btnMode = new AntdUI.Button();
            btnMinimize = new AntdUI.Button();
            btnMaximize = new AntdUI.Button();
            btnClose = new AntdUI.Button();
            pnlMain = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            btnRegister = new AntdUI.Button();
            btnLogin = new AntdUI.Button();
            label1 = new AntdUI.Label();
            pnlSidebar = new AntdUI.Panel();
            btnCollapse = new AntdUI.Button();
            mnuMain = new AntdUI.Menu();
            titlebar.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // titlebar
            // 
            titlebar.Controls.Add(btnSettings);
            titlebar.Controls.Add(btnMode);
            titlebar.Controls.Add(btnMinimize);
            titlebar.Controls.Add(btnMaximize);
            titlebar.Controls.Add(btnClose);
            titlebar.Dock = DockStyle.Top;
            titlebar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlebar.Location = new Point(0, 0);
            titlebar.Name = "titlebar";
            titlebar.Size = new Size(1024, 40);
            titlebar.SubText = "v1.0.0";
            titlebar.TabIndex = 0;
            titlebar.Text = "Hệ thống quản lí máy tính";
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Right;
            btnSettings.Ghost = true;
            btnSettings.IconSvg = "SettingOutlined";
            btnSettings.Location = new Point(714, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(62, 40);
            btnSettings.TabIndex = 8;
            btnSettings.ToggleIconSvg = "SunOutlined";
            // 
            // btnMode
            // 
            btnMode.Dock = DockStyle.Right;
            btnMode.Ghost = true;
            btnMode.IconSvg = "SunOutlined";
            btnMode.Location = new Point(776, 0);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(62, 40);
            btnMode.TabIndex = 7;
            btnMode.ToggleIconSvg = "SunOutlined";
            btnMode.Click += btnMode_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Ghost = true;
            btnMinimize.IconSvg = "MinusOutlined";
            btnMinimize.Location = new Point(838, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(62, 40);
            btnMinimize.TabIndex = 6;
            btnMinimize.ToggleIconSvg = "MenuFoldOutlined";
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.Ghost = true;
            btnMaximize.IconSvg = "BorderOutlined";
            btnMaximize.Location = new Point(900, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(62, 40);
            btnMaximize.TabIndex = 5;
            btnMaximize.ToggleIconSvg = "MenuFoldOutlined";
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.Ghost = true;
            btnClose.IconSvg = "CloseOutlined";
            btnClose.Location = new Point(962, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(62, 40);
            btnClose.TabIndex = 4;
            btnClose.ToggleIconSvg = "MenuFoldOutlined";
            btnClose.Click += btnClose_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = SystemColors.Control;
            pnlMain.Controls.Add(label3);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(btnRegister);
            pnlMain.Controls.Add(btnLogin);
            pnlMain.Controls.Add(label1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(74, 40);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(950, 608);
            pnlMain.TabIndex = 1;
            pnlMain.Text = "panel1";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 193);
            label3.Name = "label3";
            label3.Size = new Size(308, 38);
            label3.TabIndex = 9;
            label3.Text = "Bạn đã chưa có tài khoản ?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(333, 306);
            label2.Name = "label2";
            label2.Size = new Size(308, 38);
            label2.TabIndex = 8;
            label2.Text = "Bạn đã có tài khoản ?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.DefaultBack = Color.AliceBlue;
            btnRegister.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(333, 237);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(308, 63);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Đăng kí";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(333, 350);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(308, 63);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Type = AntdUI.TTypeMini.Primary;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 125);
            label1.Name = "label1";
            label1.Size = new Size(685, 73);
            label1.TabIndex = 1;
            label1.Text = "Chào mừng đến với hệ thống quản lí máy tính";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnCollapse);
            pnlSidebar.Controls.Add(mnuMain);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 40);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(74, 608);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Text = "panel2";
            // 
            // btnCollapse
            // 
            btnCollapse.Dock = DockStyle.Bottom;
            btnCollapse.ForeColor = SystemColors.ActiveBorder;
            btnCollapse.Ghost = true;
            btnCollapse.IconRatio = 1F;
            btnCollapse.IconSvg = "MenuUnfoldOutlined";
            btnCollapse.Location = new Point(0, 557);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(74, 51);
            btnCollapse.TabIndex = 3;
            btnCollapse.ToggleIconSvg = "MenuFoldOutlined";
            btnCollapse.Click += btnCollapse_Click;
            // 
            // mnuMain
            // 
            mnuMain.Dock = DockStyle.Fill;
            mnuMain.Items.Add(menuItem1);
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(74, 608);
            mnuMain.TabIndex = 2;
            mnuMain.Text = "menu1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1024, 648);
            ControlBox = false;
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Controls.Add(titlebar);
            Name = "MainWindow";
            titlebar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.PageHeader titlebar;
        private AntdUI.Panel pnlMain;
        private AntdUI.Menu mnuMain;
        private AntdUI.Button btnCollapse;
        private AntdUI.Button btnMinimize;
        private AntdUI.Button btnMaximize;
        private AntdUI.Button btnClose;
        private AntdUI.Button btnMode;
        private AntdUI.Panel pnlSidebar;
        private AntdUI.Button btnSettings;
        private AntdUI.Label label1;
        private AntdUI.Button btnRegister;
        private AntdUI.Button btnLogin;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
    }
}