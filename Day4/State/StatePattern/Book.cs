namespace StatePattern
{
    public class Book
    {
        public Book(string title)
        {
            Title = title;
        }

        public string Title { get; private set; }
    }
}
