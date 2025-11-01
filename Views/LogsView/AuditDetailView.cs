using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Services.AuditServices;

namespace computer_monitoring_desktop.Views
{
    // Giao diện hiển thị 2 loại log là text và chart
    public partial class AuditDetailView : UserControl
    {
        private readonly IAuditService? auditService;
        // Dataset và attempt đã được lưu trong repo nhưng ở đây cũng cần phải lưu !(view của attempt nào)
        private AuditDataset? currentDataset;
        private ViewMode currentMode = ViewMode.Text;
        private TextLogView? textLogView;
        private AuditChartView? auditChartView;

        // Chạy từ MainWindow -> inject default Audit's service 
        //public AuditDetailView(int attemptId) : this(new AuditService(), attemptId) { }

        internal AuditDetailView(AuditAttempt attempt) : this(new AuditService(), attempt) { }

        // Inject Inmemory Audit Service
        internal AuditDetailView(IAuditService service, AuditAttempt attempt)
        {
            // Không biết handle trường hợp nào nữa, kệ đi
            auditService = service ?? throw new ArgumentNullException(nameof(service));

            InitializeComponent();
            BindDataset(attempt.Id);

            Load += (_, __) =>
            {
                // Load vào thì hiện text log 
                EnsureViews();
                PushDatasetToViews();
                ShowView(currentMode);
            };

            btnBack.Click += (_, __) => NavigateBack();
            btnText.Click += (_, __) => ShowView(ViewMode.Text);
            btnChart.Click += (_, __) => ShowView(ViewMode.Chart);
        }

        private void BindDataset(int attemptId)
        {
            var dataset = auditService?.GetAuditDetails(attemptId);
            currentDataset = dataset;
        }

        private void PushDatasetToViews()
        {
            if (currentDataset == null) return;

            textLogView?.UpdateDataset(currentDataset);
            auditChartView?.UpdateDataset(currentDataset);
        }

        public void UpdateAttempt(AuditAttempt attempt)
        {
            var dataset = auditService?.GetAuditDetails(attempt.Id);
            if (dataset == null) return;

            BindDataset(attempt.Id);
            EnsureViews();
            PushDatasetToViews();
            ShowView(currentMode);
        }

        private void EnsureViews()
        {
            if (textLogView == null)
            {
                textLogView = new TextLogView(auditService)
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };
                pnlContentHost.Controls.Add(textLogView);
            }

            if (auditChartView == null)
            {
                auditChartView = new AuditChartView(auditService)
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };
                pnlContentHost.Controls.Add(auditChartView);
            }
        }

        private void ShowView(ViewMode mode)
        {
            currentMode = mode;

            if (textLogView != null)
            {
                textLogView.Visible = mode == ViewMode.Text;
                if (mode == ViewMode.Text)
                {
                    textLogView.BringToFront();
                }
            }

            if (auditChartView != null)
            {
                auditChartView.Visible = mode == ViewMode.Chart;
                if (mode == ViewMode.Chart)
                {
                    auditChartView.BringToFront();
                }
            }

            // Chỉnh kiểu sau khi nhấn nút
            btnText.Type = mode == ViewMode.Text ? AntdUI.TTypeMini.Primary : AntdUI.TTypeMini.Default;
            btnChart.Type = mode == ViewMode.Chart ? AntdUI.TTypeMini.Primary : AntdUI.TTypeMini.Default;
        }

        private void NavigateBack()
        {
            if (FindForm() is MainWindow mainWindow)
            {
                mainWindow.LoadRoomManagementView();
            }
        }

        // Local log type
        private enum ViewMode
        {
            Text,
            Chart
        }
    }
}
