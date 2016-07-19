using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.WeakRef
{
    class Logger
    {
        // Weak reference
        private static WeakReference _weekRef
            = new WeakReference(null);

        private static readonly object SharedLock = new object();

        private Logger()
        {
            Console.WriteLine("Logger created");
        }

        public static Logger GetIntance()
        {
            var strongRef = (Logger)_weekRef.Target;
            if (strongRef == null)
            {
                lock (SharedLock)
                {
                    if (strongRef == null)
                    {
                        // Set string and weak references
                        strongRef = new Logger();
                        _weekRef = new WeakReference(strongRef);
                    }
                }
            }

            return strongRef;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
