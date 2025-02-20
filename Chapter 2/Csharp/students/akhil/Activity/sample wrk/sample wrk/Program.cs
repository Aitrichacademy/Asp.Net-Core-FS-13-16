namespace sample_wrk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the product code (1 to 5):");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Coke  - $1.50");
            //        break;
            //    case 2:
            //        Console.WriteLine("Chips  - $1.00");
            //        break;
            //    case 3:
            //        Console.WriteLine("Chocolate  - $2.00");
            //        break;
            //    case 4:
            //        Console.WriteLine("Water  - $1.00");
            //        break;
            //    case 5:
            //        Console.WriteLine("Juice  - $1.75");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid selection. Please try again!");
            //        break;
            //        Console.ReadLine(); 
            //}

            //Console.WriteLine("Enter a command (launch, abort, status, self-destruct, reboot):");
            //string command = Console.ReadLine().ToLower();

            //switch (command)
            //{
            //    case "launch":
            //        Console.WriteLine("Initiating launch sequence");
            //        break;
            //    case "abort":
            //        Console.WriteLine("Mission aborted! Returning to standby mode");
            //        break;
            //    case "status":
            //        Console.WriteLine("All systems operational.");
            //        break;
            //    case "self-destruct":
            //        Console.WriteLine("WARNING! Self-destruct sequence initiated!");
            //        break;
            //    case "reboot":
            //        Console.WriteLine("Rebooting all systems... Please wait.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid command. Please enter a valid operation!");
            //        break;

            //        Console.ReadLine();


            //}

            //Console.WriteLine("How are you feeling? (happy, sad, angry, bored, excited, tired):");
            //string mood = Console.ReadLine().ToLower();

            //      switch (mood)
            //      {
            //          case "happy":
            //              Console.WriteLine("Go out and celebrate!");
            //              break;
            //          case "sad":
            //              Console.WriteLine("Watch a comforting movie.");
            //              break;
            //          case "angry":
            //              Console.WriteLine("Try meditation or deep breathing.");
            //              break;
            //          case "bored":
            //              Console.WriteLine("Read a book or try a new hobby.");
            //              break;
            //          case "excited":
            //              Console.WriteLine("Share the good news with friends!");
            //              break;
            //          case "tired":
            //              Console.WriteLine("Take a nap or rest.");
            //              break;
            //          default:
            //              Console.WriteLine("Mood not recognized. Try expressing yourself more clearly!");
            //              break;
            //          Console.ReadLine();
            //      }

                Console.WriteLine("Did you solve the puzzle? (true/false):");
                bool solvedPuzzle = Convert.ToBoolean(Console.ReadLine());

                if (solvedPuzzle)
                {
                    Console.WriteLine("The door opens!");
                    return;
                }

                Console.WriteLine("Do you possess the golden amulet? (true/false):");
                bool hasGoldenAmulet = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Do you have a companion who knows the puzzle solution? (true/false):");
                bool hasCompanion = Convert.ToBoolean(Console.ReadLine());

                if (hasGoldenAmulet || hasCompanion)
                {
                    Console.WriteLine("The door opens! ");
                    return;
                }

                Console.WriteLine("Are you a direct descendant of the temple's creators? (true/false):");
                bool isDescendant = Convert.ToBoolean(Console.ReadLine());

                if (isDescendant)
                {
                    Console.WriteLine("The door opens!");
                }
                else
                {
                    Console.WriteLine("The door remains locked!");
                }
           
        }

    }
    
}
