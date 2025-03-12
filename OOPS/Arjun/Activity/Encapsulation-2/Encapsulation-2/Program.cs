using System;

namespace Encapsulation2
{
    class Temperature
    {
        private double _celsius;

        public double Celsius
        {
            get { return _celsius; }
            set { if (value >= -100 && value <= 100) _celsius = value; }
        }

        public double Fahrenheit
        {
            get { return (_celsius * 9 / 5) + 32; }
        }
    }

    class Program
    {
        static void Main()
        {
            Temperature temp = new Temperature();
            temp.Celsius = 25;
            Console.WriteLine($"Celsius: {temp.Celsius}°C");
            Console.WriteLine($"Fahrenheit: {temp.Fahrenheit}°F");
        }
    }
}
