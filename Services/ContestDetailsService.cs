using System.Collections.Generic;
using computer_monitoring_desktop.Models;
using AntdUI;
namespace computer_monitoring_desktop.Services
{
    public class ContestDetailsService
    {
        public ContestDetails GetContestDetailsById(string id)
        {
            // Mock data for demonstration
            return new ContestDetails
            {
                Id = "1",
                Name = "Kỳ thi Olympic Tin học 2024",
                Status = "Đã kết thúc",
                Description = "Kỳ thi Olympic Tin học sinh viên toàn quốc lần thứ 32",
                StartTime = "08:00:00 20/10/2024",
                EndTime = "12:00:00 20/10/2024",
                Creator = "Nguyễn Văn Admin",
                CreatedAt = "10:00:00 1/10/2024",
                TotalRooms = 2,
                TotalCapacity = 55,
                CurrentParticipants = 1,
                MaxParticipants = 6,
                Violations = 3,
                Participants = new List<Participant>
                {
                    new Participant { Id = "1", StudentId = "20210001", Name = "Nguyễn Văn A" },
                    new Participant { Id = "2", StudentId = "20210002", Name = "Trần Thị B" },
                    new Participant { Id = "3", StudentId = "20210003", Name = "Lê Văn C" },
                    new Participant { Id = "4", StudentId = "20210004", Name = "Hoàng Văn E" },
                    new Participant { Id = "5", StudentId = "20210005", Name = "Vũ Thị F" },
                    new Participant { Id = "6", StudentId = "20210006", Name = "Đặng Văn G" }
                },
                Rooms = new List<Room>
                {
                    new Room { Id = "1", RoomCode = "ROOM001", Capacity = 30, CurrentParticipants = 2, ApprovalMode = "Tự động", RegisterTime = "15/10/2024 - 19/10/2024", ExamTime = "20/10/2024 08:00 - 20/10/2024 12:00" },
                    new Room { Id = "2", RoomCode = "ROOM002", Capacity = 25, CurrentParticipants = 4, ApprovalMode = "Thủ công", RegisterTime = "15/10/2024 - 19/10/2024", ExamTime = "20/10/2024 08:00 - 20/10/2024 12:00" },
                    new Room { Id = "3", RoomCode = "ROOM003", Capacity = 25, CurrentParticipants = 4, ApprovalMode = "Thủ công", RegisterTime = "15/10/2024 - 19/10/2024", ExamTime = "20/10/2024 08:00 - 20/10/2024 12:00" },
                    new Room { Id = "4", RoomCode = "ROOM004", Capacity = 25, CurrentParticipants = 4, ApprovalMode = "Thủ công", RegisterTime = "15/10/2024 - 19/10/2024", ExamTime = "20/10/2024 08:00 - 20/10/2024 12:00" }
                }
            };
        }
    }
}
