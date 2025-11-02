using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Repositories;
using computer_monitoring_desktop.Models.Repositories.Audit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    public partial class AuditChartView : UserControl
    {
        private AuditDataset dataset = null!;
        private AuditAttempt attempt = null!;
        private IReadOnlyList<AuditProcess> processes = Array.Empty<AuditProcess>();
        private IReadOnlyList<AuditLogEntry> logs = Array.Empty<AuditLogEntry>();
        private readonly HashSet<string> blacklistNames;
        private bool isLoaded;
        private (DateTime Start, DateTime End) timelineRange;

        private AntdUI.Label summaryTotalProcesses = null!;
        private AntdUI.Label summaryRunningProcesses = null!;
        private AntdUI.Label summaryAlerts = null!;
        private AntdUI.Label summaryLogs = null!;

        private readonly IAuditRepository auditRepo;

        public AuditChartView()
            : this(new InMemoryAuditRepository(), new InMemoryAuditRepository().GetAttempts().First().Id)
        {
        }

        internal AuditChartView(IAuditRepository repository)
            : this(repository, repository.GetAttempts().First().Id)
        {
        }

        public AuditChartView(int attemptId)
            : this(new InMemoryAuditRepository(), attemptId)
        {
        }

        internal AuditChartView(IAuditRepository repository, int attemptId)
        {
            auditRepo = repository ?? throw new ArgumentNullException(nameof(repository));

            InitializeComponent();

            blacklistNames = auditRepo.GetBlacklist()
                .Select(item => item.Name.Trim().ToLowerInvariant())
                .ToHashSet();

            BuildSummaryCards();
            BindDataset(attemptId);

            Load += HandleLoad;
            flpTimeline.SizeChanged += (_, __) => ResizeTimelineRows();
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
                RenderData();
            }
        }

        private void HandleLoad(object? sender, EventArgs e)
        {
            isLoaded = true;
            UpdateHeaderText();
            RenderData();
        }

        private void BindDataset(int attemptId)
        {
            dataset = auditRepo.GetDataset(attemptId);
            attempt = dataset.Attempt;
            processes = dataset.Processes;
            logs = dataset.Logs;
            timelineRange = auditRepo.GetTimelineRange(attempt.Id);
        }

        private void UpdateHeaderText()
        {
            lblTitle.Text = $"Audit chart - {attempt.StudentName}";
            lblDescription.Text = $"MSSV: {attempt.StudentCode} | May tram: {attempt.MachineName} | Phong: {attempt.RoomCode} | Ky thi: {attempt.ContestName}";
            lblTimelineTitle.Text = $"Timeline tien trinh (tu {timelineRange.Start:HH:mm:ss dd/MM} den {timelineRange.End:HH:mm:ss dd/MM})";
        }

        private void RenderData()
        {
            UpdateSummary();
            RenderAxis();
            RenderTimeline();
        }

        private void UpdateSummary()
        {
            summaryTotalProcesses.Text = processes.Count.ToString();
            summaryRunningProcesses.Text = processes.Count(p =>
                string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase)).ToString();
            summaryAlerts.Text = logs.Count(l => l.AlertId > 0).ToString();
            summaryLogs.Text = logs.Count.ToString();
        }

        private void RenderAxis()
        {
            lblAxisStart.Text = $"Bat dau: {timelineRange.Start:HH:mm:ss dd/MM}";
            var midpoint = timelineRange.Start + TimeSpan.FromTicks((timelineRange.End - timelineRange.Start).Ticks / 2);
            lblAxisMid.Text = $"Giua: {midpoint:HH:mm:ss dd/MM}";
            lblAxisEnd.Text = $"Ket thuc: {timelineRange.End:HH:mm:ss dd/MM}";
        }

        private void RenderTimeline()
        {
            flpTimeline.SuspendLayout();
            flpTimeline.Controls.Clear();

            if (processes.Count == 0)
            {
                flpTimeline.Controls.Add(CreateEmptyState("Chua co du lieu timeline nao duoc ghi nhan."));
                flpTimeline.ResumeLayout();
                return;
            }

            var ordered = processes
                .OrderByDescending(p => string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase))
                .ThenBy(p => p.EndTime ?? DateTime.MaxValue)
                .ThenBy(p => p.StartTime)
                .ToList();

            foreach (var process in ordered)
            {
                var processLogs = logs.Where(l => l.ProcessId == process.Id).ToList();

                var row = new TimelineRowControl
                {
                    ProcessName = process.Name,
                    Start = process.StartTime,
                    End = process.EndTime ?? timelineRange.End,
                    IsRunning = string.Equals(process.Status, "running", StringComparison.OrdinalIgnoreCase),
                    IsBlacklisted = blacklistNames.Contains(process.Name.Trim().ToLowerInvariant()),
                    RangeStart = timelineRange.Start,
                    RangeEnd = timelineRange.End,
                    Logs = processLogs,
                    Width = Math.Max(600, flpTimeline.ClientSize.Width - 40),
                    Margin = new Padding(0, 0, 0, 12)
                };

                flpTimeline.Controls.Add(row);
            }

            flpTimeline.ResumeLayout();
            ResizeTimelineRows();
            AdjustFlowLayoutHeight();
        }

        private void ResizeTimelineRows()
        {
            if (flpTimeline.Controls.Count == 0)
            {
                return;
            }

            var targetWidth = Math.Max(600, flpTimeline.ClientSize.Width - 40);
            foreach (Control control in flpTimeline.Controls)
            {
                if (control is TimelineRowControl row)
                {
                    row.Width = targetWidth;
                }
            }
        }

        private void AdjustFlowLayoutHeight()
        {
            if (flpTimeline.Controls.Count == 0)
            {
                flpTimeline.Height = 100;
                return;
            }

            // Calculate total height needed for all controls
            int totalHeight = 0;
            foreach (Control control in flpTimeline.Controls)
            {
                totalHeight += control.Height + control.Margin.Vertical;
            }

            // Add padding
            totalHeight += flpTimeline.Padding.Vertical;

            // Set the FlowLayoutPanel height to enable AntdUI.Panel scrollbar
            flpTimeline.Height = totalHeight;
        }

        private void BuildSummaryCards()
        {
            flpSummary.Controls.Clear();

            summaryTotalProcesses = CreateSummaryCard("Tong tien trinh");
            summaryRunningProcesses = CreateSummaryCard("Dang chay");
            summaryAlerts = CreateSummaryCard("Canh bao");
            summaryLogs = CreateSummaryCard("Tong log");
        }

        private AntdUI.Label CreateSummaryCard(string title)
        {
            var card = new AntdUI.Panel
            {
                Width = 200,
                Height = 90,
                Back = Color.White,
                Radius = 14,
                Padding = new Padding(18, 16, 18, 16),
                Margin = new Padding(0, 0, 0, 0),
                Shadow = 2
            };

            var titleLabel = new AntdUI.Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 116, 139),
                Dock = DockStyle.Top,
                Height = 28,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var valueLabel = new AntdUI.Label
            {
                Text = "0",
                Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            card.Controls.Add(valueLabel);
            card.Controls.Add(titleLabel);
            flpSummary.Controls.Add(card);

            return valueLabel;
        }

        private Control CreateEmptyState(string message)
        {
            return new AntdUI.Label
            {
                Text = message,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 116, 139),
                AutoSize = false,
                Width = Math.Max(600, flpTimeline.ClientSize.Width - 60),
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private sealed class TimelineRowControl : Control
        {
            private const int NameColumnWidth = 220;
            private const int HorizontalPadding = 16;
            private const int VerticalPadding = 16;

            private static readonly Font NameFont = new("Segoe UI", 9.5f, FontStyle.Bold);
            private static readonly Font TimeFont = new("Segoe UI", 8.5f);

            public string ProcessName { get; set; } = string.Empty;
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public bool IsRunning { get; set; }
            public bool IsBlacklisted { get; set; }
            public DateTime RangeStart { get; set; }
            public DateTime RangeEnd { get; set; }
            public IReadOnlyList<AuditLogEntry> Logs { get; set; } = Array.Empty<AuditLogEntry>();

            public TimelineRowControl()
            {
                DoubleBuffered = true;
                Height = 60;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                
                // Use theme-aware background
                var bgColor = AntdUI.Style.Db.BgBase;
                e.Graphics.Clear(bgColor);

                var nameRect = new Rectangle(0, 0, NameColumnWidth, Height);
                TextRenderer.DrawText(
                    e.Graphics,
                    ProcessName,
                    NameFont,
                    nameRect,
                    IsBlacklisted ? AntdUI.Style.Db.Error : AntdUI.Style.Db.Text,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                var chartLeft = NameColumnWidth + HorizontalPadding;
                var chartRight = Width - HorizontalPadding;
                var chartWidth = Math.Max(1, chartRight - chartLeft);
                var chartTop = VerticalPadding + 6;
                var chartHeight = Height - (VerticalPadding * 2) - 12;

                using var baselinePen = new Pen(AntdUI.Style.Db.BorderColor, 1);
                e.Graphics.DrawLine(baselinePen, chartLeft, chartTop + chartHeight, chartRight, chartTop + chartHeight);

                var totalSeconds = Math.Max(1, (RangeEnd - RangeStart).TotalSeconds);
                var clampedStart = Start < RangeStart ? RangeStart : Start;
                var clampedEnd = End > RangeEnd ? RangeEnd : End;

                var startRatio = Math.Clamp((clampedStart - RangeStart).TotalSeconds / totalSeconds, 0d, 1d);
                var endRatio = Math.Clamp((clampedEnd - RangeStart).TotalSeconds / totalSeconds, 0d, 1d);

                var barLeft = chartLeft + (int)(chartWidth * startRatio);
                var barRight = chartLeft + (int)(chartWidth * Math.Max(endRatio, startRatio + 0.02));
                var barRect = new Rectangle(barLeft, chartTop, Math.Max(6, barRight - barLeft), chartHeight);

                var barColor = IsBlacklisted
                    ? AntdUI.Style.Db.Error
                    : IsRunning
                        ? AntdUI.Style.Db.Primary
                        : AntdUI.Style.Db.TextSecondary;

                using var barBrush = new SolidBrush(Color.FromArgb(220, barColor));
                using var barPen = new Pen(barColor, 1.5f);

                e.Graphics.FillRectangle(barBrush, barRect);
                e.Graphics.DrawRectangle(barPen, barRect);

                foreach (var log in Logs)
                {
                    var logRatio = Math.Clamp((log.CreatedAt - RangeStart).TotalSeconds / totalSeconds, 0d, 1d);
                    var markerX = chartLeft + (int)(chartWidth * logRatio);
                    var markerHeight = barRect.Height + 12;
                    var markerRect = new Rectangle(markerX - 2, barRect.Top - 6, 4, markerHeight);

                    var markerColor = log.AlertId > 0
                        ? AntdUI.Style.Db.Error
                        : AntdUI.Style.Db.Primary;

                    using var markerBrush = new SolidBrush(Color.FromArgb(210, markerColor));
                    e.Graphics.FillRectangle(markerBrush, markerRect);
                }

                var timeText = $"{clampedStart:HH:mm:ss} → {(IsRunning ? "dang chay" : clampedEnd.ToString("HH:mm:ss"))}";
                var timeRect = new Rectangle(chartLeft, chartTop + chartHeight + 2, chartWidth, Height - (chartTop + chartHeight) - 2);
                TextRenderer.DrawText(
                    e.Graphics,
                    timeText,
                    TimeFont,
                    timeRect,
                    AntdUI.Style.Db.TextQuaternary,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
    }
}