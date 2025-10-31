using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;

namespace computer_monitoring_desktop.Views.Auth
{
    public partial class RegisterView : UserControl
    {
        public event EventHandler OnRegisterSuccess;
        public event EventHandler OnSwitchToLogin;

        public RegisterView()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            btnRegister.Click += BtnRegister_Click;
            linkLogin.Click += LinkLogin_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            
            // Validate inputs
            if (string.IsNullOrWhiteSpace(inputFullName.Text))
            {
                AntdUI.Message.error(form, "Vui lòng nhập họ và tên!", autoClose: 3);
                return;
            }

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

            if (inputPassword.Text.Length < 6)
            {
                AntdUI.Message.error(form, "Mật khẩu phải có ít nhất 6 ký tự!", autoClose: 3);
                return;
            }

            if (inputPassword.Text != inputConfirmPassword.Text)
            {
                AntdUI.Message.error(form, "Mật khẩu xác nhận không khớp!", autoClose: 3);
                return;
            }

            if (!checkAgree.Checked)
            {
                AntdUI.Message.error(form, "Vui lòng đồng ý với điều khoản sử dụng!", autoClose: 3);
                return;
            }

            // TODO: Implement actual registration logic here
            AntdUI.Message.success(form, "Đăng ký thành công!", autoClose: 2);
            
            // Trigger success event
            OnRegisterSuccess?.Invoke(this, EventArgs.Empty);
        }

        private void LinkLogin_Click(object sender, EventArgs e)
        {
            OnSwitchToLogin?.Invoke(this, EventArgs.Empty);
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
