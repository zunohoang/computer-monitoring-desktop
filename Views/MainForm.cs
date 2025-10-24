using computer_monitoring_desktop.Views.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadLoginView();
        }

        private void LoginView_OnLoginSucess(object sender, EventArgs e)
        {
            LoadRegisterView();
        }

        private void LoadLoginView()
        {
            pnlMain.Controls.Clear();
            var loginView = new LoginView();
            loginView.OnLoginSuccess += LoginView_OnLoginSucess;
            pnlMain.Controls.Add(loginView);
            loginView.Dock = DockStyle.Fill;
        }

        private void LoadRegisterView()
        {
            pnlMain.Controls.Clear();
            var registerView = new RegisterView();
            pnlMain.Controls.Add(registerView);
            registerView.Dock = DockStyle.Fill;
        }
    }
}
