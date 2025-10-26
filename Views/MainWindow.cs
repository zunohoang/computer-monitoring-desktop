using AntdUI;
using computer_monitoring_desktop.Models;
using computer_monitoring_desktop.Utils;
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
    public partial class MainWindow : Window
    {
        private bool isLight = true;
        private UserControl currControl;
        private int expandedWidth = 220;
        private int collapsedWidth = 70;
        private bool isAuthenticated = false;

        public MainWindow()
        {
            InitializeComponent();
            LoadMenu();
            Config.ShowInWindow = true;
            ThemeHelper.setColorMode(this, isLight);

            // Ensure menu is disabled until login
            UpdateAuthState();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            isLight = !isLight;
            btnMode.Toggle = !isLight;
            ThemeHelper.setColorMode(this, isLight);
        }

        private void LoadMenu()
        {
            mnuMain.Collapsed = true;
            mnuMain.Items.Clear();
            foreach (var itemModel in MenuData.MenuList)
            {
                mnuMain.Items.Add(new MenuItem
                {
                    Text = itemModel.Text,
                    IconSvg = itemModel.IconSvg,
                    Tag = itemModel.Tag,
                });
            }

            if (mnuMain.Items.Count > 0 && isAuthenticated)
            {
                mnuMain.Select(mnuMain.Items[0]);
            }

            mnuMain.Enabled = isAuthenticated;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {

            mnuMain.Collapsed = !mnuMain.Collapsed;

            if (mnuMain.Collapsed)
            {
                pnlSidebar.Width = collapsedWidth;
                mnuMain.Width = collapsedWidth;
            }
            else
            {
                pnlSidebar.Width = expandedWidth;
                mnuMain.Width = expandedWidth;

            }
            btnCollapse.Toggle = !mnuMain.Collapsed;

            btnCollapse.Refresh();
            mnuMain.Refresh();
        }

        private void UpdateAuthState()
        {
            if (mnuMain != null)
            {
                mnuMain.Enabled = isAuthenticated;
            }

            if (btnLogin != null)
            {
                btnLogin.Visible = !isAuthenticated;
            }
            if (btnRegister != null)
            {
                btnRegister.Visible = !isAuthenticated;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and prepare the LoginView user control
                var loginControl = new LoginView
                {
                    Dock = DockStyle.Fill
                };

                // Optional: if LoginView exposes an event named "LoginSucceeded", subscribe to update auth state
                var loginSucceededEvent = loginControl.GetType().GetEvent("LoginSucceeded");
                if (loginSucceededEvent != null)
                {
                    EventHandler handler = null;
                    handler = (_, __) =>
                    {
                        // Unsubscribe if possible to avoid multiple calls
                        loginSucceededEvent.RemoveEventHandler(loginControl, handler);

                        isAuthenticated = true;
                        UpdateAuthState();
                        if (mnuMain.Items.Count > 0)
                        {
                            mnuMain.Select(mnuMain.Items[0]);
                        }
                    };
                    loginSucceededEvent.AddEventHandler(loginControl, handler);
                }

                // Remove and dispose existing control
                if (currControl != null)
                {
                    pnlMain.Controls.Remove(currControl);
                    currControl.Dispose();
                    currControl = null;
                }

                // Show the login control inside pnlMain
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(loginControl);
                currControl = loginControl;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login view failed to load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and prepare the RegisterView user control
                var registerControl = new RegisterView
                {
                    Dock = DockStyle.Fill
                };

                // Optional: if RegisterView exposes an event named "RegisterSucceeded", subscribe to update auth state
                var registerSucceededEvent = registerControl.GetType().GetEvent("RegisterSucceeded");
                if (registerSucceededEvent != null)
                {
                    EventHandler handler = null;
                    handler = (_, __) =>
                    {
                        // Unsubscribe if possible to avoid multiple calls
                        registerSucceededEvent.RemoveEventHandler(registerControl, handler);

                        isAuthenticated = true;
                        UpdateAuthState();
                        if (mnuMain.Items.Count > 0)
                        {
                            mnuMain.Select(mnuMain.Items[0]);
                        }
                    };
                    registerSucceededEvent.AddEventHandler(registerControl, handler);
                }

                // Remove and dispose existing control
                if (currControl != null)
                {
                    pnlMain.Controls.Remove(currControl);
                    currControl.Dispose();
                    currControl = null;
                }

                // Show the register control inside pnlMain
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(registerControl);
                currControl = registerControl;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration view failed to load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
