using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonReview
{
    class Highlander : Singleton<Highlander>
    {
        private Highlander()
        {
            
        }
        private Highlander(int i)
        {
            
        }
    }
}
