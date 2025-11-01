using System;
using System.Linq;
using System.Windows.Forms;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Repositories;

namespace computer_monitoring_desktop.Views
{
    public partial class AuditLogsView : UserControl
    {
        private readonly IAuditRepository auditRepo;
        private readonly int attemptId;
        private AuditAttempt attempt = null!;

        public AuditLogsView()
            : this(new InMemoryAuditRepository(), new InMemoryAuditRepository().GetAttempts().First().Id)
        {
        }

        internal AuditLogsView(IAuditRepository repository)
            : this(repository, repository.GetAttempts().First().Id)
        {
        }

        public AuditLogsView(int attemptId)
            : this(new InMemoryAuditRepository(), attemptId)
        {
        }

        internal AuditLogsView(IAuditRepository repository, int attemptId)
        {
            auditRepo = repository ?? throw new ArgumentNullException(nameof(repository));
            this.attemptId = attemptId;

            InitializeComponent();
            
            LoadAttemptData();
            InitializeTabs();
        }

        private void LoadAttemptData()
        {
            attempt = auditRepo.GetAttempts()
                .FirstOrDefault(a => a.Id == attemptId)
                ?? throw new InvalidOperationException($"Attempt with ID {attemptId} not found.");

            // Set header title to contestant name only
            lblTitle.Text = $"{attempt.StudentName} - {attempt.StudentCode}";
        }

        private void InitializeTabs()
        {
            // Create Audit Chart view and add to first tab
            var chartView = new AuditChartView(auditRepo, attemptId);
            chartView.Dock = DockStyle.Fill;
            tabPageChart.Controls.Add(chartView);

            // Create Text Log view and add to second tab
            var textLogView = new TextLogView(auditRepo, attemptId);
            textLogView.Dock = DockStyle.Fill;
            tabPageTextLog.Controls.Add(textLogView);
        }
    }
}
