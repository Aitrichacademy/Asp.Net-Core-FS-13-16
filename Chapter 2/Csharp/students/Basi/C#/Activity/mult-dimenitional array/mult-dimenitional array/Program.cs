namespace mult_dimenitional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

 //1.2d Array

            //int[,] matrix = { { 1, 2 }, { 3, 4 } };

            //Console.WriteLine("Matrix:");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

//2.Sum of all elements

            //int[,] matrix = { { 1, 2 }, { 3, 4 } };
            //int sum = 0;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        sum += matrix[i, j];
            //    }
            //}

            //Console.WriteLine("Sum: " + sum);

//3.row and coloumn

            //int[,] matrix = { { 1, 2 }, { 3, 4 } };

            //Console.WriteLine("Row-wise Sum:");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(matrix[i, 0] + matrix[i, 1]);
            //}

            //Console.WriteLine("Column-wise Sum:");
            //for (int j = 0; j < 2; j++)
            //{
            //    Console.WriteLine(matrix[0, j] + matrix[1, j]);

            //}

//4.max and min in  a matrix

            //int[,] matrix = { { 1, 2 }, { 3, 4 } };

            //int max = matrix[0, 0], min = matrix[0, 0];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        if (matrix[i, j] > max) max = matrix[i, j];
            //        if (matrix[i, j] < min) min = matrix[i, j];
            //    }
            //}

            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Min: " + min);

//5.Transpose of a Matrix

            int[,] matrix = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("Transpose:");
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}