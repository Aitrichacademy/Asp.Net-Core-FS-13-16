using System.Diagnostics;

namespace Structure
{
    internal class Program
    {
        //    public struct student
        //    {
        //        public string title;
        //        public string author;
        //        public double price;

        //        public student(string title, string author, double price)
        //        {
        //            this.title = title;
        //            this.author = author;
        //            this.price = price;
        //        }

        //        public void display()
        //        {
        //            Console.WriteLine($"title: {title},\nauthor : {author},\nprice: {price}");
        //        }
        //    }
        //    static void Main(string[] args)
        //    {
        //        student student1;
        //        student1.title = "sree";
        //        student1.author = "ajmal";
        //        student1.price = 12;
        //        student1.display();
        //    }
        //}

        //student student2 = new student("Sree", "ajmal", 12);
        //student2.display();




        //struct Rectangle
        //{
        //    public double Length;
        //    public double Width;

        //    // Constructor to initialize Length and Width
        //    public Rectangle(double length, double width)
        //    {
        //        Length = length;
        //        Width = width;
        //    }

        //    // Method to calculate the area of the rectangle
        //    public double GetArea()
        //    {
        //        return Length * Width;
        //    }
        //}



        //    static void Main()
        //    {
        //        // Accept Length and Width from the user
        //        Console.Write("Enter the length of the rectangle: ");
        //        double length = double.Parse(Console.ReadLine());

        //        Console.Write("Enter the width of the rectangle: ");
        //        double width = double.Parse(Console.ReadLine());

        //        // Create a Rectangle instance with user input
        //        Rectangle rect = new Rectangle(length, width);

        //        // Calculate the area using GetArea method
        //        double area = rect.GetArea();

        //        // Print the area of the rectangle
        //        Console.WriteLine($"\nThe area of the rectangle is: {area}");
        //    }


        //struct Employee
        //{
        //    public int ID;
        //    public string Name;
        //    public double Salary;

        //    public Employee(int id, string name, double salary)
        //    {
        //        ID = id;
        //        Name = name;
        //        Salary = salary;
        //    }

          
        //    public void DisplayEmployeeInfo()
        //    {
        //        Console.WriteLine($"ID: {ID}");
        //        Console.WriteLine($"Name: {Name}");
        //        Console.WriteLine($"Salary: ${Salary:F2}");
        //    }
        //}


        //static void Main()
        //{
            
        //    Employee[] employees = new Employee[3];

            
        //    for (int i = 0; i < 2; i++)
        //    {
        //        Console.WriteLine($"\nEnter details for Employee {i + 1}:");

        //        Console.Write("Enter ID: ");
        //        int id = int.Parse(Console.ReadLine());

        //        Console.Write("Enter Name: ");
        //        string name = Console.ReadLine();

        //        Console.Write("Enter Salary: ");
        //        double salary = double.Parse(Console.ReadLine());

                
        //        employees[i] = new Employee(id, name, salary);
        //    }

            
        //    Console.WriteLine("\nEmployee Details:");
        //    for (int i = 0; i < employees.Length; i++)
        //    {
        //        Console.WriteLine($"\nEmployee {i + 1}:");
        //        employees[i].DisplayEmployeeInfo();
        //    }






        

struct Student
    {
        public int RollNumber;
        public string Name;
        public double Marks;

       
        public Student(int rollNumber, string name, double marks)
        {
            RollNumber = rollNumber;
            Name = name;
            Marks = marks;
        }

        
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks:F2}");
        }
    }

   
        static void Main()
        {
           
            Student[] students = new Student[2];

            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("Enter Roll Number: ");
                int rollNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Marks: ");
                double marks = double.Parse(Console.ReadLine());

                
                students[i] = new Student(rollNumber, name, marks);
            }

            
            Array.Sort(students, (x, y) => y.Marks.CompareTo(x.Marks));

            
            Console.WriteLine("\nSorted Student Details (Based on Marks in Descending Order):");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");
                students[i].DisplayStudentInfo();
            }
        }
    }

}




    
