using System.ComponentModel.Design;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 4 ) 
                        Console.Write(i);
                    else if (j == i)
                        Console.Write(i);
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
