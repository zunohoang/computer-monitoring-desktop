using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Models.Audit;
using Panel = AntdUI.Panel;

namespace computer_monitoring_desktop.Views
{
    public partial class AuditLogView : UserControl
    {
        private readonly IReadOnlyList<AuditProcess> processes;
        private readonly IReadOnlyList<AuditLogEntry> logs;
        private readonly IReadOnlyDictionary<int, AuditProcess> processMap;
        private readonly HashSet<string> blacklistNames;

        public AuditLogView()
        {
            InitializeComponent();

            processes = AuditMockData.Processes;
            logs = AuditMockData.Logs;
            processMap = processes.ToDictionary(p => p.Id);
            blacklistNames = AuditMockData.Blacklist
                .Select(item => item.Name.Trim().ToLowerInvariant())
                .ToHashSet();

            Load += (_, __) => RenderData();
            flpProcesses.Resize += (_, __) => RenderProcesses();
            flpLogs.Resize += (_, __) => RenderLogs();
        }

        private void RenderData()
        {
            RenderProcesses();
            RenderLogs();
        }

        private void RenderProcesses()
        {
            if (!IsHandleCreated)
            {
                return;
            }

            flpProcesses.SuspendLayout();
            flpProcesses.Controls.Clear();

            var ordered = processes
                .OrderByDescending(p => string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase))
                .ThenBy(p => p.StartTime)
                .ToList();

            var renderWidth = Math.Max(680, flpProcesses.ClientSize.Width - 24);
            // header docked at top
            var header = BuildProcessHeader(renderWidth);
            header.Dock = DockStyle.Top;
            flpProcesses.Controls.Add(header);

            // add rows docked Top so they stack vertically and respect scrolling
            foreach (var process in ordered)
            {
                var row = BuildProcessRow(process, renderWidth) as Control;
                row.Dock = DockStyle.Top;
                flpProcesses.Controls.Add(row);
                row.BringToFront();
            }

            if (ordered.Count == 0)
            {
                var empty = CreateEmptyState("Chưa có tiến trình nào được ghi nhận.");
                empty.Dock = DockStyle.Top;
                flpProcesses.Controls.Add(empty);
            }

            flpProcesses.ResumeLayout();
        }

        private Control BuildProcessHeader(int width)
        {
            var header = new Panel
            {
                Width = width,
                Height = 42,
                BackColor = Color.FromArgb(241, 245, 249),
                Margin = new Padding(0, 0, 16, 8),
                Padding = new Padding(16, 10, 16, 8)
            };

            var columns = GetProcessColumnWidths(width);

            header.Controls.Add(BuildHeaderLabel("Tiến trình", columns.ProcessWidth, 0));
            header.Controls.Add(BuildHeaderLabel("Trạng thái", columns.StatusWidth, columns.ProcessWidth));
            header.Controls.Add(BuildHeaderLabel("Bắt đầu", columns.StartWidth, columns.ProcessWidth + columns.StatusWidth));
            header.Controls.Add(BuildHeaderLabel("Kết thúc / ghi nhận", columns.EndWidth, columns.ProcessWidth + columns.StatusWidth + columns.StartWidth));

            return header;
        }

        private Control BuildProcessRow(AuditProcess process, int width)
        {
            var isBlacklisted = blacklistNames.Contains(process.Name.Trim().ToLowerInvariant());
            var isRunning = string.Equals(process.Status, "running", StringComparison.OrdinalIgnoreCase);

            var columns = GetProcessColumnWidths(width);

            var row = new AntdUI.Panel
            {
                Width = width,
                Height = 60,
                Back = Color.White,
                BorderColor = Color.FromArgb(226, 232, 240),
                Radius = 8,
                Margin = new Padding(0, 0, 16, 8),
                Padding = new Padding(16, 12, 16, 12)
            };

            // Table layout to avoid overlap
            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = Color.Transparent,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columns.ProcessWidth));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columns.StatusWidth));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, columns.StartWidth));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // end column takes remaining

            var nameLabel = new AntdUI.Label
            {
                Text = $"{process.Name} (PID {process.Pid})",
                Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold),
                ForeColor = isBlacklisted ? Color.FromArgb(220, 38, 38) : Color.FromArgb(30, 41, 59),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            var statusLabel = new AntdUI.Label
            {
                Text = process.Status.ToUpperInvariant(),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = isRunning ? Color.FromArgb(99, 102, 241) : Color.FromArgb(100, 116, 139),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            var startLabel = new AntdUI.Label
            {
                Text = process.StartTime == default ? "Không rõ" : process.StartTime.ToString("HH:mm:ss dd/MM"),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.FromArgb(55, 65, 81),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };

            var endPanel = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent };
            var endLabel = new AntdUI.Label
            {
                Text = process.EndTime.HasValue ? process.EndTime.Value.ToString("HH:mm:ss dd/MM") : (isRunning ? "Đang chạy" : "Không rõ"),
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = process.EndTime.HasValue ? Color.FromArgb(107, 114, 128) : Color.FromArgb(59, 130, 246),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent,
                Height = 24
            };
            var activitiesCount = logs.Count(log => log.ProcessId == process.Id);
            var countLabel = new AntdUI.Label
            {
                Text = $"Hoạt động: {activitiesCount}",
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = activitiesCount > 0 ? Color.FromArgb(30, 64, 175) : Color.FromArgb(148, 163, 184),
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent,
                Height = 20
            };

            endPanel.Controls.Add(endLabel);
            endPanel.Controls.Add(countLabel);

            table.Controls.Add(nameLabel, 0, 0);
            table.Controls.Add(statusLabel, 1, 0);
            table.Controls.Add(startLabel, 2, 0);
            table.Controls.Add(endPanel, 3, 0);

            row.Controls.Add(table);

            System.Diagnostics.Debug.WriteLine($"P:{process.Id} name='{process.Name}' procW={columns.ProcessWidth} statusW={columns.StatusWidth}");

            return row;
        }

        private (int ProcessWidth, int StatusWidth, int StartWidth, int EndWidth) GetProcessColumnWidths(int totalWidth)
        {
            var usable = totalWidth - 32; // account for panel padding
            var processWidth = (int)(usable * 0.4);
            var statusWidth = (int)(usable * 0.16);
            var startWidth = (int)(usable * 0.2);
            var endWidth = usable - processWidth - statusWidth - startWidth;

            return (processWidth, statusWidth, startWidth, Math.Max(endWidth, 180));
        }

        private Control BuildHeaderLabel(string text, int width, int left)
        {
            return new AntdUI.Label
            {
                Text = text,
                Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(left, 0),
                Size = new Size(width, 24),
                TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private void RenderLogs()
        {
            if (!IsHandleCreated)
            {
                return;
            }

            flpLogs.SuspendLayout();
            flpLogs.Controls.Clear();

            var orderedLogs = logs.OrderBy(l => l.CreatedAt).ToList();
            var renderWidth = Math.Max(680, flpLogs.ClientSize.Width - 24);

            foreach (var log in orderedLogs)
            {
                flpLogs.Controls.Add(BuildLogRow(log, renderWidth));
            }

            if (orderedLogs.Count == 0)
            {
                flpLogs.Controls.Add(CreateEmptyState("Chưa có nhật ký nào được ghi lại."));
            }

            flpLogs.ResumeLayout();
        }

        private Control BuildLogRow(AuditLogEntry log, int width)
        {
            var hasAlert = log.AlertId > 0;
            processMap.TryGetValue(log.ProcessId, out var process);
            var processName = process?.Name ?? (log.ProcessId == 0 ? "Hệ thống" : "Không rõ");

            var row = new AntdUI.Panel
            {
                Width = width,
                Height = 76,
                Back = Color.White,
                BorderColor = Color.FromArgb(229, 231, 235),
                Radius = 8,
                Margin = new Padding(0, 0, 16, 12),
                Padding = new Padding(16, 10, 16, 10)
            };

            var timeLabel = new AntdUI.Label
            {
                Text = log.CreatedAt.ToString("HH:mm:ss dd/MM"),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(0, 0),
                Size = new Size(170, 24),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var processLabel = new AntdUI.Label
            {
                Text = processName,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = blacklistNames.Contains(processName.Trim().ToLowerInvariant())
                    ? Color.FromArgb(220, 38, 38)
                    : Color.FromArgb(71, 85, 105),
                Location = new Point(0, 28),
                Size = new Size(220, 20),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var detailsLabel = new AntdUI.Label
            {
                Text = log.Details,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                ForeColor = Color.FromArgb(55, 65, 81),
                Location = new Point(190, 8),
                Size = new Size(width - 360, 48),
                TextAlign = ContentAlignment.TopLeft
            };

            var typeLabel = new AntdUI.Label
            {
                Text = log.Type.ToUpperInvariant(),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = hasAlert ? Color.FromArgb(220, 38, 38) : Color.FromArgb(59, 130, 246),
                Location = new Point(width - 140, 0),
                Size = new Size(120, 24),
                TextAlign = ContentAlignment.MiddleRight
            };

            row.Controls.Add(timeLabel);
            row.Controls.Add(processLabel);
            row.Controls.Add(detailsLabel);
            row.Controls.Add(typeLabel);

            return row;
        }

        private Control CreateEmptyState(string message)
        {
            return new AntdUI.Label
            {
                Text = message,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(100, 116, 139),
                AutoSize = false,
                Size = new Size(400, 24),
                Margin = new Padding(0, 0, 0, 12),
                TextAlign = ContentAlignment.MiddleLeft
            };
        }
    }
}
