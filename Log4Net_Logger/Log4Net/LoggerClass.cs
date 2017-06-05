using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log4Net
{
    public class PacLeaseLogManager
    {
        private static readonly ILog log =
           LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogDebugAsync(string message)
        {
            // log.Debug("Debug log is working " + DateTime.Now.Ticks);
            ThreadPool.QueueUserWorkItem(task => log.Debug(message));
        }

        public static void LogDebug(string message)
        {
            // log.Debug("Debug log is working " + DateTime.Now.Ticks);
            // log.Debug(message);
        }
    }
}
