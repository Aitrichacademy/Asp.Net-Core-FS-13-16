namespace Encaps3
{
    internal class Program
    {
        class Product
        {
            private string _name;
            private double _price;
            private int _stockQuantity;

            public string Name { get { return _name; } }
            public double Price { get { return _price; } }

            public Product(string name, double price, int stock)
            {
                _name = name;
                _price = price;
                _stockQuantity = stock;
            }

            public void Purchase(int quantity)
            {
                if (quantity <= _stockQuantity)
                {
                    _stockQuantity -= quantity;
                    Console.WriteLine(quantity + " " + _name + " purchased.");
                }
                else
                {
                    Console.WriteLine("Not enough stock available.");
                }
            }

            public int GetStock()
            {
                return _stockQuantity;
            }
        }

        
            static void Main()
            {
                Product laptop = new Product("Laptop", 800, 10);
                laptop.Purchase(3);
                Console.WriteLine("Remaining stock: " + laptop.GetStock());
            }
        }
    }

