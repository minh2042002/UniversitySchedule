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
    public class RoomController
    {
        public static RoomController _instance;

        private RoomController() { }

        public static RoomController Instance()
        {
            if (_instance == null)
            {
                _instance = new RoomController();
            }
            return _instance;
        }

        public List<Room> GetAllRoom()
        {
            List<Room> rooms = new List<Room>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    rooms = dbContext.Rooms.AsNoTracking().ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return rooms;
        }

        public int InsertRoom(Room room)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Rooms.Any(r => r.Name == room.Name))
                        {
                            return 0;
                        }
                        dbContext.Rooms.Add(room);
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

        public int UpdateRoom(Room room)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Room updateRoom = dbContext.Rooms.FirstOrDefault(r => r.Id == room.Id);
                        if (updateRoom == null)
                        {
                            return 0;
                        }

                        updateRoom.Name = room.Name;
                        updateRoom.Capacity = room.Capacity;

                        dbContext.Rooms.Update(updateRoom);
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

        public int DeleteRoom(Room room)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        Room deleteRoom = dbContext.Rooms.FirstOrDefault(r => r.Id == room.Id);
                        if (deleteRoom == null)
                        {
                            return 0;
                        }

                        dbContext.Rooms.Remove(deleteRoom);
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
