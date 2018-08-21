using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace study_CS
{
    interface ILogger
    {
        void WriteLog(string log);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }
    class ConsoleLogger : IFormattableLogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime() ,log);
        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger();
            logger.WriteLog("Log1");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}
