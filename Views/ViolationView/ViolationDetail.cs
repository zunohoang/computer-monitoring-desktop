using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views
{
    public partial class ViolationDetail : UserControl
    {
        private string maSV;
        public ViolationDetail(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void ViolationDetail_Load(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("MaSV");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("LoaiViPham");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("MucDo");
            dt.Columns.Add("TrangThai");
            dt.Columns.Add("ThoiGianXuatHien");
            dt.Columns.Add("ThoiGianBatDau");
            dt.Columns.Add("ThoiGianKetThuc");

            dt.Rows.Add("VP123", "231230823", "Nguyễn Văn A", "Mở tab ngoài",
                        "Phát hiện mở trình duyệt không hợp lệ",
                        "Cao", "Chưa xử lý",
                        DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                        "09:15:22", "09:18:10");
            var row = dt.Rows[0];
            lbl_mainID.Text = row["id"].ToString();
            lbl_mainStudentcode.Text = row["MaSV"].ToString();
            lbl_mainName.Text = row["HoTen"].ToString();
            lbl_mainViolationtype.Text = row["LoaiViPham"].ToString();
            lbl_mainDescription.Text = row["MoTa"].ToString();
            tg_level.Text = row["MucDo"].ToString();
            tg_status.Text = row["TrangThai"].ToString();
            lbl_mainTime.Text = row["ThoiGianXuatHien"].ToString();
            lbl_mainStarttime.Text = row["ThoiGianBatDau"].ToString();
            lbl_mainEndtime.Text = row["ThoiGianKetThuc"].ToString();
            switch (tg_level.Text)
            {
                case "Cao": tg_level.BackColor = Color.FromArgb(254, 226, 226); break;
                case "Trung bình": tg_level.BackColor = Color.FromArgb(254, 243, 199); break;
                case "Thấp": tg_level.BackColor = Color.FromArgb(220, 252, 231); break;
            }
            switch (tg_status.Text)
            {
                case "Đã xử lý": tg_status.BackColor = Color.FromArgb(220, 252, 231); break;
                case "Chưa xử lý": tg_status.BackColor = Color.FromArgb(254, 243, 199); break;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            ParentForm?.Close();
        }
    }
}
