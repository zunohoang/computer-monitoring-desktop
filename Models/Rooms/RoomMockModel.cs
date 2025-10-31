using System.Collections.Generic;
using System.Linq;
using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Models.Rooms
{
    internal class ExamRoom
    {
        public int Id { get; set; }
        public string AccessCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string ContestName { get; set; } = string.Empty;
        public bool AutoApprove { get; set; }
    }

    internal static class RoomMockModel
    {
        public static IReadOnlyList<ExamRoom> Rooms => DataClass.ExamRooms;

        public static ExamRoom? GetRoom(int roomId) => DataClass.ExamRooms.FirstOrDefault(r => r.Id == roomId);

        public static int GetAttemptCount(int roomId) => AuditMockModel.GetAttemptsByRoom(roomId).Count;
    }
}
