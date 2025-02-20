namespace largest_of_3_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER THE 3 DIGITS : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c )
            {
                Console.WriteLine(a + " is the largest number ");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " Is the largest number");
            }
            else
            {
                Console.WriteLine(c + " is the largest number");
            }
            Console.ReadLine();
        }
    }
}
