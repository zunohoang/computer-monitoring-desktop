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
        public string Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TotalRooms { get; set; }
        public int TotalCapacity { get; set; }
        public int CurrentParticipants { get; set; }
        public int Violations { get; set; }
        public List<Participant> Participants { get; set; }
        public List<ExamRoom> Rooms { get; set; }
    }
}
