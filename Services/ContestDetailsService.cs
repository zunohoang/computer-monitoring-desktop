using System.Collections.Generic;
using System.Linq;
using AntdUI;
using computer_monitoring_desktop.Data;
using computer_monitoring_desktop.Models.Contest;

namespace computer_monitoring_desktop.Services
{
    public class ContestDetailsService
    {
        public ContestDetails GetContestDetailsById(string id)
        {
            // Get contest from mock data
            var contest = DataClass.Contests.FirstOrDefault(c => c.Id == id);
            
            if (contest == null)
            {
                // Return first contest as fallback
                contest = DataClass.Contests.FirstOrDefault();
            }
            
            if (contest == null) return null;

            return new ContestDetails
            {
                Id = contest.Id,
                Name = contest.Name,
                Status = contest.Status,
                Description = contest.Description,
                StartTime = contest.StartTime.ToString("HH:mm:ss dd/MM/yyyy"),
                EndTime = contest.EndTime.ToString("HH:mm:ss dd/MM/yyyy"),
                Creator = contest.Creator,
                CreatedAt = contest.CreatedAt.ToString("HH:mm:ss dd/MM/yyyy"),
                TotalRooms = contest.TotalRooms,
                TotalCapacity = contest.TotalCapacity,
                CurrentParticipants = contest.CurrentParticipants,
                MaxParticipants = contest.TotalCapacity,
                Violations = contest.Violations,
                Participants = contest.Participants,
                Rooms = contest.Rooms
            };
        }
    }
}
