using System.Collections.Generic;
using computer_monitoring_desktop.Models.Rooms;
using computer_monitoring_desktop.Models.Audit;

namespace computer_monitoring_desktop.Models.Repositories
{
    internal interface IRoomRepository
    {
        IReadOnlyList<ExamRoom> GetRooms();
        ExamRoom? GetRoom(int roomId);
        int GetAttemptCount(int roomId);
        IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId);
    }
}