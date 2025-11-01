namespace computer_monitoring_desktop.Models.Rooms
{
    public class ExamRoom
    {
        public int Id { get; set; }
        public string AccessCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string ContestName { get; set; } = string.Empty;
        public bool AutoApprove { get; set; }
    }
}