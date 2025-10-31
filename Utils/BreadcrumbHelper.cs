using AntdUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace computer_monitoring_desktop.Utils
{
    public static class BreadcrumbHelper
    {
        // Set breadcrumb items
        public static void SetBreadcrumb(Breadcrumb breadcrumb, params (string Text, object Tag)[] items)
        {
            breadcrumb.Items.Clear();
            foreach (var item in items)
            {
                breadcrumb.Items.Add(new BreadcrumbItem { Text = item.Text, Tag = item.Tag });
            }
        }

        // Attach navigation handler
        public static void AttachNavigation(Breadcrumb breadcrumb, Action<object> onNavigate)
        {
            breadcrumb.ItemClick -= (s, e) => { };
            breadcrumb.ItemClick += (s, e) =>
            {
                onNavigate?.Invoke(e.Item.Tag ?? e.Item.Text);
            };
        }
    }
}
