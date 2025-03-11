namespace abstraction___3
{
    internal class Program
    {
        abstract class Animal
        {
           
            public abstract void MakeSound();
        }

       
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog: Woof! Woof!");
            }
        }

        
        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat: Meow! Meow!");
            }
        }

        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            Animal myCat = new Cat();

           
            myDog.MakeSound();
            myCat.MakeSound();
        }
    }
}
