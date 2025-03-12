using System.ComponentModel.DataAnnotations;

namespace inhrtnc_Actvty
{
    internal class Program
    {
        class employee
        {
            public string Name {  get; set; }
            public double Salary { get; set; }

            public employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public void DisplayDetails()
            {
                Console.WriteLine($"Employee Name : {Name}");
                Console.WriteLine($"Salary : {Salary}");
            }
        }

        class Manager : employee

        {
            public double Bonus { get; set; }
            public Manager(double bonus, string name, double salary) : base(name, salary)
            {
                this.Bonus = bonus;
            }

            public void DisplayTotalEarnings ()
            {
                double totalearnings = Salary + Bonus ;
                Console.WriteLine($"Total earnings (Salary + Bonus) : {totalearnings}");
            }
        }

        class program
        { 
        static void Main()
            {
                Manager mngr = new Manager (20000, "Basi" , 75000);
                mngr.DisplayDetails();
                mngr.DisplayTotalEarnings();
            }
        }
    }
}
