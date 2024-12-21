using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Dto
{
    public class CourseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Credit { get; set; }

        public int MaxStudent { get; set; }

        public int NumberClass { get; set; }

        public List<InstructorDto> Instructors { get; set; }

        public static CourseDto FromEntity(Course entity)
        {
            try
            {
                if (entity == null) return null;

                return new CourseDto
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Credit = entity.Credit,
                    MaxStudent = entity.MaxStudent,
                    NumberClass = entity.NumberClass,
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
