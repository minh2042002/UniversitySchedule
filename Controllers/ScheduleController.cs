﻿using Microsoft.EntityFrameworkCore;
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
                    List<Schedule> dbSchedules = dbContext.Schedules
                                                          .Include(s => s.Classes)
                                                            .ThenInclude(c => c.Course)
                                                          .Include(s => s.Classes)
                                                            .ThenInclude(c => c.Instructor)
                                                            .ThenInclude(i => i.User)
                                                            .ThenInclude(u => u.Information)
                                                          .Include(s => s.Classes)
                                                            .ThenInclude(c => c.Room)
                                                          .Include(s => s.Classes)
                                                            .ThenInclude(c => c.MeetingTime)
                                                          .Include(s => s.Classes)
                                                            .ThenInclude(c => c.Department)
                                                          .AsNoTracking().ToList();
                    if (dbSchedules.Count > 0)
                    {
                        dbSchedules.ForEach(s =>
                        {
                            Schedule scheduleDetail = GetScheduleDetailById(s.Id);
                            if (scheduleDetail != null)
                            {
                                schedules.Add(scheduleDetail);
                            }
                        });
                    }
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedules;
        }

        public Schedule? GetScheduleActiveDetail()
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

        private Schedule GetScheduleDetailById(int scheduleId)
        {
            Schedule? schedule = null;
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    schedule = dbContext.Schedules
                                                .AsNoTracking()
                                                .Include(s => s.Classes).ThenInclude(c => c.Course)
                                                .Include(s => s.Classes).ThenInclude(c => c.Instructor).ThenInclude(i => i.User).ThenInclude(u => u.Information)
                                                .Include(s => s.Classes).ThenInclude(c => c.Room)
                                                .Include(s => s.Classes).ThenInclude(c => c.MeetingTime)
                                                .Include(s => s.Classes).ThenInclude(c => c.Department)
                                                .FirstOrDefault(s => s.Id == scheduleId);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return schedule;
        }

        public int SetActive(Schedule schedule)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var updateSchedule = dbContext.Schedules.FirstOrDefault(s => s.Id == schedule.Id);
                        if (updateSchedule == null)
                        {
                            return 0;
                        }

                        dbContext.Schedules.ToList().ForEach(s => s.IsActive = false);

                        updateSchedule.IsActive = true;

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

        public int InsertSchedule(ScheduleDto schedule, string name)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Schedules.Any(s => s.Name == name))
                        {
                            return 0;
                        }

                        Schedule newSchedule = new Schedule();
                        newSchedule.Name = name;
                        newSchedule.IsActive = false;
                        dbContext.Schedules.Add(newSchedule);
                        dbContext.SaveChanges();

                        foreach (ClassDto classDto in schedule.Classes)
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
