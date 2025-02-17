using System;

namespace Exercise_2
{
    internal class Program
    {
        static string email = "kps@";
        static string password = "123";
        static CompanyMember[] companyMembers = new CompanyMember[10];
        static int memberCount = 0; 

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hire Me Now Job portal!");

            while (true)
            {
                Console.WriteLine("\n1. Login");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (Login())
                    {
                        ShowMenu();
                    }
                }
                else if (choice == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }

        static bool Login()
        {
            Console.Write("\nPlease enter your email: ");
            string inputEmail = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string inputPassword = Console.ReadLine();

            if (inputEmail == email && inputPassword == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid credentials. Try again.");
                return false;
            }
        }

        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. List all company members");
                Console.WriteLine("2. Add company members");
                Console.WriteLine("3. Logout");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ListMembers();
                }
                else if (choice == "2")
                {
                    AddMember();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Logging out...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }

        static void ListMembers()
        {
            Console.WriteLine("\nCompany Members:");
            Console.WriteLine("UserId | Name    | Designation        | Email             | Phone");
            Console.WriteLine("---------------------------------------------------------------");

            if (memberCount == 0)
            {
                Console.WriteLine("No members found.");
            }
            else
            {
                for (int i = 0; i < memberCount; i++)
                {
                    var member = companyMembers[i];
                    Console.WriteLine($"{i + 1}      | {member.Name} | {member.Designation} | {member.Email} | {member.Phone}");
                }
            }
        }

        static void AddMember()
        {
            if (memberCount >= companyMembers.Length)
            {
                Console.WriteLine("Member limit reached. Cannot add more members.");
                return;
            }

            Console.Write("\nPlease enter company member name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter email: ");
            string email = Console.ReadLine();

            Console.Write("Please enter Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Please enter your phone number: ");
            string phone = Console.ReadLine();

            companyMembers[memberCount] = new CompanyMember(name, email, designation, phone);
            memberCount++;
            Console.WriteLine("Registration successful");
        }
    }

    class CompanyMember
    {
        public string Name;
        public string Email;
        public string Designation;
        public string Phone;

        public CompanyMember(string name, string email, string designation, string phone)
        {
            Name = name;
            Email = email;
            Designation = designation;
            Phone = phone;
        }
    }
}
