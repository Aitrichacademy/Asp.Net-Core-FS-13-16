namespace array_strct_wd_sorting
{
    internal class Program
    {
        public struct Student
        {
            public int RollNumber;
            public string Name;
            public double Marks;

            // Constructor to initialize the fields
            public Student(int rollNumber, string name, double marks)
            {
                this.RollNumber = rollNumber;
                this.Name = name;
                this.Marks = marks;
            }

            // Method to display student details
            public void Display()
            {
                Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, Marks: {Marks}");
            }
        }

        static void Main(string[] args)
        {
            // Create an array of students
            Student[] students = new Student[5];

            // Accept details for 5 students
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.Write("Roll Number: ");
                int rollNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Marks: ");
                double marks = Convert.ToDouble(Console.ReadLine());

                // Assign the student details
                students[i] = new Student(rollNumber, name, marks);
            }

            // Sort students based on Marks in descending order
            Array.Sort(students, (s1, s2) => s2.Marks.CompareTo(s1.Marks));

            // Display the sorted list of students
            Console.WriteLine("\nSorted Student Details (by Marks):");
            foreach (var student in students)
            {
                student.Display();
            }
        }
    }
}
