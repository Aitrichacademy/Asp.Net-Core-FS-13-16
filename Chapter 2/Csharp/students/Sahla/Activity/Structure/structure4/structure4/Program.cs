namespace structure4
{
    internal class Program
    {
        public struct Student
        {
            public int Rollno;
            public string Name;
            public double mark;

            public Student(int rollno, string name, double mark)
            {
                this.Rollno = rollno;
                this.Name = name;
                this.mark = mark;
            }
            public void display()
            {
                Console.WriteLine($"Roll No:{Rollno},Name:{Name},mark:{mark}");
            }
        }
        static void Main(string[] args)
        {
            Student[] student1 = new Student[5];
            for (int i = 0; i < student1.Length; i++)
            {
                Console.WriteLine($"Enter the details of student {i+1}:");
                Console.WriteLine("Roll No:");
                int rollno=Convert.ToInt32( Console.ReadLine() );

                Console.WriteLine("Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Mark:");
                double mark = Convert.ToDouble( Console.ReadLine() ) ;

                student1 [i] = new Student(rollno, name, mark);
                Console.WriteLine();
            }
            student1=student1.OrderByDescending(x => x.mark).ToArray();
            foreach (Student student in student1)
            {
                student.display();
            }
        }
    }
}
