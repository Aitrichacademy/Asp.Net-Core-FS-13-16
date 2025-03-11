namespace Abstract1
{
    using System;
    abstract class Shape
    {
        public abstract double GetArea();
        public void DisplayArea()
        {
            Console.WriteLine("The area of the shape is: " + GetArea());
        }
    }
    class Rectangle : Shape
    {
        double Length, Width;
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double GetArea()
        {
            return Length * Width;
        }
    }
    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(10, 5);
            rect.DisplayArea();
        }
    }
}
