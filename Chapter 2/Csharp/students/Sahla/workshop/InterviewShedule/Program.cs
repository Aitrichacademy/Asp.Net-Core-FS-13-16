namespace interview
{
    internal class Program
    {
        public struct Interview
        {
            public string jobTitle;
            public DateTime dateTime;
            public string Location; 

            public Interview(string jobTitle, DateTime dateTime, string location)
            {
                this.jobTitle = jobTitle;
                this.dateTime = dateTime;
                this.Location=location;
            }
            public override string ToString()
            {
                return $"Job Title: {jobTitle},Date & Time : {dateTime},Location: {Location}";
            }
        }
        static Interview[] interviews = new Interview[5];
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("\nInterview Scheduler");
                Console.WriteLine("1. Schedule an Interview");
                Console.WriteLine("2. View Scheduled Interviews");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose an option");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ScheduleInterview();
                        break;
                    case "2":
                        DisplayInterviews();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.Please try again.");
                        break;


                }
            }
        }
            static void ScheduleInterview()
            {
                Console.WriteLine("\nEnter Job Title: ");
                string jobTitle=Console.ReadLine();

                Console.WriteLine("Enter Interview Date(YYYY-MM-DD)");
                if(DateTime.TryParse(Console.ReadLine(),out DateTime dateTime))
                {
                    Console.WriteLine("Enter Location: ");
                    string location=Console.ReadLine();

                    interviews.Add(new Interview(jobTitle, dateTime, location));
                    Console.WriteLine("Interview scheduled successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid date format.Please try again.");
                }

            }
            static void DisplayInterviews()
            {
                if(interviews.Count == 0)
                {
                    Console.WriteLine("\nNo interviews scheduled.");
                    return;
                }
                Console.WriteLine("\nScheduled Interviews:");
                foreach (Interview interview in interviews)
                {
                    Console.WriteLine(interview);
                }
            }
        }
    }

 