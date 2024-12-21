using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Dto;
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
                    schedules = dbContext.Schedules.AsNoTracking().ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedules;
        }

        public Schedule GetScheduleActiveDetail()
        {
            Schedule? schedule = null;
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    Schedule scheduleActive = dbContext.Schedules.AsNoTracking().FirstOrDefault(s => s.IsActive);
                    if (scheduleActive != null)
                    {
                        schedule = GetScheduleDetailById(scheduleActive.Id);
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedule;
        }

        public Schedule GetScheduleDetailById(int scheduleId)
        {
            Schedule? schedule = null;
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    schedule = dbContext.Schedules
                                                .AsNoTracking()
                                                .Include(s => s.Classes).ThenInclude(c => c.Course)
                                                .Include(s => s.Classes).ThenInclude(c => c.Instructor)
                                                .Include(s => s.Classes).ThenInclude(c => c.Room)
                                                .Include(s => s.Classes).ThenInclude(c => c.MeetingTime)
                                                .Include(s => s.Classes).ThenInclude(c => c.Department)
                                                .FirstOrDefault(s => s.Id == scheduleId);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedule;
        }

        public bool InsertSchedule(ScheduleDto scheduleDto, bool isActive)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (isActive)
                        {
                            if (dbContext.Schedules.Any(s => s.IsActive))
                            {
                                dbContext.Schedules.RemoveRange(dbContext.Schedules.Where(s => s.IsActive));
                            }
                        }

                        Schedule newSchedule = new Schedule();
                        newSchedule.IsActive = isActive;
                        dbContext.Schedules.Add(newSchedule);
                        dbContext.SaveChanges();

                        foreach (ClassDto classDto in scheduleDto.Classes)
                        {
                            Class newClass = new Class();
                            newClass.CourseId = classDto.Course.Id;
                            newClass.InstructorId = classDto.Instructor.Id;
                            newClass.RoomId = classDto.Room.Id;
                            newClass.MeetingTimeId = classDto.MeetingTime.Id;
                            newClass.DepartmentId = classDto.Department.Id;
                            newClass.ScheduleId = newSchedule.Id;
                            dbContext.Classes.Add(newClass);
                        }

                        dbContext.SaveChanges();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "");

                        transaction.Rollback();
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
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
