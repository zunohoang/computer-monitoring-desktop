namespace computer_monitoring_desktop.Views.Auth
{
    partial class LoginView
    {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            linkRegister = new AntdUI.Label();
            lblNoAccount = new AntdUI.Label();
            divider1 = new AntdUI.Divider();
            btnLogin = new AntdUI.Button();
            linkForgotPassword = new AntdUI.Label();
            inputPassword = new AntdUI.Input();
            lblPassword = new AntdUI.Label();
            inputEmail = new AntdUI.Input();
            lblEmail = new AntdUI.Label();
            lblTitle = new AntdUI.Label();
            SuspendLayout();
            // 
            // linkRegister
            // 
            linkRegister.Anchor = AnchorStyles.Top;
            linkRegister.Cursor = Cursors.Hand;
            linkRegister.ForeColor = Color.FromArgb(22, 119, 255);
            linkRegister.Location = new Point(510, 734);
            linkRegister.Margin = new Padding(4, 5, 4, 5);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(142, 50);
            linkRegister.TabIndex = 9;
            linkRegister.Text = "Đăng ký ngay";
            // 
            // lblNoAccount
            // 
            lblNoAccount.Anchor = AnchorStyles.Top;
            lblNoAccount.Location = new Point(296, 734);
            lblNoAccount.Margin = new Padding(4, 5, 4, 5);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(200, 50);
            lblNoAccount.TabIndex = 8;
            lblNoAccount.Text = "Chưa có tài khoản?";
            lblNoAccount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // divider1
            // 
            divider1.Anchor = AnchorStyles.Top;
            divider1.Location = new Point(245, 692);
            divider1.Margin = new Padding(4, 5, 4, 5);
            divider1.Name = "divider1";
            divider1.Size = new Size(486, 1);
            divider1.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Location = new Point(245, 585);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(486, 66);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Type = AntdUI.TTypeMini.Primary;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.Anchor = AnchorStyles.Top;
            linkForgotPassword.Cursor = Cursors.Hand;
            linkForgotPassword.ForeColor = Color.FromArgb(22, 119, 255);
            linkForgotPassword.Location = new Point(245, 526);
            linkForgotPassword.Margin = new Padding(4, 5, 4, 5);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(486, 34);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.Text = "Quên mật khẩu?";
            linkForgotPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Top;
            inputPassword.Location = new Point(245, 435);
            inputPassword.Margin = new Padding(4, 5, 4, 5);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.PlaceholderText = "Nhập mật khẩu";
            inputPassword.Size = new Size(486, 66);
            inputPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(245, 392);
            lblPassword.Margin = new Padding(4, 5, 4, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(486, 34);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.Top;
            inputEmail.Location = new Point(245, 301);
            inputEmail.Margin = new Padding(4, 5, 4, 5);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Nhập email";
            inputEmail.Size = new Size(486, 66);
            inputEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(245, 260);
            lblEmail.Margin = new Padding(4, 5, 4, 5);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(486, 34);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(245, 160);
            lblTitle.Margin = new Padding(4, 5, 4, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(486, 66);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(lblTitle);
            Controls.Add(lblEmail);
            Controls.Add(inputEmail);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(linkForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(divider1);
            Controls.Add(lblNoAccount);
            Controls.Add(linkRegister);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginView";
            Size = new Size(996, 1000);
            ResumeLayout(false);
        }
        private AntdUI.Label linkRegister;
        private AntdUI.Label lblNoAccount;
        private AntdUI.Divider divider1;
        private AntdUI.Button btnLogin;
        private AntdUI.Label linkForgotPassword;
        private AntdUI.Input inputPassword;
        private AntdUI.Label lblPassword;
        private AntdUI.Input inputEmail;
        private AntdUI.Label lblEmail;
        private AntdUI.Label lblTitle;
    }
}
