using System;
using System.Collections.Generic;

namespace Visitor
{
    class BlogEntry : BlogComponent
    {
        public override string Title { get; set; }
        public override DateTime Date { get; set; }

        public override IEnumerable<BlogComponent> Children
        {
            get { yield break; }
        }

        public override void Accept(BlogComponentVisitor visitor)
        {
            visitor.VisitEntry(this);
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
