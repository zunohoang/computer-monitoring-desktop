using AntdUI;
using computer_monitoring_desktop.Views.Violation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AntdUI.Table;
using computer_monitoring_desktop.Models.Violation;

namespace computer_monitoring_desktop.Views
{
    public partial class ViolationView : UserControl
    {
        private List<ViolationRecord> dataList = new();
        private List<ViolationRecord> filteredList = new();
        private int violationPageSize = 10;
        private int violationCurrentPage = 1;

        public ViolationView()
        {
            InitializeComponent();
        }

        private void ViolationView_Load(object sender, EventArgs e)
        {
            AdjustPanelLayout();
            this.Resize += ViolationView_Resize;

            LoadData();
            SetupTable();
            ApplyFilterHandlers();
        }

        private void LoadData()
        {
            dataList = new List<ViolationRecord>
            {
                new ViolationRecord { Id = 1, MaSV = "SV001", LoaiViPham = "Quay cóp", MoTa = "Nhìn bài bạn", MucDo = "Cao", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Now.AddMinutes(-30) },
                new ViolationRecord { Id = 2, MaSV = "SV002", LoaiViPham = "Rời khỏi chỗ", MoTa = "Đi ra ngoài không báo", MucDo = "Trung bình", TrangThai = "Đã xử lý", ThoiGian = DateTime.Now.AddHours(-1) },
                new ViolationRecord { Id = 3, MaSV = "SV003", LoaiViPham = "Sử dụng điện thoại", MoTa = "Phát hiện đang cầm điện thoại", MucDo = "Cao", TrangThai = "Chưa xử lý", ThoiGian = DateTime.Now.AddHours(-2) },
                new ViolationRecord { Id = 4, MaSV = "SV004", LoaiViPham = "Nói chuyện", MoTa = "Nói chuyện trong giờ", MucDo = "Thấp", TrangThai = "Đã xử lý", ThoiGian = DateTime.Now.AddHours(-3) }
            };

            filteredList = new List<ViolationRecord>(dataList);
            UpdateStatistics();
        }

        private void SetupTable()
        {
            tbl_violation.FixedHeader = true;
            tbl_violation.Bordered = true;
            tbl_violation.AutoSizeColumnsMode = ColumnsMode.Auto;
            tbl_violation.VisibleHeader = true;
            tbl_violation.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tbl_violation.RowSelectedFore = Color.Black;

            tbl_violation.Columns.Add(new Column("STT", "STT") {
                Align = ColumnAlign.Center
            });
            tbl_violation.Columns.Add(new Column("Id", "ID"));
            tbl_violation.Columns.Add(new Column("MaSV", "Mã SV"));
            tbl_violation.Columns.Add(new Column("LoaiViPham", "Loại vi phạm"));
            tbl_violation.Columns.Add(new Column("MoTa", "Mô tả"));
            tbl_violation.Columns.Add(new Column("MucDo", "Mức độ"));
            tbl_violation.Columns.Add(new Column("TrangThai", "Trạng thái"));
            tbl_violation.Columns.Add(new Column("ThoiGian", "Thời gian"));
            tbl_violation.Columns.Add(new Column("ChiTiet", "Nội dung chi tiết") { Align = ColumnAlign.Center});
            tbl_violation.Columns.Add(new Column("XuLy", "Xử lý") { Align = ColumnAlign.Center });

            // Setup pagination
            pgnViolations.Total = filteredList.Count;
            pgnViolations.PageSize = violationPageSize;
            pgnViolations.Current = 1;
            pgnViolations.ValueChanged += PgnViolations_ValueChanged;

            RefreshTable();
        }

        private void PgnViolations_ValueChanged(object sender, PagePageEventArgs e)
        {
            violationCurrentPage = e.Current;
            if (e.PageSize != violationPageSize)
            {
                violationPageSize = e.PageSize;
            }
            RefreshTable();
        }

        private void RefreshTable()
        {
            // Paginate filtered list
            var pagedList = filteredList
                .Skip((violationCurrentPage - 1) * violationPageSize)
                .Take(violationPageSize)
                .ToList();

            var dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("MaSV", typeof(string));
            dt.Columns.Add("LoaiViPham", typeof(string));
            dt.Columns.Add("MoTa", typeof(string));
            dt.Columns.Add("MucDo", typeof(CellTag));
            dt.Columns.Add("TrangThai", typeof(CellTag));
            dt.Columns.Add("ThoiGian", typeof(string));
            dt.Columns.Add("ChiTiet", typeof(string));
            dt.Columns.Add("XuLy", typeof(string));

            int rowNumber = (violationCurrentPage - 1) * violationPageSize + 1;
            foreach (var v in pagedList)
            {
                TTypeMini mucDoType = v.MucDo switch
                {
                    "Cao" => TTypeMini.Error,
                    "Trung bình" => TTypeMini.Warn,
                    "Thấp" => TTypeMini.Success,
                    _ => TTypeMini.Default
                };
                CellTag mucDoTag = new CellTag(v.MucDo, mucDoType);

                TTypeMini trangThaiType = v.TrangThai switch
                {
                    "Đã xử lý" => TTypeMini.Success,
                    "Chưa xử lý" => TTypeMini.Warn,
                    _ => TTypeMini.Default
                };
                CellTag trangThaiTag = new CellTag(v.TrangThai, trangThaiType);

                dt.Rows.Add(
                    rowNumber++,
                    v.Id,
                    v.MaSV,
                    v.LoaiViPham,
                    v.MoTa,
                    mucDoTag,
                    trangThaiTag,
                    v.ThoiGian.ToString("HH:mm dd/MM/yyyy"),
                    "Chi tiết",
                    v.TrangThai == "Chưa xử lý" ? "Xử lý" : ""
                );
            }

            tbl_violation.DataSource = dt;
            pgnViolations.Total = filteredList.Count;
        }

        private void table_violation_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Record == null) return;

            string col = e.Column?.Title ?? "";
            string maSV = "";

            if (e.Record is DataRow dataRow)
            {
                maSV = dataRow["MaSV"]?.ToString() ?? "";
            }

            if (col == "Nội dung chi tiết")
            {
                if (string.IsNullOrEmpty(maSV)) return;

                AntdUI.Message.info(FindForm(), $"Mở chi tiết cho {maSV}");
                Form detailForm = new Form();
                detailForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                detailForm.MaximizeBox = false;
                detailForm.MinimizeBox = false;
                detailForm.ControlBox = false;
                detailForm.ShowIcon = false;
                detailForm.ShowInTaskbar = false;
                detailForm.StartPosition = FormStartPosition.CenterParent;
                detailForm.Size = new Size(1500, 1300);
                ViolationDetail detail = new ViolationDetail(maSV);
                detailForm.Controls.Add(detail);
                detailForm.ShowDialog();
            }
            else if (col == "Xử lý")
            {
                if (string.IsNullOrEmpty(maSV)) return;

                var violation = filteredList.FirstOrDefault(v => v.MaSV == maSV);

                if (violation == null || violation.TrangThai != "Chưa xử lý")
                {
                    return;
                }

                AntdUI.Message.success(FindForm(), $"Mở xử lý cho {maSV}");
                Form handleForm = new Form();
                handleForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                handleForm.MaximizeBox = false;
                handleForm.MinimizeBox = false;
                handleForm.ControlBox = false;
                handleForm.ShowIcon = false;
                handleForm.ShowInTaskbar = false;
                handleForm.StartPosition = FormStartPosition.CenterParent;
                handleForm.Size = new Size(1400, 850);
                ViolationHandle handle = new ViolationHandle(maSV);
                handleForm.Controls.Add(handle);

                if (handleForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateViolationStatus(maSV);
                }
            }
        }
        public void UpdateViolationStatus(string maSV)
        {
            var violation = dataList.FirstOrDefault(v => v.MaSV == maSV);
            if (violation != null)
            {
                violation.TrangThai = "Đã xử lý";
            }

            FilterData();
            AntdUI.Message.success(FindForm(), $"Đã cập nhật trạng thái cho {maSV}");
        }
        private void ApplyFilterHandlers()
        {
            slt_allStatus.SelectedIndexChanged += (s, e) => FilterData();
            slt_allLevel.SelectedIndexChanged += (s, e) => FilterData();
        }

        private void FilterData()
        {
            string status = slt_allStatus.Text?.Trim();
            string level = slt_allLevel.Text?.Trim();

            filteredList = dataList.Where(v =>
                (string.IsNullOrEmpty(status) || status == "Tất cả trạng thái" || v.TrangThai == status) &&
                (string.IsNullOrEmpty(level) || level == "Tất cả mức độ" || v.MucDo == level)
            ).ToList();

            RefreshTable();
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            lbl_violationNumber.Text = filteredList.Count.ToString();
            lbl_conditionNumber.Text = filteredList.Count(v => v.TrangThai == "Chưa xử lý").ToString();
            lbl_levelNumber.Text = filteredList.Count(v => v.MucDo == "Cao").ToString();
        }

        private void ViolationView_Resize(object sender, EventArgs e)
        {
            AdjustPanelLayout();
        }

        private void AdjustPanelLayout()
        {
            int spacing = 20;
            int width = (pnl_notification.ClientSize.Width - spacing * 4) / 3;
            int height = pnl_notification.ClientSize.Height - spacing * 2;

            pnl_condition.SetBounds(spacing, spacing, width, height);
            pnl_level.SetBounds(pnl_condition.Right + spacing, spacing, width, height);
            pnl_totalviolations.SetBounds(pnl_level.Right + spacing, spacing, width, height);
        }
    }
}