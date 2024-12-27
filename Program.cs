using UniversitySchedule.Models;
using UniversitySchedule.Utils;
using UniversitySchedule.View;

namespace UniversitySchedule
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log4Net.ConfigureLog4Net();
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                Log4Net.LogException(ex, "Unhandled exception occurred");
            };

            TaskScheduler.UnobservedTaskException += (sender, e) =>
            {
                Log4Net.LogException(e.Exception, "Unobserved task exception occurred");
                e.SetObserved();  // Để tránh terminate application
            };

            try
            {
                // Tạo cơ sở dữ liệu nếu nó không tồn tại
                using (var dbContext = new UniversityScheduleContext())
                {
                    dbContext.Database.EnsureCreated();
                }
            }
            catch (Exception ex) { Log4Net.LogException(ex, ""); }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Login());
        }
    }
}