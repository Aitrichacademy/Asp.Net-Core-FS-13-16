namespace Abstract2
{
    abstract class Vehicle
    {
        public abstract int Speed { get; set; }
        public void ShowSpeed()
        {
            Console.WriteLine("The speed of the vehicle is: " + Speed + " km/h");
        }
    }
    class Car : Vehicle
    {
        public override int Speed { get; set; }
        public Car(int speed)
        {
            Speed = speed;
        }
    }
    class Program
    {
        static void Main()
        {
            Car myCar = new Car(120);
            myCar.ShowSpeed();
        }
    }
}

