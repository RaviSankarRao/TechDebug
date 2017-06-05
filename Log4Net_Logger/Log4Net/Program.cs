using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4Net
{
    class Program
    {
        // private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            // Console.WriteLine("Started Logging at {0}", DateTime.Now.Ticks);

            // log.Info("Info log is working "+ DateTime.Now.Ticks);
            // log.Debug("Debug log is working "+ DateTime.Now.Ticks);
            // log.Error("Error log is working "+ DateTime.Now.Ticks);

            Unit unit = new Unit
            {
                BodyType = "Straight Truck",
                Class = "Class 8",
                Make = "Kenworth",
                Model = "t680"
            };

            var unitString = ObjectDumper.Dump(unit);

            // PacLeaseLogManager.LogDebug(string.Format("Unit Details - {0}", unitString));
            // Logging.Logger.LogDebug(unitString);

            for (long n = 1; n < 5; n++)
            {
                // log.Debug(string.Format("Log entry {0}", n));
                // PacLeaseLogManager.LogDebugAsync(string.Format("Log entry {0}", n));
                // Task.Run(() => PacLeaseLogManager.LogDebug(string.Format("Log entry {0}", n)));
                Logging.Logger.LogDebug(string.Format("Log entry {0}", n));
            }

            

            Console.WriteLine("Completed at {0}", DateTime.Now.Ticks);
        }

        
    }
}
