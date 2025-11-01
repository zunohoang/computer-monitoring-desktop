using System;

namespace computer_monitoring_desktop.Models.Audit
{
    public class AuditLogEntry
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
}