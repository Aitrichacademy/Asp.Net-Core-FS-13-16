using System;
using System.Diagnostics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your mark");
            //int mark = Convert.ToInt32(Console.ReadLine());

            //if (mark > 50)
            //{
            //    Console.WriteLine("pass");
            //}
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age > 18)
            //{
            //    Console.WriteLine("eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("not eligible");
            //    Console.ReadLine(); 
            //}



            //Console.WriteLine("Enter your mark (out of 100)");
            //int mark = Convert.ToInt32(Console.ReadLine());

            //if (mark > 90)
            //{
            //    Console.WriteLine("A+ grade");
            //}
            //else if (mark > 80)
            //{
            //    Console.WriteLine("A grade");
            //}
            //else if (mark > 70)
            //{
            //    Console.WriteLine("B+ grade");
            //}
            //else if (mark > 60)
            //{
            //    Console.WriteLine("B grade");
            //}
            //else if (mark > 50)
            //{
            //    Console.WriteLine("C+ grade");
            //}
            //else if (mark > 40)
            //{
            //    Console.WriteLine("C grade");
            //}
            //else if (mark > 30)
            //{
            //    Console.WriteLine("D+ grade");
            //}
            //else
            //{
            //    Console.WriteLine("fILED");
            //}


            //Check if a Number is Positive or Negative

            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("number is positive");
            //}
            //else
            //{
            //    Console.WriteLine("number is negetive");
            //}



            //Find the Largest of Two Numbers


            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter another number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //if (num > num1)
            //{
            //    Console.WriteLine($"{num} is largest");
            //}
            //else
            //{
            //    Console.WriteLine($"{num1} is largest");
            //}


            //Find the Largest of Three Numbers

            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter another number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter third number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num > num1)
            //{
            //    if (num > num2)
            //    {
            //        Console.WriteLine($"{num} is largest");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num2} is largest");
            //    }

            //}
            //else if (num1 > num2)
            //{

            //        Console.WriteLine($"{num1} is largest");

            //}


            //else
            //{
            //    Console.WriteLine($"{num2}is largest");
            //}



            //Check if a Year is a Leap Year

            //Console.WriteLine("enter a year");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Year = {year}");
            //if (year%4==0)
            //{
            //    Console.WriteLine("Leap Year!");
            //}
            //else
            //{
            //    Console.WriteLine("Not a Leap Year!");
            //}


            //Check Vowel or Consonant


            //Console.WriteLine("enter a letter");
            //char letter = Convert.ToChar(Console.ReadLine());
            //char low = char.ToLower(year);

            //if (low == 'a' || low == 'e' || low == 'i' || low == 'o' || low == 'u')
            //{
            //    Console.WriteLine($"{low} is a vowel");
            //}
            //else
            //{
            //    Console.WriteLine($"{low} is not  a vowel");
            //}



            //Nested if: Check Even or Odd and Positive or Negative


            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("number is positive");
            //    if (num % 2 == 0)
            //    {
            //        Console.WriteLine("number is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("number is odd");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("number is negetive");
            //}




            //Check if a Person is Eligible to Vote


            //Console.WriteLine("enter your age");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num >= 18)
            //{
            //    Console.WriteLine("you are eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine("you are not eligible to vote");
            //}




            //Check if a Number is Even or Odd


            //Console.WriteLine("enter a number");
            //int num = Convert.ToInt32(Console.ReadLine());



            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("number is even");
            //}
            //else
            //{
            //    Console.WriteLine("number is odd");
            //}


            //Check Number Type(Positive, Negative, Zero

            //            Console.WriteLine("enter a number");
            //            int num = Convert.ToInt32(Console.ReadLine());

            //            if (num > 0)
            //            {
            //                Console.WriteLine("number is positive");
            //            }
            //            else if (num < 0)
            //            {
            //                Console.WriteLine("number is negetive");
            //            }
            //            else
            //            {
            //                Console.WriteLine("number is Zero");
            //            }


            //simple calculator

            Console.WriteLine("enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator ( + , - , * , / )");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':

                    int sum = num1 + num2;
                    Console.WriteLine($"the result is {sum}");
                    break;
                case '-':

                    int sub = num1 - num2;
                    Console.WriteLine($"the result is {sub}");
                    break;
                case '*':

                    int mul = num1 * num2;
                    Console.WriteLine($"the result is {mul}");
                    break;
                case '/':

                    int div = num1 / num2;
                    Console.WriteLine($"the result is {div}");
                    break;
                case '\0':
                    Console.WriteLine("nashinj");
                    break;
            }

        }
    }
}



