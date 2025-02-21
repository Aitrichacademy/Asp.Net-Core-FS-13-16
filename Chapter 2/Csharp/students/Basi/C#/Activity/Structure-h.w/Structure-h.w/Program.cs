namespace Structure_h.w
{
    internal class Program
    {

        public struct book
        {
            public string Title;
            public string Author;
            public double Price;

            public book(string title, string author, double price)
            {
                this.Title = title;
                this.Author = author;
                this.Price = price;
            }

            public void display ()
            {
                Console.WriteLine($"Title:{Title},Author:{Author},Price:{Price}");
            }
        }
        static void Main(string[] args)
        {
            book book1;
            book1.Title = " Aadujeevitham";
            book1.Author = " Benyamin";
            book1.Price = 230.00;
            book1.display();

            book book2 = new book("Chemmeen", "Thakazhi" ,200);
            book2.display();
            book book3 = new book("maram", "o.v vijayan", 170);
            book3.display();
        }
    }
}
