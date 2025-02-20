using System;

namespace InterviewScheduleManagement
{
    struct Interview
    {
        public string JobTitle;
        public string Date;
        public string Time;
        public string Location;
    }

    class Program
    {
        static void Main()
        {
            const int maxInterviews = 10; 
            Interview[] interviews = new Interview[maxInterviews];
            int count = 0;
            char choice;

            do
            {
                Console.WriteLine("\nInterview Schedule Management");
                Console.WriteLine("A - Schedule an Interview");
                Console.WriteLine("D - View Scheduled Interviews");
                Console.WriteLine("X - Exit");
                Console.Write("Enter your choice: ");
                choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                switch (choice)
                {
                    case 'A':
                        if (count < maxInterviews)
                        {
                            Console.Write("Enter Job Title: ");
                            interviews[count].JobTitle = Console.ReadLine();
                            Console.Write("Enter Date (YYYY-MM-DD): ");
                            interviews[count].Date = Console.ReadLine();
                            Console.Write("Enter Time (HH:MM): ");
                            interviews[count].Time = Console.ReadLine();
                            Console.Write("Enter Location: ");
                            interviews[count].Location = Console.ReadLine();

                            Console.WriteLine("Interview scheduled successfully!\n");
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("Interview schedule is full. Cannot add more interviews.\n");
                        }
                        break;

                    case 'D':
                        if (count == 0)
                        {
                            Console.WriteLine("No interviews scheduled.\n");
                        }
                        else
                        {
                            Console.WriteLine("\nScheduled Interviews:");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"{i + 1}. Job Title: {interviews[i].JobTitle}, Date: {interviews[i].Date}, Time: {interviews[i].Time}, Location: {interviews[i].Location}");
                            }
                        }
                        break;

                    case 'X':
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
            } while (choice != 'X');
        }
    }
}
