using System;
using System.Collections.Generic;
using System.Linq;

namespace computer_monitoring_desktop.Models.Audit
{
    internal class AuditProcess
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ParentId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    internal class AuditLogEntry
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public int AttemptId { get; set; }
        public int ProcessId { get; set; }
        public int ImageId { get; set; }
        public int AlertId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Details { get; set; } = string.Empty;
    }

    internal class ProcessBlacklistEntry
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    internal static class AuditMockData
    {
        private static readonly IReadOnlyList<AuditProcess> ProcessesInternal = new List<AuditProcess>
        {
            new AuditProcess { Id = 1, Pid = 4020, Name = "exam_portal.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:05:10"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 2, Pid = 4056, Name = "monitor_agent.exe", ParentId = 1, StartTime = Parse("2024-10-20T08:05:12"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 3, Pid = 4210, Name = "chrome.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:07:30"), EndTime = Parse("2024-10-20T08:09:20"), Status = "stopped" },
            new AuditProcess { Id = 4, Pid = 4216, Name = "chrome_helper.exe", ParentId = 3, StartTime = Parse("2024-10-20T08:07:32"), EndTime = Parse("2024-10-20T08:09:18"), Status = "stopped" },
            new AuditProcess { Id = 5, Pid = 4301, Name = "code.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:06:00"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 6, Pid = 4308, Name = "code_helper.exe", ParentId = 5, StartTime = Parse("2024-10-20T08:06:02"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 7, Pid = 4500, Name = "powershell.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:06:40"), EndTime = Parse("2024-10-20T08:07:05"), Status = "stopped" },
            new AuditProcess { Id = 8, Pid = 4620, Name = "teams.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:10:00"), EndTime = Parse("2024-10-20T08:11:45"), Status = "stopped" },
            new AuditProcess { Id = 9, Pid = 4715, Name = "discord.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:15:12"), EndTime = Parse("2024-10-20T08:16:50"), Status = "stopped" },
            new AuditProcess { Id = 10, Pid = 4804, Name = "msedge.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:18:30"), EndTime = Parse("2024-10-20T08:18:55"), Status = "stopped" },
            new AuditProcess { Id = 11, Pid = 4950, Name = "slack.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:20:05"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 12, Pid = 5002, Name = "cmd.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:21:10"), EndTime = Parse("2024-10-20T08:23:00"), Status = "stopped" },
            new AuditProcess { Id = 13, Pid = 5024, Name = "notepad.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:23:05"), EndTime = Parse("2024-10-20T08:24:00"), Status = "stopped" },
            new AuditProcess { Id = 14, Pid = 5088, Name = "python.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:24:10"), EndTime = Parse("2024-10-20T08:31:00"), Status = "stopped" },
            new AuditProcess { Id = 15, Pid = 5120, Name = "git.exe", ParentId = 12, StartTime = Parse("2024-10-20T08:25:45"), EndTime = Parse("2024-10-20T08:26:00"), Status = "stopped" },
            new AuditProcess { Id = 16, Pid = 5201, Name = "obsidian.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:30:00"), EndTime = Parse("2024-10-20T09:15:00"), Status = "stopped" },
            new AuditProcess { Id = 17, Pid = 5310, Name = "zoom.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:35:20"), EndTime = Parse("2024-10-20T08:40:05"), Status = "stopped" },
            new AuditProcess { Id = 18, Pid = 5404, Name = "telegram.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:42:10"), EndTime = Parse("2024-10-20T08:42:45"), Status = "stopped" },
            new AuditProcess { Id = 19, Pid = 5480, Name = "spotify.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:43:30"), EndTime = null, Status = "running" },
            new AuditProcess { Id = 20, Pid = 5522, Name = "taskmgr.exe", ParentId = 0, StartTime = Parse("2024-10-20T08:50:00"), EndTime = Parse("2024-10-20T08:55:00"), Status = "running" },
        };

        private static readonly IReadOnlyList<AuditLogEntry> LogsInternal = new List<AuditLogEntry>
        {
            new AuditLogEntry { Id = 1, Type = "login", AttemptId = 1, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = Parse("2024-10-20T08:05:00"), Details = "Sinh vien 20210001 dang nhap vao he thong giam sat." },
            new AuditLogEntry { Id = 2, Type = "action", AttemptId = 1, ProcessId = 3, ImageId = 1, AlertId = 1, CreatedAt = Parse("2024-10-20T08:07:35"), Details = "Chrome.exe truy cap google.com." },
            new AuditLogEntry { Id = 3, Type = "action", AttemptId = 1, ProcessId = 8, ImageId = 0, AlertId = 0, CreatedAt = Parse("2024-10-20T08:10:45"), Details = "Teams.exe bat cuoc tro chuyen." },
            new AuditLogEntry { Id = 4, Type = "action", AttemptId = 1, ProcessId = 9, ImageId = 2, AlertId = 2, CreatedAt = Parse("2024-10-20T08:15:20"), Details = "Phat hien discord.exe trong phien thi." },
            new AuditLogEntry { Id = 5, Type = "action", AttemptId = 1, ProcessId = 14, ImageId = 0, AlertId = 3, CreatedAt = Parse("2024-10-20T08:24:30"), Details = "Python.exe chay script automation.py." },
            new AuditLogEntry { Id = 6, Type = "action", AttemptId = 1, ProcessId = 18, ImageId = 0, AlertId = 2, CreatedAt = Parse("2024-10-20T08:42:20"), Details = "Telegram.exe nam trong danh sach den." },
            new AuditLogEntry { Id = 7, Type = "action", AttemptId = 1, ProcessId = 11, ImageId = 0, AlertId = 0, CreatedAt = Parse("2024-10-20T09:05:10"), Details = "Slack.exe nhan thong bao kenh noi bo." },
            new AuditLogEntry { Id = 8, Type = "logout", AttemptId = 1, ProcessId = 0, ImageId = 0, AlertId = 0, CreatedAt = Parse("2024-10-20T11:55:10"), Details = "Sinh vien 20210001 dang xuat khoi he thong." },
        };

        private static readonly IReadOnlyList<ProcessBlacklistEntry> BlacklistInternal = new List<ProcessBlacklistEntry>
        {
            new ProcessBlacklistEntry { Id = 1, Name = "discord.exe", Description = "Ung dung chat khong phu hop trong luc thi." },
            new ProcessBlacklistEntry { Id = 2, Name = "telegram.exe", Description = "Ung dung nhan tin co nguy co gian lan." },
            new ProcessBlacklistEntry { Id = 3, Name = "skype.exe", Description = "Ung dung goi dien khong duoc phep." },
            new ProcessBlacklistEntry { Id = 4, Name = "teamviewer.exe", Description = "Ung dung dieu khien tu xa." },
        };

        public static IReadOnlyList<AuditProcess> Processes => ProcessesInternal;

        public static IReadOnlyList<AuditLogEntry> Logs => LogsInternal;

        public static IReadOnlyList<ProcessBlacklistEntry> Blacklist => BlacklistInternal;

        public static (DateTime Start, DateTime End) GetTimelineRange()
        {
            var timestamps = new List<DateTime>();
            timestamps.AddRange(ProcessesInternal.Select(p => p.StartTime));
            timestamps.AddRange(ProcessesInternal.Where(p => p.EndTime.HasValue).Select(p => p.EndTime!.Value));
            timestamps.AddRange(LogsInternal.Select(l => l.CreatedAt));

            if (timestamps.Count == 0)
            {
                var now = DateTime.Now;
                return (now.AddMinutes(-1), now);
            }

            var start = timestamps.Min();
            var end = timestamps.Max();
            if (end <= start)
            {
                end = start.AddMinutes(1);
            }

        return (start, end);
        }

        private static DateTime Parse(string value)
        {
            if (DateTime.TryParse(value, out var parsed))
            {
                return DateTime.SpecifyKind(parsed, DateTimeKind.Local);
            }

            return DateTime.Now;
        }
    }
}
