namespace computer_monitoring_desktop.Views.Violation
{
    partial class ViolationHandle
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
            pg_title = new AntdUI.PageHeader();
            panel1 = new AntdUI.Panel();
            btn_confirm = new AntdUI.Button();
            btn_cancel = new AntdUI.Button();
            input1 = new AntdUI.Input();
            lbl_warning = new AntdUI.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pg_title
            // 
            pg_title.BackColor = Color.White;
            pg_title.Dock = DockStyle.Top;
            pg_title.Font = new Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pg_title.Location = new Point(0, 0);
            pg_title.Name = "pg_title";
            pg_title.Size = new Size(1408, 126);
            pg_title.TabIndex = 0;
            pg_title.Text = "Xử lý vi phạm";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_confirm);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(input1);
            panel1.Controls.Add(lbl_warning);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 126);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1408, 731);
            panel1.TabIndex = 3;
            panel1.Text = "panel1";
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(57, 110, 185);
            btn_confirm.BorderWidth = 1F;
            btn_confirm.Location = new Point(1124, 570);
            btn_confirm.Margin = new Padding(3, 4, 3, 4);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(255, 139);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Xác nhận";
            btn_confirm.Click += btn_confirm_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BorderWidth = 1F;
            btn_cancel.Location = new Point(880, 570);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(211, 139);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Hủy";
            btn_cancel.Click += btn_cancel_Click;
            // 
            // input1
            // 
            input1.Location = new Point(13, 127);
            input1.Margin = new Padding(3, 4, 3, 4);
            input1.Multiline = true;
            input1.Name = "input1";
            input1.PlaceholderText = "Ghi chú(tùy chọn)";
            input1.Size = new Size(1366, 422);
            input1.TabIndex = 1;
            // 
            // lbl_warning
            // 
            lbl_warning.BackColor = Color.White;
            lbl_warning.Dock = DockStyle.Top;
            lbl_warning.Location = new Point(0, 0);
            lbl_warning.Margin = new Padding(3, 4, 3, 4);
            lbl_warning.Name = "lbl_warning";
            lbl_warning.Padding = new Padding(21, 0, 0, 0);
            lbl_warning.Size = new Size(1408, 91);
            lbl_warning.TabIndex = 0;
            lbl_warning.Text = "Bạn có chắc chắn muốn đánh dấu vi phạm này là đã xử lý?";
            // 
            // ViolationHandle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(pg_title);
            Name = "ViolationHandle";
            Size = new Size(1408, 857);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.PageHeader pg_title;
        private AntdUI.Panel panel1;
        private AntdUI.Button btn_confirm;
        private AntdUI.Button btn_cancel;
        private AntdUI.Input input1;
        private AntdUI.Label lbl_warning;
    }
}