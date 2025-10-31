using System;
using System.Collections.Generic;
using System.Linq;
using computer_monitoring_desktop.Data;

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

    internal class AuditAttempt
    {
        public int Id { get; set; }
        public string StudentCode { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string MachineName { get; set; } = string.Empty;
        public int RoomId { get; set; }
        public string RoomCode { get; set; } = string.Empty;
        public string ContestName { get; set; } = string.Empty;
    }

    internal sealed class AuditDataset
    {
        public AuditDataset(AuditAttempt attempt, IReadOnlyList<AuditProcess> processes, IReadOnlyList<AuditLogEntry> logs)
        {
            Attempt = attempt;
            Processes = processes;
            Logs = logs;
        }

        public AuditAttempt Attempt { get; }
        public IReadOnlyList<AuditProcess> Processes { get; }
        public IReadOnlyList<AuditLogEntry> Logs { get; }
    }

    internal static class AuditMockModel
    {
        private static IReadOnlyList<AuditAttempt> AttemptsInternal => DataClass.AuditAttempts;
        private static IReadOnlyDictionary<int, IReadOnlyList<AuditProcess>> ProcessesInternal => DataClass.AuditProcessesByAttempt;
        private static IReadOnlyDictionary<int, IReadOnlyList<AuditLogEntry>> LogsInternal => DataClass.AuditLogsByAttempt;
        private static IReadOnlyList<ProcessBlacklistEntry> BlacklistInternal => DataClass.ProcessBlacklist;

        public static IReadOnlyList<AuditAttempt> Attempts => AttemptsInternal;

        public static IReadOnlyList<ProcessBlacklistEntry> Blacklist => BlacklistInternal;

        public static AuditDataset GetDataset(int attemptId)
        {
            var attempt = AttemptsInternal.FirstOrDefault(a => a.Id == attemptId);
            if (attempt == null)
            {
                attempt = AttemptsInternal.First();
                attemptId = attempt.Id;
            }

            ProcessesInternal.TryGetValue(attemptId, out var processes);
            LogsInternal.TryGetValue(attemptId, out var logs);

            processes ??= Array.Empty<AuditProcess>();
            logs ??= Array.Empty<AuditLogEntry>();

            return new AuditDataset(attempt, processes, logs);
        }

        public static IReadOnlyList<AuditProcess> GetProcesses(int attemptId) => GetDataset(attemptId).Processes;

        public static IReadOnlyList<AuditLogEntry> GetLogs(int attemptId) => GetDataset(attemptId).Logs;

        public static IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId)
        {
            return AttemptsInternal.Where(a => a.RoomId == roomId).ToList();
        }

        public static (DateTime Start, DateTime End) GetTimelineRange(int attemptId)
        {
            var dataset = GetDataset(attemptId);
            var timeline = new List<DateTime>();
            timeline.AddRange(dataset.Processes.Select(p => p.StartTime));
            timeline.AddRange(dataset.Processes.Where(p => p.EndTime.HasValue).Select(p => p.EndTime!.Value));
            timeline.AddRange(dataset.Logs.Select(l => l.CreatedAt));

            if (timeline.Count == 0)
            {
                var now = DateTime.Now;
                return (now.AddMinutes(-1), now);
            }

            var start = timeline.Min();
            var end = timeline.Max();
            if (end <= start)
            {
                end = start.AddMinutes(1);
            }

            return (start, end);
        }

    }
}
