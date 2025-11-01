namespace computer_monitoring_desktop.Views.Settings
{
    partial class UserView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_main = new AntdUI.Panel();
            panel1 = new AntdUI.Panel();
            tbl_user = new AntdUI.Table();
            panel2 = new AntdUI.Panel();
            pnl_navbar = new AntdUI.Panel();
            btn_create = new AntdUI.Button();
            btn_search = new AntdUI.Button();
            txt_search = new AntdUI.Input();
            panel3 = new AntdUI.Panel();
            pnl_main.SuspendLayout();
            panel1.SuspendLayout();
            pnl_navbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(panel1);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1500, 900);
            pnl_main.TabIndex = 1;
            pnl_main.Text = "panel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbl_user);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnl_navbar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 900);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // tbl_user
            // 
            tbl_user.BackColor = Color.White;
            tbl_user.Dock = DockStyle.Fill;
            tbl_user.Gap = 12;
            tbl_user.Location = new Point(0, 152);
            tbl_user.Name = "tbl_user";
            tbl_user.Size = new Size(1500, 748);
            tbl_user.TabIndex = 5;
            tbl_user.Text = "table1";
            tbl_user.CellClick += tbl_user_CellClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 34);
            panel2.TabIndex = 3;
            panel2.Text = "panel2";
            // 
            // pnl_navbar
            // 
            pnl_navbar.Controls.Add(btn_create);
            pnl_navbar.Controls.Add(btn_search);
            pnl_navbar.Controls.Add(txt_search);
            pnl_navbar.Dock = DockStyle.Top;
            pnl_navbar.Location = new Point(0, 31);
            pnl_navbar.Name = "pnl_navbar";
            pnl_navbar.Size = new Size(1500, 87);
            pnl_navbar.TabIndex = 2;
            // 
            // btn_create
            // 
            btn_create.BorderWidth = 1F;
            btn_create.Dock = DockStyle.Right;
            btn_create.IconSvg = "PlusOutlined";
            btn_create.Location = new Point(1112, 0);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(388, 87);
            btn_create.TabIndex = 2;
            btn_create.Text = "Thêm người dùng";
            btn_create.Click += btn_create_Click;
            // 
            // btn_search
            // 
            btn_search.BorderWidth = 1F;
            btn_search.Dock = DockStyle.Left;
            btn_search.IconSvg = "SearchOutlined";
            btn_search.Location = new Point(465, 0);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(99, 87);
            btn_search.TabIndex = 1;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Dock = DockStyle.Left;
            txt_search.Location = new Point(0, 0);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Tìm kiếm người dùng...";
            txt_search.Size = new Size(465, 87);
            txt_search.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1500, 31);
            panel3.TabIndex = 0;
            panel3.Text = "panel3";
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_main);
            Name = "UserView";
            Size = new Size(1500, 900);
            pnl_main.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnl_navbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Panel pnl_main;
        private AntdUI.Panel panel1;
        private AntdUI.Table tbl_user;
        private AntdUI.Panel panel2;
        private AntdUI.Panel pnl_navbar;
        private AntdUI.Button btn_create;
        private AntdUI.Button btn_search;
        private AntdUI.Input txt_search;
        private AntdUI.Panel panel3;
    }
}
