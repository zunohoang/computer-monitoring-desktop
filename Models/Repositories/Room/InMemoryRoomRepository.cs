using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Rooms;

namespace computer_monitoring_desktop.Models.Repositories.Room
{
    public class InMemoryRoomRepository : IRoomRepository
    {
        public IReadOnlyList<ExamRoom> GetRooms() => DataClass.ExamRooms;
        public ExamRoom? GetRoom(int roomId) => DataClass.ExamRooms.FirstOrDefault(r => r.Id == roomId);
        public int GetAttemptCount(int roomId) => DataClass.AuditAttempts.Count(a => a.RoomId == roomId);
        public IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId) => DataClass.AuditAttempts.Where(a => a.RoomId == roomId).ToList();
    }   
}