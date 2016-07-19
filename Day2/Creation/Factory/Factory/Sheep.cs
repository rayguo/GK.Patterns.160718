using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Sheep : Animal
    {
        public override string Speak()
        {
            return "Bah";
        }
    }
}
