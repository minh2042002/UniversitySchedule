using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;

namespace UniversitySchedule.Dto
{
    public class ClassDto
    {
        public virtual CourseDto Course { get; set; }

        public virtual DepartmentDto Department { get; set; }

        public virtual InstructorDto Instructor { get; set; }

        public virtual MeetingTime MeetingTime { get; set; }

        public virtual Room Room { get; set; }

        public virtual ScheduleDto Schedule { get; set; }
    }
}
