namespace ConsoleApp1
{


    namespace AdminProfileManagement
    {
        
        struct AdminProfile
        {
            public string Name;
            public string Username;
            public string Email;
            public string Phone;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                
                AdminProfile admin = new AdminProfile();

                
                bool isRegistered = false;

                char userChoice;
                char continueChoice;

                do
                {
                    
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine(" Welcome to Admin Part");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("A - Register Admin");
                    Console.WriteLine("D - Display Admin Details");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Select an option (A/D): ");

                    userChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine(); 

                    switch (char.ToUpper(userChoice))
                    {
                        case 'A':
                            
                            Console.WriteLine("\n--- Admin Registration ---");

                            Console.Write("Enter the Name of Admin: ");
                            admin.Name = Console.ReadLine();

                            Console.Write("Enter the Username of Admin: ");
                            admin.Username = Console.ReadLine();

                            Console.Write("Enter the Email of Admin: ");
                            admin.Email = Console.ReadLine();

                            Console.Write("Enter the Phone of Admin: ");
                            admin.Phone = Console.ReadLine();

                            isRegistered = true;
                            Console.WriteLine("\nAdmin registered successfully!\n");
                            break;

                        case 'D':
                            
                            Console.WriteLine("\n--- List of Admin ---");
                            if (isRegistered)
                            {
                                Console.WriteLine($"Admin Name: {admin.Name}");
                                Console.WriteLine($"Username:   {admin.Username}");
                                Console.WriteLine($"Email:      {admin.Email}");
                                Console.WriteLine($"Phone:      {admin.Phone}");
                            }
                            else
                            {
                                Console.WriteLine("No admin registered yet.");
                            }
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("\nInvalid choice. Please select 'A' or 'D'.\n");
                            break;
                    }

                    
                    Console.Write("Do you want to continue? (Y/N): ");
                    continueChoice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                } while (char.ToUpper(continueChoice) == 'Y');

                Console.WriteLine("\nProgram ended. Press any key to close.");
                Console.ReadKey();
            }
        }
    }
}
    
