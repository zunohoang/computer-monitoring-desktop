using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Dtos;
using computer_monitoring_desktop.Services.Auth;
using computer_monitoring_desktop.Utils;
using Microsoft.Extensions.Logging;

namespace computer_monitoring_desktop.Views.Auth
{
    public partial class LoginView : UserControl
    {
        private readonly ILogger<LoginView> _logger;

        public event EventHandler OnLoginSuccess;
        public event EventHandler OnSwitchToRegister;
        private AuthService authService = new AuthService();


        public LoginView()
        {
            _logger = LoggerProvider.CreateLogger<LoginView>();
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            btnLogin.Click += BtnLogin_Click;
            linkForgotPassword.Click += LinkForgotPassword_Click;
            linkRegister.Click += LinkRegister_Click;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
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

            try
            {
                LoginResponse? loginResponse = await authService.LoginAsync(new LoginRequest
                {
                    email = inputEmail.Text.Trim(),
                    password = inputPassword.Text
                });

                if (loginResponse != null && (!string.IsNullOrEmpty(loginResponse.token) || loginResponse.success == true))
                {
                    AntdUI.Message.success(form, "Đăng nhập thành công!", autoClose: 2);
                    OnLoginSuccess?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    string errorMessage = loginResponse?.message ?? "Đăng nhập thất bại!";
                    AntdUI.Message.error(form, errorMessage, autoClose: 3);
                }
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(form, $"Lỗi kết nối: {ex.Message}", autoClose: 3);
            }
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
