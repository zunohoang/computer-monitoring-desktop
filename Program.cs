using computer_monitoring_desktop.Views;
using System.Drawing.Text;
namespace computer_monitoring_desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AntdUI.Config.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            AntdUI.Config.TextRenderingHighQuality = true;

            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}