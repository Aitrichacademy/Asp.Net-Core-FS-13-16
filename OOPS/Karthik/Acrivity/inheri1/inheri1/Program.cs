namespace inheri1
{
    internal class Program
    {
        class Employee
        {
            public string Name;
            public double Salary;
        }

        class Manager : Employee
        {
            public double Bonus;

            public void ShowTotalEarnings()
            {
                Console.WriteLine(Name + "'s Total Earnings: " + (Salary + Bonus));
            }
        }

        
            static void Main()
            {
                Manager mgr = new Manager();
                mgr.Name = "Poly";
                mgr.Salary = 50000;
                mgr.Bonus = 10000;

                mgr.ShowTotalEarnings();
            }
        }
    }

