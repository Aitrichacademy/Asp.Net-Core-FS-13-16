namespace machinetest
{
    internal class Program
    {
        public struct Book
        {
            public int bookId;
            public string title;
            public string author;

            public Book(int bookId, string title, string author)
            {
                this.bookId = bookId;
                this.title = title;
                this.author = author;
            }
            public void display()
            {
                //Console.WriteLine($"ID :{bookId},       Title: {title},       Author: {author}");
               
            }
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[5];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"\nBook {i + 1}: ");
                books[i] = new Book();

                Console.Write($"Enter Book Id : ");
                books [i].bookId = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Enter Title : ");
                books[i].title = Console.ReadLine();

                Console.Write($"Enter Author Name: ");
                books[i].author = Console.ReadLine();

            }
           
            Console.WriteLine("\nEnter BookId for Search : ");
            int searchid=Convert.ToInt32(Console.ReadLine());
            bool found=false;   
            foreach (Book book in books)
            {
                if(searchid == book.bookId)
                {
                    Console.WriteLine($"Search Id = Book Id:{book.bookId},    Title:{book.title},          Author:{book.author} ");
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Invalid search id!");
            }
        }
    }
}
