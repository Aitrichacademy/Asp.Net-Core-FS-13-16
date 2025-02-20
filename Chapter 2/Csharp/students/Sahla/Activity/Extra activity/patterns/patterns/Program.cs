namespace patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            for (int i = 1;i <= 6;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine(" ");
            }

            Console.WriteLine();
            int n = 6;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < 2*i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (2 * (n-i)- 1); k++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
