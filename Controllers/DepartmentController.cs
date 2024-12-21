using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Dto;
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
                    departments = dbContext.Departments.AsNoTracking().ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return departments;
        }

        public List<DepartmentDto> GetAllDepartmentForAlgorithm()
        {
            List<DepartmentDto> departmentDtos = new List<DepartmentDto>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    List<Department> departments = dbContext.Departments
                                                    .Include(d => d.Courses)
                                                    .ThenInclude(c => c.Instructors)
                                                    .ThenInclude(i => i.User)
                                                    .ThenInclude(u => u.Information)
                                                    .AsNoTracking()
                                                    .ToList();
                    departmentDtos = departments.Select(DepartmentDto.FromEntity).ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return departmentDtos;
        }

        public Department GetDepartmentByName(string name)
        {
            Department department = new Department();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    department = dbContext.Departments.AsNoTracking().FirstOrDefault(d => d.Name == name);
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
                        Department updateDepartment = dbContext.Departments.FirstOrDefault(d => d.Id == department.Id);
                        if (updateDepartment == null)
                        {
                            return 0;
                        }

                        updateDepartment.Name = department.Name;
                        
                        dbContext.Departments.Update(updateDepartment);
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
                        Department deleteDepartment = dbContext.Departments.FirstOrDefault(d => d.Id == department.Id);
                        if (deleteDepartment == null)
                        {
                            return 0;
                        }

                        dbContext.Departments.Remove(deleteDepartment);
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
