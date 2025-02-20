using System.ComponentModel;
using System.Reflection;
using System.Transactions;

namespace conditional_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your mark:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 50)
            //{
            //    Console.WriteLine("Pass");
            //}
            //Console.WriteLine("Enter your age:");
            //int num =Convert.ToInt32(Console.ReadLine());
            //if (num < 18)
            //            {
            //    Console.WriteLine("Not eligiable for voting");
            //}
            //else
            //{
            //    Console.WriteLine(" Eligiable for voting");

            //}
            //Console.ReadLine();

            //Console.WriteLine("enter your mark:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 90)
            //{
            //    Console.WriteLine("Grade: A +");

            //}
            //else if (num > 80)
            //{
            //    Console.WriteLine("Grade:A");

            //}
            //else if (num > 70)
            //{
            //    Console.WriteLine("Grade:B+");
            //}
            //else if(num >60)
            //{
            //    Console.WriteLine("Grade:B");
            //}
            //else if (num > 50)
            //{
            //    Console.WriteLine("Grade:C+");
            //}
            //else if(num > 40)
            //{
            //    Console.WriteLine("Grade:C");
            //}
            //else if(num > 30)
            //{
            //    Console.WriteLine("Grade:D+");   
            //}
            //else
            //{
            //    Console.WriteLine("Failed");

            //}
            //Console.ReadLine();

            //Console.WriteLine("enter the number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 0)
            //{
            //    Console.WriteLine("the number is postive");
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("the number is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the numberis odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("the number is negative");
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("the number is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the number is odd");

            //    }

            //}
            //Console.ReadLine();

            //Console.WriteLine("enter the number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("the number is postive");
            //}
            //    if (num < 0)
            //    {
            //        Console.WriteLine("the number is negative");
            //    }
            //    else {
            //        Console.WriteLine("the number is zero");
            //    }
            //Console.ReadLine();

            //Console.WriteLine("enter the number");
            //int num =Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("the number is even");
            //}
            //else
            //{
            //    Console.WriteLine("the number is odd");
            //}
            //Console.ReadLine();

            //Console.WriteLine("enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter  the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine("the largest number is :" + num1);

            //}
            //else if (num2 > num1)
            //{
            //    Console.WriteLine("the largest number is :" + num2);
            //}
            //else
            //{
            //    Console.WriteLine("both are equal");
            //}
            //Console.ReadLine();

            //Console.WriteLine("enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter  the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter the thrid number ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int largest;

            //if (num1 >= num2 && num1 >= num3)
            //{
            //    largest = 1;
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    largest = 2;
            //}
            //else
            //{
            //    largest= 3;

            //}
            //switch(largest)
            //{
            //    case 1:
            //    Console.WriteLine("the largest number is :" + num1);
            //        break;

            //    case 2:
            //    Console.WriteLine("the largest number is :" + num2);
            //        break;
            //        case 3:
            //    Console.WriteLine("the largest number is :"+num3);
            //        break;
            //}
            //Console.ReadLine();

            //Console.WriteLine("enter the year ");
            //int year = Convert.ToInt32(Console.ReadLine());  

            //if (year % 4 == 0 &&  year  % 100 == 0 )
            //{
            char operation;

            Console.WriteLine("enter the first number:");
            int num1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter operation (+,- ,*,/):");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result;
            switch(operation)
            {
                case '+':
                     result = num1 + num2;
                    Console.WriteLine("result:"+ result);
                break;
                case '-':
                     result = num1 - num2;
                    Console.WriteLine("result:"+ result);

                    break;
                case '*':
                     result =num1 * num2;
                    Console.WriteLine("result:" + result);
                    break;
                    case '/':
                    result = num1 / num2;
                    Console.WriteLine("result:" + result);
                    break;
                    Console.ReadLine();

            }
        }
    }
}
