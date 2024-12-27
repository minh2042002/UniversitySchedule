using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySchedule.Models
{
    public class UserLogin
    {
        public static string Name { get; set; }

        public static string Phone { get; set; }

        public static string Email { get; set; }

        public static DateOnly DayOfBirth { get; set; }

        public static int UserId { get; set; }

        public static Role Role { get; set; }
    }
}
