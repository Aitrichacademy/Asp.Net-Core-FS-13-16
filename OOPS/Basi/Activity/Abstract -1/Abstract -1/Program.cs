
    namespace Abstract__1
    {
        internal class Program
        {
            //abstract class student
            //{
            //    public abstract void print();
            //}

            //     class department : student
            //{
            //    public override void print ()
            //    {
            //        Console.WriteLine("This is department");
            //    }
            //}

        interface Ivehicle
        {
            void start ();
        }

        class car : Ivehicle
        {
            public void start() 
            {
                Console.WriteLine("car Starts With a key");
            }
        }
        class bike : Ivehicle
        {
            public void start()
            {
                Console.WriteLine("Bike Starts With a Self button");
            }
        }

        static void Main(string[] args)
            {
                Ivehicle bike = new bike();
                bike.start();

                Ivehicle car = new car();
                car.start();
                //department department = new department();
                //department.print();

            }
        }
    }
