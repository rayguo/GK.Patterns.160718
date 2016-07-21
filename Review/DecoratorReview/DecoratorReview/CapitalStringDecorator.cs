using System;
using System.Text;

namespace DecoratorReview
{
    public class CapitalStringDecorator : StringDecorator
    {
        private readonly StringDecorator _decorator;
        public override StringBuilder Builder { get; set; }

        public CapitalStringDecorator(StringBuilder builder)
        {
            Builder = builder;
        }

        public CapitalStringDecorator(StringDecorator decorator)
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
            string capital = original.ToUpper();
            Builder.Replace(original, capital);
            return capital;
        }
    }
}
