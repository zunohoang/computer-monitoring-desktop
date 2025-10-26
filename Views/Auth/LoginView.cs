using System;
using System.Drawing;
using System.Windows.Forms;
using AntdUI;
using Button = AntdUI.Button;

namespace computer_monitoring_desktop.Views.Auth
{
    public partial class LoginView : UserControl
    {
        public event EventHandler OnLoginSuccess;

        private Control? _parentForEvents;

        public LoginView()
        {
            InitializeComponent();
        }


    }
}
