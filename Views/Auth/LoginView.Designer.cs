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
            btnLogin = new AntdUI.Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(251, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 55);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(289, 66);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(156, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(289, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(156, 27);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(136, 53);
            label1.Name = "label1";
            label1.Size = new Size(125, 53);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.Location = new Point(136, 148);
            label2.Name = "label2";
            label2.Size = new Size(125, 53);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
            Name = "LoginView";
            Size = new Size(652, 347);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Button btnLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
    }
}
