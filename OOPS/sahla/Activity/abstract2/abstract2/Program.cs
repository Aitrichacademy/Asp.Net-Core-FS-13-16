namespace abstract2
{
    internal class Program
    {
        abstract class vehicle
        {
            public abstract int speed { get; set; }
            public void showspeed()
            {
                Console.WriteLine($"speed :{speed}km/h");
            }
        }
        class car : vehicle
        {
            public override int speed {  get; set; }
        }
        static void Main(string[] args)
        {
            car mycar = new car { speed=120};
            mycar.showspeed();
        }
    }
}
