using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Controllers;
using UniversitySchedule.Dto;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Algorithm
{
    public class Data
    {
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<InstructorDto> Instructors { get; set; } = new List<InstructorDto>();
        public List<CourseDto> Courses { get; set; } = new List<CourseDto>();
        public List<MeetingTime> MeetingTimes { get; set; } = new List<MeetingTime>();
        public List<DepartmentDto> Departments { get; set; } = new List<DepartmentDto>();

        public int NumberClass = 0;

        public Data()
        {
            Initialize();
        }

        private Data Initialize()
        {
            try
            {
                Rooms = RoomController.Instance().GetAllRoom();
                MeetingTimes = MeetingTimeController.Instance().GetAllMeetingTime();
                Instructors = InstructorController.Instance().GetAllInstructorForAlgorithm();
                Courses = CourseController.Instance().GetAllCourseForAlgorithm();
                Departments = DepartmentController.Instance().GetAllDepartmentForAlgorithm();

                Departments.ForEach(d => d.Courses.ForEach(c => NumberClass += c.NumberClass));
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return this;
        }
    }
}
