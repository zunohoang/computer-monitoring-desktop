namespace computer_monitoring_desktop.Views.Settings
{
    partial class AddUser
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
            pnl_main = new AntdUI.Panel();
            pnl_status = new AntdUI.Panel();
            rbtn_nonaction = new AntdUI.Radio();
            rbtn_action = new AntdUI.Radio();
            lbl_status = new AntdUI.Label();
            pnl_role = new AntdUI.Panel();
            rbtn_supervisor = new AntdUI.Radio();
            rbtn_admin = new AntdUI.Radio();
            lbl_code = new AntdUI.Label();
            txt_email = new AntdUI.Input();
            lbl_email = new AntdUI.Label();
            txt_fullname = new AntdUI.Input();
            lbl_fullname = new AntdUI.Label();
            btn_cancel = new AntdUI.Button();
            btn_create = new AntdUI.Button();
            txt_userlogin = new AntdUI.Input();
            lbl_userlogin = new AntdUI.Label();
            phd_addprocess = new AntdUI.PageHeader();
            pnl_main.SuspendLayout();
            pnl_status.SuspendLayout();
            pnl_role.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BorderWidth = 2F;
            pnl_main.Controls.Add(pnl_status);
            pnl_main.Controls.Add(lbl_status);
            pnl_main.Controls.Add(pnl_role);
            pnl_main.Controls.Add(lbl_code);
            pnl_main.Controls.Add(txt_email);
            pnl_main.Controls.Add(lbl_email);
            pnl_main.Controls.Add(txt_fullname);
            pnl_main.Controls.Add(lbl_fullname);
            pnl_main.Controls.Add(btn_cancel);
            pnl_main.Controls.Add(btn_create);
            pnl_main.Controls.Add(txt_userlogin);
            pnl_main.Controls.Add(lbl_userlogin);
            pnl_main.Controls.Add(phd_addprocess);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(981, 736);
            pnl_main.TabIndex = 2;
            pnl_main.Text = "panel1";
            // 
            // pnl_status
            // 
            pnl_status.Controls.Add(rbtn_nonaction);
            pnl_status.Controls.Add(rbtn_action);
            pnl_status.Location = new Point(293, 473);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new Size(601, 81);
            pnl_status.TabIndex = 18;
            pnl_status.Text = "panel1";
            // 
            // rbtn_nonaction
            // 
            rbtn_nonaction.BackColor = Color.White;
            rbtn_nonaction.Location = new Point(290, 4);
            rbtn_nonaction.Name = "rbtn_nonaction";
            rbtn_nonaction.Size = new Size(368, 58);
            rbtn_nonaction.TabIndex = 11;
            rbtn_nonaction.Text = "Dừng hoạt động";
            // 
            // rbtn_action
            // 
            rbtn_action.BackColor = Color.White;
            rbtn_action.Location = new Point(3, 4);
            rbtn_action.Name = "rbtn_action";
            rbtn_action.Size = new Size(308, 58);
            rbtn_action.TabIndex = 10;
            rbtn_action.Text = "Đang hoạt động";
            // 
            // lbl_status
            // 
            lbl_status.BackColor = Color.White;
            lbl_status.Location = new Point(28, 482);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(188, 58);
            lbl_status.TabIndex = 17;
            lbl_status.Text = "Trạng thái:";
            // 
            // pnl_role
            // 
            pnl_role.Controls.Add(rbtn_supervisor);
            pnl_role.Controls.Add(rbtn_admin);
            pnl_role.Location = new Point(293, 386);
            pnl_role.Name = "pnl_role";
            pnl_role.Size = new Size(519, 81);
            pnl_role.TabIndex = 16;
            pnl_role.Text = "panel1";
            // 
            // rbtn_supervisor
            // 
            rbtn_supervisor.BackColor = Color.White;
            rbtn_supervisor.Location = new Point(290, 0);
            rbtn_supervisor.Name = "rbtn_supervisor";
            rbtn_supervisor.Size = new Size(188, 58);
            rbtn_supervisor.TabIndex = 11;
            rbtn_supervisor.Text = "Giám thị";
            // 
            // rbtn_admin
            // 
            rbtn_admin.BackColor = Color.White;
            rbtn_admin.Location = new Point(3, 4);
            rbtn_admin.Name = "rbtn_admin";
            rbtn_admin.Size = new Size(239, 58);
            rbtn_admin.TabIndex = 10;
            rbtn_admin.Text = "Quản trị viên";
            // 
            // lbl_code
            // 
            lbl_code.BackColor = Color.White;
            lbl_code.Location = new Point(28, 395);
            lbl_code.Name = "lbl_code";
            lbl_code.Size = new Size(188, 58);
            lbl_code.TabIndex = 15;
            lbl_code.Text = "Vai trò:";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(293, 269);
            txt_email.Name = "txt_email";
            txt_email.PlaceholderText = "Nhập email...";
            txt_email.Size = new Size(439, 86);
            txt_email.TabIndex = 8;
            // 
            // lbl_email
            // 
            lbl_email.BackColor = Color.White;
            lbl_email.Location = new Point(28, 281);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(233, 58);
            lbl_email.TabIndex = 7;
            lbl_email.Text = "Email:";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(293, 177);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.PlaceholderText = "Nhập họ và tên...";
            txt_fullname.Size = new Size(439, 86);
            txt_fullname.TabIndex = 4;
            // 
            // lbl_fullname
            // 
            lbl_fullname.BackColor = Color.White;
            lbl_fullname.Location = new Point(28, 189);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(233, 58);
            lbl_fullname.TabIndex = 3;
            lbl_fullname.Text = "Họ và tên:";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ControlDark;
            btn_cancel.BorderWidth = 1F;
            btn_cancel.Location = new Point(603, 584);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(250, 102);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Hủy";
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = SystemColors.ControlDark;
            btn_create.BorderWidth = 1F;
            btn_create.Location = new Point(320, 584);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(250, 102);
            btn_create.TabIndex = 5;
            btn_create.Text = "Thêm";
            btn_create.Click += btn_create_Click;
            // 
            // txt_userlogin
            // 
            txt_userlogin.Location = new Point(293, 84);
            txt_userlogin.Name = "txt_userlogin";
            txt_userlogin.PlaceholderText = "Nhập tên đăng nhập...";
            txt_userlogin.Size = new Size(439, 86);
            txt_userlogin.TabIndex = 2;
            // 
            // lbl_userlogin
            // 
            lbl_userlogin.BackColor = Color.White;
            lbl_userlogin.Location = new Point(28, 96);
            lbl_userlogin.Name = "lbl_userlogin";
            lbl_userlogin.Size = new Size(233, 58);
            lbl_userlogin.TabIndex = 1;
            lbl_userlogin.Text = "Tên đăng nhập:";
            // 
            // phd_addprocess
            // 
            phd_addprocess.BackColor = Color.White;
            phd_addprocess.Dock = DockStyle.Top;
            phd_addprocess.Location = new Point(5, 5);
            phd_addprocess.Name = "phd_addprocess";
            phd_addprocess.Size = new Size(971, 58);
            phd_addprocess.TabIndex = 0;
            phd_addprocess.Text = "Thêm người dùng";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 736);
            Controls.Add(pnl_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            Load += AddUser_Load;
            pnl_main.ResumeLayout(false);
            pnl_status.ResumeLayout(false);
            pnl_role.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnl_main;
        private AntdUI.Input txt_email;
        private AntdUI.Label lbl_email;
        private AntdUI.Input txt_fullname;
        private AntdUI.Label lbl_fullname;
        private AntdUI.Button btn_cancel;
        private AntdUI.Button btn_create;
        private AntdUI.Input txt_userlogin;
        private AntdUI.Label lbl_userlogin;
        private AntdUI.PageHeader phd_addprocess;
        private AntdUI.Panel pnl_role;
        private AntdUI.Radio rbtn_supervisor;
        private AntdUI.Radio rbtn_admin;
        private AntdUI.Label lbl_code;
        private AntdUI.Panel pnl_status;
        private AntdUI.Radio rbtn_nonaction;
        private AntdUI.Radio rbtn_action;
        private AntdUI.Label lbl_status;
    }
}