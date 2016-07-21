using System;

namespace StatePattern
{
    public abstract class OrderState
    {
        protected Order Order { get; set; }

        protected OrderState(Order order)
        {
            Order = order;
        }

        public virtual void AddBook(string title)
        {
            throw new InvalidOperationException($"AddBook not valid for current state: {GetType().Name}");
        }

        public virtual void SubmitOrder()
        {
            throw new InvalidOperationException($"SubmitOrder not valid for current state: {GetType().Name}");
        }

        public virtual void SetDeliveryDetails()
        {
            throw new InvalidOperationException($"SetDeliveryDetails not valid for current state: {GetType().Name}");
        }

        public virtual void GiftWrap()
        {
            throw new InvalidOperationException($"GiftWrap not valid for current state: {GetType().Name}");
        }

        public virtual void Ship()
        {
            throw new InvalidOperationException($"Ship not valid for current state: {GetType().Name}");
        }
    }
}
