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
            titlebar = new AntdUI.PageHeader();
            inpSearch = new AntdUI.Input();
            btnTheme = new AntdUI.Button();
            btnSettings = new AntdUI.Button();
            btnCollapse = new AntdUI.Button();
            pnlSidebar = new AntdUI.Panel();
            mnuSidebar = new AntdUI.Menu();
            pnlContent = new AntdUI.Panel();
            breadcrumb1 = new AntdUI.Breadcrumb();
            titlebar.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // titlebar
            // 
            titlebar.Controls.Add(inpSearch);
            titlebar.Controls.Add(btnTheme);
            titlebar.Controls.Add(btnSettings);
            titlebar.DividerShow = true;
            titlebar.Dock = DockStyle.Top;
            titlebar.Location = new Point(0, 0);
            titlebar.Margin = new Padding(2);
            titlebar.Name = "titlebar";
            titlebar.ShowButton = true;
            titlebar.ShowIcon = true;
            titlebar.Size = new Size(1068, 34);
            titlebar.SubText = "v1.0.0";
            titlebar.TabIndex = 0;
            titlebar.Text = "Hệ thống quản lí máy tính";
            // 
            // inpSearch
            // 
            inpSearch.AllowClear = true;
            inpSearch.Dock = DockStyle.Right;
            inpSearch.IconRatio = 0.8F;
            inpSearch.LocalizationPlaceholderText = "search";
            inpSearch.Location = new Point(682, 0);
            inpSearch.Margin = new Padding(2);
            inpSearch.Name = "inpSearch";
            inpSearch.PlaceholderText = "Tìm kiếm";
            inpSearch.PrefixSvg = "SearchOutlined";
            inpSearch.Size = new Size(134, 34);
            inpSearch.TabIndex = 4;
            inpSearch.TextChanged += inpSearch_TextChanged;
            // 
            // btnTheme
            // 
            btnTheme.Dock = DockStyle.Right;
            btnTheme.Ghost = true;
            btnTheme.IconRatio = 0.8F;
            btnTheme.IconSvg = "SunOutlined";
            btnTheme.Location = new Point(816, 0);
            btnTheme.Margin = new Padding(2);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(36, 34);
            btnTheme.TabIndex = 3;
            btnTheme.ToggleIconSvg = "MoonOutlined";
            btnTheme.WaveSize = 0;
            btnTheme.Click += btnTheme_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Right;
            btnSettings.Ghost = true;
            btnSettings.IconRatio = 0.8F;
            btnSettings.IconSvg = "SettingOutlined";
            btnSettings.Location = new Point(852, 0);
            btnSettings.Margin = new Padding(2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(36, 34);
            btnSettings.TabIndex = 2;
            btnSettings.ToggleIconSvg = "MenuFoldOutlined";
            btnSettings.WaveSize = 0;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Dock = DockStyle.Bottom;
            btnCollapse.Ghost = true;
            btnCollapse.IconRatio = 1F;
            btnCollapse.IconSvg = "MenuUnfoldOutlined";
            btnCollapse.Location = new Point(0, 523);
            btnCollapse.Margin = new Padding(2);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(86, 42);
            btnCollapse.TabIndex = 1;
            btnCollapse.ToggleIconSvg = "MenuFoldOutlined";
            btnCollapse.WaveSize = 0;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Back = Color.Transparent;
            pnlSidebar.Controls.Add(mnuSidebar);
            pnlSidebar.Controls.Add(btnCollapse);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 34);
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(86, 565);
            pnlSidebar.TabIndex = 2;
            pnlSidebar.Text = "panel1";
            // 
            // mnuSidebar
            // 
            mnuSidebar.Dock = DockStyle.Fill;
            mnuSidebar.Location = new Point(0, 0);
            mnuSidebar.Margin = new Padding(2);
            mnuSidebar.Name = "mnuSidebar";
            mnuSidebar.Size = new Size(86, 523);
            mnuSidebar.TabIndex = 2;
            mnuSidebar.Text = "menu1";
            mnuSidebar.SelectChanged += mnuSidebar_SelectChanged;
            // 
            // pnlContent
            // 
            pnlContent.Back = Color.Transparent;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(86, 67);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(982, 532);
            pnlContent.TabIndex = 3;
            pnlContent.Text = "panel2";
            // 
            // breadcrumb1
            // 
            breadcrumb1.Dock = DockStyle.Top;
            breadcrumb1.Location = new Point(86, 34);
            breadcrumb1.Name = "breadcrumb1";
            breadcrumb1.Size = new Size(982, 33);
            breadcrumb1.TabIndex = 0;
            breadcrumb1.Text = "breadcrumb1";

            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 599);
            Controls.Add(pnlContent);
            Controls.Add(breadcrumb1);
            Controls.Add(pnlSidebar);
            Controls.Add(titlebar);
            Margin = new Padding(2);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            titlebar.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader titlebar;
        private AntdUI.Button btnCollapse;
        private AntdUI.Input inpSearch;
        private AntdUI.Button btnTheme;
        private AntdUI.Button btnSettings;
        private AntdUI.Panel pnlSidebar;
        private AntdUI.Menu mnuSidebar;
        private AntdUI.Panel pnlContent;
        private AntdUI.Breadcrumb breadcrumb1;
    }
}