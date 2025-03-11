namespace multilevel_inheritance_2
{
    internal class Program
    {
        class Vehicle
        {
            public void Start()
            {
                Console.WriteLine("Vehicle is starting...");
            }
        }

        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

            public void ShowDoors()
            {
                Console.WriteLine($"This car has {NumberOfDoors} doors.");
            }
        }

        class SportsCar : Car
        {
            public void TurboBoost()
            {
                Console.WriteLine("Sports car activates turbo boost! 🔥");
            }
        }

        static void Main(string[] args)
        {
            SportsCar mySportsCar = new SportsCar();

           
            mySportsCar.Start();        
            mySportsCar.NumberOfDoors = 2;
            mySportsCar.ShowDoors();   
            mySportsCar.TurboBoost();   

            Console.ReadLine();
        }
    }
}
