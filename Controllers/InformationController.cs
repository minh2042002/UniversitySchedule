using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UniversitySchedule.Controllers
{
    public class InformationController
    {
        private static InformationController _instance;
        private InformationController() { }

        public static InformationController Instance()
        {
            if (_instance == null)
            {
                _instance = new InformationController();
            }
            return _instance;
        }

        public Information GetInformationByUser(User user)
        {
            Information information = new Information();
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    information = dbContext.Informations.FirstOrDefault(i => i.UserId == user.Id);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return information;
        }

        public bool IsExistsPhone(string phone)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    return dbContext.Informations.Any(i => i.Phone == phone);
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return true;

            }
        }

        public bool IsExistsEmail(string email)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                {
                    return dbContext.Informations.Any(i => i.Email == email);
                }
            }
            catch (Exception ex)
            {
                Log4Net.LogException(ex, "");
                return true;

            }
        }

        public int InsertInformation(Information information)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (dbContext.Informations.Any(i => i.Phone == information.Phone))
                        {
                            return 0;
                        }
                        else if (dbContext.Informations.Any(i => i.Email == information.Email))
                        {
                            return 0;
                        }
                        dbContext.Informations.Add(information);
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

        public int UpdateInformation(Information information)
        {
            try
            {
                using (var dbContext = new UniversityScheduleContext())
                using (var transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        if (!dbContext.Informations.Any(i => i.Id == information.Id))
                        {
                            return 0;
                        }
                        dbContext.Informations.Update(information);
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