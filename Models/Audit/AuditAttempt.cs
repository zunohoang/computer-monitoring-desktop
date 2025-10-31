namespace computer_monitoring_desktop.Models.Audit
{
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
}