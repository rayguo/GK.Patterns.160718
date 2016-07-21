using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonReview
{
    class Singleton<T>
        where T : class //, new()
    {
        private static T _instance;

        private static object SyncRoot = new object();

        protected Singleton()
        {
        }

        public static T Default => GetInstance();

        private static T GetInstance()
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
                        //_instance = new T();
                        _instance = (T)Activator.CreateInstance(typeof(T),
                            BindingFlags.NonPublic | BindingFlags.Instance,
                            null, null, CultureInfo.InvariantCulture);
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
