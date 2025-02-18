namespace maxMinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] numbers = { 12, 5, 78, 3, 45, 89, 2, 56 };

            int max = numbers[0];
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;

                if (num < min)
                    min = num;
            }

            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");
        }
    }
}
