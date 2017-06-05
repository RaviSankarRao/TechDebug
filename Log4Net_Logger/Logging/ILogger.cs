using System;
using System.Collections.Generic;

namespace Logging
{
    public interface ILogger
    {
        void LogMessage(string message, LogLevel logLevel);

        void LogMessage(string message, LogLevel level, params object[] parameters);

        void LogMessage(string message, LogLevel level, IDictionary<string, object> methodParameters);

        void LogException(Exception e);

        void LogException(Exception e, params object[] parameters);

        void LogException(Exception e, IDictionary<string, object> methodParameters);
    }
}
