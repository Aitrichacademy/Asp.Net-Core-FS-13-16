namespace Inheritence
{
    internal class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Animal");
            }

            class Dog : Animal
            {
                public void Bark()
                {
                    Console.WriteLine("Dog is Barking");
                }
            }


            static void Main(string[] args)
            {
                Dog mydog = new Dog();
                mydog.Eat();
                mydog.Bark();
            }
        }
    }
}
