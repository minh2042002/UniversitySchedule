using Microsoft.EntityFrameworkCore;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Dto;
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

        public List<CourseDto> GetAllCourseForAlgorithm()
        {
            List<CourseDto> courseDtos = new List<CourseDto>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    List<Course> courses = dbContext.Courses
                                                    .Include(c => c.Instructors)
                                                    .ThenInclude(i => i.User)
                                                    .ThenInclude(u => u.Information)
                                                    .AsNoTracking()
                                                    .ToList();
                    courseDtos = courses.Select(CourseDto.FromEntity).ToList();
                    return courseDtos;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return courseDtos;
        }

        public List<Course> GetAllCourse()
        {
            List<Course> courses = new List<Course>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    courses = dbContext.Courses
                                        .Include(c => c.Department)
                                        .Include(c => c.Instructors)
                                        .AsNoTracking()
                                        .ToList();
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
                    courses = dbContext.Courses
                                       .Include(c => c.Department)
                                       .Where(c => c.DepartmentId == department.Id)
                                       .AsNoTracking()
                                       .ToList();
                    return courses;
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return courses;
        }

        public List<Course> GetCoursesByInstructor(Instructor instructor)
        {
            List<Course> courses = new List<Course>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    courses = dbContext.Courses
                                       .Include(c => c.Department)
                                       .Where(c => c.Instructors.Any(i => i.Id == instructor.Id))
                                       .AsNoTracking()
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
                        Course updateCourse = dbContext.Courses.FirstOrDefault(c => c.Id == course.Id);
                        if (updateCourse == null)
                        {
                            return 0;
                        }

                        updateCourse.Name = course.Name;
                        updateCourse.Credit = course.Credit;
                        updateCourse.MaxStudent = course.MaxStudent;
                        updateCourse.NumberClass = course.NumberClass;
                        updateCourse.DepartmentId = course.DepartmentId;

                        dbContext.Courses.Update(updateCourse);
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

        public int DeleteCourse(Course course)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Course deleteCourse = dbContext.Courses.FirstOrDefault(c => c.Id == course.Id);
                        if (deleteCourse == null)
                        {
                            return 0;
                        }

                        dbContext.Courses.Remove(deleteCourse);
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
