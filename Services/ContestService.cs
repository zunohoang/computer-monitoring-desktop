using System;
using System.Collections.Generic;
using computer_monitoring_desktop.Models;

namespace computer_monitoring_desktop.Services
{


    public class ContestService
    {
        // Mock data
        private List<Contest> _mockContests = new List<Contest>
        {
            new Contest { Id = "1", Name = "Olympic Tin học 2024", Description = "Kỳ thi Olympic Tin học sinh viên toàn quốc lần thứ 32", StartTime = new DateTime(2024, 10, 20, 8, 0, 0), EndTime = new DateTime(2024, 10, 20, 12, 0, 0), Status = "Đã kết thúc" },
            new Contest { Id = "2", Name = "Contest 2", Description = "Mô tả cuộc thi 2", StartTime = new DateTime(2024, 11, 1, 9, 0, 0), EndTime = new DateTime(2024, 11, 1, 11, 0, 0), Status = "Đang diễn ra" },
            new Contest { Id = "3", Name = "Contest 3", Description = "Mô tả cuộc thi 3", StartTime = new DateTime(2024, 12, 5, 14, 0, 0), EndTime = new DateTime(2024, 12, 5, 17, 0, 0), Status = "Sắp diễn ra" }
        };

        public List<Contest> GetAllContests()
        {
            // In real implementation, call API here
            return _mockContests;
        }

        public Contest GetContestById(string id)
        {
            // In real implementation, call API here
            return _mockContests.Find(c => c.Id == id);
        }

    }
}
