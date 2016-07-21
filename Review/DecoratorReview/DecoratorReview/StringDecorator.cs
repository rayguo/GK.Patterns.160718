using System.Text;

namespace DecoratorReview
{
    public abstract class StringDecorator
    {
        public abstract StringBuilder Builder { get; set; }
        public abstract string Transform();
    }
}
