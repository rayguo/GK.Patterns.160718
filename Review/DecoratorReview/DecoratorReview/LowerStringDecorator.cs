using System;
using System.Text;

namespace DecoratorReview
{
    public class LowerStringDecorator : StringDecorator
    {
        private readonly StringDecorator _decorator;
        public override StringBuilder Builder { get; set; }

        public LowerStringDecorator(StringBuilder builder)
        {
            Builder = builder;
        }

        public LowerStringDecorator(StringDecorator decorator)
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
            string lower = original.ToLower();
            Builder.Replace(original, lower);
            return lower;
        }
    }
}
