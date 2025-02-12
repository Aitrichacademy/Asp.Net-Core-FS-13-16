namespace structure_constructor
{
    internal class Program
    {
        struct Employee
        {
            public int ID;
            public string Name;
            public double Salary;

            
            public Employee(int id, string name, double salary)
            {
                ID = id;
                Name = name;
                Salary = salary;
            }

           
            public void Display()
            {
                Console.WriteLine($"ID: {ID}, Name: {Name}, Salary: {Salary:C}");
            }
        }

        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

               
                employees[i] = new Employee(id, name, salary);
            }

            
            Console.WriteLine("\nEmployee Details:");
            foreach (Employee emp in employees)
            {
                emp.Display();
                Console.ReadLine();
            }
        }
    }
}
    

