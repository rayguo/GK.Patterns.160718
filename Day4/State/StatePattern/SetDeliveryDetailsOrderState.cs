namespace StatePattern
{
    public class SetDeliveryDetailsOrderState : OrderState
    {
        public SetDeliveryDetailsOrderState(Order order) : base(order)
        {
        }

        public override void SetDeliveryDetails()
        {
            // Set delivery details
            Order.InternalSetDeliveryDetails();
            Order.OrderState = new ReadyForShippingOrderState(Order);
        }

        public override void GiftWrap()
        {
            // Gift wrap
            Order.InternalGiftWrap();
        }
    }
}
