namespace exercise
{
    using System;

    class JobPortalAdmin
    {
        
        const string adminEmail = "admin@gmail.com";
        const string adminPassword = "123";

        {
        
        struct JobSeeker
            public string ID;
            public string DateApplied;
            public string Company;
            public string Type;
            public string Position;
            public string Status;
        }

        static void Main()
        {
            Console.WriteLine("Welcome to the Hire Me Now Job Portal!\n");

            
            Console.Write("Please enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Please enter your password: ");
            string password = Console.ReadLine();

            if (email == adminEmail && password == adminPassword)
            {
                Console.WriteLine("\nLogin successful!\n");

                
                JobSeeker[] jobSeekers = {
                new JobSeeker { ID = "APL-03323", DateApplied = "June 1 2022,10:23 AM", Company = "TCS", Type = "FREELANCE", Position = "Intern UI Designer", Status = "Pending" },
                new JobSeeker { ID = "APL-03324", DateApplied = "June 2 2022,11:23 AM", Company = "Aitrich", Type = "PART TIME", Position = "Junior UX Designer", Status = "On-Hold" },
                new JobSeeker { ID = "APL-03325", DateApplied = "March 3 2022,1:45 PM", Company = "Microsoft", Type = "FREELANCE", Position = "Dotnet Developer", Status = "Pending" },
                new JobSeeker { ID = "APL-03326", DateApplied = "May 1 2022,1:23 AM", Company = "TCS", Type = "PART TIME", Position = "Senior UI Designer", Status = "Candidate" },
                new JobSeeker { ID = "APL-03327", DateApplied = "Nov 1 2022,04:23 PM", Company = "Wipro", Type = "FREELANCE", Position = "Intern Java Developer", Status = "Pending" }
            };

                while (true)
                {
                    Console.WriteLine("\n1. New Registrations");
                    Console.WriteLine("2. List all Job Seekers");
                    Console.WriteLine("3. Search Job Seekers");
                    Console.WriteLine("4. Logout");
                    Console.Write("Select an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("\nNew Registrations:");
                            DisplayJobSeekers(jobSeekers);
                            break;

                        case "2":
                            Console.WriteLine("\nList of All Job Seekers:");
                            DisplayJobSeekers(jobSeekers);
                            break;

                        case "3":
                            Console.Write("\nEnter Job Seeker ID to search: ");
                            string searchID = Console.ReadLine();
                            SearchJobSeeker(jobSeekers, searchID);
                            break;

                        case "4":
                            Console.WriteLine("\nLogging out...");
                            return;

                        default:
                            Console.WriteLine("\nInvalid option. Please try again.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nInvalid credentials! Exiting...");
            }
        }

     
        static void DisplayJobSeekers(JobSeeker[] jobSeekers)
        {
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine("ID         | Date Applied      | Company  | Type     | Position           | Status");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var seeker in jobSeekers)
            {
                Console.WriteLine($"{seeker.ID,-10} | {seeker.DateApplied,-15} | {seeker.Company,-8} | {seeker.Type,-9} | {seeker.Position,-18} | {seeker.Status}");
            }
        }

       
        static void SearchJobSeeker(JobSeeker[] jobSeekers, string searchID)
        {
            bool found = false;
            foreach (var seeker in jobSeekers)
            {
                if (seeker.ID.Equals(searchID, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nJob Seeker Found:");
                    Console.WriteLine($"ID: {seeker.ID}");
                    Console.WriteLine($"Date Applied: {seeker.DateApplied}");
                    Console.WriteLine($"Company: {seeker.Company}");
                    Console.WriteLine($"Type: {seeker.Type}");
                    Console.WriteLine($"Position: {seeker.Position}");
                    Console.WriteLine($"Status: {seeker.Status}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("\nJob Seeker not found.");
            }
        }
    }

}
