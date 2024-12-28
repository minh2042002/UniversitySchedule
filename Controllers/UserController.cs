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

        public (bool, string, User?) Login(string username, string password)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    // Tìm người dùng theo tên đăng nhập
                    var user = dbContext.Users
                                        .Include(u => u.Information)
                                        .Include(u => u.Instructor)
                                        .ThenInclude(i => i.Department)
                                        .FirstOrDefault(u => u.Username == username);

                    // Kiểm tra nếu người dùng tồn tại
                    if (user == null)
                    {
                        return (false, "Tài khoản không tồn tại!", null);
                    }

                    // Kiểm tra mật khẩu (nên hash mật khẩu và so sánh)
                    if (user.Password != password)
                    {
                        return (false, "Mật khẩu không chính xác!", null);
                    }

                    // Đăng nhập thành công
                    return (true, "", user);
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return (false, "Đã xảy ra lỗi, vui lòng thử lại!", null);
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

        public int SetHeadForInstructor(Instructor instructor)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var newHeadInstructor = dbContext.Instructors
                                                         .Include(i => i.User)
                                                         .FirstOrDefault(i => i.Id == instructor.Id);

                        if (newHeadInstructor == null || newHeadInstructor.User == null)
                        {
                            return 0;
                        }

                        var department = dbContext.Departments
                                                  .Include(d => d.Instructors)
                                                  .ThenInclude(i => i.User)
                                                  .FirstOrDefault(d => d.Id == newHeadInstructor.DepartmentId);

                        var currentHead = department.Instructors
                                                    .FirstOrDefault(i => i.User.Role == Role.Head);

                        if (currentHead != null && currentHead.Id != newHeadInstructor.Id)
                        {
                            currentHead.User.Role = Role.Instructor;
                        }

                        newHeadInstructor.User.Role = Role.Head;

                        dbContext.SaveChanges();
                        transaction.Commit();
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        Log4Net.LogException(ex, "Lỗi trong SetHeadForInstructor");
                        transaction.Rollback();
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "Lỗi ngoài giao dịch trong SetHeadForInstructor");
                return -1;
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
