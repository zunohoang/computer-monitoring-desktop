using System.Collections.Generic;

namespace computer_monitoring_desktop.Models
{
    internal class MenuData
    {
        public static readonly List<MenuItemModel> MenuList = new List<MenuItemModel>
        {
            new MenuItemModel {Text = "Dashboard", IconSvg = "DashboardOutlined", Tag = "Dashboard"},
            new MenuItemModel {Text = "Audit log", IconSvg = "ClockCircleOutlined", Tag = "AuditLog"},
            new MenuItemModel {Text = "Quản lý cuộc thi", IconSvg = "TrophyOutlined", Tag = "Contests"},
            new MenuItemModel {Text = "Quản lý phòng thi", IconSvg = "BankOutlined", Tag = "Rooms"},
            new MenuItemModel {Text = "Quản lý vi phạm", IconSvg = "WarningOutlined", Tag = "Violations"},
            new MenuItemModel {Text = "Quản lý tin nhắn", IconSvg = "MessageOutlined", Tag = "Messages"},
        };
    }
}
