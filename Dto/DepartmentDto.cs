using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Dto
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseDto> Courses { get; set; }
        public List<InstructorDto> Instructors { get; set; }

        public static DepartmentDto FromEntity(Department entity)
        {
            try
            {
                if (entity == null) return null;

                return new DepartmentDto
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Courses = entity.Courses.Select(CourseDto.FromEntity).ToList() ?? new List<CourseDto>(),
                    Instructors = entity.Instructors?.Select(InstructorDto.FromEntity).ToList() ?? new List<InstructorDto>(),
                };
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return null;
            }
        }
    }
}
