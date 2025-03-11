namespace abstraction
{
    internal class Program
    {
        abstract class Shape
        {
           
            public abstract double GetArea();

           
            public void DisplayArea()
            {
                Console.WriteLine($"The area is: {GetArea()}");
            }
        }

        
        class Rectangle : Shape
        {
            public double Length;
            public double Width;

            
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

        static void Main(string[] args)
        {
           
            Rectangle rect = new Rectangle(10, 5);

           
            rect.DisplayArea();
        }
    }
}
