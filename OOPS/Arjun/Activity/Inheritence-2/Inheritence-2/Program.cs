using System;

namespace Inheritence2
{
    class Shape
    {
        public void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    class Circle : Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public void CalculateArea()
        {
            Console.WriteLine($"Area: {3.14 * Radius * Radius}");
        }
    }
}
