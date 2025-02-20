using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace _2nd_program
{
    internal class Program

    {
       

        static void Main(string[] args)
        {
            int age = 23;
            Console.WriteLine("The age is"+age);
            double pi = 3.14;
            Console.WriteLine("the value of pi is"+pi);
            bool postive (int number)
            {
                return (number > 0);
            }
            Console.WriteLine(postive(3));
            char grade = 'A';
            Console.WriteLine(grade);
            string name = "shajan";
            Console.WriteLine(name);
            

            object Name = "aju";
            object Age = 23;
            object mark = 43;

            //Console.WriteLine($"{Name} {Age} {mark}\n");
           Console.WriteLine( Name);
            Console.WriteLine(age);
            Console.WriteLine(mark);

            string[] myname = { "karthik", "ajmal", };
            foreach (string item in myname)
            {
                Console.WriteLine(item);

               
            }
        }
    }
}

