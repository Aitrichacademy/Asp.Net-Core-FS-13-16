﻿namespace condition7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command code: ");
            string code=Console.ReadLine();
            switch(code)
            {
                case "launch":Console.WriteLine("Initiating launch sequence.....");
                    break;
                case "abort":Console.WriteLine("Mission aborted! Returning to standby mode.");
                    break;
                case "status":Console.WriteLine("All systems operational");
                    break;
                case "self-destruct":Console.WriteLine("WARNING! Self- destruct sequence initiated!");
                    break;
                case "reboot":Console.WriteLine("Rebooting all systems....Please wait.");
                    break;
                default: Console.WriteLine("Invalid command.Please enter a valid operation!");
                    break;
            }
        }
    }
}
