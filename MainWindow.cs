using AntdUI;
using computer_monitoring_desktop.Models;
using computer_monitoring_desktop.Models.Repositories;
using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Utils;
using computer_monitoring_desktop.Views.Auth;
using computer_monitoring_desktop.Views.Contests;
using computer_monitoring_desktop.Views.SubViews;
using System;
using System.Linq;
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
                case "home":
                case "Trang chủ":
                    SetBreadcrumb(("Trang chủ", "home"));
                    LoadDashboardView();
                    break;
                case "Dashboard":
                    SetBreadcrumb(("Trang chủ", "home"), ("Dashboard", "Dashboard"));
                    LoadDashboardView();
                    break;
                case "rooms":
                case "Quản lý phòng thi":
                    SetBreadcrumb(("Trang chủ", "home"), ("Quản lý phòng thi", "rooms"));
                    LoadRoomManagementView();
                    break;
                case "violations":
                case "Quản lý vi phạm":
                    SetBreadcrumb(("Trang chủ", "home"), ("Quản lý vi phạm", "violations"));
                    LoadViolationView();
                    break;
                case "messages":
                case "Quản lý tin nhắn":
                    SetBreadcrumb(("Trang chủ", "home"), ("Quản lý tin nhắn", "messages"));
                    // LoadMessagesView();
                    break;
                case "Danh sách cuộc thi":
                    LoadContestView();
                    break;
                case "Chi tiết cuộc thi":
                    // Optionally reload details or do nothing
                    break;
                default:
                    // If it's an attemptId (int), reload the audit chart
                    if (int.TryParse(key, out int attemptId))
                    {
                        LoadAuditChartView(attemptId);
                    }
                    break;
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

        public void LoadAuditChartView(int attemptId)
        {
            var attempt = new InMemoryAuditRepository().GetAttempts().FirstOrDefault(a => a.Id == attemptId);
            if (attempt != null)
            {
                SetBreadcrumb(
                    ("Trang chủ", "home"),
                    ("Quản lý phòng thi", "rooms"),
                    ($"{attempt.StudentName} - {attempt.StudentCode}", attemptId)
                );
            }
            
            var logsView = new AuditLogsView(attemptId);
            ViewManager.LoadView(pnlContent, logsView);
        }

        internal void LoadAuditChartView(Models.Audit.AuditAttempt attempt)
        {
            LoadAuditChartView(attempt.Id);
        }
        
        // Backwards compatibility - redirect to AuditChartView
        public void LoadAuditDetailView(int attemptId)
        {
            LoadAuditChartView(attemptId);
        }

        internal void LoadAuditDetailView(Models.Audit.AuditAttempt attempt)
        {
            LoadAuditChartView(attempt.Id);
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
                        SetBreadcrumb(("Trang chủ", "home"), ("Dashboard", "Dashboard"));
                        LoadDashboardView();
                        break;
                    case "Contests":
                        LoadContestView();
                        break;
                    case "Rooms":
                        SetBreadcrumb(("Trang chủ", "home"), ("Quản lý phòng thi", "rooms"));
                        LoadRoomManagementView();
                        break;
                    case "Violations":
                        SetBreadcrumb(("Trang chủ", "home"), ("Quản lý vi phạm", "violations"));
                        LoadViolationView();
                        break;
                    case "Messages":
                        SetBreadcrumb(("Trang chủ", "home"), ("Quản lý tin nhắn", "messages"));
                        // LoadMessagesView(); // Add this when you have the view
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
