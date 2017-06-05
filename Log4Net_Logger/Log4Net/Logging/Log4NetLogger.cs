using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.Logging
{
    public class Log4NetLogger : ILogger
    {
        private static readonly ILog log =
           LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void LogDebug(string message)
        {
            log.Debug(message);
        }

        public void LogError(string message)
        {
            log.Error(message);
        }

        public void LogException(string message, Exception exception)
        {
            log.Error(message, exception);
        }

        public void LogInfo(string message)
        {
            log.Info(message);
        }

        public void LogWarn(string message)
        {
            log.Warn(message);
        }

        public void LogFatal(string message)
        {
            log.Fatal(message);
        }
    }
}
