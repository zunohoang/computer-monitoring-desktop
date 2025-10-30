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
            linkRegister.Location = new Point(424, 588);
            linkRegister.Margin = new Padding(3, 4, 3, 4);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(114, 40);
            linkRegister.TabIndex = 9;
            linkRegister.Text = "Đăng ký ngay";
            // 
            // lblNoAccount
            // 
            lblNoAccount.Anchor = AnchorStyles.Top;
            lblNoAccount.Location = new Point(253, 588);
            lblNoAccount.Margin = new Padding(3, 4, 3, 4);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(160, 40);
            lblNoAccount.TabIndex = 8;
            lblNoAccount.Text = "Chưa có tài khoản?";
            lblNoAccount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // divider1
            // 
            divider1.Anchor = AnchorStyles.Top;
            divider1.Location = new Point(196, 554);
            divider1.Margin = new Padding(3, 4, 3, 4);
            divider1.Name = "divider1";
            divider1.Size = new Size(389, 1);
            divider1.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.Location = new Point(196, 468);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(389, 53);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Type = AntdUI.TTypeMini.Primary;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.Anchor = AnchorStyles.Top;
            linkForgotPassword.Cursor = Cursors.Hand;
            linkForgotPassword.ForeColor = Color.FromArgb(22, 119, 255);
            linkForgotPassword.Location = new Point(196, 421);
            linkForgotPassword.Margin = new Padding(3, 4, 3, 4);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(389, 27);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.Text = "Quên mật khẩu?";
            linkForgotPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Top;
            inputPassword.Location = new Point(196, 348);
            inputPassword.Margin = new Padding(3, 4, 3, 4);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.PlaceholderText = "Nhập mật khẩu";
            inputPassword.Size = new Size(389, 53);
            inputPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(196, 314);
            lblPassword.Margin = new Padding(3, 4, 3, 4);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(389, 27);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.Top;
            inputEmail.Location = new Point(196, 241);
            inputEmail.Margin = new Padding(3, 4, 3, 4);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Nhập email";
            inputEmail.Size = new Size(389, 53);
            inputEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(196, 208);
            lblEmail.Margin = new Padding(3, 4, 3, 4);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(389, 27);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(196, 128);
            lblTitle.Margin = new Padding(3, 4, 3, 4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(389, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng nhập";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginView";
            Size = new Size(797, 800);
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
