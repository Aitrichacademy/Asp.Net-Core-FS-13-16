using System;

namespace Inheritence4
{
    class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle starting");
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors;
        public Car(int doors)
        {
            NumberOfDoors = doors;
        }
    }

    class SportsCar : Car
    {
        public SportsCar(int doors) : base(doors) { }
        public void TurboBoost()
        {
            Console.WriteLine("Turbo Boost Activated");
        }
    }
}
