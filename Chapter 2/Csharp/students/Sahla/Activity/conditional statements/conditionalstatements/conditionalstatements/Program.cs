namespace conditionalstatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if(mark>=50)
            //{
            //    Console.WriteLine("PASS");
            //    Console.ReadLine();
            //}
            //if (age >= 18)
            //{
            //    Console.WriteLine("Eligible for Vote");
            //}
            //else
            //{
            //    Console.WriteLine("NOT Eligible for Vote");
            //}
            //Console.ReadLine();

            Console.WriteLine("Enter your Mark");
            int mark =Convert.ToInt32(Console.ReadLine());
            if (mark >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (mark >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (mark >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (mark >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("FAILED");
            }
        }
    }
}
