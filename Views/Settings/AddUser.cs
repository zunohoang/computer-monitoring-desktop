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
    public partial class AddUser : Form
    {
        public string UserLogin { get; set; } = "";
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "Giám thị"; 
        public bool IsActive { get; set; } = true;   
        public string ButtonText { get; set; } = "Thêm";
        public AddUser()
        {
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            txt_userlogin.Text = UserLogin;
            txt_fullname.Text = FullName;
            txt_email.Text = Email;

            if (Role == "Quản trị viên")
                rbtn_admin.Checked = true;
            else
                rbtn_supervisor.Checked = true;

            if (IsActive)
                rbtn_action.Checked = true;
            else
                rbtn_nonaction.Checked = true;

            btn_create.Text = ButtonText;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_userlogin.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_userlogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_fullname.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fullname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_email.Text) || !txt_email.Text.Contains("@"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return;
            }
            UserLogin = txt_userlogin.Text.Trim();
            FullName = txt_fullname.Text.Trim();
            Email = txt_email.Text.Trim();

            Role = rbtn_admin.Checked ? "Quản trị viên" : "Giám thị";
            IsActive = rbtn_action.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
