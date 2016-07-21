namespace FirstPass
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.AddBook("The Hobbit");
            order.AddBook("Lord of the Rings");
            order.AddBook("The Two Towers");
            order.AddBook("Silmarillion");
            order.AddBook("Return of the King");

            order.SubmitOrder();

            order.SetDeliveryDetails();

            //order.SubmitOrder();

            order.Ship();
        }
    }
}
