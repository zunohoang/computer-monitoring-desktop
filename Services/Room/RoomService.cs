using computer_monitoring_desktop.Models.Audit;
using computer_monitoring_desktop.Models.Rooms;
using computer_monitoring_desktop.Models.Repositories.Room;

namespace computer_monitoring_desktop.Services.RoomServices
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository roomRepo;

        public RoomService() : this(new InMemoryRoomRepository()) { }

        public RoomService(IRoomRepository repo)
        {
            roomRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        public IReadOnlyList<ExamRoom> GetRooms()
        {
            return roomRepo.GetRooms();
        }

        public IReadOnlyList<AuditAttempt> GetAttemptsByRoom(int roomId)
        {
            return roomRepo.GetAttemptsByRoom(roomId);
        }

        public int GetAttemptCount(int roomId)
        {
            return roomRepo.GetAttemptCount(roomId);
        }
    }
}
