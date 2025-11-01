using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Repositories;
using computer_monitoring_desktop.Models.Repositories.Audit;

namespace computer_monitoring_desktop.Services.AuditServices
{
    internal class AuditService : IAuditService
    {
        // Repo này được inject bởi <InMemoryAuditRepos>
        private readonly IAuditRepository auditRepo;

        public AuditService() : this(new InMemoryAuditRepository()) { }

        public AuditService(IAuditRepository repo)
        {
            auditRepo = repo;
        }

        public AuditDataset GetAuditDetails(int attemptId)
        {
            return auditRepo.GetDataset(attemptId);
        }

        // TODO: Các phần này sử dụng repo khác, không nằm trong repo audit
        public IReadOnlyList<AuditAttempt> GetAttempts()
        {
            return auditRepo.GetAttempts();
        }

        public IReadOnlyList<AuditProcess> GetProcesses(int attemptId)
        {
            return auditRepo.GetDataset(attemptId).Processes;
        }

        public IReadOnlyList<AuditProcess> GetOrderedProcesses(int attemptId)
        {
            var dataset = auditRepo.GetDataset(attemptId);

            // Target-Typed (Biểu thức new - Cú pháp viết tắt Syntactic Sugar, không phải biểu thức mới đâu)
            // Nó handle được null case, sẽ tốt hơn là viết try catch 
            return [.. dataset.Processes
                .Where(p => p != null)
                .OrderByDescending(p => string.Equals(p.Status, "running", StringComparison.OrdinalIgnoreCase))
                .ThenBy(p => p.EndTime ?? DateTime.MaxValue)
                .ThenBy(p => p.StartTime)];
        }

        public IReadOnlyList<AuditLogEntry> GetLogs(int attemptId)
        {
            return auditRepo.GetDataset(attemptId).Logs;
        }

        public IReadOnlyList<ProcessBlacklistEntry> GetBlacklist()
        {
            return auditRepo.GetBlacklist();
        }

        public HashSet<string> GetBlacklistNames()
        {
            return auditRepo.GetBlacklist()
                .Select(b => b.Name.Trim().ToLowerInvariant())
                .ToHashSet();
        }

        public (DateTime Start, DateTime End) GetTimelineRange(int attemptId)
        {
            try
            {
                return auditRepo.GetTimelineRange(attemptId);
            }
            catch
            {
                // fallback: tự tính theo log/process
                var ds = auditRepo.GetDataset(attemptId);
                var start = ds.Processes.Min(p => p.StartTime);
                var end = ds.Processes.Max(p => p.EndTime ?? DateTime.Now);
                return (start, end);
            }
        }

        public void RefreshAttempt(int attemptId)
        {
            // TODO: Do something
            // Refresh button chẳng hạn
        }
    }
}
