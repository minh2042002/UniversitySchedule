using UniversitySchedule.Algorithm;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Dto
{
    public class ScheduleDto
    {
        public List<ClassDto> Classes { get; set; }

        public bool IsFitnessChange = true;

        public int NumberConflict { get; set; } = 0;

        private double _fitness = -1;
        public double Fitness
        {
            get
            {
                if (IsFitnessChange)
                {
                    _fitness = CalculateFitness();
                    IsFitnessChange = false;
                }
                return _fitness;
            }
            set
            {
                _fitness = value;
            }
        }

        public ScheduleDto() { }

        public ScheduleDto(Data data)
        {
            initialize(data);
        }

        private ScheduleDto initialize(Data data)
        {
            try
            {
                Classes = new List<ClassDto>(data.NumberClass);
                foreach (DepartmentDto department in data.Departments)
                {
                    foreach (CourseDto course in department.Courses)
                    {
                        for (int i = 0; i < course.NumberClass; i++)
                        {
                            ClassDto newClass = new ClassDto();
                            newClass.Department= department;
                            newClass.Course = course;
                            newClass.Room = data.Rooms[new Random().Next(data.Rooms.Count)];
                            List<MeetingTime> meetingTimes = data.MeetingTimes.FindAll(time => time.Credit == course.Credit).ToList();
                            newClass.MeetingTime = meetingTimes[new Random().Next(meetingTimes.Count)];
                            newClass.Instructor = course.Instructors[new Random().Next(course.Instructors.Count)];

                            Classes.Add(newClass);
                        }
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return this;
        }

        private double CalculateFitness()
        {
            NumberConflict = 0;
            foreach (ClassDto currentClass in Classes)
            {
                if (currentClass.Room.Capacity < currentClass.Course.MaxStudent) { NumberConflict++; }
                foreach (ClassDto otherClass in Classes.Where(otherClass => Classes.IndexOf(otherClass) > Classes.IndexOf(currentClass)))
                {
                    if (currentClass.MeetingTime.IsTimeConflict(otherClass.MeetingTime))
                    {
                        if (currentClass.Room.Equals(otherClass.Room))
                        {
                            NumberConflict++;
                        }

                        if (currentClass.Instructor.Equals(otherClass.Instructor))
                        {
                            NumberConflict++;
                        }
                    }
                }
            }
            return 1 / (double) (NumberConflict + 1);
        }
    }
}
