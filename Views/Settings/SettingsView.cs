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
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            LoadView();
        }
        private void LoadView()
        {
            var blacklistView = new BlackListView();
            blacklistView.Dock = DockStyle.Fill;
            tbp_blacklist.Controls.Add(blacklistView);

            var warningView = new WarningView();
            warningView.Dock = DockStyle.Fill;
            tbp_warning.Controls.Add(warningView);

            var userView = new UserView();
            userView.Dock = DockStyle.Fill;
            tbp_user.Controls.Add(userView);
        }
    }
}
