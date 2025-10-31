using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Views.Violation
{
    public partial class ViolationHandle : UserControl
    {
        private string maSV;
        public ViolationHandle(string maSV)
        {
            InitializeComponent();
            this.maSV = maSV;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ParentForm.DialogResult = DialogResult.Cancel;
            ParentForm?.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            ParentForm.DialogResult = DialogResult.OK;
            ParentForm?.Close();
        }
    }
}
