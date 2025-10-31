using System;

namespace computer_monitoring_desktop.Models
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
        public List<Room> Rooms { get; set; }
    }

    public class Participant
    {
        public string Id { get; set; }
        public string StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Room
    {
        public string Id { get; set; }
        public string RoomCode { get; set; }
        public int Capacity { get; set; }
        public int CurrentParticipants { get; set; }
        public string ApprovalMode { get; set; }
        public string RegisterTime { get; set; }
        public string ExamTime { get; set; }
    }
}
