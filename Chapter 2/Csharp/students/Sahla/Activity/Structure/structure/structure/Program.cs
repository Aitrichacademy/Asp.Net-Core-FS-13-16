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
                Console.WriteLine($"Name: {name},age: {age},mark:{mark}");
            }
        }
        static void Main(string[] args)
        {
            //student student1;
            //student1.name = "sahla";
            //student1.age = 22;
            //student1.mark = 99;
            //student1.display();


            student student2 = new student("sahla",22,99);
            student2.display();
        }
    }
}
