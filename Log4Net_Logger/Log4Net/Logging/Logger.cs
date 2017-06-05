using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.Logging
{
    public static class Logger
    {
        private static ILogger logger = LoggerFactory.GetLogger();

        private static string GetFormattedMessage(string message, LogLevel logLevel)
        {
            return LogFormatter.GetFormattedMessage(message, logLevel);
        }

        public static void LogInfo(string message)
        {
            logger.LogInfo(GetFormattedMessage(message, LogLevel.INFO));
        }

        public static void LogDebug(string message)
        {
            logger.LogDebug(GetFormattedMessage(message, LogLevel.DEBUG));
        }

        public static void LogError(string message)
        {
            logger.LogError(GetFormattedMessage(message, LogLevel.ERROR));
        }

        public static void LogException(string message, Exception exception)
        {
            logger.LogException(GetFormattedMessage(message, LogLevel.ERROR), exception);
        }

        public static void LogWarn(string message)
        {
            logger.LogWarn(GetFormattedMessage(message, LogLevel.WARN));
        }

        public static void LogFatal(string message)
        {
            logger.LogFatal(GetFormattedMessage(message, LogLevel.FATAL));
        }
    }
}
