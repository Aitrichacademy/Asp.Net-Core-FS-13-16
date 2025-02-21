namespace Machine_test
{

    struct Car
    {
        public int carID;
        public string Model;
        public bool isAvailable;
    }
    internal class Program
    {
        static void Main()
        {
            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Enter the Car details {i + 1} : ");
                Console.Write("car ID : ");
                cars[i].carID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Model : ");
                cars[i].Model = Console.ReadLine();
                Console.Write("Is Available : ");
                cars[i].isAvailable = Convert.ToBoolean(Console.ReadLine());
            }
                Console.WriteLine("Enter the car ID : ");
                int SearchId =Convert.ToInt32(Console.ReadLine());
                bool Found = false;

            foreach (var car in cars) 
            { 
                if (car.carID == SearchId)
                {
                    Console.WriteLine($"Car Model: {car.Model}, Availability: {(car.isAvailable ? "Available" : "Not Available")} ");
                    Found = true;
                }
                else
                {
                    Console.WriteLine("Car not Found");
                }
            }
        }
    }
}
