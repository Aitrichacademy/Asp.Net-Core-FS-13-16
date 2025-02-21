using System.ComponentModel.DataAnnotations;

namespace arrayquestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] n = { 1, 2, 3, 6, 5, 6, 7, 8, 9, 10 };
            //int i = n.Max(x => x);
            //int j = n.Min(x => x);
            //Console.WriteLine("minmum is :" + j);
            //Console.WriteLine("maximum is :" + i);


            //string[] n = { "apple", "banana", "orange", "pinapple" };
            //for (int i = 0; i < n.Length; i++)
            //{
            //    Console.WriteLine(n[i]);


            //    for (int j = 0; args.Length > i; i--)
            //    {
            //        Console.WriteLine(args[i]);
            //    }
            //}

            //int[] n = { 1, 2, 3};

            //int sum = 0;
            //int j = 1;

            //foreach (int i in n)
            //{
            //    sum += i;
            //    j = sum / n.Length;
            //    Console.WriteLine("total sum "+sum);
            //    Console.WriteLine(j);
            //}





            //int[] i = {1,2,3,4,4,2,6,4};
            //Console.WriteLine("enter the number");
            //int target=int.Parse(Console.ReadLine());
            //int count = 0;

            //foreach(int x in i)
            //{
            //    if(x == target) count++;

            //}
            //Console.WriteLine($"the number{target} apperas  {count}  times in the array");


            //multidimentional array
            //2)
            //    Console.Write("enter the rows :");
            //    int m=int.Parse(Console.ReadLine());

            //    Console.Write("enter thw coloms :");
            //    int n=int.Parse(Console.ReadLine());

            //    int[,] metrix= new int[m, n];
            //    int sum = 0;
            //    Console.WriteLine("enter the metrix elements");
            //    for(int i=0; i<m; i++)
            //    {
            //        for(int j=0; j<n; j++)
            //        {
            //            Console.Write($"element[{i},{j}]:");
            //            metrix[i, j] = int.Parse(Console.ReadLine());
            //            sum += metrix[i, j];
            //        }
            //        Console.WriteLine("$sum of all metrix :{sum}");

            //    }

            int[,] i = new int[2, 2];
            i[0, 0] = 1;
            i[0, 1] = 2;
            i[1, 0] = 3;
            i[1, 1] = 4;
            
           


        }
        

      
    }
    
}
