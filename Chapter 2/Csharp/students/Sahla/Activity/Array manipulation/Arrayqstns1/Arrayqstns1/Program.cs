using System.Diagnostics.CodeAnalysis;

namespace Arrayqstns1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            int n=marks.Length;
            int[] temp = new int[n];
            marks[0] = 91;
            marks[1] = 58;
            marks[2] = 91;
            marks[3] = 72;
            marks[4] = 23;
            Console.WriteLine("Maximum ="+marks.Max());
            Console.WriteLine("Minimum="+marks.Min());
            int sum = 0;
            int count = 0;
            int target = 91;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(marks[i]);
                temp[i] = marks[n-i-1];
                sum += temp[i];
                if(marks[i] == target)
                {
                    count++;
                }

            }
            Console.WriteLine("count occurence of given target= "+count);
            Console.WriteLine("reverse of array");
            for (int i = 0; i < n; i++)
            {
                marks[i] = temp[i];
                Console.WriteLine(marks[i]);
            }
            int avg=sum/n;
            Console.WriteLine("sum of array elements:"+sum);
            Console.WriteLine("Average:"+avg);
            for (int i = 0;i < n; i++)
            {
                for (int j = 0; j < (n-i-1); j++)
                {
                    if (marks[j] > marks[j+1])
                    { 
                        int res=marks[j];
                        marks[j] = marks[j+1];
                        marks[j+1]=res;
                    }
                }
            }
            Console.WriteLine(marks);
            
        }
    }
}
