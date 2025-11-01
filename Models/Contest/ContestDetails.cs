using computer_monitoring_desktop.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_monitoring_desktop.Models.Contest
{
    public class ContestDetails
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Creator { get; set; }
        public string CreatedAt { get; set; }
        public int TotalRooms { get; set; }
        public int TotalCapacity { get; set; }
        public int CurrentParticipants { get; set; }
        public int MaxParticipants { get; set; }
        public int Violations { get; set; }
        public List<Participant> Participants { get; set; }
        public List<ExamRoom> Rooms { get; set; }
    }
}
