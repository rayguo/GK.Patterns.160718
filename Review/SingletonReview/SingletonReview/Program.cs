using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonReview
{
    class Program
    {
        static void Main(string[] args)
        {
            var highlander = Singleton<Highlander>.Default;
        }
    }
}
