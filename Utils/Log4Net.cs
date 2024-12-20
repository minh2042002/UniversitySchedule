using log4net.Appender;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySchedule.Utils
{
    public class Log4Net
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void ConfigureLog4Net()
        {
            // Tạo layout cho log
            var layout = new PatternLayout();
            layout.ActivateOptions();

            var rollingFileAppender = new RollingFileAppender
            {
                Name = "RollingFileAppender",
                // Đặt tên file với tiền tố và định dạng ngày
                File = $"{AppDomain.CurrentDomain.BaseDirectory}logs//error_log",
                AppendToFile = true,
                RollingStyle = RollingFileAppender.RollingMode.Date, // Tách file theo ngày
                StaticLogFileName = false, // Cho phép tên file thay đổi theo ngày
                Layout = layout,
                MaxSizeRollBackups = 30, // Số file backup tối đa (có thể điều chỉnh)
                MaximumFileSize = "100MB", // Kích thước file tối đa

            };

            rollingFileAppender.ActivateOptions(); // Gọi phương thức này sau khi thiết lập các thuộc tính

            // Tạo logger và cấu hình root logger
            var hierarchy = (Hierarchy)LogManager.GetRepository(Assembly.GetCallingAssembly());
            hierarchy.Root.AddAppender(rollingFileAppender);
            hierarchy.Root.Level = log4net.Core.Level.Debug; // Chọn mức độ ghi log
            hierarchy.Configured = true;
        }

        public static void LogException(Exception ex, string message, [CallerFilePath] string nameFile = "", [CallerMemberName] string nameFunction = "")
        {
            // Ghi log vào file
            try
            {
                string logMessage =
                    $"Time: {DateTime.Now}\n" +
                    $"File: {nameFile}\n" +
                    $"Function: {nameFunction}\n" +
                    $"Message: {message}\n" +
                    $"Detail: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}" +
                    "--------------------------------------------------\n";

                logger.Error(logMessage);
            }
            catch { }
        }

        public static void LogInfo(string message, [CallerFilePath] string nameFile = "", [CallerMemberName] string nameFunction = "")
        {
            try
            {
                // Ghi log vào file
                string logMessage =
                    $"Time: {DateTime.Now}\n" +
                    $"File: {nameFile}\n" +
                    $"Function: {nameFunction}\n" +
                    $"Message: {message}\n" +
                    "--------------------------------------------------\n";
                logger.Info(logMessage);
            }
            catch { }
        }

    }
}
