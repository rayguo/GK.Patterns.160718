using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    class Logger
    {
        private static Logger _instance;

        private static readonly object SharedLock = new object();

        private Logger()
        {
            Console.WriteLine("Logger created");
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (SharedLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                } 
            }

            return _instance;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
