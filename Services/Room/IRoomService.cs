using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Rooms;

namespace computer_monitoring_desktop.Services.RoomServices
{
    public interface IRoomService
    {
        IReadOnlyList<ExamRoom> GetRooms();
        IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId);
        int GetAttemptCount(int roomId);
    }
}