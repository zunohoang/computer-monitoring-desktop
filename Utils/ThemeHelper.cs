using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntdUI;
namespace computer_monitoring_desktop.Utils
{
    internal class ThemeHelper
    {
        public static bool isLightMode()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            if (key != null)
            {
                int useLightTheme = (int)key.GetValue("AppsUseLightTheme", -1);

                if (useLightTheme == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static void setColorMode(Window window, bool isLightMode)
        {
            if (isLightMode)
            {
                Config.IsLight = true;
                window.BackColor = Color.White;
                window.ForeColor = Color.Black;
            }
            else
            {
                Config.IsDark = true;
                window.BackColor = Color.FromArgb(31, 31, 31);
                window.ForeColor = Color.White;
            }
        }
    }
}
