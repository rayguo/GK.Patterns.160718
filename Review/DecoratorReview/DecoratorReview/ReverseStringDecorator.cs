using System;
using System.Text;

namespace DecoratorReview
{
    public class ReverseStringDecorator : StringDecorator
    {
        private readonly StringDecorator _decorator;
        public override StringBuilder Builder { get; set; }

        public ReverseStringDecorator(StringBuilder builder)
        {
            Builder = builder;
        }

        public ReverseStringDecorator(StringDecorator decorator)
        {
            _decorator = decorator;
            Builder = _decorator.Builder;
        }

        public override string Transform()
        {
            string original;
            if (_decorator != null)
                original = _decorator.Transform();
            else
                original = Builder.ToString();
            string reverse = Reverse(original);
            Builder.Replace(original, reverse);
            return reverse;
        }

        private string Reverse(string s)
        {
            var chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
