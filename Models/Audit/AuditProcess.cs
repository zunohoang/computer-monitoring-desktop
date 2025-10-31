using System;

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
}