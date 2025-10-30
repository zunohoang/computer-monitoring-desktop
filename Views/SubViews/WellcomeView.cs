using AntdUI;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.SubViews
{
    public partial class WellcomeView : UserControl
    {
        private Window? parentWindow;

        public event EventHandler OnNavigateToLogin;
        public event EventHandler OnNavigateToRegister;

        public WellcomeView(Window _window)
        {
            parentWindow = _window;
            InitializeComponent();
            InitializeEvents();
        }

        private void InitializeEvents()
        {
            // button1 = Register button
            button1.Click += Button1_Click;
            // button2 = Login button
            button2.Click += Button2_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Navigate to Register view
            OnNavigateToRegister?.Invoke(this, EventArgs.Empty);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Navigate to Login view
            OnNavigateToLogin?.Invoke(this, EventArgs.Empty);
        }

        private void WellcomeView_Load(object sender, EventArgs e)
        {
            if (parentWindow == null) return;

            Spin.open(parentWindow, new Spin.Config()
            {
                Radius = 6,
                Font = new Font("Segoe UI", 12f),
            }, (config) =>
            {
                config.Text = "LOADING...";
                Thread.Sleep(1000);
            }, () =>
            {
                if (label1 != null)
                {
                    label1.Text = "Hệ thống quản lí máy tính";
                }
            });
        }
    }
}
