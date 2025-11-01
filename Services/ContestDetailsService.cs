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
             return null;
        }
    }
}
