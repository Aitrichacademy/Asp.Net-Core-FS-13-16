namespace condition3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Have you get a distress signal: ");
            string signal=Console.ReadLine();
            if (signal == "yes")
            {
                Console.WriteLine("SAFE");
            }
            else
            {
                if (signal == "no")
                {
                    Console.WriteLine("The astronaut is on a habitable planet:");
                    string N=Console.ReadLine();
                    Console.WriteLine("planet is in reachable distance: ");
                    string p=Console.ReadLine();
                    if(p =="yes" && N =="yes")
                    {
                        Console.WriteLine("Rescue team is ready");
                    }
                    else
                    {
                        Console.WriteLine("Mission not executed.");
                    }
                }
            }
        }
    }
}
