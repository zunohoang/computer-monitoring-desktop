namespace computer_monitoring_desktop.Views.Settings
{
    partial class AddWarning
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
            pnl_level = new AntdUI.Panel();
            rbtn_low = new AntdUI.Radio();
            rbtn_average = new AntdUI.Radio();
            rbtn_high = new AntdUI.Radio();
            pnl_code = new AntdUI.Panel();
            rbtn_warning = new AntdUI.Radio();
            rbtn_critical = new AntdUI.Radio();
            lbl_level = new AntdUI.Label();
            lbl_code = new AntdUI.Label();
            btn_cancel = new AntdUI.Button();
            btn_create = new AntdUI.Button();
            txt_description = new AntdUI.Input();
            lbl_description = new AntdUI.Label();
            txt_warningname = new AntdUI.Input();
            lbl_warningname = new AntdUI.Label();
            phd_addprocess = new AntdUI.PageHeader();
            pnl_main.SuspendLayout();
            pnl_level.SuspendLayout();
            pnl_code.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BorderWidth = 2F;
            pnl_main.Controls.Add(pnl_level);
            pnl_main.Controls.Add(pnl_code);
            pnl_main.Controls.Add(lbl_level);
            pnl_main.Controls.Add(lbl_code);
            pnl_main.Controls.Add(btn_cancel);
            pnl_main.Controls.Add(btn_create);
            pnl_main.Controls.Add(txt_description);
            pnl_main.Controls.Add(lbl_description);
            pnl_main.Controls.Add(txt_warningname);
            pnl_main.Controls.Add(lbl_warningname);
            pnl_main.Controls.Add(phd_addprocess);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(907, 709);
            pnl_main.TabIndex = 1;
            pnl_main.Text = "panel1";
            // 
            // pnl_level
            // 
            pnl_level.Controls.Add(rbtn_low);
            pnl_level.Controls.Add(rbtn_average);
            pnl_level.Controls.Add(rbtn_high);
            pnl_level.Location = new Point(222, 448);
            pnl_level.Name = "pnl_level";
            pnl_level.Size = new Size(553, 84);
            pnl_level.TabIndex = 15;
            pnl_level.Text = "panel1";
            // 
            // rbtn_low
            // 
            rbtn_low.BackColor = Color.White;
            rbtn_low.Location = new Point(359, 13);
            rbtn_low.Name = "rbtn_low";
            rbtn_low.Size = new Size(188, 58);
            rbtn_low.TabIndex = 16;
            rbtn_low.Text = "Thấp";
            // 
            // rbtn_average
            // 
            rbtn_average.BackColor = Color.White;
            rbtn_average.Location = new Point(135, 13);
            rbtn_average.Name = "rbtn_average";
            rbtn_average.Size = new Size(218, 58);
            rbtn_average.TabIndex = 15;
            rbtn_average.Text = "Trung bình";
            // 
            // rbtn_high
            // 
            rbtn_high.BackColor = Color.White;
            rbtn_high.Location = new Point(5, 13);
            rbtn_high.Name = "rbtn_high";
            rbtn_high.Size = new Size(188, 58);
            rbtn_high.TabIndex = 14;
            rbtn_high.Text = "Cao";
            // 
            // pnl_code
            // 
            pnl_code.Controls.Add(rbtn_warning);
            pnl_code.Controls.Add(rbtn_critical);
            pnl_code.Location = new Point(224, 348);
            pnl_code.Name = "pnl_code";
            pnl_code.Size = new Size(519, 81);
            pnl_code.TabIndex = 14;
            pnl_code.Text = "panel1";
            // 
            // rbtn_warning
            // 
            rbtn_warning.BackColor = Color.White;
            rbtn_warning.Location = new Point(213, 4);
            rbtn_warning.Name = "rbtn_warning";
            rbtn_warning.Size = new Size(188, 58);
            rbtn_warning.TabIndex = 11;
            rbtn_warning.Text = "warning";
            // 
            // rbtn_critical
            // 
            rbtn_critical.BackColor = Color.White;
            rbtn_critical.Location = new Point(3, 4);
            rbtn_critical.Name = "rbtn_critical";
            rbtn_critical.Size = new Size(188, 58);
            rbtn_critical.TabIndex = 10;
            rbtn_critical.Text = "critical";
            // 
            // lbl_level
            // 
            lbl_level.BackColor = Color.White;
            lbl_level.Location = new Point(28, 448);
            lbl_level.Name = "lbl_level";
            lbl_level.Size = new Size(188, 58);
            lbl_level.TabIndex = 10;
            lbl_level.Text = "Mức độ:";
            // 
            // lbl_code
            // 
            lbl_code.BackColor = Color.White;
            lbl_code.Location = new Point(28, 352);
            lbl_code.Name = "lbl_code";
            lbl_code.Size = new Size(188, 58);
            lbl_code.TabIndex = 7;
            lbl_code.Text = "Mã:";
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
            // txt_description
            // 
            txt_description.Location = new Point(222, 176);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.PlaceholderText = "Nhập mô tả...";
            txt_description.Size = new Size(439, 152);
            txt_description.TabIndex = 4;
            // 
            // lbl_description
            // 
            lbl_description.BackColor = Color.White;
            lbl_description.Location = new Point(28, 188);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(188, 58);
            lbl_description.TabIndex = 3;
            lbl_description.Text = "Mô tả:";
            // 
            // txt_warningname
            // 
            txt_warningname.Location = new Point(222, 84);
            txt_warningname.Name = "txt_warningname";
            txt_warningname.PlaceholderText = "Nhập tên cảnh báo...";
            txt_warningname.Size = new Size(439, 86);
            txt_warningname.TabIndex = 2;
            // 
            // lbl_warningname
            // 
            lbl_warningname.BackColor = Color.White;
            lbl_warningname.Location = new Point(28, 96);
            lbl_warningname.Name = "lbl_warningname";
            lbl_warningname.Size = new Size(188, 58);
            lbl_warningname.TabIndex = 1;
            lbl_warningname.Text = "Tên cảnh báo:";
            // 
            // phd_addprocess
            // 
            phd_addprocess.BackColor = Color.White;
            phd_addprocess.Dock = DockStyle.Top;
            phd_addprocess.Location = new Point(5, 5);
            phd_addprocess.Name = "phd_addprocess";
            phd_addprocess.Size = new Size(897, 58);
            phd_addprocess.TabIndex = 0;
            phd_addprocess.Text = "Thêm cảnh báo";
            // 
            // AddWarning
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 709);
            Controls.Add(pnl_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddWarning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddWarning";
            Load += AddWarning_Load;
            pnl_main.ResumeLayout(false);
            pnl_level.ResumeLayout(false);
            pnl_code.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel pnl_main;
        private AntdUI.Button btn_cancel;
        private AntdUI.Button btn_create;
        private AntdUI.Input txt_description;
        private AntdUI.Label lbl_description;
        private AntdUI.Input txt_warningname;
        private AntdUI.Label lbl_warningname;
        private AntdUI.PageHeader phd_addprocess;
        private AntdUI.Label lbl_code;
        private AntdUI.Label lbl_level;
        private AntdUI.Panel pnl_code;
        private AntdUI.Radio rbtn_warning;
        private AntdUI.Radio rbtn_critical;
        private AntdUI.Panel pnl_level;
        private AntdUI.Radio rbtn_low;
        private AntdUI.Radio rbtn_average;
        private AntdUI.Radio rbtn_high;
    }
}