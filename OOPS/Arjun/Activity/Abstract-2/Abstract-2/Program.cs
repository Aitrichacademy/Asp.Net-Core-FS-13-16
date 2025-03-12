
using System;

abstract class Vehicle
{
    public abstract int Speed { get; set; }

    public void ShowSpeed()
    {
        Console.WriteLine("Speed: " + Speed + " km/h");
    }
}

class Car : Vehicle
{
    private int speed;

    public override int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
}

class Program2
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Speed = 120;
        myCar.ShowSpeed();
    }
}
