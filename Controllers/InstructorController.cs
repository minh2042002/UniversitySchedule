using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Controllers
{
    public class InstructorController
    {
        private static InstructorController _instance;
        private InstructorController() { }

        public static InstructorController Instance()
        {
            if (_instance == null)
            {
                _instance = new InstructorController();
            }
            return _instance;
        }

        public List<Instructor> GetAllInstructorDetail()
        {
            List<Instructor> instructors = new List<Instructor>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    instructors = dbContext.Instructors
                                                    .Include(i => i.User)
                                                    .ThenInclude(u => u.Information)
                                                    .Include(i => i.Department)
                                                    .ToList();
                    return instructors;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return instructors;
        }

        public List<Instructor> GetInstructorByDepartment(Department department)
        {
            List<Instructor> instructors = new List<Instructor>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    instructors = dbContext.Instructors
                                                    .Include(i => i.User)
                                                    .ThenInclude(u => u.Information)
                                                    .Include(i => i.Department)
                                                    .Where(i => i.DepartmentId == department.Id)
                                                    .ToList();
                    return instructors;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return instructors;
        }

        public int UpdateDepartment(Instructor instructor, Department department)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Instructor updateInstructor = dbContext.Instructors.FirstOrDefault(i => i.Id == instructor.Id);
                        if (updateInstructor == null)
                        {
                            return 0;
                        }

                        updateInstructor.DepartmentId = department.Id;

                        dbContext.Instructors.Update(updateInstructor);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "");
                        transaction.Rollback();
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return -1;
            }
        }
    }
}
