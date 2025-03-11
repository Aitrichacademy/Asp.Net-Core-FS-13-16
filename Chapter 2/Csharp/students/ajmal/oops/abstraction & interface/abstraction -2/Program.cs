namespace abstraction__2
{
    internal class Program
    {
        abstract class Vehicle
        {
            
            public abstract void SetSpeed(int value);

            
            public abstract int GetSpeed();

            
            public void ShowSpeed()
            {
                Console.WriteLine("Speed: " + GetSpeed() + " km/h");
            }
        }

       
        class Car : Vehicle
        {
            private int speed;

           
            public override void SetSpeed(int value)
            {
                speed = value;
            }

            public override int GetSpeed()
            {
                return speed;
            }
        }
                static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.SetSpeed(120);
            myCar.ShowSpeed();
        }
    }
}
