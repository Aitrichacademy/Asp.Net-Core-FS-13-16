using System;

struct CompanyMember
{
    public int UserId;
    public string Name;
    public string Designation;
    public string Email;
    public string Phone;

    public CompanyMember(int userId, string name, string designation, string email, string phone)
    {
        UserId = userId;
        Name = name;
        Designation = designation;
        Email = email;
        Phone = phone;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{UserId,-10} | {Name,-15} | {Designation,-20} | {Email,-25} | {Phone,-15}");
    }
}

class JobPortal
{
    static CompanyMember[] companyMembers = new CompanyMember[10]; 
    static int memberCount = 0; 

    static void Main()
    {
        Console.WriteLine("Welcome to the Hire Me Now Job portal!\n");

        
        Console.WriteLine("1. Login");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("\nPlease enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (email == "ahamedajmal7372@gmail.com" && password == "ahamed7372")
            {
                Console.WriteLine("Login successful!\n");
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Invalid credentials. Exiting...");
            }
        }
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n1. List all company members");
            Console.WriteLine("2. Add company members");
            Console.WriteLine("3. Logout");
            Console.Write("Enter your choice: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCompanyMembers();
                    break;
                case 2:
                    AddCompanyMember();
                    break;
                case 3:
                    Console.WriteLine("Logging out...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void ListCompanyMembers()
    {
        Console.WriteLine("\nCompany Members:");
        Console.WriteLine("UserId    | Name           | Designation          | Email                    | Phone");
        Console.WriteLine("----------------------------------------------------------------------------------------");

        if (memberCount == 0)
        {
            Console.WriteLine("No members found.");
        }
        else
        {
            for (int i = 0; i < memberCount; i++)
            {
                companyMembers[i].DisplayInfo();
            }
        }
    }

    static void AddCompanyMember()
    {
        if (memberCount >= companyMembers.Length)
        {
            Console.WriteLine("Member limit reached. Cannot add more.");
            return;
        }

        Console.Write("\nPlease enter company member name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter email: ");
        string email = Console.ReadLine();
        Console.Write("Please enter Designation: ");
        string designation = Console.ReadLine();
        Console.Write("Please enter phone number: ");
        string phone = Console.ReadLine();

        companyMembers[memberCount] = new CompanyMember(memberCount + 1, name, designation, email, phone);
        memberCount++;

        Console.WriteLine("Registration successful!");
    }
}
