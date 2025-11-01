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
    public partial class AddProcess : Form
    {
        public string ProcessName
        {
            get => txt_processname.Text;
            set => txt_processname.Text = value;
        } 
        public string Description
        {
            get => txt_description.Text;
            set => txt_description.Text = value;
        }
        public string ButtonText
        {
            get => btn_create.Text;
            set => btn_create.Text = value;
        }
        public AddProcess()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProcessName))
            {
                AntdUI.Message.warn(this, "Tên tiến trình không được để trống!", null, 1500);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.FindForm()?.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.FindForm()?.Close();
        }
    }
}
