using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net.Logging
{
    public static class LoggerFactory
    {
        public static ILogger GetLogger()
        {
            return new Log4NetLogger();
        }
    }
}
