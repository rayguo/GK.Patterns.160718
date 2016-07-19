using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Generic
{
    class Logger : Singleton<Logger>
    {
        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            return InternalGetIntance();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
