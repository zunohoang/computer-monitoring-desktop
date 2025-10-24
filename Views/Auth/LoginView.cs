using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.Auth
{
    public partial class LoginView : UserControl
    {
        public event EventHandler OnLoginSuccess;
        public LoginView()
        {
            InitializeComponent();
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                OnLoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

    }
}
