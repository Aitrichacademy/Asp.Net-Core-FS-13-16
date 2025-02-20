namespace structure
{
    internal class Program
    {
        public struct student
        {
            public string name;
            public int age;
            public int mark;

            public student(string name, int age, int mark)
            {
                this.name = name;
                this.age = age;
                this.mark = mark;
            }
            public void display()
            {
                Console.WriteLine($"Name:{name},age:{age},mark:{mark};");
            }
        }




        static void Main(string[] args)
        {
            student student1;
            student1.name = "sahana";
            student1.age = 23;
            student1.mark = 90;
            student1.display();
            //structure  multiple namelek loop cheyyum

            student student2 = new student("sahana", 30, 40);
            student2.display();



            //question

        }
    }
    }

