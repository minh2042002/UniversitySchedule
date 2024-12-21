using Microsoft.EntityFrameworkCore;
using Sunny.UI;
using UniversitySchedule.Dto;
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

        public List<InstructorDto> GetAllInstructorForAlgorithm()
        {
            List<InstructorDto> instructorDtos = new List<InstructorDto>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    List<Instructor> instructors = dbContext.Instructors
                                                    .Include(i => i.User)
                                                    .ThenInclude(u => u.Information)
                                                    .AsNoTracking()
                                                    .ToList();
                    instructorDtos = instructors.Select(InstructorDto.FromEntity).ToList();
                    return instructorDtos;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return instructorDtos;
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
                                                    .AsNoTracking()
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
                                                    .AsNoTracking()
                                                    .ToList();
                    return instructors;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return instructors;
        }

        public int UpdateCourse(Instructor instructor, List<Course> courses)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var updateInstructor = dbContext.Instructors
                                                        .Include(i => i.Courses)
                                                        .FirstOrDefault(i => i.Id == instructor.Id);

                        if (updateInstructor == null)
                        {
                            return 0;
                        }

                        var courseIds = courses.Select(c => c.Id).ToList();
                        var dbCourses = dbContext.Courses.Where(c => courseIds.Contains(c.Id)).ToList();

                        updateInstructor.Courses.Clear();

                        foreach (var course in dbCourses)
                        {
                            updateInstructor.Courses.Add(course);
                        }

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
