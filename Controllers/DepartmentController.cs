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
    public class DepartmentController
    {
        private static DepartmentController _instance;
        private DepartmentController() { }

        public static DepartmentController Instance()
        {
            if (_instance == null)
            {
                _instance = new DepartmentController();
            }
            return _instance;
        }

        public List<Department> GetAllDepartment()
        {
            List<Department> departments = new List<Department>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    departments = dbContext.Departments.ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return departments;
        }

        public List<Department> GetAllDepartmentForAlgorithm()
        {
            List<Department> departments = new List<Department>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    departments = dbContext.Departments
                                                    .Include(d => d.Courses)
                                                    .ThenInclude(c => c.Instructors)
                                                    .ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return departments;
        }

        public Department GetDepartmentByName(string name)
        {
            Department department = new Department();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    department = dbContext.Departments.FirstOrDefault(d => d.Name == name);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return department;
        }

        public int InsertDepartment(Department department)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Departments.Any(d => d.Name == department.Name))
                        {
                            return 0;
                        }
                        dbContext.Departments.Add(department);
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

        public int UpdateDepartment(Department department)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Departments.Any(d => d.Id == department.Id))
                        {
                            return 0;
                        }
                        dbContext.Departments.Update(department);
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

        public int DeleteDepartment(Department department)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Departments.Any(d => d.Id == department.Id))
                        {
                            return 0;
                        }
                        dbContext.Departments.Remove(department);
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
