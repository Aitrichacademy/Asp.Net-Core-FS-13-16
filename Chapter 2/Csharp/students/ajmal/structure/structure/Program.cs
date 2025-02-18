namespace structure
{
    internal class Program
    {
        struct Book
        {
            public string Title;
            public string Author;
            public double Price;


            public Book(string title, string author, double price)
            {
                Title = title;
                Author = author;
                Price = price;
            }


            public void Display()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, Price: ${Price}");

               
            }

        }
        static void Main(string[] args)
        {
            Book book1 = new Book("The great gatsby", "F. scott Fitzgerald", 10.99);
            book1.Display();


            Console.ReadLine();
        }
        
        
    }
}
