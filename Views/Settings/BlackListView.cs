using AntdUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.Settings
{
    public partial class BlackListView : UserControl
    {
        private List<BlackListItem> dataList = new();
        private List<BlackListItem> filteredList = new();

        public BlackListView()
        {
            InitializeComponent();
            SetupTable();
            LoadData();
        }

        private void LoadData()
        {
            dataList = new List<BlackListItem>
            {
                new BlackListItem { Id = 1, ProcessName = "Discord.exe", Description = "Ứng dụng trò chuyện"},
                new BlackListItem { Id = 2, ProcessName = "Facebook.exe", Description = "Truy cập mạng xã hội"},
                new BlackListItem { Id = 3, ProcessName = "Valorant.exe", Description = "Chơi game trong giờ" },
            };

            filteredList = new List<BlackListItem>(dataList);
            RefreshTable();
        }

        private void SetupTable()
        {
            tbl_blacklist.FixedHeader = true;
            tbl_blacklist.Bordered = true;
            tbl_blacklist.AutoSizeColumnsMode = ColumnsMode.Auto;
            tbl_blacklist.VisibleHeader = true;
            tbl_blacklist.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tbl_blacklist.RowSelectedFore = Color.Black;
            tbl_blacklist.Font = new Font("Segoe UI Emoji", 9);

            tbl_blacklist.Columns.Add(new Column("Id", "ID"));
            tbl_blacklist.Columns.Add(new Column("ProcessName", "Tên tiến trình"));
            tbl_blacklist.Columns.Add(new Column("Description", "Mô tả"));
            tbl_blacklist.Columns.Add(new Column("Edit", "Sửa") { Align = ColumnAlign.Center });
            tbl_blacklist.Columns.Add(new Column("Action", "Thao tác") { Align = ColumnAlign.Center });
        }

        private void RefreshTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("ProcessName", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Edit",typeof(string));
            dt.Columns.Add("Action", typeof(string));

            foreach (var item in filteredList)
            {
                dt.Rows.Add(
                    item.Id,
                    item.ProcessName,
                    item.Description,
                    "✏ Sửa",
                    "❌ Xóa"
                );
            }

            tbl_blacklist.DataSource = dt;
        }

        private void tbl_blacklist_CellClick(object sender, AntdUI.TableClickEventArgs e)
        {
            if (e.Record == null) return;

            string col = e.Column?.Title ?? "";
            string processName = "";
            int id = 0;

            if (e.Record is DataRow row)
            {
                processName = row["ProcessName"]?.ToString() ?? "";
                id = Convert.ToInt32(row["Id"]);
            }

            if (col == "Thao tác")
            {
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa '{processName}' khỏi danh sách đen?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirm != DialogResult.Yes) return;
                else
                {
                    var item = dataList.Find(x => x.Id == id);
                    if (item != null)
                    {
                        dataList.Remove(item);
                        filteredList = new List<BlackListItem>(dataList);
                        RefreshTable();
                        AntdUI.Message.success(FindForm()!, "Đã xóa thành công!", null, 1500);
                    }
                }
            }
            else if (col == "Sửa")
            {
                var item = dataList.Find(x => x.Id == id);
                if (item != null)
                {
                    using (var frm = new AddProcess()) 
                    {
                        frm.ProcessName = item.ProcessName;
                        frm.Description = item.Description;
                        frm.ButtonText = "Sửa";

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            item.ProcessName = frm.ProcessName;
                            item.Description = frm.Description;
                            filteredList = new List<BlackListItem>(dataList);
                            RefreshTable();
                            AntdUI.Message.success(FindForm()!, "Đã cập nhật thành công!", null, 1500);
                        }
                    }
                }
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            using (var frm = new AddProcess())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    int newId = dataList.Count > 0 ? dataList[^1].Id + 1 : 1;
                    var newItem = new BlackListItem
                    {
                        Id = newId,
                        ProcessName = frm.ProcessName,
                        Description = frm.Description,
                        AddedTime = DateTime.Now
                    };
                    dataList.Add(newItem);
                    filteredList = new List<BlackListItem>(dataList);
                    RefreshTable();
                }

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                filteredList = new List<BlackListItem>(dataList);
            }
            else
            {
                filteredList = dataList.FindAll(x =>
                    x.ProcessName.ToLower().Contains(keyword));
            }

            RefreshTable();
        }
    }


    public class BlackListItem
    {
        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string Description { get; set; }
        public DateTime AddedTime { get; set; }
    }
}
