using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public static class Logger
    {
        private static ILogger logger = LoggerProvider.GetLogger();

        public static void LogMessage(string message, LogLevel logLevel)
        {
            logger.LogMessage(message, logLevel);
        }

        public static void LogMessage(string message, LogLevel logLevel, params object[] parameters)
        {
            logger.LogMessage(message, logLevel, parameters);
        }
    }
}
