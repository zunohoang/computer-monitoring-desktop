using AntdUI;
using computer_monitoring_desktop.Models;
using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Utils;
using computer_monitoring_desktop.Views.Auth;
using computer_monitoring_desktop.Views.Contests;
using computer_monitoring_desktop.Views.SubViews;
using System;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    public partial class MainWindow : Window
    {
        private bool isLight = true;

        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            LoadMenu();
            // isLight = ThemeHelper.isLightMode();
            btnTheme.Toggle = !isLight;
            ThemeHelper.setColorMode(this, isLight);
            Config.ShowInWindow = true;
            // Attach breadcrumb navigation
            BreadcrumbHelper.AttachNavigation(breadcrumb1, HandleBreadcrumbNavigation);
            LoadWelcomeView();
        }

        private void HandleBreadcrumbNavigation(object tagOrText)
        {
            // Use tag if set, otherwise use text
            string key = tagOrText?.ToString();
            switch (key)
            {
                case "Trang chủ":
                    LoadDashboardView();
                    break;
                case "Danh sách cuộc thi":
                    LoadContestView();
                    break;
                case "Chi tiết cuộc thi":
                    // Optionally reload details or do nothing
                    break;
                // Add more cases as needed
            }
        }

        private void LoadWelcomeView()
        {
            var welcomeView = new WellcomeView(this);
            welcomeView.OnNavigateToLogin += (s, e) => LoadLoginView();
            welcomeView.OnNavigateToRegister += (s, e) => LoadRegisterView();
            ViewManager.LoadView(pnlContent, welcomeView);
        }

        private void LoadLoginView()
        {
            var loginView = new LoginView();
            loginView.OnLoginSuccess += (s, e) => {
                AntdUI.Message.success(this, "Đăng nhập thành công! Chào mừng bạn!", autoClose: 3);
                // After successful login, navigate to room management dashboard
                LoadRoomManagementView();
            };
            loginView.OnSwitchToRegister += (s, e) => LoadRegisterView();
            ViewManager.LoadView(pnlContent, loginView);
        }

        private void LoadDashboardView()
        {
            var dashboard = new DashboardView();
            ViewManager.LoadView(pnlContent, dashboard);
        }

        // Helper to set breadcrumb items dynamically
        public void SetBreadcrumb(params (string Text, object Tag)[] items)
        {
            BreadcrumbHelper.SetBreadcrumb(breadcrumb1, items);
        }

        public void LoadContestView()
        {
            SetBreadcrumb(("Trang chủ", null), ("Danh sách cuộc thi", null));
            var contestView = new ContestView();
            ViewManager.LoadView(pnlContent, contestView);
        }

        public void LoadRoomManagementView()
        {
            var roomView = new RoomManagementView();
            ViewManager.LoadView(pnlContent, roomView);
        }
        
        public void LoadViolationView()
        {
            var violationView = new ViolationView();
            ViewManager.LoadView(pnlContent, violationView);
        }

        public void LoadAuditDetailView(Models.Audit.AuditAttempt attempt)
        {
            var auditView = new AuditDetailView(attempt);
            ViewManager.LoadView(pnlContent, auditView);
        }

        public void LoadContestDetailsView(string contestId,string contestName)
        {
            SetBreadcrumb(("Trang chủ", null), ("Danh sách cuộc thi", null), (contestName, contestId));
            var contestDetailsView = new ContestDetailsView(contestId,contestName);
            ViewManager.LoadView(pnlContent, contestDetailsView);
        }

        private void LoadRegisterView()
        {
            var registerView = new RegisterView();
            registerView.OnRegisterSuccess += (s, e) => {
               AntdUI.Message.success(this, "Đăng ký thành công! Vui lòng đăng nhập.", autoClose: 3);
                LoadLoginView();
            };
            registerView.OnSwitchToLogin += (s, e) => LoadLoginView();
            ViewManager.LoadView(pnlContent, registerView);
        }

        private void LoadMenu(string filter = "")
        {
            mnuSidebar.Collapsed = true;

            mnuSidebar.Items.Clear();
            foreach (var itemModel in DataClass.MenuItems)
            {
                var childItem = itemModel.Text.ToLower();

                if (childItem.Contains(filter))
                {
                    mnuSidebar.Items.Add(new MenuItem
                    {
                        Text = itemModel.Text,
                        IconSvg = itemModel.IconSvg,
                        Tag = itemModel.Tag,
                    });
                }
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (mnuSidebar.Collapsed) pnlSidebar.Width = (int)(250 * Config.Dpi);
            else pnlSidebar.Width = (int)(50 * Config.Dpi);
            btnCollapse.Toggle = !btnCollapse.Toggle;
            mnuSidebar.Collapsed = !mnuSidebar.Collapsed;
            if (mnuSidebar.Items.Count > 0)
            {
                mnuSidebar.Select(mnuSidebar.Items[0]);
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            isLight = !isLight;
            btnTheme.Toggle = !isLight;
            ThemeHelper.setColorMode(this, isLight);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            titlebar.Loading = true;
            var text = inpSearch.Text.ToLower();
            LoadMenu(text);
            titlebar.Loading = false;
        }

        private void mnuSidebar_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            // Load different views based on menu selection
            if (e.Value != null && e.Value.Tag != null)
            {
                string tag = e.Value.Tag.ToString();
                
                switch (tag)
                {
                    case "Dashboard":
                        LoadDashboardView();
                        break;
                    case "Contests":
                        LoadContestView();
                        break;
                    case "Rooms":
                        LoadRoomManagementView();
                        break;
                    case "Violations":
                        LoadViolationView();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
