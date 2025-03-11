namespace inher2
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
            public double Radius;

            public void CalculateArea()
            {
                double area = 3.14 * Radius * Radius;
                Console.WriteLine("Circle Area: " + area);
            }
        }
            static void Main()
            {
                Circle circle = new Circle();
                circle.Radius = 5;

                circle.Display();
                circle.CalculateArea();
            }
        }

    }

