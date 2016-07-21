using System;
using System.Collections.Generic;

namespace FirstPass
{
    public class Order
    {
        private OrderStates _state = OrderStates.Selecting;

        private readonly  List<Book> _books = new List<Book>();

        public void AddBook(string title)
        {
            if (_state == OrderStates.Selecting)
            {
                _books.Add(new Book(title));
                Console.WriteLine($"{title} added to order");
            }
            else
                throw new InvalidOperationException("AddBook");
        }

        public void SubmitOrder()
        {
            if (_state == OrderStates.Selecting)
            {
                Console.WriteLine("Submitting order");
                _state = OrderStates.Submitted;
            }
            else
                throw new InvalidOperationException("SubmitOrder");
        }

        public void SetDeliveryDetails()
        {
            if (_state == OrderStates.Submitted)
            {
                Console.WriteLine("Supplying delivery info");
                _state = OrderStates.ReadyForShipping;
            }
            else
                throw new InvalidOperationException("DeliveryDetailsSupplied");
        }

        public void Ship()
        {
            if (_state == OrderStates.ReadyForShipping)
            {
                Console.WriteLine("Shipping order");
                _state = OrderStates.Shipped;
            }
            else
                throw new InvalidOperationException("Ship");
        }
    }
}
