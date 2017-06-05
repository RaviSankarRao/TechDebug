using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            string name = "Ravi Sankar";
            Logger.LogMessage(string.Format("Loggng data"), LogLevel.INFO, number, name);

            //for (int i = 0; i < 1000; i++)
            //{
            //    Logger.LogMessage(string.Format("Loggng data {0}", i), LogLevel.INFO);
            //}
        }
    }
}
