namespace examples
{
    internal class Program
    {
        interface Persons
        {
            void display();
        }
        class Person : Persons
        {
            public int id;
            public string Name;
            public int age;
            public void display()
            {
                Console.WriteLine($"Id:{id},Name:{Name},Age:{age}");
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            int even = 0;
            int odd = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    odd += 1;
                }
                Console.WriteLine(num);
            }
            //Person p1 = new Person();
            //p1.Name = "John";
            //p1.id = 1;
            //p1.age = 23;
            //p1.display();

            List<int> num1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> num2 = num1;
            num2.Add(6);
            num2.Remove(5);

            Dictionary<int, string> Students = new Dictionary<int, string>();
            Students.Add(1, "Sahana");
            Students.Add(2, "Sahla");
            Students.Add(3, "Karthik");
            Students.Add(4, "Akhil");
            Students.Add(5, "Basith");
            Students.Add(6, "Ajmal");
            Students.Add(7, "Arjun");

            Console.WriteLine("Student Names :");
            foreach (var item in Students)
            {
                Console.WriteLine($"Id : {item.Key} Name : {item.Value}");
            }

            Console.WriteLine("Enter your Mark");
            int mark=Convert.ToInt32( Console.ReadLine() );
            

        }
    }
    }
}
