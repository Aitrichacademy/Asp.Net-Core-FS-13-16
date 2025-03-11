namespace single_inheritance_2
{
    internal class Program
    {
        class Shape
        {
            public void Display()
            {
                Console.WriteLine("This is a shape.");
            }
        }

        
        class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }

        static void Main(string[] args)
        {
            Circle myCircle = new Circle(5.0);
            myCircle.Display();
            Console.WriteLine($"Radius: {myCircle.Radius}");
            Console.WriteLine($"Area: {myCircle.CalculateArea():F2}");
        }
    }
}
