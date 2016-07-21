using System.Collections.Generic;

namespace Visitor
{
    class BlogCategory : BlogComponent
    {
        public override string Title { get; set; }

        private IEnumerable<BlogComponent> _children;
        public override IEnumerable<BlogComponent> Children
        {
            get { return _children; }
        }

        public override void Accept(BlogComponentVisitor visitor)
        {
            visitor.VisitCategory(this);

            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }

        public BlogCategory(string title,
            IEnumerable<BlogComponent> children)
        {
            Title = title;
            _children = children;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
