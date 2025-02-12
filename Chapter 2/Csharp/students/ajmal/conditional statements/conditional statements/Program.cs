using System.ComponentModel.Design;
using System.Reflection;
using System.Transactions;

namespace conditional_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your mark:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 50)
            //{
            //    Console.WriteLine("pass");
            //}

            //Console.WriteLine("enter age:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 18) 
            //{
            //    Console.WriteLine("eligible for vote");

            //}
            //else
            //{
            //    Console.WriteLine("not eligible for vote");
            //}

            //Console.ReadLine();

            //Console.WriteLine("enter mark:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 90)
            //{
            //    Console.WriteLine("Grade:A+");
            //}
            //else if(num >=80)
            //        {
            //    Console.WriteLine("Grade:A");
            //}
            //else if (num >=70)
            //{
            //    Console.WriteLine("Grade:B");
            //}
            //else if (num>=50)
            //{
            //    Console.WriteLine("Grade:c");
            //}
            //else
            //{
            //    Console.WriteLine("Potti");
            //}
            //Console.ReadLine();
            //{
            //    Console.WriteLine("enter number:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 0)
            //    {
            //        if (num % 2 == 0)
            //        {
            //            Console.WriteLine("the number even");
            //        }
            //        else
            //        {
            //            Console.WriteLine("the number is odd");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("negative");
            //    }
            //    Console.ReadLine();
            //}


            //{
            //    Console.WriteLine("enter a number");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 0)
            //    {
            //        Console.WriteLine("the number is positive");

            //    }
            //    else if (num < 0) 
            //    {
            //        Console.WriteLine("the number is negative");

            //    }
            //    else
            //    {
            //        Console.WriteLine("the number is zero");
            //    }
            //    Console.ReadLine();
            //}


            //{
            //    Console.WriteLine("enter a number");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num %2==0)
            //    {
            //        Console.WriteLine("the number is even");

            //    }

            //    else
            //    {
            //        Console.WriteLine("the number is odd");
            //    }
            //    Console.ReadLine();
            //}
            //{
            //    Console.WriteLine("enter the first number:");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("enter the second number:");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("the largest number is :" + num1);
            //    }
            //    else if (num2 > num1)
            //    {
            //        Console.WriteLine("the largest number is :" + num2);

            //    }
            //    else
            //    {
            //        Console.WriteLine("both numbers are equal");
            //    }
            //    Console.ReadLine();


            //}

            //{
            //    Console.WriteLine("enter the first number");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the second number");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the third number");
            //    int num3 = Convert.ToInt32(Console.ReadLine());
            //    int largest;

            //    if (num1 > num2 && num1 > num3)
            //    {
            //        largest = num1;
            //    }
            //    else if (num2 > num1 && num2 > num3) 
            //    {
            //        largest = num2;
            //    }
            //    else
            //    {
            //        largest = num3;
            //    }
            //    Console.WriteLine("the largest number is:"+ largest);
            //}
            //{
            //    Console.ReadLine();
            //}

            //{
            //    Console.WriteLine("enter the year");
            //    int year = Convert.ToInt32(Console.ReadLine());

            //    if (year % 4 == 0 && year % 100 == 0)
            //    {
            //        Console.WriteLine(year + "is a leapyear");
            //    }
            //    else {
            //        Console.WriteLine(year + "not a leapyear");
            //    }
            //    {
            //        Console.ReadLine();
            //    }


            {
                Console.WriteLine("enter the first number:");
                int num1=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter an operation(+,-,*,/):");
                operation = Convert.ToChar(Console.ReadLine());



            }
        }

    }

}

