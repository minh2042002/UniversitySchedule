using Microsoft.EntityFrameworkCore;
using UniversitySchedule.Models;
using UniversitySchedule.Utils;

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
                    information = dbContext.Informations.AsNoTracking().FirstOrDefault(i => i.UserId == user.Id);
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            return information;
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
                        Information updateInformation = dbContext.Informations.FirstOrDefault(i => i.Id == information.Id);
                        if (updateInformation == null)
                        {
                            return 0;
                        }

                        updateInformation.Name = information.Name;
                        updateInformation.DayOfBirth = information.DayOfBirth;

                        dbContext.Informations.Update(updateInformation);
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