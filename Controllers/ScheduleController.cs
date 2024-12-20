using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Controllers
{
    public class ScheduleController
    {
        private static ScheduleController _instance;

        private ScheduleController() { }

        public static ScheduleController Instance()
        {
            if (_instance == null)
            {
                _instance = new ScheduleController();
            }
            return _instance;
        }

        public List<Schedule> GetAllSchedule()
        {
            List<Schedule> schedules = new List<Schedule>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    schedules = dbContext.Schedules.ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, "Error occurred while saving active schedule."); }
            return schedules;
        }

        public Schedule GetScheduleActiveDetail()
        {
            Schedule? schedule = null;
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    Schedule scheduleActive = dbContext.Schedules.FirstOrDefault(s => s.IsActive);
                    if (scheduleActive != null)
                    {
                        schedule = GetScheduleDetailByName(scheduleActive.Name);
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, "Error occurred while saving active schedule."); }
            return schedule;
        }

        public Schedule GetScheduleDetailByName(string name)
        {
            Schedule? schedule = null;
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    schedule = dbContext.Schedules
                                                .Include(s => s.Classes).ThenInclude(c => c.Course)
                                                .Include(s => s.Classes).ThenInclude(c => c.Instructor)
                                                .Include(s => s.Classes).ThenInclude(c => c.Room)
                                                .Include(s => s.Classes).ThenInclude(c => c.MeetingTime)
                                                .Include(s => s.Classes).ThenInclude(c => c.Department)
                                                .FirstOrDefault(s => s.Name == name);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, "Error occurred while saving active schedule."); }
            return schedule;
        }

        public bool SaveScheduleActive(Schedule schedule)
        {
            try
            {
                if (!schedule.IsActive)
                {
                    return false;
                }

                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // Chỉ cần kiểm tra xem có schedule nào đã active hay không
                        if (dbContext.Schedules.Any(s => s.IsActive))
                        {
                            dbContext.Schedules.RemoveRange(dbContext.Schedules.Where(s => s.IsActive));
                        }

                        dbContext.Schedules.Add(schedule);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "Error during schedule activation and saving.");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "Error occurred while saving active schedule.");
            }

            return false;
        }

        public bool InsertSchedule(Schedule schedule)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Schedules.Add(schedule);
                        dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "Error occurred while saving active schedule.");

                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "Error occurred while saving active schedule.");
            }
            return false;
        }
       
        public bool DeleteSchedule(Schedule schedule)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        // Truy vấn đối tượng trực tiếp từ database
                        var existingSchedule = dbContext.Schedules.FirstOrDefault(s => s.Id == schedule.Id);
                        if (existingSchedule != null)
                        {
                            dbContext.Remove(existingSchedule);
                            dbContext.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "Error occurred while deleting schedule inside transaction.");
                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "Error occurred while deleting schedule.");
            }
            return false;
        }
    }
}
