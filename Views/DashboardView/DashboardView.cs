using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AntdUI;
using computer_monitoring_desktop.Models;
using computer_monitoring_desktop.Models.Violation;

namespace computer_monitoring_desktop.Views.SubViews
{
    public partial class DashboardView : UserControl
    {
        private List<ViolationRecord> allViolations;
        private int violationPageSize = 5;
        private int violationCurrentPage = 1;

        public DashboardView()
        {
            InitializeComponent();
            InitializeViolationsTable();
            LoadDashboardData();
            BindEvents();
        }

        private void AdjustStatsCardsHeight()
        {
            if (pnlStats == null || pnlStats.Controls.Count == 0) return;

            int cardWidth = 300;
            int cardHeight = 177;
            int gap = 16;
            int margin = 15;
            int availableWidth = pnlStats.Width;
            int cardsPerRow = Math.Max(1, (availableWidth + gap) / (cardWidth + margin + gap));
            int totalRows = (int)Math.Ceiling((double)pnlStats.Controls.Count / cardsPerRow);
            int totalHeight = totalRows * cardHeight + (totalRows - 1) * gap;

            pnlStats.Height = totalHeight;
        }

        private void PnlStats_Resize(object sender, EventArgs e)
        {
            AdjustStatsCardsHeight();
        }

        private void BindEvents()
        {
            // Resize event for stat cards
            pnlStats.Resize += PnlStats_Resize;
            this.Load += (s, e) => AdjustStatsCardsHeight();

            // Violations pagination events
            pgnViolations.ValueChanged += PgnViolations_ValueChanged;
        }

        private void LoadDashboardData()
        {
            // Mock data - replace with actual data later
            lblContestsValue.Text = "3";
            lblStudentsValue.Text = "1 / 7";
            lblPendingValue.Text = "2";
            lblViolationsValue.Text = "2 / 3";
            lblRoomsValue.Text = "3";

            // Load violations data
            allViolations = new List<ViolationRecord>
            {
                new ViolationRecord { Id = 1, MaSV = "20210001", LoaiViPham = "Quay cóp", MoTa = "Sinh viên 20210001 mở ứng dụng không được phép", MucDo = "Cao", TrangThai = "Đã xử lý", ThoiGian = DateTime.Parse("2024-10-20 08:20:00") },
                new ViolationRecord { Id = 2, MaSV = "20210002", LoaiViPham = "Truy cập web", MoTa = "Sinh viên 20210002 truy cập trang web không phù hợp", MucDo = "Trung bình", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Parse("2024-10-20 08:15:00") },
                new ViolationRecord { Id = 3, MaSV = "20210003", LoaiViPham = "Sử dụng thiết bị", MoTa = "Sinh viên 20210003 có hoạt động đáng ngờ", MucDo = "Thấp", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Parse("2024-10-20 09:00:00") },
                new ViolationRecord { Id = 4, MaSV = "20210004", LoaiViPham = "Nói chuyện", MoTa = "Sinh viên 20210004 nói chuyện trong giờ thi", MucDo = "Trung bình", TrangThai = "Đã xử lý", ThoiGian = DateTime.Parse("2024-10-20 08:45:00") },
                new ViolationRecord { Id = 5, MaSV = "20210005", LoaiViPham = "Rời khỏi chỗ", MoTa = "Sinh viên 20210005 rời khỏi chỗ không báo", MucDo = "Cao", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Parse("2024-10-20 09:10:00") },
                new ViolationRecord { Id = 6, MaSV = "20210006", LoaiViPham = "Điện thoại", MoTa = "Sinh viên 20210006 sử dụng điện thoại", MucDo = "Cao", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Parse("2024-10-20 09:20:00") }
            };

            pgnViolations.Total = allViolations.Count;
            pgnViolations.PageSize = violationPageSize;
            pgnViolations.Current = 1;

            UpdateViolationsTable();
        }

        private void InitializeViolationsTable()
        {
            // Configure table columns
            tblViolations.Columns = new ColumnCollection
            {
                new Column("STT", "STT", ColumnAlign.Center) { 
                    Fixed = true
                },
                new Column("StudentId", "Mã SV", ColumnAlign.Center),
                new Column("Description", "Mô tả", ColumnAlign.Left),
                new Column("Severity", "Mức độ", ColumnAlign.Center),
                new Column("Status", "Trạng thái", ColumnAlign.Center),
                new Column("Time", "Thời gian", ColumnAlign.Center),
                new Column("Actions", "Thao tác", ColumnAlign.Center)
                {
                    Fixed = true,
                    Render = (value, record, rowIndex) => new CellLink[]
                    {
                        new CellButton("view", "Chi tiết") { Type = TTypeMini.Primary, Ghost = true, IconSvg = "EyeOutlined" }
                    }
                }
            };

            // Add cell button click event
            tblViolations.CellButtonClick += TblViolations_CellButtonClick;
        }

        private void TblViolations_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            if (e.Btn.Id == "view")
            {
                // Get the violation record from the row
                var violation = e.Record.GetType().GetProperty("Violation")?.GetValue(e.Record) as ViolationRecord;
                
                if (violation != null)
                {
                    // Navigate to violations view
                    var mainWindow = this.FindForm() as MainWindow;
                    if (mainWindow != null)
                    {
                        mainWindow.LoadViolationView();
                        
                        // Optional: Show notification
                        AntdUI.Message.info(mainWindow, $"Xem chi tiết vi phạm của sinh viên {violation.MaSV}", autoClose: 2);
                    }
                }
            }
        }

        private void PgnViolations_ValueChanged(object sender, PagePageEventArgs e)
        {
            violationCurrentPage = e.Current;
            if (e.PageSize != violationPageSize)
            {
                violationPageSize = e.PageSize;
            }
            UpdateViolationsTable();
        }

        private void UpdateViolationsTable()
        {
            if (allViolations == null) return;

            var pagedViolations = allViolations
                .Skip((violationCurrentPage - 1) * violationPageSize)
                .Take(violationPageSize)
                .ToList();

            // Transform data for table
            var tableData = pagedViolations.Select((v, index) => new
            {
                STT = (violationCurrentPage - 1) * violationPageSize + index + 1,
                StudentId = v.MaSV,
                Description = v.MoTa,
                Severity = new CellTag(v.MucDo, GetSeverityType(v.MucDo)),
                Status = new CellTag(v.TrangThai, GetStatusType(v.TrangThai)),
                Time = v.ThoiGian.ToString("HH:mm:ss dd/MM/yyyy"),
                Violation = v
            }).ToList();

            tblViolations.DataSource = tableData;
        }

        private TTypeMini GetSeverityType(string severity)
        {
            return severity switch
            {
                "Cao" => TTypeMini.Error,
                "Trung bình" => TTypeMini.Warn,
                "Thấp" => TTypeMini.Success,
                _ => TTypeMini.Default
            };
        }

        private TTypeMini GetStatusType(string status)
        {
            return status switch
            {
                "Đã xử lý" => TTypeMini.Success,
                "Chưa xử lý" => TTypeMini.Warn,
                _ => TTypeMini.Default
            };
        }
    }
}
