using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Controllers
{
    public class MeetingTimeController
    {
        public static MeetingTimeController _instance;

        private MeetingTimeController() { }

        public static MeetingTimeController Instance()
        {
            if (_instance == null)
            {
                _instance = new MeetingTimeController();
            }
            return _instance;
        }

        public List<MeetingTime> GetAllMeetingTime()
        {
            List<MeetingTime> meetingTimes = new List<MeetingTime>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    meetingTimes = dbContext.MeetingTimes.ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return meetingTimes;
        }

    }
}
