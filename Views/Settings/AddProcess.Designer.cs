namespace computer_monitoring_desktop.Views.Settings
{
    partial class AddProcess
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
            btn_cancel = new AntdUI.Button();
            btn_create = new AntdUI.Button();
            txt_description = new AntdUI.Input();
            lbl_description = new AntdUI.Label();
            txt_processname = new AntdUI.Input();
            lbl_processname = new AntdUI.Label();
            phd_addprocess = new AntdUI.PageHeader();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BorderWidth = 2F;
            pnl_main.Controls.Add(btn_cancel);
            pnl_main.Controls.Add(btn_create);
            pnl_main.Controls.Add(txt_description);
            pnl_main.Controls.Add(lbl_description);
            pnl_main.Controls.Add(txt_processname);
            pnl_main.Controls.Add(lbl_processname);
            pnl_main.Controls.Add(phd_addprocess);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(883, 602);
            pnl_main.TabIndex = 0;
            pnl_main.Text = "panel1";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.ControlDark;
            btn_cancel.BorderWidth = 1F;
            btn_cancel.Location = new Point(603, 478);
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
            btn_create.Location = new Point(320, 478);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(250, 102);
            btn_create.TabIndex = 5;
            btn_create.Text = "Thêm";
            btn_create.Click += btn_create_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(222, 226);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.PlaceholderText = "Nhập mô tả...";
            txt_description.Size = new Size(439, 215);
            txt_description.TabIndex = 4;
            // 
            // lbl_description
            // 
            lbl_description.BackColor = Color.White;
            lbl_description.Location = new Point(28, 238);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(188, 58);
            lbl_description.TabIndex = 3;
            lbl_description.Text = "Mô tả:";
            // 
            // txt_processname
            // 
            txt_processname.Location = new Point(222, 120);
            txt_processname.Name = "txt_processname";
            txt_processname.PlaceholderText = "Nhập tên tiến trình...";
            txt_processname.Size = new Size(439, 86);
            txt_processname.TabIndex = 2;
            // 
            // lbl_processname
            // 
            lbl_processname.BackColor = Color.White;
            lbl_processname.Location = new Point(28, 132);
            lbl_processname.Name = "lbl_processname";
            lbl_processname.Size = new Size(188, 58);
            lbl_processname.TabIndex = 1;
            lbl_processname.Text = "Tên tiến trình:";
            // 
            // phd_addprocess
            // 
            phd_addprocess.BackColor = Color.White;
            phd_addprocess.Dock = DockStyle.Top;
            phd_addprocess.Location = new Point(5, 5);
            phd_addprocess.Name = "phd_addprocess";
            phd_addprocess.Size = new Size(873, 58);
            phd_addprocess.TabIndex = 0;
            phd_addprocess.Text = "Thêm tiến trình";
            // 
            // AddProcess
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 602);
            Controls.Add(pnl_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProcess";
            StartPosition = FormStartPosition.CenterScreen;
            pnl_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnl_main;
        private AntdUI.PageHeader phd_addprocess;
        private AntdUI.Label lbl_processname;
        private AntdUI.Button btn_cancel;
        private AntdUI.Button btn_create;
        private AntdUI.Input txt_description;
        private AntdUI.Label lbl_description;
        private AntdUI.Input txt_processname;
    }
}
