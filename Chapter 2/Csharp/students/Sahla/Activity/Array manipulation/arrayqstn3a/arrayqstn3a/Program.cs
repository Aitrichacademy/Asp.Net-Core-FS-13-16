namespace arrayqstn3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrays = new int[3][];
            arrays[0] = new int[3] { 1, 3, 5 };
            arrays[1] = new int[2] { 2, 4 };
            arrays[2] = new int[3] { 0, 1, 2 };
            //Array.Reverse(arrays);
            int sum = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    Console.Write(arrays[i][j] + " ");
                }
                Console.WriteLine();
            }
            int max=int.MinValue;
            int maxIndex = -1;
            int rev = 0;
            Console.WriteLine("sum of each row");
            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    sum += arrays[i][j];
                    
                    if (sum > max)
                    {
                        max = sum;
                        maxIndex = i;
                    }
                }
                Console.WriteLine(sum);
                sum = 0;
               
            }
            Console.WriteLine("Maximum sum="+max);
        }
    }
}
