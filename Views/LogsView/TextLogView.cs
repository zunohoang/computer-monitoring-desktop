using System.ComponentModel;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Services.AuditServices;

namespace computer_monitoring_desktop.Views
{
    public partial class TextLogView : UserControl
    {
        private readonly IAuditService? auditService;
        // Đối với truy vấn sql nó sẽ ra bảng data table, còn lưu 1 row của bảng thì sử dụng binding list là lưu object (ở đây là class cuối file)
        private readonly BindingList<ProcessRow> processRows = new();
        private readonly BindingSource processBinding = new();

        private bool isLoaded;
        // Bộ data của thí sinh đã chọn
        private AuditDataset? currentDataset;
        private HashSet<string>? blacklistNames;
        
        // Không cần constructor không tham số

        internal TextLogView(IAuditService service)
        {
            // Again, don't know why
            auditService = service ?? throw new ArgumentNullException(nameof(service));
            InitializeComponent();

            blacklistNames = auditService?.GetBlacklistNames();

            // Config cho datagridview
            ConfigureGrid();
            Load += HandleLoad;
        }

        private void HandleLoad(object? sender, EventArgs e)
        {
            isLoaded = true;
            if (currentDataset != null)
            {
                UpdateHeaderText();
                PopulateGrid();
            }
        }

        public void UpdateDataset(AuditDataset dataset)
        {
            currentDataset = dataset ?? throw new ArgumentNullException(nameof(dataset));
            blacklistNames = auditService?.GetBlacklistNames();

            if (isLoaded)
            {
                UpdateHeaderText();
                PopulateGrid();
            }
        }

        private void UpdateHeaderText()
        {
            if (currentDataset == null) return;

            var attempt = currentDataset.Attempt;
            lblTitle.Text = $"Text log - {attempt.StudentName}";
            lblDescription.Text = $"MSSV: {attempt.StudentCode} | Máy trạm: {attempt.MachineName} | Phòng: {attempt.RoomCode} | Kỳ thi: {attempt.ContestName}";
            lblGridTitle.Text = "Tiến trình đang theo dõi";
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

            // Gọi hàm sau mỗi lần bind data xong (để format lại giao diện)
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
            if (currentDataset == null) return;

            var attempt = currentDataset.Attempt;
            var processes = currentDataset.Processes;
            // Tắt raise event (kiểu event mà indexchange,... thì sự kiện kích hoạt) cho đến khi update xong bindinglist
            processRows.RaiseListChangedEvents = false;
            processRows.Clear();

            // Sắp xếp lại row theo dạng:
            // Running thì lên trước, sau đó đến endtime lớn hơn (vừa tắt), cuối cùng là giảm dần của starttime
            var orderedProcesses = auditService?.GetOrderedProcesses(attempt.Id);
            foreach (var process in orderedProcesses)
            {
                processRows.Add(new ProcessRow(process, blacklistNames?.Contains(process.Name.Trim().ToLowerInvariant()) ?? false ));
            }

            processRows.RaiseListChangedEvents = true;
            processBinding.ResetBindings(false);
            gridProcesses.ClearSelection();

            lblGridSubtitle.Text = processRows.Count > 0
                ? $"Có {processRows.Count} tiến trình được ghi nhận trên máy {attempt.MachineName}."
                : $"Không có tiến trình nào được ghi nhận trên máy {attempt.MachineName}.";
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

        // Class không bị kế thừa, không ai biết, chú giấu kỹ quá..., nó là 1 cách để cấu trúc class mang tính đóng gói
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

            public string StatusDisplay => IsRunning ? "Đang chạy" : Status;
            public string StartDisplay => StartTime.ToString("HH:mm:ss dd/MM");
            public string EndDisplay => EndTime.HasValue ? EndTime.Value.ToString("HH:mm:ss dd/MM") : "Đang chạy";
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
                        return $"{duration.TotalMinutes:F0} phút";
                    }

                    return $"{duration.TotalHours:F1} giờ";
                }
            }
        }
    }
}
