namespace condition6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your product code: ");
            int n=Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:Console.WriteLine("Coke-$1.50");
                    break;
                case 2:Console.WriteLine("Chips - $1.00");
                    break;
                case 3:Console.WriteLine("Chocolate - $2.00");
                    break;
                case 4:Console.WriteLine("Water - $1.00");
                    break;
                case 5:Console.WriteLine("Juice - $1.75");
                    break;
                default: Console.WriteLine("Invalid Selection.Please try again!");
                    break;
            }
        }
    }
}
