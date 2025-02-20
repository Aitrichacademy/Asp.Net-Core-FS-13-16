namespace if_else_if
{
    internal class Program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("Enter Your Mark !");
            int mark = Convert.ToInt32(Console.ReadLine());
            if (mark >= 90)
            {
                Console.WriteLine("Grade A");
            }
            if (mark >= 80 && mark < 90)
            {
                Console.WriteLine("Grade B ");
            }
            if (mark >= 70 && mark < 79)
            {
                Console.WriteLine("Grade C ");
            }
            else if (mark >= 60 && mark < 69)
            {
                Console.WriteLine("Grade D ");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine();
        }
    }
}
