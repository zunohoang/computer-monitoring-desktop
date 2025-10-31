using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Views
{
    public partial class TextLogView : UserControl
    {
        private AuditDataset dataset = null!;
        private AuditAttempt attempt = null!;
        private IReadOnlyList<AuditProcess> processes = Array.Empty<AuditProcess>();
        private readonly HashSet<string> blacklistNames;
        private bool isLoaded;

        private readonly BindingList<ProcessRow> processRows = new();
        private readonly BindingSource processBinding = new();

        public TextLogView()
            : this(AuditMockModel.Attempts.First().Id)
        {
        }

        internal TextLogView(AuditAttempt attempt)
            : this(attempt.Id)
        {
        }

        public TextLogView(int attemptId)
        {
            InitializeComponent();

            blacklistNames = AuditMockModel.Blacklist
                .Select(item => item.Name.Trim().ToLowerInvariant())
                .ToHashSet();

            ConfigureGrid();
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
                PopulateGrid();
            }
        }

        private void HandleLoad(object? sender, EventArgs e)
        {
            isLoaded = true;
            UpdateHeaderText();
            PopulateGrid();
        }

        private void BindDataset(int attemptId)
        {
            dataset = AuditMockModel.GetDataset(attemptId);
            attempt = dataset.Attempt;
            processes = dataset.Processes;
        }

        private void UpdateHeaderText()
        {
            lblTitle.Text = $"Text log - {attempt.StudentName}";
            lblDescription.Text = $"MSSV: {attempt.StudentCode} | May tram: {attempt.MachineName} | Phong: {attempt.RoomCode} | Ky thi: {attempt.ContestName}";
            lblGridTitle.Text = "Tien trinh dang theo doi";
        }

        private void ConfigureGrid()
        {
            processBinding.DataSource = processRows;
            gridProcesses.AutoGenerateColumns = false;
            gridProcesses.ReadOnly = true;
            gridProcesses.DataSource = processBinding;

            gridProcesses.Columns.Clear();
            gridProcesses.Columns.Add(CreateTextColumn("colProcessName", "Tien trinh", nameof(ProcessRow.ProcessName), 200f));
            gridProcesses.Columns.Add(CreateTextColumn("colStatus", "Trang thai", nameof(ProcessRow.StatusDisplay), 120f));
            gridProcesses.Columns.Add(CreateTextColumn("colStart", "Bat dau", nameof(ProcessRow.StartDisplay), 140f));
            gridProcesses.Columns.Add(CreateTextColumn("colEnd", "Ket thuc", nameof(ProcessRow.EndDisplay), 140f));
            gridProcesses.Columns.Add(CreateTextColumn("colDuration", "Thoi luong", nameof(ProcessRow.DurationDisplay), 120f));
            gridProcesses.Columns.Add(CreateTextColumn("colPid", "PID", nameof(ProcessRow.Pid), 80f, DataGridViewContentAlignment.MiddleRight));

            gridProcesses.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            gridProcesses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            gridProcesses.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            gridProcesses.EnableHeadersVisualStyles = false;

            gridProcesses.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            gridProcesses.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            gridProcesses.DefaultCellStyle.BackColor = Color.White;
            gridProcesses.DefaultCellStyle.SelectionBackColor = Color.FromArgb(191, 219, 254);
            gridProcesses.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            gridProcesses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);

            gridProcesses.DataBindingComplete += GridProcesses_DataBindingComplete;
        }

        private static DataGridViewTextBoxColumn CreateTextColumn(string name, string header, string property, float fillWeight, DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleLeft)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                DataPropertyName = property,
                FillWeight = fillWeight,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = alignment }
            };
        }

        private void PopulateGrid()
        {
            processRows.RaiseListChangedEvents = false;
            processRows.Clear();

            foreach (var process in processes
                         .OrderByDescending(p => string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase))
                         .ThenBy(p => p.EndTime ?? DateTime.MaxValue)
                         .ThenBy(p => p.StartTime))
            {
                processRows.Add(new ProcessRow(process, blacklistNames.Contains(process.Name.Trim().ToLowerInvariant())));
            }

            processRows.RaiseListChangedEvents = true;
            processBinding.ResetBindings(false);
            gridProcesses.ClearSelection();

            lblGridSubtitle.Text = processRows.Count > 0
                ? $"Co {processRows.Count} tien trinh duoc ghi nhan tren may {attempt.MachineName}."
                : $"Khong co tien trinh nao duoc ghi nhan tren may {attempt.MachineName}.";
        }

        private void GridProcesses_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            var baseForeColor = Color.FromArgb(30, 41, 59);
            var baseBackColor = Color.White;
            var baseSelectionBack = Color.FromArgb(191, 219, 254);

            foreach (DataGridViewRow row in gridProcesses.Rows)
            {
                if (row.DataBoundItem is not ProcessRow processRow)
                {
                    continue;
                }

                if (processRow.IsBlacklisted)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(220, 38, 38);
                    row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(220, 38, 38);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(254, 226, 226);
                    row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(252, 165, 165);
                }
                else if (processRow.IsRunning)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(22, 101, 52);
                    row.DefaultCellStyle.SelectionForeColor = Color.FromArgb(22, 101, 52);
                    row.DefaultCellStyle.BackColor = baseBackColor;
                    row.DefaultCellStyle.SelectionBackColor = baseSelectionBack;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = baseForeColor;
                    row.DefaultCellStyle.SelectionForeColor = baseForeColor;
                    row.DefaultCellStyle.BackColor = baseBackColor;
                    row.DefaultCellStyle.SelectionBackColor = baseSelectionBack;
                }
            }
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
