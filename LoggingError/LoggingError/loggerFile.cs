using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace EMS.App
{
    internal static class Logger
    {
        private static readonly string LogDirectory;
        private static readonly string CustomLogFilePath;

        static Logger()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            if (baseDir.Contains($"{Path.DirectorySeparatorChar}bin{Path.DirectorySeparatorChar}Debug") ||
                baseDir.Contains($"{Path.DirectorySeparatorChar}bin{Path.DirectorySeparatorChar}Release"))
            {

                LogDirectory = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "Log"));
            }
            else
            {
                LogDirectory = Path.Combine(baseDir, "Log");
            }

            CustomLogFilePath = Path.Combine(LogDirectory, "custom_exceptions.log");

            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }

        }

        public static void LogWithCustomFile(string message, Exception ex)
        {
            try
            {
                string logMessage = $"[CUSTOM LOG - {DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}Exception: {ex.Message}{Environment.NewLine}StackTrace: {ex.StackTrace}{Environment.NewLine}{new string('=', 40)}{Environment.NewLine}";
                File.AppendAllText(CustomLogFilePath, logMessage);
            }
            catch (Exception fileEx)
            {
                Console.WriteLine($"Failed to write to custom log file: {fileEx.Message}");
            }
        }


    }
}
