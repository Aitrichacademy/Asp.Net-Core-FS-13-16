namespace inheri3
{
    internal class Program
    {
        class Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }

        class Mammal : Animal
        {
            public void Walk()
            {
                Console.WriteLine("Mammal walks.");
            }
        }

        class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("Dog barks: Woof! Woof!");
            }
        }
            static void Main()
            {
                Dog myDog = new Dog();
                myDog.MakeSound();
                myDog.Walk();
                myDog.Bark();
            }
        }
    }

