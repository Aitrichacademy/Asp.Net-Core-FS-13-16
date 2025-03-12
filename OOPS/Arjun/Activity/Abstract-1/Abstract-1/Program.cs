using System;

abstract class Shape
{
    public abstract double GetArea();

    public void DisplayArea()
    {
        Console.WriteLine("Area: " + GetArea());
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

class Program1
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 3);
        rect.DisplayArea();
    }
}
