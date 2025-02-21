using System.ComponentModel.DataAnnotations;

namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;
            numbers[1, 0] = 4;
            numbers[1, 1] = 5;
            numbers[1, 2] = 6;
            numbers[2, 0] = 7;
            numbers[2, 1] = 8;
            numbers[2, 2] = 9;
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            //maximum,minimum and sum program
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(numbers[i, j] + " ");
                    sum += numbers[i, j];
                    if (numbers[i,j]>max)
                    {
                        max = numbers[i,j];
                    }
                    if (numbers[i,j]<min)
                    {
                        min=numbers[i,j];
                    }
                }
                Console.WriteLine();
               
            }
            Console.WriteLine("Largest element = "+max);
            Console.WriteLine("Smallest = "+min);
            Console.WriteLine("SUM = " +sum);
            sum= 0;
            int[,] transpose = new int[3,3];
                //sum of each row
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += numbers[i, j];
                    transpose[j,i]=numbers[i,j];    
                }
                Console.WriteLine("sum of row"+i+"="+sum);
                sum= 0;
            }
            //transpose program
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    transpose[j, i] = numbers[i, j];
                }
            }
            Console.WriteLine("Transpose of the matrix:");
            for (int i = 0;i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.WriteLine(transpose[j,i]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
