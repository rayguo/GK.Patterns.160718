using System;
using System.Collections.Generic;

namespace StatePattern
{
    public class Order
    {
        internal OrderState OrderState { get; set; }

        private readonly  List<Book> _books = new List<Book>();

        public Order()
        {
            OrderState = new SelectingOrderState(this);
        }

        public void AddBook(string title)
        {
            OrderState.AddBook(title);
        }

        public void SubmitOrder()
        {
            OrderState.SubmitOrder();
        }

        public void SetDeliveryDetails()
        {
            OrderState.SetDeliveryDetails();
        }

        public void GiftWrapOrder()
        {
            OrderState.GiftWrap();
        }

        public void Ship()
        {
            OrderState.Ship();
        }

        internal void InternalAddBook(string title)
        {
            _books.Add(new Book(title));
            Console.WriteLine($"{title} added to order");
        }

        internal void InternalSubmitOrder()
        {
            Console.WriteLine("Submitting order");
        }

        internal void InternalSetDeliveryDetails()
        {
            Console.WriteLine("Supplying delivery info");
        }

        internal void InternalGiftWrap()
        {
            Console.WriteLine("Gift wrapping order");
        }

        internal void InternalShip()
        {
            Console.WriteLine("Shipping order");
        }
    }
}
