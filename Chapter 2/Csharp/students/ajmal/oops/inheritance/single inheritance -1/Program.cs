namespace single_inheritance__1
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public void Display()
            {
                Console.WriteLine($"Name: {Name}, Salary: {Salary}");
            }
        }

        class Manager : Employee
        {
            public double Bonus { get; set; }

            public Manager(string name, double salary, double bonus) : base(name, salary)
            {
                Bonus = bonus;
            }

            public void DisplayTotalEarnings()
            {
                double totalEarnings = Salary + Bonus;
                Console.WriteLine($"Name: {Name}, Salary: {Salary}, Bonus: {Bonus}, Total Earnings: {totalEarnings}");
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee("John", 50000);
            emp.Display();

            Manager mgr = new Manager("Alice", 70000, 10000);
            mgr.DisplayTotalEarnings();
        }
    }
}
