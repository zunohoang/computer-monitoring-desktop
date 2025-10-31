namespace computer_monitoring_desktop.Views.Auth
{
    partial class RegisterView
    {
        private System.ComponentModel.IContainer components = null;
        private AntdUI.Label lblTitle;
        private AntdUI.Label lblFullName;
        private AntdUI.Input inputFullName;
        private AntdUI.Label lblEmail;
        private AntdUI.Input inputEmail;
        private AntdUI.Label lblPassword;
        private AntdUI.Input inputPassword;
        private AntdUI.Label lblConfirmPassword;
        private AntdUI.Input inputConfirmPassword;
        private AntdUI.Checkbox checkAgree;
        private AntdUI.Button btnRegister;
        private AntdUI.Divider divider1;
        private AntdUI.Label lblHaveAccount;
        private AntdUI.Label linkLogin;
        
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
            lblTitle = new AntdUI.Label();
            lblFullName = new AntdUI.Label();
            inputFullName = new AntdUI.Input();
            lblEmail = new AntdUI.Label();
            inputEmail = new AntdUI.Input();
            lblPassword = new AntdUI.Label();
            inputPassword = new AntdUI.Input();
            lblConfirmPassword = new AntdUI.Label();
            inputConfirmPassword = new AntdUI.Input();
            checkAgree = new AntdUI.Checkbox();
            btnRegister = new AntdUI.Button();
            divider1 = new AntdUI.Divider();
            lblHaveAccount = new AntdUI.Label();
            linkLogin = new AntdUI.Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(296, 55);
            lblTitle.Margin = new Padding(4, 5, 4, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(486, 66);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng ký";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = AnchorStyles.Top;
            lblFullName.Font = new Font("Segoe UI", 9F);
            lblFullName.Location = new Point(296, 155);
            lblFullName.Margin = new Padding(4, 5, 4, 5);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(486, 34);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên";
            // 
            // inputFullName
            // 
            inputFullName.Anchor = AnchorStyles.Top;
            inputFullName.Location = new Point(296, 196);
            inputFullName.Margin = new Padding(4, 5, 4, 5);
            inputFullName.Name = "inputFullName";
            inputFullName.PlaceholderText = "Nhập họ và tên";
            inputFullName.Size = new Size(486, 66);
            inputFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(296, 288);
            lblEmail.Margin = new Padding(4, 5, 4, 5);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(486, 34);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.Top;
            inputEmail.Location = new Point(296, 330);
            inputEmail.Margin = new Padding(4, 5, 4, 5);
            inputEmail.Name = "inputEmail";
            inputEmail.PlaceholderText = "Nhập email";
            inputEmail.Size = new Size(486, 66);
            inputEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.Location = new Point(296, 421);
            lblPassword.Margin = new Padding(4, 5, 4, 5);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(486, 34);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Mật khẩu";
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Top;
            inputPassword.Location = new Point(296, 462);
            inputPassword.Margin = new Padding(4, 5, 4, 5);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.PlaceholderText = "Nhập mật khẩu";
            inputPassword.Size = new Size(486, 66);
            inputPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Anchor = AnchorStyles.Top;
            lblConfirmPassword.Font = new Font("Segoe UI", 9F);
            lblConfirmPassword.Location = new Point(296, 555);
            lblConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(486, 34);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // inputConfirmPassword
            // 
            inputConfirmPassword.Anchor = AnchorStyles.Top;
            inputConfirmPassword.Location = new Point(296, 596);
            inputConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            inputConfirmPassword.Name = "inputConfirmPassword";
            inputConfirmPassword.PasswordChar = '*';
            inputConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            inputConfirmPassword.Size = new Size(486, 66);
            inputConfirmPassword.TabIndex = 8;
            // 
            // checkAgree
            // 
            checkAgree.Anchor = AnchorStyles.Top;
            checkAgree.Location = new Point(296, 688);
            checkAgree.Margin = new Padding(4, 5, 4, 5);
            checkAgree.Name = "checkAgree";
            checkAgree.Size = new Size(486, 50);
            checkAgree.TabIndex = 9;
            checkAgree.Text = "Tôi đồng ý với điều khoản sử dụng";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top;
            btnRegister.Location = new Point(296, 762);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(486, 66);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Đăng ký";
            btnRegister.Type = AntdUI.TTypeMini.Primary;
            // 
            // divider1
            // 
            divider1.Anchor = AnchorStyles.Top;
            divider1.Location = new Point(296, 862);
            divider1.Margin = new Padding(4, 5, 4, 5);
            divider1.Name = "divider1";
            divider1.Size = new Size(486, 1);
            divider1.TabIndex = 11;
            // 
            // lblHaveAccount
            // 
            lblHaveAccount.Anchor = AnchorStyles.Top;
            lblHaveAccount.Location = new Point(329, 893);
            lblHaveAccount.Margin = new Padding(4, 5, 4, 5);
            lblHaveAccount.Name = "lblHaveAccount";
            lblHaveAccount.Size = new Size(200, 50);
            lblHaveAccount.TabIndex = 12;
            lblHaveAccount.Text = "Đã có tài khoản?";
            lblHaveAccount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // linkLogin
            // 
            linkLogin.Anchor = AnchorStyles.Top;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.ForeColor = Color.FromArgb(22, 119, 255);
            linkLogin.Location = new Point(537, 893);
            linkLogin.Margin = new Padding(4, 5, 4, 5);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(171, 50);
            linkLogin.TabIndex = 13;
            linkLogin.Text = "Đăng nhập ngay";
            // 
            // RegisterView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(inputFullName);
            Controls.Add(lblEmail);
            Controls.Add(inputEmail);
            Controls.Add(lblPassword);
            Controls.Add(inputPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(inputConfirmPassword);
            Controls.Add(checkAgree);
            Controls.Add(btnRegister);
            Controls.Add(divider1);
            Controls.Add(lblHaveAccount);
            Controls.Add(linkLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "RegisterView";
            Size = new Size(1115, 1000);
            ResumeLayout(false);
        }
    }
}
