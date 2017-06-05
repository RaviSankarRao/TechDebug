using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Log4Net.Logging
{
    public class LogFormatter
    {
        public static string GetFormattedMessage(string message, LogLevel logLevel)
        {
            return string.Format(CultureInfo.CurrentCulture, "{0} [{1}] [{2}]: {3}",
                           DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt", CultureInfo.CurrentCulture)
                           , logLevel.ToString().ToUpper()
                           , Thread.CurrentThread.ManagedThreadId
                           , message);
        }
    }
}
