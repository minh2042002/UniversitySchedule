using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Controllers
{
    public class CourseController
    {
        private static CourseController _instance;
        private CourseController() { }

        public static CourseController Instance()
        {
            if (_instance == null)
            {
                _instance = new CourseController();
            }
            return _instance;
        }

        public List<Course> GetAllCourse()
        {
            List<Course> courses = new List<Course>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    courses = dbContext.Courses.Include(c => c.Department).ToList();
                    return courses;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return courses;
        }

        public List<Course> GetCourseByDepartment(Department department)
        {
            List<Course> courses = new List<Course>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    // Lọc Course theo DepartmentId
                    courses = dbContext.Courses
                                       .Include(c => c.Department)
                                       .Where(c => c.DepartmentId == department.Id)
                                       .ToList();
                    return courses;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return courses;
        }

        public int InsertCourse(Course Course)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Courses.Any(d => d.Name == Course.Name))
                        {
                            return 0;
                        }
                        dbContext.Courses.Add(Course);
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

        public int UpdateCourse(Course course)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Courses.Any(c => c.Id == course.Id))
                        {
                            return 0;
                        }
                        dbContext.Courses.Update(course);
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

        public int DeleteCourse(Course Course)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Courses.Any(d => d.Id == Course.Id))
                        {
                            return 0;
                        }
                        dbContext.Courses.Remove(Course);
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
