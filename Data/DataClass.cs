using System;
using System.Collections.Generic;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Menu;
using computer_monitoring_desktop.Models.Rooms;

namespace computer_monitoring_desktop.Data
{
    internal static class DataClass
    {
        internal static readonly IReadOnlyList<MenuItemModel> MenuItems = new List<MenuItemModel>
        {
            new MenuItemModel {Text = "Dashboard", IconSvg = "DashboardOutlined", Tag = "Dashboard"},
            new MenuItemModel {Text = "Quản lý cuộc thi", IconSvg = "TrophyOutlined", Tag = "Contests"},
            new MenuItemModel {Text = "Quản lý phòng thi", IconSvg = "BankOutlined", Tag = "Rooms"},
            new MenuItemModel {Text = "Quản lý vi phạm", IconSvg = "WarningOutlined", Tag = "Violations"},
            new MenuItemModel {Text = "Quản lý tin nhắn", IconSvg = "MessageOutlined", Tag = "Messages"},
        };

        internal static readonly IReadOnlyList<AuditAttempt> AuditAttempts = new List<AuditAttempt>
        {
            new AuditAttempt { Id = 1, StudentCode = "20210001", StudentName = "Nguyen Van A", MachineName = "PC-01", RoomId = 101, RoomCode = "ROOM001", ContestName = "Ky thi Olympic Tin hoc 2024" },
            new AuditAttempt { Id = 2, StudentCode = "20210002", StudentName = "Tran Thi B", MachineName = "PC-02", RoomId = 101, RoomCode = "ROOM001", ContestName = "Ky thi Olympic Tin hoc 2024" },
            new AuditAttempt { Id = 3, StudentCode = "20210003", StudentName = "Le Minh C", MachineName = "PC-03", RoomId = 102, RoomCode = "ROOM002", ContestName = "Ky thi Lap trinh co ban K68" },
            new AuditAttempt { Id = 4, StudentCode = "20210004", StudentName = "Pham Gia D", MachineName = "PC-04", RoomId = 103, RoomCode = "ROOM003", ContestName = "Hackathon 2024" },
        };

        internal static readonly IReadOnlyDictionary<int, IReadOnlyList<AuditProcess>> AuditProcessesByAttempt =
            new Dictionary<int, IReadOnlyList<AuditProcess>>
            {
                [1] = new List<AuditProcess>
                {
                    new AuditProcess { Id = 1, Pid = 4020, Name = "exam_portal.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:05:10"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 2, Pid = 4056, Name = "monitor_agent.exe", ParentId = 1, StartTime = ParseDate("2024-10-20T08:05:12"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 3, Pid = 4210, Name = "chrome.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:07:30"), EndTime = ParseDate("2024-10-20T08:09:20"), Status = "stopped" },
                    new AuditProcess { Id = 4, Pid = 4216, Name = "chrome_helper.exe", ParentId = 3, StartTime = ParseDate("2024-10-20T08:07:32"), EndTime = ParseDate("2024-10-20T08:09:18"), Status = "stopped" },
                    new AuditProcess { Id = 5, Pid = 4301, Name = "code.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:06:00"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 6, Pid = 4308, Name = "code_helper.exe", ParentId = 5, StartTime = ParseDate("2024-10-20T08:06:02"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 7, Pid = 4500, Name = "powershell.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:06:40"), EndTime = ParseDate("2024-10-20T08:07:05"), Status = "stopped" },
                    new AuditProcess { Id = 8, Pid = 4620, Name = "teams.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:10:00"), EndTime = ParseDate("2024-10-20T08:11:45"), Status = "stopped" },
                    new AuditProcess { Id = 9, Pid = 4715, Name = "discord.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:15:12"), EndTime = ParseDate("2024-10-20T08:16:50"), Status = "stopped" },
                    new AuditProcess { Id = 10, Pid = 4804, Name = "msedge.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:18:30"), EndTime = ParseDate("2024-10-20T08:18:55"), Status = "stopped" },
                    new AuditProcess { Id = 11, Pid = 4950, Name = "slack.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:20:05"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 12, Pid = 5002, Name = "cmd.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:21:10"), EndTime = ParseDate("2024-10-20T08:23:00"), Status = "stopped" },
                    new AuditProcess { Id = 13, Pid = 5024, Name = "notepad.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:23:05"), EndTime = ParseDate("2024-10-20T08:24:00"), Status = "stopped" },
                    new AuditProcess { Id = 14, Pid = 5088, Name = "python.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:24:10"), EndTime = ParseDate("2024-10-20T08:31:00"), Status = "stopped" },
                    new AuditProcess { Id = 15, Pid = 5120, Name = "git.exe", ParentId = 12, StartTime = ParseDate("2024-10-20T08:25:45"), EndTime = ParseDate("2024-10-20T08:26:00"), Status = "stopped" },
                    new AuditProcess { Id = 16, Pid = 5201, Name = "obsidian.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:30:00"), EndTime = ParseDate("2024-10-20T09:15:00"), Status = "stopped" },
                    new AuditProcess { Id = 17, Pid = 5310, Name = "zoom.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:35:20"), EndTime = ParseDate("2024-10-20T08:40:05"), Status = "stopped" },
                    new AuditProcess { Id = 18, Pid = 5404, Name = "telegram.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:42:10"), EndTime = ParseDate("2024-10-20T08:42:45"), Status = "stopped" },
                    new AuditProcess { Id = 19, Pid = 5480, Name = "spotify.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:43:30"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 20, Pid = 5522, Name = "taskmgr.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:50:00"), EndTime = ParseDate("2024-10-20T08:55:00"), Status = "running" },
                },
                [2] = new List<AuditProcess>
                {
                    new AuditProcess { Id = 101, Pid = 6100, Name = "exam_portal.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:05:30"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 102, Pid = 6130, Name = "monitor_agent.exe", ParentId = 101, StartTime = ParseDate("2024-10-20T08:05:32"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 103, Pid = 6240, Name = "firefox.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:12:10"), EndTime = ParseDate("2024-10-20T08:13:45"), Status = "stopped" },
                    new AuditProcess { Id = 104, Pid = 6248, Name = "firefox_helper.exe", ParentId = 103, StartTime = ParseDate("2024-10-20T08:12:12"), EndTime = ParseDate("2024-10-20T08:13:40"), Status = "stopped" },
                    new AuditProcess { Id = 105, Pid = 6330, Name = "word.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:16:00"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 106, Pid = 6400, Name = "zoom.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:30:00"), EndTime = ParseDate("2024-10-20T08:31:10"), Status = "stopped" },
                    new AuditProcess { Id = 107, Pid = 6450, Name = "teams.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:40:00"), EndTime = ParseDate("2024-10-20T08:42:10"), Status = "stopped" },
                    new AuditProcess { Id = 108, Pid = 6470, Name = "spotify.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:50:15"), EndTime = ParseDate("2024-10-20T08:51:00"), Status = "stopped" },
                    new AuditProcess { Id = 109, Pid = 6550, Name = "telegram.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T08:55:00"), EndTime = ParseDate("2024-10-20T08:55:50"), Status = "stopped" },
                    new AuditProcess { Id = 110, Pid = 6600, Name = "excel.exe", ParentId = 0, StartTime = ParseDate("2024-10-20T09:00:00"), EndTime = null, Status = "running" },
                },
                [3] = new List<AuditProcess>
                {
                    new AuditProcess { Id = 201, Pid = 7200, Name = "exam_portal.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T07:50:00"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 202, Pid = 7220, Name = "monitor_agent.exe", ParentId = 201, StartTime = ParseDate("2024-10-21T07:50:02"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 203, Pid = 7300, Name = "chrome.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T08:02:15"), EndTime = ParseDate("2024-10-21T08:05:40"), Status = "stopped" },
                    new AuditProcess { Id = 204, Pid = 7310, Name = "chrome_helper.exe", ParentId = 203, StartTime = ParseDate("2024-10-21T08:02:18"), EndTime = ParseDate("2024-10-21T08:05:35"), Status = "stopped" },
                    new AuditProcess { Id = 205, Pid = 7400, Name = "notepad.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T08:10:00"), EndTime = ParseDate("2024-10-21T08:14:00"), Status = "stopped" },
                    new AuditProcess { Id = 206, Pid = 7420, Name = "calc.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T08:20:00"), EndTime = ParseDate("2024-10-21T08:20:30"), Status = "stopped" },
                    new AuditProcess { Id = 207, Pid = 7500, Name = "discord.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T08:45:10"), EndTime = ParseDate("2024-10-21T08:45:45"), Status = "stopped" },
                    new AuditProcess { Id = 208, Pid = 7550, Name = "teams.exe", ParentId = 0, StartTime = ParseDate("2024-10-21T08:55:00"), EndTime = ParseDate("2024-10-21T08:56:20"), Status = "stopped" },
                },
                [4] = new List<AuditProcess>
                {
                    new AuditProcess { Id = 301, Pid = 8100, Name = "exam_portal.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T09:10:00"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 302, Pid = 8115, Name = "monitor_agent.exe", ParentId = 301, StartTime = ParseDate("2024-10-22T09:10:02"), EndTime = null, Status = "running" },
                    new AuditProcess { Id = 303, Pid = 8200, Name = "edge.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T09:22:00"), EndTime = ParseDate("2024-10-22T09:24:10"), Status = "stopped" },
                    new AuditProcess { Id = 304, Pid = 8300, Name = "powershell.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T09:35:40"), EndTime = ParseDate("2024-10-22T09:36:10"), Status = "stopped" },
                    new AuditProcess { Id = 305, Pid = 8350, Name = "teams.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T09:40:00"), EndTime = ParseDate("2024-10-22T09:41:15"), Status = "stopped" },
                    new AuditProcess { Id = 306, Pid = 8400, Name = "obsidian.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T09:50:00"), EndTime = ParseDate("2024-10-22T09:58:00"), Status = "stopped" },
                    new AuditProcess { Id = 307, Pid = 8450, Name = "telegram.exe", ParentId = 0, StartTime = ParseDate("2024-10-22T10:05:00"), EndTime = ParseDate("2024-10-22T10:05:35"), Status = "stopped" },
                },
            };

        internal static readonly IReadOnlyDictionary<int, IReadOnlyList<AuditLogEntry>> AuditLogsByAttempt =
            new Dictionary<int, IReadOnlyList<AuditLogEntry>>
            {
                [1] = new List<AuditLogEntry>
                {
                    new AuditLogEntry { Id = 1, Type = "login", AttemptId = 1, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T08:05:00"), Details = "Sinh vien 20210001 dang nhap vao he thong giam sat." },
                    new AuditLogEntry { Id = 2, Type = "action", AttemptId = 1, ProcessId = 3, ImageId = 1, AlertId = 1, CreatedAt = ParseDate("2024-10-20T08:07:35"), Details = "Chrome.exe truy cap google.com." },
                    new AuditLogEntry { Id = 3, Type = "action", AttemptId = 1, ProcessId = 8, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T08:10:45"), Details = "Teams.exe bat cuoc tro chuyen." },
                    new AuditLogEntry { Id = 4, Type = "action", AttemptId = 1, ProcessId = 9, ImageId = 2, AlertId = 2, CreatedAt = ParseDate("2024-10-20T08:15:20"), Details = "Phat hien discord.exe trong phien thi." },
                    new AuditLogEntry { Id = 5, Type = "action", AttemptId = 1, ProcessId = 14, ImageId = 0, AlertId = 3, CreatedAt = ParseDate("2024-10-20T08:24:30"), Details = "Python.exe chay script automation.py." },
                    new AuditLogEntry { Id = 6, Type = "action", AttemptId = 1, ProcessId = 18, ImageId = 0, AlertId = 2, CreatedAt = ParseDate("2024-10-20T08:42:20"), Details = "Telegram.exe nam trong danh sach den." },
                    new AuditLogEntry { Id = 7, Type = "action", AttemptId = 1, ProcessId = 11, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T09:05:10"), Details = "Slack.exe nhan thong bao kenh noi bo." },
                    new AuditLogEntry { Id = 8, Type = "logout", AttemptId = 1, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T11:55:10"), Details = "Sinh vien 20210001 dang xuat khoi he thong." },
                },
                [2] = new List<AuditLogEntry>
                {
                    new AuditLogEntry { Id = 101, Type = "login", AttemptId = 2, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T08:05:20"), Details = "Sinh vien 20210002 dang nhap vao he thong giam sat." },
                    new AuditLogEntry { Id = 102, Type = "action", AttemptId = 2, ProcessId = 103, ImageId = 0, AlertId = 1, CreatedAt = ParseDate("2024-10-20T08:12:30"), Details = "Firefox.exe truy cap stackoverflow.com." },
                    new AuditLogEntry { Id = 103, Type = "action", AttemptId = 2, ProcessId = 107, ImageId = 2, AlertId = 2, CreatedAt = ParseDate("2024-10-20T08:41:10"), Details = "Teams.exe duoc mo cung luc voi ky thi." },
                    new AuditLogEntry { Id = 104, Type = "action", AttemptId = 2, ProcessId = 109, ImageId = 0, AlertId = 2, CreatedAt = ParseDate("2024-10-20T08:55:20"), Details = "Telegram.exe nam trong danh sach den." },
                    new AuditLogEntry { Id = 105, Type = "action", AttemptId = 2, ProcessId = 110, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T09:05:00"), Details = "Excel.exe duoc mo de xem file thong ke bai lam." },
                    new AuditLogEntry { Id = 106, Type = "logout", AttemptId = 2, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-20T11:30:00"), Details = "Sinh vien 20210002 dang xuat khoi he thong." },
                },
                [3] = new List<AuditLogEntry>
                {
                    new AuditLogEntry { Id = 201, Type = "login", AttemptId = 3, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-21T07:49:40"), Details = "Sinh vien 20210003 dang nhap vao he thong giam sat." },
                    new AuditLogEntry { Id = 202, Type = "action", AttemptId = 3, ProcessId = 203, ImageId = 0, AlertId = 1, CreatedAt = ParseDate("2024-10-21T08:03:00"), Details = "Chrome.exe mo tab tim kiem de thi cu." },
                    new AuditLogEntry { Id = 203, Type = "action", AttemptId = 3, ProcessId = 207, ImageId = 1, AlertId = 2, CreatedAt = ParseDate("2024-10-21T08:45:30"), Details = "Discord.exe mo tro chuyen bi chan." },
                    new AuditLogEntry { Id = 204, Type = "action", AttemptId = 3, ProcessId = 205, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-21T08:12:15"), Details = "Notepad.exe duoc dung de ghi chu bai thi." },
                    new AuditLogEntry { Id = 205, Type = "logout", AttemptId = 3, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-21T11:40:00"), Details = "Sinh vien 20210003 ket thuc bai thi va dang xuat." },
                },
                [4] = new List<AuditLogEntry>
                {
                    new AuditLogEntry { Id = 301, Type = "login", AttemptId = 4, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-22T09:09:40"), Details = "Sinh vien 20210004 dang nhap vao he thong hackathon." },
                    new AuditLogEntry { Id = 302, Type = "action", AttemptId = 4, ProcessId = 303, ImageId = 0, AlertId = 1, CreatedAt = ParseDate("2024-10-22T09:22:20"), Details = "Edge.exe mo trang tim kiem tai lieu tham khao." },
                    new AuditLogEntry { Id = 303, Type = "action", AttemptId = 4, ProcessId = 305, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-22T09:40:30"), Details = "Teams.exe duoc su dung de lien lac voi teammate." },
                    new AuditLogEntry { Id = 304, Type = "action", AttemptId = 4, ProcessId = 307, ImageId = 0, AlertId = 2, CreatedAt = ParseDate("2024-10-22T10:05:15"), Details = "Telegram.exe nam trong danh sach den can canh bao." },
                    new AuditLogEntry { Id = 305, Type = "logout", AttemptId = 4, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = ParseDate("2024-10-22T12:10:00"), Details = "Sinh vien 20210004 hoan thanh hackathon va dang xuat." },
                },
            };

        internal static readonly IReadOnlyList<ProcessBlacklistEntry> ProcessBlacklist = new List<ProcessBlacklistEntry>
        {
            new ProcessBlacklistEntry { Id = 1, Name = "discord.exe", Description = "Ung dung chat khong phu hop trong luc thi." },
            new ProcessBlacklistEntry { Id = 2, Name = "telegram.exe", Description = "Ung dung nhan tin co nguy co gian lan." },
            new ProcessBlacklistEntry { Id = 3, Name = "skype.exe", Description = "Ung dung goi dien khong duoc phep." },
            new ProcessBlacklistEntry { Id = 4, Name = "teamviewer.exe", Description = "Ung dung dieu khien tu xa." },
        };

        internal static readonly IReadOnlyList<ExamRoom> ExamRooms = new List<ExamRoom>
        {
            new ExamRoom { Id = 101, AccessCode = "ROOM001", Name = "Phong 101 - Day A", Capacity = 30, ContestName = "Ky thi Olympic Tin hoc 2024", AutoApprove = true },
            new ExamRoom { Id = 102, AccessCode = "ROOM002", Name = "Phong 202 - Day B", Capacity = 25, ContestName = "Ky thi Lap trinh co ban K68", AutoApprove = false },
            new ExamRoom { Id = 103, AccessCode = "ROOM003", Name = "Phong Lab - Tang 3", Capacity = 20, ContestName = "Hackathon 2024", AutoApprove = true },
        };

        internal static DateTime ParseDate(string value)
        {
            if (DateTime.TryParse(value, out var parsed))
            {
                return DateTime.SpecifyKind(parsed, DateTimeKind.Local);
            }

            return DateTime.Now;
        }
    }
}

