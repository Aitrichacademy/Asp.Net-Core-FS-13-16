namespace structure5
{
    internal class Program
    {
        public struct Company
        {
            public string CompanyName;
            public Department Dept;
            public struct Department
            {
                public string DeptName;
                public string manager;
            }
            public void display()
            {
                Console.WriteLine($"Company Name:{CompanyName}");
                Console.WriteLine($"Department:{Dept.DeptName}");
                Console.WriteLine($"Manager :{Dept.manager}");
      
            }
        }
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.Write($"Enter the company name:");
            company.CompanyName=Console.ReadLine();

            Console.WriteLine($"Enter the Department:");
            company.Dept.DeptName=Console.ReadLine();

            Console.Write($"Enter Manager Name : ");
            company.Dept.manager = Console.ReadLine();
           
             company.display();
        }
    }
}
