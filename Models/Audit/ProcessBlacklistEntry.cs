namespace computer_monitoring_desktop.Models.Audit
{
    internal class ProcessBlacklistEntry
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}