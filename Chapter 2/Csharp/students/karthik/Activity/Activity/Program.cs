namespace Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Console.Write("Input the First Number: ");
            //    int firstNumber = Convert.ToInt32(Console.ReadLine());  


            //    Console.Write("Input the Second Number: ");
            //    int secondNumber = Convert.ToInt32(Console.ReadLine());


            //    int temp = firstNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = temp;


            //    Console.WriteLine("After Swapping:");
            //    Console.WriteLine("First Number: " + firstNumber); 
            //    Console.WriteLine("Second Number: " + secondNumber);
            //}



            //    Console.Write("Enter the number: ");
            //    int number = Convert.ToInt32(Console.ReadLine());


            //    for (int i = 0; i <= 10; i++)
            //    {

            //        Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            //    }
            //}




            //    Console.Write("Enter the First number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the Second number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the Third number: ");
            //    int num3 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter the Fourth number: ");
            //    int num4 = Convert.ToInt32(Console.ReadLine());


            //    double average = (num1 + num2 + num3 + num4) / 4.0;


            //    Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", num1, num2, num3, num4, average);
            //}




            //    Console.Write("Enter a digit: ");
            //    string digit = Console.ReadLine();


            //    Console.WriteLine("{0} {0} {0} {0}", digit);


            //    Console.WriteLine("{0}{0}{0}{0}", digit);


            //    Console.WriteLine("{0} {0} {0} {0}", digit);
            //    Console.WriteLine("{0}{0}{0}{0}", digit);
            //}




            //    Console.Write("Enter the number of rows for star pattern: ");
            //    int rows = Convert.ToInt32(Console.ReadLine());  


            //    for (int i = 1; i <= rows; i++) 
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write("* ");  
            //        }
            //        Console.WriteLine(); 
            //    }
            //}



            //Console.Write("Enter the number of rows for number pyramid: ");
            //int rows = Convert.ToInt32(Console.ReadLine());  


            //for (int i = 1; i <= rows; i++)  
            //{

            //    for (int j = i; j < rows; j++)  
            //    {
            //        Console.Write(" "); 
            //    }


            //    for (int j = 1; j <= i; j++)  
            //        Console.Write(j + " ");  
            //    }

            //    Console.WriteLine();  
            //}






            //    Console.Write("Enter the number of rows for inverted star pattern: ");
            //    int rows = Convert.ToInt32(Console.ReadLine());  


            //    for (int i = rows; i >= 1; i--)  
            //    {
            //        for (int j = 1; j <= i; j++)  
            //        {
            //            Console.Write("* ");  
            //        }
            //        Console.WriteLine();  
            //    }
            //}





            //Console.Write("Enter a number to check if it is a palindrome: ");
            //int number = Convert.ToInt32(Console.ReadLine());  
            //int reversedNumber = 0;


            //while (number != 0)
            //{
            //    int digit = number % 10;  
            //    reversedNumber = reversedNumber * 10 + digit;  
            //    number /= 10;  
            //}


            //if (originalNumber == reversedNumber)
            //{
            //    Console.WriteLine("The number is a palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is not a palindrome.");
            //}







            Console.Write("Enter a number to check if it is an Armstrong number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;


            while (number != 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number /= 10;
            }


            if (originalNumber == sum)
            {
                Console.WriteLine("The number is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("The number is not an Armstrong number.");
            }






            //Console.Write("Enter the number of terms for Fibonacci series: ");
            //int num = Convert.ToInt32(Console.ReadLine());


            //int first = 0, second = 1;

            //Console.WriteLine("Fibonacci Series:");
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(first + " ");
            //    int next = first + second;
            //    first = second;
            //    second = next;
            //}








            //Console.Write("Enter a string to find its length: ");
            //string inputString = Console.ReadLine();


            //int length = inputString.Length;


            //Console.WriteLine("The length  is: " + length);











        }
    }
}




