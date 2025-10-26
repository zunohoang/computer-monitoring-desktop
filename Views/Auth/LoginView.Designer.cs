namespace computer_monitoring_desktop.Views.Auth
{
    partial class LoginView
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
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance3 = new AntdUI.HyperlinkLabel.LinkAppearance();
            AntdUI.HyperlinkLabel.LinkAppearance linkAppearance4 = new AntdUI.HyperlinkLabel.LinkAppearance();
            lblLogin = new AntdUI.Label();
            input1 = new AntdUI.Input();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            button1 = new AntdUI.Button();
            hyperlinkLabel1 = new AntdUI.HyperlinkLabel();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(353, 63);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(212, 92);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Đăng nhập";
            // 
            // input1
            // 
            input1.Location = new Point(302, 206);
            input1.Name = "input1";
            input1.Size = new Size(291, 51);
            input1.TabIndex = 1;
            input1.Text = "Nhập email";
            // 
            // label1
            // 
            label1.Location = new Point(307, 171);
            label1.Name = "label1";
            label1.Size = new Size(140, 29);
            label1.TabIndex = 2;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.Location = new Point(307, 280);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // input2
            // 
            input2.Location = new Point(302, 315);
            input2.Name = "input2";
            input2.Size = new Size(291, 47);
            input2.TabIndex = 4;
            input2.Text = "Mật khẩu";
            input2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(309, 395);
            button1.Name = "button1";
            button1.Size = new Size(284, 48);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.Type = AntdUI.TTypeMini.Primary;
            // 
            // hyperlinkLabel1
            // 
            hyperlinkLabel1.HoverStyle = linkAppearance3;
            hyperlinkLabel1.Location = new Point(390, 449);
            hyperlinkLabel1.Name = "hyperlinkLabel1";
            hyperlinkLabel1.NormalStyle = linkAppearance4;
            hyperlinkLabel1.Size = new Size(121, 29);
            hyperlinkLabel1.TabIndex = 6;
            hyperlinkLabel1.Text = "Quên mật khẩu ?";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(hyperlinkLabel1);
            Controls.Add(button1);
            Controls.Add(input2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input1);
            Controls.Add(lblLogin);
            Name = "LoginView";
            Size = new Size(910, 518);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label lblLogin;
        private AntdUI.Input input1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input2;
        private AntdUI.Button button1;
        private AntdUI.HyperlinkLabel hyperlinkLabel1;
    }
}
