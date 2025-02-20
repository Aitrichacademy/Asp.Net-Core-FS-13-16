namespace oddEvenCOunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int even = 0, odd = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine($"Even numbers count: {even}");
            Console.WriteLine($"Odd numbers count: {odd}");


            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int length = number.Length;

           
            for (int i = 0; i < length / 2; i++)
            {
                int temp = number[i];
                number[i] = number[length - i - 1];
                number[length - i - 1] = temp;
            }

           
            Console.WriteLine("Reversed Array:");
            foreach (int num in number)
            {
                Console.Write(num + " ");
            }
        }
    }
}
