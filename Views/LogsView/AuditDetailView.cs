using System;
using System.Windows.Forms;
using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Views
{
    public partial class AuditDetailView : UserControl
    {
        private AuditDataset dataset = null!;
        private AuditAttempt attempt = null!;
        private TextLogView? textLogView;
        private AuditChartView? auditChartView;
        private ViewMode currentMode = ViewMode.Text;

        public AuditDetailView(int attemptId)
        {
            InitializeComponent();
            BindDataset(attemptId);

            Load += (_, __) =>
            {
                EnsureViews();
                ShowView(currentMode);
            };

            btnBack.Click += (_, __) => NavigateBack();
            btnText.Click += (_, __) => ShowView(ViewMode.Text);
            btnChart.Click += (_, __) => ShowView(ViewMode.Chart);
        }

        internal AuditDetailView(AuditAttempt attempt)
            : this(attempt.Id)
        {
        }

        public void UpdateAttempt(int attemptId)
        {
            BindDataset(attemptId);
            EnsureViews();
            textLogView?.UpdateAttempt(attempt);
            auditChartView?.UpdateAttempt(attempt);
            ShowView(currentMode);
        }

        internal void UpdateAttempt(AuditAttempt newAttempt)
        {
            UpdateAttempt(newAttempt.Id);
        }

        private void BindDataset(int attemptId)
        {
            dataset = AuditMockModel.GetDataset(attemptId);
            attempt = dataset.Attempt;
        }

        private void EnsureViews()
        {
            if (textLogView == null)
            {
                textLogView = new TextLogView(attempt)
                {
                    Dock = DockStyle.Fill,
                    Visible = false
                };
                pnlContentHost.Controls.Add(textLogView);
            }

            if (auditChartView == null)
            {
                auditChartView = new AuditChartView(attempt)
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

        private enum ViewMode
        {
            Text,
            Chart
        }
    }
}
