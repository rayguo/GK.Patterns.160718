using System;
using System.Collections.Generic;

namespace Composition.CompositionPattern
{
    class BlogEntry : BlogComponent
    {
        public override string Title { get; set; }
        public override DateTime Date { get; set; }

        public override IEnumerable<BlogComponent> Children
        {
            get { yield break; }
        }

        public BlogEntry(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Title} {Date.ToShortDateString()}";
        }
    }
}
