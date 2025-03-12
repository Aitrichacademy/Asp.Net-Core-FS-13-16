using System;

namespace Inheritence1
{
    class Employee
    {
        public string Name;
        public double Salary;
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    class Manager : Employee
    {
        public double Bonus;
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public void DisplayTotalEarnings()
        {
            Console.WriteLine($"Total Earnings: {Salary + Bonus}");
        }
    }
}