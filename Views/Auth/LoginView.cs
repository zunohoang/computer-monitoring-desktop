using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;

namespace computer_monitoring_desktop.Views.Auth
{
    public partial class LoginView : UserControl
    {
        public event EventHandler OnLoginSuccess;
        public event EventHandler OnSwitchToRegister;

        public LoginView()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            btnLogin.Click += BtnLogin_Click;
            linkForgotPassword.Click += LinkForgotPassword_Click;
            linkRegister.Click += LinkRegister_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            
            // Validate inputs
            if (string.IsNullOrWhiteSpace(inputEmail.Text))
            {
                AntdUI.Message.error(form, "Vui lòng nhập email!", autoClose: 3);
                return;
            }

            if (!IsValidEmail(inputEmail.Text))
            {
                AntdUI.Message.error(form, "Email không hợp lệ!", autoClose: 3);
                return;
            }

            if (string.IsNullOrWhiteSpace(inputPassword.Text))
            {
                AntdUI.Message.error(form, "Vui lòng nhập mật khẩu!", autoClose: 3);
                return;
            }

            // TODO: Implement actual login logic here
            // For now, just show success message
            AntdUI.Message.success(form, "Đăng nhập thành công!", autoClose: 2);
            
            // Trigger success event
            OnLoginSuccess?.Invoke(this, EventArgs.Empty);
        }

        private void LinkForgotPassword_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            // TODO: Implement forgot password logic
            AntdUI.Message.info(form, "Chức năng đang được phát triển!", autoClose: 3);
        }

        private void LinkRegister_Click(object sender, EventArgs e)
        {
            OnSwitchToRegister?.Invoke(this, EventArgs.Empty);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
