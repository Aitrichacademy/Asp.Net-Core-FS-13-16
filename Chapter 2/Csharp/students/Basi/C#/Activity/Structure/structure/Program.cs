using System.Net;

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
                Console.WriteLine($"name:{name},age:{age},mark:{mark}");
            }

        }
            static void Main(string[] args)
            {
                student student1;
                student1.name = "basi";
                student1.age = 23;
                student1.mark = 42;
                student1.display();

                student student2 = new student("shl",18,89);
                student2.display();

            }
        
    }
}
