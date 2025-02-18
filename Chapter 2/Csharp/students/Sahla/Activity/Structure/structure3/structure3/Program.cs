using System.ComponentModel.DataAnnotations;

namespace structure3
{
    internal class Program
    { 
   public struct Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;

        }
        public void display()
        {
            Console.WriteLine($"Id:{Id}, Name:{Name}, Salary:{Salary}");
        }
    }
    
        static void Main(string[] args)
        {
            Employee[] employe = new Employee[3];
            for (int i = 0; i < employe.Length; i++)
            {
                Console.WriteLine($"Enter the details of employees{i + 1}:");
                Console.WriteLine("Id");
                int id=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Name");
                string name=Console.ReadLine();

                Console.WriteLine("Salary");
                double salary=Convert.ToDouble(Console.ReadLine());

                employe[i]=new Employee(id, name, salary);
                Console.WriteLine();


            }
            foreach(Employee employee in employe)
            {
                employee.display();
            }
        }
    }
}
