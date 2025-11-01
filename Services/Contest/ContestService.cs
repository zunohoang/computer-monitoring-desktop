using System;
using System.Collections.Generic;
using computer_monitoring_desktop.Models.Contest;

namespace computer_monitoring_desktop.Services.Contest
{
    public class ContestService
    {
        // Mock data
        private List<ContestDetails> _mockContests = new List<ContestDetails>
        {
            new ContestDetails { Id = "1", Name = "Olympic Tin học 2024", Description = "Kỳ thi Olympic Tin học sinh viên toàn quốc lần thứ 32", StartTime = new DateTime(2024, 10, 20, 8, 0, 0).ToString(), EndTime = new DateTime(2024, 10, 20, 12, 0, 0).ToString(), Status = "Đã kết thúc" },
            new ContestDetails { Id = "2", Name = "Contest 2", Description = "Mô tả cuộc thi 2", StartTime = new DateTime(2024, 11, 1, 9, 0, 0).ToString(), EndTime = new DateTime(2024, 11, 1, 11, 0, 0).ToString(), Status = "Đang diễn ra" },
            new ContestDetails { Id = "3", Name = "Contest 3", Description = "Mô tả cuộc thi 3", StartTime = new DateTime(2024, 12, 5, 14, 0, 0).ToString(), EndTime = new DateTime(2024, 12, 5, 17, 0, 0).ToString(), Status = "Sắp diễn ra" }
        };

        public List<ContestDetails> GetAllContests()
        {
            return _mockContests;
        }

        public ContestDetails GetContestById(string id)
        {
            return _mockContests.Find(c => c.Id == id);
        }

    }
}
