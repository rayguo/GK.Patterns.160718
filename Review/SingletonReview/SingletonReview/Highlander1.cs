using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonReview
{
    class Highlander1
    {
        private static Highlander1 _instance;

        private static object SyncRoot = new object();

        private Highlander1()
        {
            Console.WriteLine("Highlander initialized");
        }

        public static Highlander1 Default => GetInstance();

        private static Highlander1 GetInstance()
        {
            if (_instance == null)
            {
                var success = Monitor.TryEnter(SyncRoot, 2000);
                if (!success)
                    throw new Exception("Could acquire lock");
                try
                {
                    if (_instance == null)
                    {
                        _instance = new Highlander1();
                    }
                }
                finally
                {
                    Monitor.Exit(SyncRoot);
                } 
            } 

            return _instance;
        }
    }
}
