using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Models.Repositories.Audit
{
    internal interface IAuditRepository
    {
        IReadOnlyList<AuditAttempt> GetAttempts();
        IReadOnlyList<ProcessBlacklistEntry> GetBlacklist();
        AuditDataset GetDataset(int attemptId);
        IReadOnlyList<AuditProcess> GetProcesses(int attemptId);
        IReadOnlyList<AuditLogEntry> GetLogs(int attemptId);
        IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId);
        (DateTime Start, DateTime End) GetTimelineRange(int attemptId);
    }
}