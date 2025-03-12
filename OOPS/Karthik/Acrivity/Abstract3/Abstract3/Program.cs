namespace Abstract3
{
    abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("bow bow");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        class Program
        {
            static void Main()
            {
                Dog myDog = new Dog();
                Cat myCat = new Cat();

                myDog.MakeSound();
                myCat.MakeSound();
            }
        }
    }
}
