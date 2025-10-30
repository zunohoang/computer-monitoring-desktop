using System;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Utils
{
    internal class ViewManager
    {
        public static void LoadView(Control container, UserControl view, DockStyle dockStyle = DockStyle.Fill)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            if (view == null)
            {
                throw new ArgumentNullException(nameof(view));
            }

            ClearContainer(container);

            view.Dock = dockStyle;
            container.Controls.Add(view);
        }

        public static void ClearContainer(Control container)
        {
            if (container == null)
            {
                throw new ArgumentNullException(nameof(container));
            }

            while (container.Controls.Count > 0)
            {
                var control = container.Controls[0];
                container.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}