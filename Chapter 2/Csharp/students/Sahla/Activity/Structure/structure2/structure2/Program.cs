using System.ComponentModel.DataAnnotations;

namespace structure2
{
    public struct Rectangle
    {
        public double x;
        public double y;

        public Rectangle(double x, double y)
        {
           this.x = x;
            this.y = y;
        }
        public double getArea()
        {
            return x *y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length:");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            double y=Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(x,y);
            double area= rectangle.getArea();
            Console.WriteLine($"Area:{area}");
        }
    }
}
