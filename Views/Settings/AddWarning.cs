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
    public partial class AddWarning : Form
    {
        public string WarningName { get; set; } = "";
        public string Description { get; set; } = "";
        public string Code { get; set; } = "warning";
        public string Level { get; set; } = "Thấp";
        public string ButtonText { get; set; } = "Thêm";
        public AddWarning()
        {
            InitializeComponent();
        }

        private void AddWarning_Load(object sender, EventArgs e)
        {
            txt_warningname.Text = WarningName;
            txt_description.Text = Description;

            if (Code.ToLower() == "critical") rbtn_critical.Checked = true;
            else rbtn_warning.Checked = true;

            switch (Level)
            {
                case "Cao":
                    rbtn_high.Checked = true;
                    break;
                case "Trung bình":
                    rbtn_average.Checked = true;
                    break;
                default:
                    rbtn_low.Checked = true;
                    break;
            }

            btn_create.Text = ButtonText;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_warningname.Text))
            {
                MessageBox.Show("Vui lòng nhập tên cảnh báo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WarningName = txt_warningname.Text.Trim();
            Description = txt_description.Text.Trim();
            Code = rbtn_critical.Checked ? "critical" : "warning";

            if (rbtn_high.Checked) Level = "Cao";
            else if (rbtn_average.Checked) Level = "Trung bình";
            else Level = "Thấp";

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
