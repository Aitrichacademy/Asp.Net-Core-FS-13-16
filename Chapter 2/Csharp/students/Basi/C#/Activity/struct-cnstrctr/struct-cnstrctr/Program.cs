namespace struct_cnstrctr
{
    internal class Program
    {
        public struct Employee
        {
            public int ID;
            public string Name;
            public double Salary;

            // Constructor to initialize the fields
            public Employee(int id, string name, double salary)
            {
                this.ID = id;
                this.Name = name;
                this.Salary = salary;
            }

            // Method to display employee details
            public void Display()
            {
                Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary}");
            }
        }

        static void Main(string[] args)
        {
            // Create an array of employees
            Employee employee1;
            employee1.ID = 1;
            employee1.Name = "Alice";
            employee1.Salary = 50000;
            employee1.Display();

            Employee employee2 = new Employee(2, "Bob", 60000);
            employee2.Display();

            Employee employee3 = new Employee(3, "Charlie", 70000);
            employee3.Display();
        }
    }
}
