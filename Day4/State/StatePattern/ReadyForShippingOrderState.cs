namespace StatePattern
{
    public class ReadyForShippingOrderState : OrderState
    {
        public ReadyForShippingOrderState(Order order) : base(order)
        {
        }

        public override void Ship()
        {
            // Ship
            Order.InternalShip();
            Order.OrderState = new ShippedOrderState(Order);
        }
    }
}
