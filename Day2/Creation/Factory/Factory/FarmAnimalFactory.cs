using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class FarmAnimalFactory : AnimalFactory
    {
        public override Animal Create(string animalKind)
        {
            switch (animalKind)
            {
                case "cow":
                    return new Cow();
                case "chicken":
                    return new Chicken();
                case "sheep":
                    return new Sheep();
                default:
                    throw new Exception("Invalid animal type");
            }
        }
    }
}
