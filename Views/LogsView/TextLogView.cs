using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Repositories;
using AntdUI;

namespace computer_monitoring_desktop.Views
{
    public partial class TextLogView : UserControl
    {
        private AuditDataset dataset = null!;
        private AuditAttempt attempt = null!;
        private IReadOnlyList<AuditProcess> processes = Array.Empty<AuditProcess>();
        private readonly HashSet<string> blacklistNames;
        private bool isLoaded;

        private readonly IAuditRepository auditRepo;

        public TextLogView()
            : this(new InMemoryAuditRepository(), new InMemoryAuditRepository().GetAttempts().First().Id)
        {
        }

        internal TextLogView(IAuditRepository repository)
            : this(repository, repository.GetAttempts().First().Id)
        {
        }

        public TextLogView(int attemptId)
            : this(new InMemoryAuditRepository(), attemptId)
        {
        }

        internal TextLogView(IAuditRepository repository, int attemptId)
        {
            auditRepo = repository ?? throw new ArgumentNullException(nameof(repository));

            InitializeComponent();

            blacklistNames = auditRepo.GetBlacklist()
                .Select(item => item.Name.Trim().ToLowerInvariant())
                .ToHashSet();

            InitializeTable();
            BindDataset(attemptId);

            Load += HandleLoad;
        }

        internal void UpdateAttempt(AuditAttempt newAttempt)
        {
            UpdateAttempt(newAttempt.Id);
        }

        public void UpdateAttempt(int newAttemptId)
        {
            BindDataset(newAttemptId);
            if (isLoaded)
            {
                UpdateHeaderText();
                PopulateTable();
            }
        }

        private void HandleLoad(object? sender, EventArgs e)
        {
            isLoaded = true;
            UpdateHeaderText();
            PopulateTable();
        }

        private void BindDataset(int attemptId)
        {
            dataset = auditRepo.GetDataset(attemptId);
            attempt = dataset.Attempt;
            processes = dataset.Processes;
        }

        private void UpdateHeaderText()
        {
            lblTitle.Text = $"Text log - {attempt.StudentName}";
            lblDescription.Text = $"MSSV: {attempt.StudentCode} | Máy trạm: {attempt.MachineName} | Phòng: {attempt.RoomCode} | Kỳ thi: {attempt.ContestName}";
            lblGridTitle.Text = "Tiến trình đang theo dõi";
        }

        private void InitializeTable()
        {
            var columns = new ColumnCollection
            {
                new Column("ProcessName", "Tiến trình", ColumnAlign.Left),
                new Column("StatusDisplay", "Trạng thái", ColumnAlign.Center),
                new Column("StartDisplay", "Bắt đầu", ColumnAlign.Center),
                new Column("EndDisplay", "Kết thúc", ColumnAlign.Center),
                new Column("DurationDisplay", "Thời lượng", ColumnAlign.Center),
                new Column("Pid", "PID", ColumnAlign.Center)
            };
            
            tblProcesses.Columns = columns;
            
            // Add hover and click styling for blacklisted rows
            tblProcesses.SetRowStyle += Table_SetRowStyle;
        }

        private Table.CellStyleInfo Table_SetRowStyle(object sender, TableSetRowStyleEventArgs e)
        {
            if (e.Record is ProcessRow row && row.IsBlacklisted)
            {
                // Red background for blacklisted rows
                return new Table.CellStyleInfo
                {
                    BackColor = Style.Db.ErrorBg
                };
            }
            return null;
        }

        private void PopulateTable()
        {
            var processData = processes
                .OrderByDescending(p => string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase))
                .ThenBy(p => p.EndTime ?? DateTime.MaxValue)
                .ThenBy(p => p.StartTime)
                .Select(process => new ProcessRow(process, blacklistNames.Contains(process.Name.Trim().ToLowerInvariant())))
                .ToArray();

            tblProcesses.DataSource = processData;
            
            // Refresh the table to apply the SetRowStyle styling
            tblProcesses.Invalidate();

            lblGridSubtitle.Text = processData.Length > 0
                ? $"Có {processData.Length} tiến trình được ghi nhận trên {attempt.MachineName}."
                : $"Không có tiến trình được ghi nhận trên {attempt.MachineName}.";
        }

        private sealed class ProcessRow
        {
            public ProcessRow(AuditProcess process, bool isBlacklisted)
            {
                ProcessName = process.Name;
                Status = process.Status;
                StartTime = process.StartTime;
                EndTime = process.EndTime;
                Pid = process.Pid;
                IsRunning = string.Equals(process.Status, "running", StringComparison.OrdinalIgnoreCase);
                IsBlacklisted = isBlacklisted;
            }

            public string ProcessName { get; }
            public string Status { get; }
            public DateTime StartTime { get; }
            public DateTime? EndTime { get; }
            public int Pid { get; }
            public bool IsRunning { get; }
            public bool IsBlacklisted { get; }

            
            public string StatusDisplay => IsRunning ? "Dang chay" : Status;
            public string StartDisplay => StartTime.ToString("HH:mm:ss dd/MM");
            public string EndDisplay => EndTime.HasValue ? EndTime.Value.ToString("HH:mm:ss dd/MM") : "Dang chay";
            public string DurationDisplay
            {
                get
                {
                    var end = EndTime ?? DateTime.Now;
                    var duration = end - StartTime;

                    if (duration.TotalMinutes < 1)
                    {
                        return $"{duration.TotalSeconds:F0}s";
                    }

                    if (duration.TotalHours < 1)
                    {
                        return $"{duration.TotalMinutes:F0} phut";
                    }

                    return $"{duration.TotalHours:F1} gio";
                }
            }
        }
    }
}
