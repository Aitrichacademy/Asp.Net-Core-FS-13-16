namespace Inheritance
{
    internal class Program
    {

        class animal
        {
            public void eat()
            {
                Console.WriteLine("Animal");
            }
        }

        class dog : animal
        {
            public void bark()
            {
                Console.WriteLine("Barking");
            }

            static void Main(string[] args)
            {
                dog myDog = new dog();
                myDog.eat();
                myDog.bark();
            }
        }
    }
}
