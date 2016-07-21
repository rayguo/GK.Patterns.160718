namespace StatePattern
{
    public class SelectingOrderState : OrderState
    {
        public SelectingOrderState(Order order) : base(order)
        {
        }

        public override void AddBook(string title)
        {
            // Add the order
            Order.InternalAddBook(title);
        }

        public override void SubmitOrder()
        {
            // Submit the order
            Order.InternalSubmitOrder();
            Order.OrderState = new SetDeliveryDetailsOrderState(Order);
        }
    }
}
