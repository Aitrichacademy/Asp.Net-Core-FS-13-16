using System.ComponentModel.DataAnnotations;

namespace studentDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Karthik";
            int age = 21;
            char grade = 'D';
            double weight = 1.3;
            Console.WriteLine("name : "+ name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("grade : " + grade);
            Console.WriteLine("weight : " + weight);
            //Console.WriteLine("Hello, World!");
            
            Console.WriteLine();
            string fName = "karthik";
            string lName = "panthayil";
            Console.WriteLine("fullname = "+fName+" "+lName);
            Console.WriteLine();
            int num = 10;
            string myNum = num.ToString()+"www";
            Console.WriteLine(myNum);
            Console.WriteLine();


            int num1 = 10;
            int num2 = 20;
            int sum=(num1+num2);
            Console.WriteLine("sum = "+sum);
            Console.WriteLine();
            Console.WriteLine();


            //Console.Write("enter the first number : ");
            //int numb1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter the second number : ");
            //int numb2 = Convert.ToInt32(Console.ReadLine());

            //int rem = numb1 % numb2;
            //Console.WriteLine("reminder : " + rem);


            object name1 = "karthik";
            object age1 = 21;
            object pi1 = 1.3;
            object grade1 = 'A';

            Console.WriteLine(name1);
            Console.WriteLine(age1);
            Console.WriteLine(pi1);
            Console.WriteLine(grade1);
            Console.WriteLine();
            Console.WriteLine($"{name1}\n{age1}\n{pi1}\n{grade1}");
            Console.WriteLine();

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in number) 
            {
                Console.WriteLine(item);
            }





        }
    }
}
