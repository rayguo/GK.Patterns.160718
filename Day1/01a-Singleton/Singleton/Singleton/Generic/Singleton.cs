using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Generic
{
    abstract class Singleton<T>
        where T : class
    {
        private static WeakReference _weekRef
            = new WeakReference(null);

        private static readonly object SharedLock = new object();

        protected static T InternalGetIntance()
        {
            var strongRef = (T)_weekRef.Target;
            if (strongRef == null)
            {
                lock (SharedLock)
                {
                    if (strongRef == null)
                    {
                        // Set string and weak references
                        //strongRef = new T();
                        strongRef = (T)Activator.CreateInstance(typeof(T),
                            BindingFlags.NonPublic | BindingFlags.Instance,
                            null, null, CultureInfo.InvariantCulture);
                            
                        _weekRef = new WeakReference(strongRef);
                    }
                }
            }

            return strongRef;
        }
    }
}
