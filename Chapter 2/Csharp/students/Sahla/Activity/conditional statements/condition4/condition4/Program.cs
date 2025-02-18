namespace condition4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you solve the puzzle: ");
            string solve=Console.ReadLine();
            if (solve=="yes")
            {
                Console.WriteLine("Door Open");    
            }
            else if (solve=="no") 
            {
                Console.WriteLine("Do you have a golden amulet: ");
                string amulet=Console.ReadLine();
                Console.WriteLine("your campanion knows the solution? ");
                string solu=Console.ReadLine();
                if((solu=="yes") || (amulet=="yes"))
                {
                    Console.WriteLine("Door opens");
                }
                else
                {
                    Console.WriteLine("direct descendant");
                }
            }
            else
            {
                Console.WriteLine("Door Locked");
            }
        }
    }
}

