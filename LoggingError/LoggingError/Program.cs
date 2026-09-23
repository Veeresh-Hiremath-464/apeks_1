using EMS.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingError
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RunApplication();
            }
            catch (Exception ex)
            {
                Logger.LogWithCustomFile(
                    "Unhandled exception in the application.",
                    ex);

                Console.WriteLine(
                    "An error occurred. Details were written to the log file.");
            }
        }

        private static void RunApplication()
        {
            // Your application logic
            throw new InvalidOperationException("Example exception.");
        }
    
    }
}
