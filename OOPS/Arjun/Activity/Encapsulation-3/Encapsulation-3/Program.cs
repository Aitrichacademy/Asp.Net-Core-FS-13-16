using System;

namespace Encapsulation3
{
    class Product
    {
        private string _name;
        private double _price;
        private int _stockQuantity;

        public Product(string name, double price, int stockQuantity)
        {
            _name = name;
            _price = price;
            _stockQuantity = stockQuantity;
        }

        public void Purchase(int quantity)
        {
            if (quantity <= _stockQuantity)
            {
                _stockQuantity -= quantity;
                Console.WriteLine($"Purchased {quantity} units.");
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }
        }

        public int GetStock()
        {
            return _stockQuantity;
        }
    }

    class Program
    {
        static void Main()
        {
            Product laptop = new Product("Laptop", 800, 10);
            laptop.Purchase(3);
            Console.WriteLine($"Stock left: {laptop.GetStock()}");
        }
    }
}
