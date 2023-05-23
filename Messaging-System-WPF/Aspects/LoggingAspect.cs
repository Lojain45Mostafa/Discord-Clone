using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Messaging_System_WPF.Aspects
{
    public static class LoggingAspect
    {
        private static readonly string logFilePath = "log.txt";

        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"[{DateTime.Now}] - {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging message: {ex.Message}");
            }
        }
    }
}
