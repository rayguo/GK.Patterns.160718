using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            var stringBuilder = new StringBuilder(s);

            Console.WriteLine("Press Enter add reversing");
            Console.ReadLine();
            var reverseDec = new ReverseStringDecorator(stringBuilder);

            Console.WriteLine("Change to capital {C} or lower {Any}");
            string option = Console.ReadLine().ToUpper();

            StringDecorator caseDec;
            if (option == "C")
            {
                caseDec = new CapitalStringDecorator(reverseDec);
            }
            else
            {
                caseDec = new LowerStringDecorator(reverseDec);
            }

            string output = caseDec.Transform();
            Console.WriteLine($"Output: {output}");
        }
    }
}
