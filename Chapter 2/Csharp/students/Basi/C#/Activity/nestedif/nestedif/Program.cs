namespace nestedif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER YOUR NUMBER !");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark > 0)
            {
                if (mark % 2 == 0)
                { 
                Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
        }
    }
}
