using System;

struct Employee
{
    public int EmployeeID;
    public string Name;
    public double Salary;
}

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[5];

        
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Enter the details of Employee {i + 1}:");

            Console.Write("Enter EmployeeID: ");
            employees[i].EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            employees[i].Name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            employees[i].Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
        }

        
        double highest = employees[0].Salary;
        double lowest = employees[0].Salary;

        
        foreach (Employee employee in employees)
        {
            if (employee.Salary > highest)
                highest = employee.Salary;

            if (employee.Salary < lowest)
                lowest = employee.Salary;
        }

        
        Console.WriteLine("Details of the Employees:");
        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"EmployeeID: {employees[i].EmployeeID}, Name: {employees[i].Name}, Salary: {employees[i].Salary}");
        }

        Console.WriteLine($"Highest Salary: {highest}");
        Console.WriteLine($"Lowest Salary: {lowest}");
    }
}
