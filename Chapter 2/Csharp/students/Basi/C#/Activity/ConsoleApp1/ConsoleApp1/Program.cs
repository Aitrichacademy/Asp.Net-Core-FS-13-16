namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE AGE : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
            Console.ReadLine();
        }
    }
}
