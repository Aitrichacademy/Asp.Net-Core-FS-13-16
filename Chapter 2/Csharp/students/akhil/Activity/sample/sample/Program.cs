namespace sample
{
    internal class Program
    {
        interface students
        {

            void Display();
        }
        class person:students
        {
            public string name;
            public int age;

            public void Display()
            {
                Console.WriteLine($"name:{name},age:{age}");
                //Console.WriteLine(person.age);

            }
           

        }
        
        static void Main(string[] args)
        {

            //person person = new person { name = "shajan", age = 23 };

            //Console.WriteLine($"person name:{ person.name}");
            //Console.WriteLine($"person age: {person.age}");
            //Console.WriteLine();
            person p1 = new person();
            p1.name = "shajan";
            p1.age = 45;
            p1.Display();

        }
    }
}
