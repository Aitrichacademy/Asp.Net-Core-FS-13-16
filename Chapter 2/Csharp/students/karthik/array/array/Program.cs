using System.Runtime.ConstrainedExecution;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[10];
            //num[0] = 1; 
            //num[1] = 2; 
            //num[2] = 3;
            //num[3] = 4; 
            //num[4] = 5;

            //foreach (int n in num)
            //{
            //    Console.WriteLine(n);
            //    Console.ReadLine();
            //}


            //    string[] per = new string[5];
            //    per[0]= "poly";
            //    per[1] = "sugu";
            //    per[2] = "manu";

            //    foreach (string s in per)
            //    {
            //        Console.WriteLine(s);

            //    }
            //    Console.ReadLine();
            //}




            //int[,] num = new int[3,3];
            //num[0,0] = 1;
            //num[0,1] = 2;
            //num[0,2] = 3;
            //num[1,0] = 4;
            //num[1,1] = 5;
            //num[1,2] = 6;
            //num[2,0] = 7;
            //num[2,1] = 8;
            //num[2,2] = 9;


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(num[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();









            //int[][] num = new int[2][];
            //num[0] = new int[] { 1,2,3,4,5};
            //num[1] = new int[] {2,3,4,5};



            //for (int i = 0; i < num.Length; i++)
            //{

            //    for (int j = 0; j < num[i].Length; j++)
            //    {
            //        Console.Write(num[i][j]+ "");

            //    }
            //    Console.WriteLine();    
            //}



            //int[] arr = { 3, 5, 7, 2, 8, 1, 9 };

            //int max = arr[0];
            //int min = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num > max)
            //        max = num;

            //    if (num < min)
            //        min = num;
            //}

            //Console.WriteLine($"Maximum: {max}");
            //Console.WriteLine($"Minimum: {min}");


            //int[] arr = { 1, 2, 3, 4, 5 };

            //int start = 0;
            //int end = arr.Length - 1;

            //while (start < end)
            //{
            //    int temp = arr[start];
            //    arr[start] = arr[end];
            //    arr[end] = temp;

            //    start++;
            //    end--;
            //}

            //Console.WriteLine("Reversed Array:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}



            //int[] arr = { 3, 6, 9, 12, 15 };
            //int sum = 0;

            //foreach (int num in arr)
            //{
            //    sum += num;
            //}

            //double average = sum / (double)arr.Length;

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Average: {average}");



            //int[] arr = { 1, 2, 3, 4, 1, 2, 1, 3, 4, 1 };
            //int target = 1; // Element to count
            //int count = 0;

            //foreach (int num in arr)
            //{
            //    if (num == target)
            //        count++;
            //}

            //Console.WriteLine($"The element {target} appears {count} times.");



            int[] arr = { 5, 3, 8, 4, 2, 7, 1 };

            // Ascending Order Bubble Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            //Console.WriteLine("Sorted in Ascending Order:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            //// For Descending Order, reverse the array after sorting in ascending order
            //Array.Reverse(arr);

            //Console.WriteLine("\nSorted in Descending Order:");
            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}





                // ---------------------------- Task 1: Create and Display a 2D Array ----------------------------

                /*
                Console.Write("Enter the number of rows: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int n = int.Parse(Console.ReadLine());

                // Declare the matrix
                int[,] matrix = new int[m, n];

                // Take user input for matrix elements
                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Display the matrix
                Console.WriteLine("\nThe entered matrix is:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                */

                // ---------------------------- Task 2: Sum of All Elements in a Matrix ----------------------------

                /*
                Console.Write("Enter the number of rows: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int n = int.Parse(Console.ReadLine());

                // Declare the matrix
                int[,] matrix = new int[m, n];
                int sum = 0;

                // Take user input for matrix elements
                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                        sum += matrix[i, j];
                    }
                }

                // Display the sum of all elements
                Console.WriteLine($"\nThe sum of all elements in the matrix is: {sum}");
                */

                // ---------------------------- Task 3: Row-wise and Column-wise Sum of a Matrix ----------------------------

                /*
                Console.Write("Enter the number of rows: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int n = int.Parse(Console.ReadLine());

                // Declare the matrix
                int[,] matrix = new int[m, n];

                // Take user input for matrix elements
                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Row-wise sum
                Console.WriteLine("\nRow-wise sum:");
                for (int i = 0; i < m; i++)
                {
                    int rowSum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        rowSum += matrix[i, j];
                    }
                    Console.WriteLine($"Sum of row {i}: {rowSum}");
                }

                // Column-wise sum
                Console.WriteLine("\nColumn-wise sum:");
                for (int j = 0; j < n; j++)
                {
                    int colSum = 0;
                    for (int i = 0; i < m; i++)
                    {
                        colSum += matrix[i, j];
                    }
                    Console.WriteLine($"Sum of column {j}: {colSum}");
                }
                */

                // ---------------------------- Task 4: Find the Largest and Smallest Element in a Matrix ----------------------------

                /*
                Console.Write("Enter the number of rows: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int n = int.Parse(Console.ReadLine());

                // Declare the matrix
                int[,] matrix = new int[m, n];

                // Take user input for matrix elements
                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Find the largest and smallest element
                int max = matrix[0, 0];
                int min = matrix[0, 0];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, j] > max)
                            max = matrix[i, j];
                        if (matrix[i, j] < min)
                            min = matrix[i, j];
                    }
                }

                // Display results
                Console.WriteLine($"\nThe largest element in the matrix is: {max}");
                Console.WriteLine($"The smallest element in the matrix is: {min}");
                */

                // ---------------------------- Task 5: Transpose of a Matrix ----------------------------

                Console.Write("Enter the number of rows: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of columns: ");
                int n = int.Parse(Console.ReadLine());

                // Declare the matrix
                int[,] matrix = new int[m, n];

                // Take user input for matrix elements
                Console.WriteLine("Enter the elements of the matrix:");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                // Transpose the matrix
                Console.WriteLine("\nThe transpose of the matrix is:");
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

    }


