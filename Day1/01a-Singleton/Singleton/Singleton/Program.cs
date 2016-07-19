using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //UseGlobalVariables();
            //UseSimple();
            //UseThreadSafe();
            UseGeneric();
        }

        private static void UseGeneric()
        {
            var logger1 = Generic.Logger.GetInstance();
            logger1 = null;
            GC.Collect(0);
            var logger2 = Generic.Logger.GetInstance();
            logger2.LogMessage("Hello");
        }

        private static void UseThreadSafe()
        {
            var logger = ThreadSafe.Logger.GetInstance();
            logger.LogMessage("Hello");
        }

        private static void UseSimple()
        {
            //var logger = new Simple.Logger();

            Console.WriteLine("Going to use the logger");

            var logger = Simple.Logger.CreateInstance();
            logger.LogMessage("Hello");
        }

        private static void UseGlobalVariables()
        {
            var logger1 = GlobalVariables.Global.Logger;

            // Nothing to prevent this
            var logger2 = new GlobalVariables.Logger();
        }
    }
}
