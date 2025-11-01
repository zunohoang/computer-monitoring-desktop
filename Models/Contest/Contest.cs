using computer_monitoring_desktop.Models.Rooms;
using System;
using System.Collections.Generic;

namespace computer_monitoring_desktop.Models.Contest
{
    public class Contest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
    }



}
