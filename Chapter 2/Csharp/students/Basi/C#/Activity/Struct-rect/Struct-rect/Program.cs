namespace Struct_rect
{
    internal class Program
    {
        public struct Rectangle
        {
            public double Length;
            public double Width;

            // Constructor to initialize the values
            public Rectangle(double length, double width)
            {
                this.Length = length;
                this.Width = width;
            }

            // Method to calculate the area
            public double GetArea()
            {
                return Length * Width;
            }

            // Method to display the details
            public void Display()
            {
                Console.WriteLine($"Length: {Length}, Width: {Width}");
            }
        }

        static void Main(string[] args)
        {
            // First rectangle instance
            Rectangle rectangle1;
            rectangle1.Length = 5.5;
            rectangle1.Width = 3.2;
            rectangle1.Display();
            Console.WriteLine($"Area: {rectangle1.GetArea()}");

            // Second rectangle instance using constructor
            Rectangle rectangle2 = new Rectangle(7.8, 4.4);
            rectangle2.Display();
            Console.WriteLine($"Area: {rectangle2.GetArea()}");
        }
    }
}
