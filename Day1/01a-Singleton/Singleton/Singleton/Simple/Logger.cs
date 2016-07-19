using System;

namespace Singleton.Simple
{
    class Logger
    {
        private static readonly Logger Instance;// = new Logger();

        // Explicit type ctor
        // But there is a performance penalty!
        static Logger()
        {
            Instance = new Logger();
        }

        private Logger()
        {
            Console.WriteLine("Logger created");
        }

        public static Logger CreateInstance()
        {
            return Instance;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
