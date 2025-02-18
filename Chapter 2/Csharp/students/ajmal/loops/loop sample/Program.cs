namespace loop_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("even nummbers from 1 to 50");

            //for(int i = 2;i<=50;i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Enter a number to reverse: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int originalNumber = number; 
            //int reversedNumber = 0;

            //while (number != 0) 
            //{
            //    int digit = number % 10;  
            //    reversedNumber = (reversedNumber * 10) + digit; 
            //    number /= 10; 
            //}

            //Console.WriteLine("Reversed Number: " + reversedNumber);

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //do
            //{
            //    sum += number % 10; 
            //    number /= 10;  
            //} while (number > 0); 
            //Console.WriteLine("Sum of Digits: " + sum);

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //long factorial = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i;

            //    Console.WriteLine("Factorial of " + number + " is: " + factorial);
            //}

            Console.Write("Enter the number of rows: ");   
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}