using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

namespace UniversitySchedule.Controllers
{
    public class UserController
    {
        private static UserController _instance;
        private UserController() { }

        public static UserController Instance()
        {
            if (_instance == null)
            {
                _instance = new UserController();
            }
            return _instance;
        }

        public List<User> GetAllUser()
        {
            List<User> users = new List<User>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    users = dbContext.Users.Include(u => u.Information).ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return users;
        }

        public List<User> GetAllUserByRole(Role role)
        {
            List<User> users = new List<User>();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    users = dbContext.Users
                                     .Include(u => u.Information)
                                     .Where(u => u.Role == role)
                                     .ToList();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return users;
        }

        public bool IsExists(string username)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    return dbContext.Users.Any(u => u.Username == username);
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return true;

            }
        }

        public (int, string) InsertUserWithInformation(User user)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Users.Any(u => u.Username == user.Username))
                        {
                            return (0, "Tài khoản đã tồn tại!");
                        }

                        if (dbContext.Informations.Any(i => i.Phone == user.Information.Phone))
                        {
                            return (0, "Số điện thoại đã tồn tại!\nVui lòng thử lại với số điện thoại khác.");
                        }
                        
                        if (dbContext.Informations.Any(i => i.Email == user.Information.Email))
                        {
                            return (0, "Email đã tồn tại!\nVui lòng thử lại với email khác");
                        }


                        dbContext.Users.Add(user);
                        dbContext.Informations.Add(user.Information);

                        user.Instructor.UserId = user.Id;
                        dbContext.Instructors.Add(user.Instructor);

                        dbContext.SaveChanges();
                        transaction.Commit();
                        return (1, "Thêm tài khoản thành công");
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "");
                        transaction.Rollback();
                        return (-1, "Đã xảy ra lỗi vui lòng thử lại!");
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return (-1, "Đã xảy ra lỗi vui lòng thử lại!");
            }
        }

        public int DeleteUser(User user)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Users.Any(u => u.Id == user.Id))
                        {
                            return 0;
                        }
                        dbContext.Users.Remove(user);
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
