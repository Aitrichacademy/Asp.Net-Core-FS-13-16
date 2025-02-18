namespace condition5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Given your feeling: ");
            string feel=Console.ReadLine();
            switch(feel)
            {
                case "happy":Console.WriteLine("Go out and Celebrate");
                    break;
                case "sad":Console.WriteLine("Watch a comforting movie");
                    break;
                case "angry":Console.WriteLine("Try meditation or deep breathing");
                    break;
                case "bored":Console.WriteLine("Read a book or try a new hobby");
                    break;
                case "excited":Console.WriteLine("Share the good news with friends");
                    break;
                case "tired":Console.WriteLine("Take a nap or rest");
                    break;
                 default:Console.WriteLine("Mood not recognised.Try expressing yourself more clearly!");
                    break;
            }
        }
    }
}
