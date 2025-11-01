using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.Settings
{
    public partial class WarningView : UserControl
    {
        private List<WarningItem> dataList = new();
        private List<WarningItem> filteredList = new();
        public WarningView()
        {
            InitializeComponent();
            SetupTable();
            LoadData();
        }
        private void LoadData()
        {
            dataList = new List<WarningItem>
            {
                new WarningItem { Id = 1, Code="Warning", WarningName = "Truy cập website không được phép", Description = "Phát hiện truy cập vào website ",Level="Thấp"},
                new WarningItem { Id = 2, Code="Critical",WarningName = "Chạy ứng dụng bị cấm", Description = "Truy cập mạng xã hội",Level="Cao"},
                new WarningItem { Id = 3, Code="Warning",WarningName = "Copy/Paste nghi vấn", Description = "Chơi game trong giờ",Level="Trung bình"},
            };

            filteredList = new List<WarningItem>(dataList);
            RefreshTable();
        }

        private void SetupTable()
        {
            tbl_warning.FixedHeader = true;
            tbl_warning.Bordered = true;
            tbl_warning.AutoSizeColumnsMode = ColumnsMode.Auto;
            tbl_warning.VisibleHeader = true;
            tbl_warning.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tbl_warning.RowSelectedFore = Color.Black;
            tbl_warning.Font = new Font("Segoe UI Emoji", 9);

            tbl_warning.Columns.Add(new Column("Id", "ID"));
            tbl_warning.Columns.Add(new Column("Code", "Mã"));
            tbl_warning.Columns.Add(new Column("WarningName", "Tên cảnh báo"));
            tbl_warning.Columns.Add(new Column("Description", "Mô tả"));
            tbl_warning.Columns.Add(new Column("Level", "Mức độ"));
            tbl_warning.Columns.Add(new Column("Edit", "Sửa") { Align = ColumnAlign.Center });
            tbl_warning.Columns.Add(new Column("Action", "Thao tác") { Align = ColumnAlign.Center });
        }

        private void RefreshTable()
        {
            tbl_warning.DataSource = filteredList.Select(item => new
            {
                item.Id,
                Code = new CellTag(item.Code, item.Code.ToLower() switch
                {
                    "critical" => TTypeMini.Error,
                    "warning" => TTypeMini.Warn,
                    _ => TTypeMini.Default
                }),
                item.WarningName,
                item.Description,
                Level = new CellTag(item.Level, item.Level switch
                {
                    "Cao" => TTypeMini.Error,
                    "Trung bình" => TTypeMini.Warn,
                    "Thấp" => TTypeMini.Primary,
                    _ => TTypeMini.Default
                }),
                Edit = "✏ Sửa",
                Action = "❌ Xóa"
            }).ToList();
        }
        private void tbl_warning_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Record == null) return;

            string col = e.Column?.Title ?? "";
            int id = 0;

            dynamic record = e.Record;
            try
            {
                id = record.Id;
            }
            catch
            {
                return;
            }

            if (col == "Thao tác")
            {
                var item = dataList.Find(x => x.Id == id);
                if (item == null) return;

                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa '{item.WarningName}'?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm != DialogResult.Yes) return;

                dataList.Remove(item);
                filteredList = new List<WarningItem>(dataList);
                RefreshTable();
                AntdUI.Message.success(FindForm()!, "Đã xóa thành công!", null, 1500);
            }
            else if (col == "Sửa")
            {
                var item = dataList.Find(x => x.Id == id);
                if (item == null) return;

                using (var frm = new AddWarning()) 
                {
                    frm.WarningName = item.WarningName;
                    frm.Description = item.Description;
                    frm.Level = item.Level;
                    frm.ButtonText = "Sửa";

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        item.WarningName = frm.WarningName;
                        item.Description = frm.Description;
                        item.Level = frm.Level;

                        filteredList = new List<WarningItem>(dataList);
                        RefreshTable();
                        AntdUI.Message.success(FindForm()!, "Đã cập nhật thành công!", null, 1500);
                    }
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            using var frm = new AddWarning();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int newId = dataList.Count > 0 ? dataList.Max(x => x.Id) + 1 : 1;
                var newItem = new WarningItem
                {
                    Id = newId,
                    WarningName = frm.WarningName,
                    Description = frm.Description,
                    Code = frm.Code,
                    Level = frm.Level,
                };
                dataList.Add(newItem);
                filteredList = new List<WarningItem>(dataList);
                RefreshTable();
                AntdUI.Message.success(FindForm()!, "Đã thêm cảnh báo!", null, 1500);
            }
        }
    }
    public class WarningItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string WarningName { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }    
    }
}
