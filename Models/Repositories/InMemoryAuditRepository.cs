using System;
using System.Collections.Generic;
using System.Linq;
using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Models.Repositories
{
    internal class InMemoryAuditRepository : IAuditRepository
    {
        public IReadOnlyList<AuditAttempt> GetAttempts() => DataClass.AuditAttempts;
        public IReadOnlyList<ProcessBlacklistEntry> GetBlacklist() => DataClass.ProcessBlacklist;

        public AuditDataset GetDataset(int attemptId)
        {
            var attempt = DataClass.AuditAttempts.FirstOrDefault(a => a.Id == attemptId) ?? DataClass.AuditAttempts.First();
            DataClass.AuditProcessesByAttempt.TryGetValue(attempt.Id, out var processes);
            DataClass.AuditLogsByAttempt.TryGetValue(attempt.Id, out var logs);
            processes ??= Array.Empty<AuditProcess>();
            logs ??= Array.Empty<AuditLogEntry>();
            return new AuditDataset(attempt, processes, logs);
        }

        public IReadOnlyList<AuditProcess> GetProcesses(int attemptId) => GetDataset(attemptId).Processes;
        public IReadOnlyList<AuditLogEntry> GetLogs(int attemptId) => GetDataset(attemptId).Logs;
        public IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId) => DataClass.AuditAttempts.Where(a => a.RoomId == roomId).ToList();
        public (DateTime Start, DateTime End) GetTimelineRange(int attemptId)
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