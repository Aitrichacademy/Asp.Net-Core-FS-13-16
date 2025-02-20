using System;

struct Job
{
    public string Title;
    public string Company;
    public string Location;
    public string Description;
}

class JobPostingPlatform
{
    static void Main()
    {
        const int maxJobs = 10; 
        Job[] jobs = new Job[maxJobs];
        int jobCount = 0;

        char choice;
        do
        {
            Console.WriteLine("\nJob Posting Platform");
            Console.WriteLine("A - Post a Job");
            Console.WriteLine("D - View Posted Jobs");
            Console.WriteLine("E - Exit");
            Console.Write("Enter your choice: ");
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'A':
                    if (jobCount < maxJobs)
                    {
                        Console.Write("Enter Job Title: ");
                        jobs[jobCount].Title = Console.ReadLine();
                        Console.Write("Enter Company Name: ");
                        jobs[jobCount].Company = Console.ReadLine();
                        Console.Write("Enter Job Location: ");
                        jobs[jobCount].Location = Console.ReadLine();
                        Console.Write("Enter Job Description: ");
                        jobs[jobCount].Description = Console.ReadLine();
                        jobCount++;
                        Console.WriteLine("Job posted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Job list is full. Cannot add more jobs.");
                    }
                    break;

                case 'D':
                    if (jobCount == 0)
                    {
                        Console.WriteLine("No jobs posted yet.");
                    }
                    else
                    {
                        Console.WriteLine("\nPosted Jobs:");
                        for (int i = 0; i < jobCount; i++)
                        {
                            Console.WriteLine($"\nJob {i + 1}:");
                            Console.WriteLine($"Title: {jobs[i].Title}");
                            Console.WriteLine($"Company: {jobs[i].Company}");
                            Console.WriteLine($"Location: {jobs[i].Location}");
                            Console.WriteLine($"Description: {jobs[i].Description}");
                        }
                    }
                    break;

                case 'E':
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please select a valid option.");
                    break;
            }
        } while (choice != 'E');
    }
}
