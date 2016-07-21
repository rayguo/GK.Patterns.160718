using System.Collections.Generic;

namespace Composition.CompositionPattern
{
    class BlogCategory : BlogComponent
    {
        public override string Title { get; set; }

        private IEnumerable<BlogComponent> _children;
        public override IEnumerable<BlogComponent> Children
        {
            get { return _children; }
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
