using System.Collections.Generic;

namespace computer_monitoring_desktop.Models.Audit
{
    public sealed class AuditDataset
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
}