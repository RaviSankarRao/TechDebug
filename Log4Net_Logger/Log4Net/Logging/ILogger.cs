using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.Logging
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogDebug(string message);

        void LogError(string message);

        void LogException(string message, Exception exception);

        void LogWarn(string message);

        void LogFatal(string message);
    }
}
