namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;


            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();



            //int[,] maxtrix = new int[2, 2];

            //maxtrix[0, 0] = 1;
            //maxtrix[0, 1] = 2;
            //maxtrix[1, 0] = 3;
            //maxtrix[0, 0] = 4;




            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {

            //        Console.Write(maxtrix[i, j] + " ");
            //    }
            //    Console.WriteLine(); 




            int[][] jaggedArray = new int[3][];


            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };


            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();


        }
    }

}
