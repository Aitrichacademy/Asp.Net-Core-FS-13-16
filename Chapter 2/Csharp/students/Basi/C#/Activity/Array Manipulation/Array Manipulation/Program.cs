
using System.Xml.Linq;

namespace Array_Manipulation
{
    internal class Program
    {
    
        static void Main()
        {

            //1.Find the Maximum and Minimum Element

            //int[] arr = { 10, 25, 7, 90, 45, 3 };
            //int max = arr[0], min = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num > max) max = num;
            //    if (num < min) min = num;
            //}

            //Console.WriteLine($"Maximum: {max}, Minimum: {min}");

            //2.•	Reverse an Array

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int n = arr.Length;

            //for (int i = 0; i < n / 2; i++)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[n - 1 - i];
            //    arr[n - 1 - i] = temp;
            //}

            //Console.WriteLine("Reversed Array: " + string.Join(", ", arr));

            //3.•	Sum and Average of Array Elements

            //int[] arr = { 5, 10, 15, 20 };

            //Console.WriteLine("Sum: " + arr.Sum());
            //Console.WriteLine("Average: " + arr.Average());

            //4.•	Count Occurrences of an Element

            //int[] arr = { 2, 3, 4, 3, 2, 3, 5 };
            //int target = 3;

            //Console.WriteLine($"Number {target} appears {arr.Count(x => x == target)} times.");

            //5•	Sort an Array  

            int[] arr = { 5, 1, 4, 2, 8 };

            Console.WriteLine("Ascending: " + string.Join(", ", arr.OrderBy(x => x)));
            Console.WriteLine("Descending: " + string.Join(", ", arr.OrderByDescending(x => x)));
        }
    }
}
