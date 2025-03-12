
using System;

abstract class Animal
{
    public abstract void MakeSound();
    public abstract void Move();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks.");
    }

    public override void Move()
    {
        Console.WriteLine("Dog runs.");
    }
}

class Program3
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.MakeSound();
        myDog.Move();
    }
}
