namespace structure1
{
    internal class Program
    {
        public struct Book
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
            public void display()
            {
                Console.WriteLine($"Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine("______________");
            }
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Enter the details of book{i + 1}:");
                Console.Write("Title:");
                string title = Console.ReadLine();

                Console.Write("Author:");
                string author = Console.ReadLine();

                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine());

                books[i] = new Book(title, author, price);
                Console.WriteLine();
            }
            Console.WriteLine("Book Details:");
            Console.WriteLine("--------------");
            foreach(Book book in books)
            {
                book.display();
            }


            //Book Book1 = new Book("Aadujeevitham","Benyamin",230);
            //Book1.display();

        }
    }
}
