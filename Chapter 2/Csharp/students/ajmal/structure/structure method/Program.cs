namespace sructure_method
{
    internal class Program
    {

        struct Rectangle
        {
            public double Length;
            public double Width;

            
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            
            public double GetArea()
            {
                return Length * Width;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());


            Rectangle rect = new Rectangle(length, width);


            Console.WriteLine($"The area of the rectangle is: {rect.GetArea()}");

            Console.ReadLine();
        }
    }

}
    

