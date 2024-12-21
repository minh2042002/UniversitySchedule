using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Dto
{
    public class InstructorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is InstructorDto instructor &&
                                        instructor.Name == Name;
        }


        public static InstructorDto FromEntity(Instructor entity)
        {
            try
            {
                if (entity == null) return null;

                return new InstructorDto
                {
                    Id = entity.Id,
                    Name = entity.User.Information.Name,
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
