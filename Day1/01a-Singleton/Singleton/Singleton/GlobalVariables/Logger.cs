using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.GlobalVariables
{
    class Logger
    {
        public Logger()
        {
            Console.WriteLine("Logger created");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
