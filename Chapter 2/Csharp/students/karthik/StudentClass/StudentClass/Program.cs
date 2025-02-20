namespace StudentClass
{
    internal class Program
    {
        interface Students
        {
            void view();
            
        }

        class Student : Students
        {
            public string Name;
            public int Age;

            public void view()
            {
                Console.WriteLine("Student Details:");
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");

            }
        }



            static void Main(string[] args)
            {

                Student student1 = new Student();
                student1.Name = "AKHIL POLY";
                student1.Age = 21;
            student1.view(); 



            }
        }
    }


