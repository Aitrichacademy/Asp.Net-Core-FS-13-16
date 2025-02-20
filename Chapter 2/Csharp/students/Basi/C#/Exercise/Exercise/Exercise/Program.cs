namespace Exercise
{
    internal class Program
    {

        class JobPortal
        {
            static string registeredEmail = "basi@";
            static string registeredPassword = "45";

            static void Main()
            {
                Console.WriteLine("Welcome to the job portal!");

                while (true)
                {
                    Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    if (choice == "2") // Login
                    {
                        if (Login())
                        {
                            JobSeekerMenu();
                        }
                    }
                    else if (choice == "3") // Exit
                    {
                        Console.WriteLine("Goodbye!");
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
                string email = Console.ReadLine();
                Console.Write("Please enter your password: ");
                string password = Console.ReadLine();

                if (email == registeredEmail && password == registeredPassword)
                {
                    Console.WriteLine("Login successful!");
                    Console.WriteLine($"Welcome {email}!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid email or password. Try again.");
                    return false;
                }
            }

            static void JobSeekerMenu()
            {
                List<string> jobs = new List<string>
        {
            "1. Software Engineer | 3+ years | Acme Inc. | New York, NY | $100,000 - $150,000",
            "2. Product Manager | 5+ years | Globex Corp. | San Francisco, CA | $120,000 - $180,000",
            "3. Marketing Specialist | 2+ years | Hooli Enterprises | Seattle, WA | $70,000 - $90,000"
        };

                while (true)
                {
                    Console.WriteLine("\n1. List all jobs\n2. My profile\n3. Logout");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    if (choice == "1") // Show Jobs
                    {
                        Console.WriteLine("\nJobs available:");
                        foreach (string job in jobs)
                        {
                            Console.WriteLine(job);
                        }
                    }
                    else if (choice == "3") // Logout
                    {
                        Console.WriteLine("Logged out successfully!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                    }
                }
            }
        }
    }
}