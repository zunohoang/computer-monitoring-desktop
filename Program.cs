using computer_monitoring_desktop.Views;
using System;
using System.Drawing.Text;
using System.Windows.Forms;

namespace computer_monitoring_desktop
{
    internal static class Program
    {
        private static MainWindow? mainWindow;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            AntdUI.Config.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            AntdUI.Config.TextRenderingHighQuality = true;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}