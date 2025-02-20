namespace project2
{
    internal class Program
    {
        static bool positive(int num)
        {
            return num > 0;
        }


        static void Main(string[] args)
        {
            int age = 21;
            Console.WriteLine("my age :" + age);
            //Console.WriteLine("Hello, World!");
            double pi = 3.14;
            Console.WriteLine("value of pi :"+pi);

        

            Console.WriteLine(positive(age));

            char grade = 'A';
            Console.WriteLine(grade);

            string name = "poly";
            Console.WriteLine(name);
        }
    }
}
