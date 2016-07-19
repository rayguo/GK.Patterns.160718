using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class BetterAnimalFactory : AnimalFactory
    {
        public override Animal Create(string animalKind)
        {
            var animalType = Type.GetType($"Factory.{animalKind}");
            if (animalType == null)
                throw new Exception("Animal kind not supported");

            var animal = (Animal)Activator.CreateInstance(animalType,
                BindingFlags.Public | BindingFlags.Instance,
                null, null, CultureInfo.InvariantCulture);

            return animal;
        }
    }
}
