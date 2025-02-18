namespace Conditnl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your Mark");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //if (mark >= 90)
            //{
            //    Console.WriteLine("Grade A");
            //}
            //else if (mark >= 80)
            //{
            //    Console.WriteLine("Grade B");
            //}
            //else if (mark >= 70)
            //{
            //    Console.WriteLine("Grade C");
            //}
            //else if (mark >= 60)
            //{
            //    Console.WriteLine("Grade D");
            //}
            //else
            //{
            //    Console.WriteLine("FAILED");
            //}
            //Console.ReadLine();

            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd Number");
                }
            }
            else
            {
                Console.WriteLine("negative number");
            }

            //Console.WriteLine("Enter Number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("POSITIVE number");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVE number");
            //}


            //Console.WriteLine("Enter Number 1");
            //int num1=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number 2");
            //int num2=Convert.ToInt32(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1+"is largest");
            //}
            //else
            //{
            //    Console.WriteLine(num2+"is largest");
            //}
        }
    }
}
