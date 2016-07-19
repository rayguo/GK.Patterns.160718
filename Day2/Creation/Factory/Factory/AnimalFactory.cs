using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    abstract class AnimalFactory
    {
        public abstract Animal Create(string animalKind);
    }
}
