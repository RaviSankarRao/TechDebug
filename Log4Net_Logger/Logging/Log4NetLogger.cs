using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class Log4NetLogger : ILogger
    {

        private static ILog log =
           LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogParameters(IDictionary<string, object> parameters, LogLevel level)
        {
            if (parameters == null)
            {
                return;
            }
            StringBuilder strmessage = new StringBuilder();
            strmessage.Append("Parameters : ");
            foreach (KeyValuePair<string, object> param in parameters)
            {
                strmessage.AppendFormat("{0} - {1} | ", param.Key, param.Value);
            }
            
        }

        public void LogMessage(string message, LogLevel logLevel)
        {
            switch(logLevel)
            {
                case LogLevel.DEBUG:
                    log.Debug(message);
                    break;
                case LogLevel.INFO:
                    log.Info(message);
                    break;
                default:
                    break;

            }
        }

        public void LogMessage(string message, LogLevel level, IDictionary<string, object> methodParameters)
        {
            log.InfoFormat(message, methodParameters);
        }

        public void LogMessage(string message, LogLevel level, params object[] parameters)
        {
            log.InfoFormat(message, parameters);
        }

        public void LogException(Exception e)
        {
            throw new NotImplementedException();
        }

        public void LogException(Exception e, IDictionary<string, object> methodParameters)
        {
            throw new NotImplementedException();
        }

        public void LogException(Exception e, params object[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
