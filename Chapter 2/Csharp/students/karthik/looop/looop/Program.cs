namespace looop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Even numbers from 1 to 50:");

            //for (int i = 2; i <= 50; i += 2)  
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();




            //Console.Write("Enter a number to reverse: ");
            //int number = int.Parse(Console.ReadLine());
            //int reversedNumber = 0;

            //while (number > 0)
            //{
            //    int digit = number % 10; 
            //    reversedNumber = (reversedNumber * 10) + digit; 
            //    number /= 10; 
            //}

            //Console.WriteLine("Reversed Number: " + reversedNumber);







            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;

            //do
            //{
            //    sum += number % 10; // Extract the last digit and add it to sum
            //    number /= 10; // Remove the last digit
            //} while (number > 0);

            //Console.WriteLine("Sum of digits: " + sum);








            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //long factorial = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    factorial *= i; // Multiply  number with factorial
            //}

            //Console.WriteLine("Factorial of " + number + " is: " + factorial);





            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int count = 0;

            //if (number == 0)
            //{
            //    count = 1; 
            //}
            //else
            //{
            //    while (number != 0)
            //    {
            //        number /= 10; 
            //        count++; 
            //    }
            //}

            //Console.WriteLine("Number of digits: " + count);







            //int n = 10; 
            //int first = 0, second = 1, count = 0;

            //Console.WriteLine("Fibonacci Series (First 10 Numbers):");

            //do
            //{
            //    Console.Write(first + " ");
            //    int next = first + second; 
            //    first = second; 
            //    second = next; 
            //    count++; 
            //} while (count < n);

            //Console.WriteLine(); 








            //int[] numbers = { 10, 20, 30, 40, 50 }; // Sample array
            //int sum = 0;

            //foreach (int num in numbers)
            //{
            //    sum += num; // Add each element to sum
            //}

            //Console.WriteLine("Sum of array elements: " + sum);









            //int[] numbers = { 25, 78, 45, 89, 32, 99, 67 }; // Sample array
            //int max = numbers[0]; // Assume first element is the largest

            //foreach (int num in numbers)
            //{
            //    if (num > max)
            //    {
            //        max = num; // Update max if a larger number is found
            //    }
            //}

            //Console.WriteLine("Largest number in the array: " + max);







            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int originalNumber = number; // Store the original number
            //int reversedNumber = 0;

            //while (number > 0)
            //{
            //    int digit = number % 10; // Extract the last digit
            //    reversedNumber = (reversedNumber * 10) + digit; // Build the reversed number
            //    number /= 10; // Remove the last digit
            //}

            //if (originalNumber == reversedNumber)
            //{
            //    Console.WriteLine(originalNumber + " is a Palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine(originalNumber + " is not a Palindrome.");

            //}





            int rows = 5; // Number of rows for the pattern

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*"); // Print star
                }
                Console.WriteLine(); // Move to the next line after each row
            }
        }
    }
}
