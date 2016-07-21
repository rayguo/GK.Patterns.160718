using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composition.CompositionPattern;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            //IterateBlog();
            UseComposition();
        }

        private static void UseComposition()
        {
            var root = CompositionPattern.Blog.RootCategory;

            foreach (var component in root.FindAll())
            {
                var category = component as BlogCategory;
                if (category != null)
                    Console.WriteLine();
                Console.WriteLine(component);
            }
        }

        //private static void IterateBlog()
        //{
        //    var root = Iteration.Blog.RootCategory;

        //    foreach (var item in root.FindAll())
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
