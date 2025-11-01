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
    public partial class UserView : UserControl
    {
        private List<UserItem> dataList = new();
        private List<UserItem> filteredList = new();
        public UserView()
        {
            InitializeComponent();
            SetupTable();
            LoadData();
        }
        private void LoadData()
        {
            dataList = new List<UserItem>
            {
                new UserItem { Id = 1, UserLogin = "admin", FullName = "Nguyễn Văn A", Email = "admin@school.com", Role = "Quản trị viên", Status = true },
                new UserItem { Id = 2, UserLogin = "supervisor1", FullName = "Trần Thị B", Email = "sup1@school.com", Role = "Giám thị", Status = true },
                new UserItem { Id = 3, UserLogin = "supervisor2", FullName = "Lê Văn C", Email = "sup2@school.com", Role = "Giám thị", Status = false },
            };
            filteredList = new List<UserItem>(dataList);
            RefreshTable();
        }

        private void SetupTable()
        {
            tbl_user.FixedHeader = true;
            tbl_user.Bordered = true;
            tbl_user.AutoSizeColumnsMode = ColumnsMode.Auto;
            tbl_user.VisibleHeader = true;
            tbl_user.RowSelectedBg = Color.FromArgb(230, 247, 255);
            tbl_user.RowSelectedFore = Color.Black;
            tbl_user.Font = new Font("Segoe UI Emoji", 9);

            tbl_user.Columns.Clear();
            tbl_user.Columns.Add(new Column("Id", "ID"));
            tbl_user.Columns.Add(new Column("UserLogin", "Tên đăng nhập"));
            tbl_user.Columns.Add(new Column("FullName", "Họ và tên"));
            tbl_user.Columns.Add(new Column("Email", "Email"));
            tbl_user.Columns.Add(new Column("Role", "Vai trò"));
            tbl_user.Columns.Add(new Column("Status", "Trạng thái") { Align = ColumnAlign.Center });
            tbl_user.Columns.Add(new Column("Edit", "Sửa") { Align = ColumnAlign.Center });
            tbl_user.Columns.Add(new Column("Action", "Thao tác") { Align = ColumnAlign.Center });
        }

        private void RefreshTable()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("UserLogin", typeof(string));
            dt.Columns.Add("FullName", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Role", typeof(object));
            dt.Columns.Add("Status", typeof(object));
            dt.Columns.Add("Edit", typeof(string));
            dt.Columns.Add("Action", typeof(string));

            foreach (var item in filteredList)
            {
                var roleTag = new CellTag(item.Role, item.Role switch
                {
                    "Quản trị viên" => TTypeMini.Error,
                    "Giám thị" => TTypeMini.Primary,
                    _ => TTypeMini.Default
                });
                var statusTag = new CellTag(
                    item.Status ? "Đang hoạt động" : "Dừng hoạt động",
                    item.Status ? TTypeMini.Success : TTypeMini.Default
                );
                dt.Rows.Add(
                    item.Id,
                    item.UserLogin,
                    item.FullName,
                    item.Email,
                    roleTag,
                    statusTag,
                    "✏ Sửa",
                    "❌ Xóa"
                );
            }
            tbl_user.DataSource = dt;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            using var frm = new AddUser();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                int newId = dataList.Count > 0 ? dataList.Max(x => x.Id) + 1 : 1;
                var newItem = new UserItem
                {
                    Id = newId,
                    UserLogin = frm.UserLogin,
                    FullName = frm.FullName,
                    Email = frm.Email,
                    Role = frm.Role,
                    Status = frm.IsActive
                };
                dataList.Add(newItem);
                filteredList = new List<UserItem>(dataList);
                RefreshTable();
                AntdUI.Message.success(FindForm()!, "Đã thêm cảnh báo!", null, 1500);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                filteredList = new List<UserItem>(dataList);
            }
            else
            {
                filteredList = dataList.FindAll(x =>
                    x.UserLogin.ToLower().Contains(keyword));
            }

            RefreshTable();
        }

        private void tbl_user_CellClick(object sender, TableClickEventArgs e)
        {
            if (e.Record == null) return;

            string col = e.Column?.Title ?? "";
            string username = "";
            int id = 0;

            if (e.Record is DataRow row)
            {
                username = row["UserLogin"]?.ToString() ?? "";
                id = Convert.ToInt32(row["Id"]);
            }

            if (col == "Thao tác")
            {
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xóa '{username}'?",
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
                        filteredList = new List<UserItem>(dataList);
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
                    using (var frm = new AddUser())
                    {
                        frm.UserLogin = item.UserLogin;
                        frm.FullName = item.FullName;
                        frm.Email = item.Email;
                        frm.Role = item.Role;
                        frm.IsActive = item.Status;
                        frm.ButtonText = "Sửa";

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            item.UserLogin = frm.UserLogin;
                            item.FullName = frm.FullName;
                            item.Email = frm.Email;
                            item.Role = frm.Role;
                            item.Status = frm.IsActive;
                            RefreshTable();
                            AntdUI.Message.success(FindForm()!, "Đã cập nhật thành công!", null, 1500);
                        }
                    }
                }
            }
        }
    }
    public class UserItem
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
    }
}
