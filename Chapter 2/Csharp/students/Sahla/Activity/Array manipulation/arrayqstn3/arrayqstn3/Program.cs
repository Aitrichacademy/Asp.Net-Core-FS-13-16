using System.Data.Common;

namespace arrayqstn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrays = new int[3][];
            arrays[0] = new int[] { 1, 2, 3 };
            arrays[1] = new int[] { 3, 5, 7, 9 };
            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    Console.Write(arrays[i][j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int[][] jArray = new int[rows][];
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"enter the no of columns for row{i + 1}: ");
                int cols = Convert.ToInt32(Console.ReadLine());
                jArray[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter value for row{i + 1}, column {j + 1} = ");
                    jArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"sum of each row {i} = ");
            }
            Console.WriteLine("\n Array in matrix format:");
            foreach (int[] row in jArray)
            {
                foreach (int item in row)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
