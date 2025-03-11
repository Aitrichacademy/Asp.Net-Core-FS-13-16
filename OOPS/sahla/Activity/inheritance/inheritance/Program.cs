namespace inheritance
{
    internal class Program
    {
        public class Employee
        {
            public string Name { get; set; }
            public double salary {  get; set; }
            public Employee(string name, double salary)
            {
                Name = name;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine($"Employee: {Name}, Salary : {salary:C}");
            }
        }
        class Manager : Employee
        {
            public double Bonus { get; set; }

            public Manager(string name, double salary,double bonus):base (name,salary)
            {
                Bonus = bonus;
            }
            public  void display()
            {
                double total = salary + Bonus;
                Console.WriteLine($"Manager: {Name},Total Earnings: {total}(Salary:{salary:C}+ Bonus: {Bonus:C})");
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", 50000);
            emp.display();

            Manager mng = new Manager("Alan", 70000, 15000);
            mng.display();
        }
    }
}
