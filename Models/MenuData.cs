using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_monitoring_desktop.Models
{
    internal class MenuData
    {
        public static readonly List<MenuItemModel> MenuList = new List<MenuItemModel>
        {
            new MenuItemModel {Text = "Dashboard",IconSvg = "DashboardOutlined", Tag = "Dashboard"},
            new MenuItemModel {Text = "Quản lí cuộc thi",IconSvg = "TrophyOutlined", Tag = "Contests"},
            new MenuItemModel {Text = "Quản lí phòng thi",IconSvg = "BankOutlined", Tag = "Rooms"},
            new MenuItemModel {Text = "Quản lí vi phạm",IconSvg = "WarningOutlined", Tag = "Violations"},
            new MenuItemModel {Text = "Quản lí tin nhắn",IconSvg = "MessageOutlined", Tag = "Messages"},

        };

    }
}
