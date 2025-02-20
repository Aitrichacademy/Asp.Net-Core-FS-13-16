namespace jobProvider1
{
    internal class Program
    {
        public struct Registration
        {
            public string ID;
            public DateOnly Date;
            public string Company;
            public string type;
            public string Position;
            public string status;

            public Registration(int Id,DateOnly Date,string Company,string type,string position,string status)
            {
                ID = Id;
                Date=Date;
                Company = Company;
                type = type;
                Position = position;
                status = status;
            }
            public override string ToString()
            {
                return $"Id:{ID},Date:{Date},Company:{Company},Type:{type},Position:{Position},Status:{status}";
            }
        }
        static Registration[] register = new Registration[8];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hire me now job portal!");
            Console.WriteLine("1.Login");
            Console.WriteLine("Select any option:");
            Console.ReadLine();
            Console.WriteLine("please enter your email:");
            Console.ReadLine();
            Console.WriteLine("Please enter your password");
            Console.ReadLine();
            Console.WriteLine("Login Successful!");
            Console.WriteLine();
            do
            {
                Console.WriteLine("choose an option:");
                Console.WriteLine("1.New registration");
                Console.WriteLine("2.List all job seekers");
                Console.WriteLine("3.Search job seekers");
                Console.WriteLine("4.Logout");
                string ch= Console.ReadLine();
                switch(ch)
                {
                    case "1":
                        {
                            Console.WriteLine("ID          |Date Applied          |Company         |Type           |Positon              |Status");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------");
                            Console.WriteLine("APL-03323   |June 1 2022,10:23AM   |TCS             |FREELANCE      |Intern UI Designer   |Pending");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------");
                            Console.WriteLine("APL-05678   |JUNE 2 2022.10;43AM   |AITRICH         |PART TIME      |Junior UX Designer   |on-hold");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------");
                            Console.WriteLine("APL-05678   |JUNE 2 2022.10;43AM   |Microsoft       |PART TIME     |Junior UX Designer   |candidate");
                            Console.WriteLine("--------------------------------------------------------------------------------------------------");
                            Console.WriteLine("APL-05678   |JUNE 2 2022.10;43AM   |Wipro           |FREE LANCE    |Senior UX Designer   |Pending");


                        }
                        newRegistration();
                        break;
                    case "2":Console.WriteLine("2. List all job seekers");
                        break;
                    case "3":Console.WriteLine("3.Search job seekers");
                        break;
                    case "4":Console.WriteLine("4. Logout");
                        break;
                }
            }
            while (true);
            Console.WriteLine();
            static void newRegistration()
            {
                Console.WriteLine("ID          |Date Applied          |Company         |Type           |Positon              |Status");
                Console.WriteLine("-------------------------------------------------------------------------------------------------");

                foreach (var reg in register)
                {
                    Console.WriteLine(reg.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
