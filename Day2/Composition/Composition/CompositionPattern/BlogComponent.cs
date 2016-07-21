using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.CompositionPattern
{
    abstract class BlogComponent
    {
        // Entry only properties
        public virtual DateTime Date { get; set; }

        // Entry and category properties
        public abstract string Title { get; set; }
        public abstract  IEnumerable<BlogComponent> Children { get; }

        public IEnumerable<BlogComponent> FindAll()
        {
            yield return this;

            foreach (var child1 in Children)
            {
                //yield return child1.FindAll();

                foreach (var child2 in child1.FindAll())
                {
                    yield return child2;
                }
            }

            //foreach (var entry in Entries)
            //{
            //    yield return entry;
            //}

            //foreach (var category in Categories)
            //{
            //    yield return category;

            //    // Recursively enumerate categories
            //    foreach (var child in category.FindAll())
            //    {
            //        yield return child;
            //    }
            //}
        }



    }
}
