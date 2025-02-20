using System.Security.Cryptography.X509Certificates;

namespace structurequestion
{
    internal class Program
    {
        public struct Book
        {
            public string Title;
            public string Author;
            public double price;


            public Book(string title, string author, double price)
            {
                this.Title = title;
                this.Author = author;
                this.price = price;
            }

            public void display()
            {
                Console.WriteLine($"Title:{Title},Author:{Author},price:{price}");
            }

            static void Main(string[] args)
            {
                Book book1;
                book1.Title = "Rich dad poor dad";
                book1.Author = "Robert kioskaki";
                book1.price = 100;

                book1.display();
            }
        }
    }
}
