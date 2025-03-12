using System;

namespace Inheritence3
{
    class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Mammal : Animal { }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }
}