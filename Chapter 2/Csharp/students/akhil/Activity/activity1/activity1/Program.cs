namespace activity1
{
    internal class Program
    {
        static void Main(string[] args)
            {
            
                int[] numbers = { 12, 53, 23, 56, 0, 45, 67, 5 };

            
                int min = numbers[0];
                int max = numbers[0];

                foreach (int num in numbers)
                {
                    if (num < min)
                        min = num;

                    if (num > max)
                        max = num;
                }

            
                Console.WriteLine($"Minimum value: {min}");
                Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine();

             int[] count = { 12, 5, 23, 1, 45, 3, 8, 20 };
        
        int evenCount = 0, oddCount = 0;
        
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

            
        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");
            }
        }

    }


