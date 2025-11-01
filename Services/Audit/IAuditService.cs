using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Services.AuditServices
{
    internal interface IAuditService
    {
        AuditDataset GetAuditDetails(int attemptId);
        IReadOnlyList<AuditAttempt> GetAttempts();
        IReadOnlyList<AuditProcess> GetProcesses(int attemptId);
        IReadOnlyList<AuditProcess> GetOrderedProcesses(int attemptId);
        IReadOnlyList<AuditLogEntry> GetLogs(int attemptId);
        IReadOnlyList<ProcessBlacklistEntry> GetBlacklist();
        HashSet<string> GetBlacklistNames();
        (DateTime Start, DateTime End) GetTimelineRange(int attemptId);
        void RefreshAttempt(int attemptId);
    }
}
