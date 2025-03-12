namespace encap_3
{
    internal class Program
    {
        class Product
        {
            private string _name;
            private double _price;
            private int _stockQuantity;

            public string Name
            {
                get { return _name; }
            }

            public double Price
            {
                get { return _price; }
            }

            public Product(string name, double price, int stockQuantity)
            {
                _name = name;
                _price = price;
                _stockQuantity = stockQuantity;
            }

            public bool Purchase(int quantity)
            {
                if (quantity <= _stockQuantity)
                {
                    _stockQuantity -= quantity;
                    Console.WriteLine($"Purchased {quantity} unit(s) of {_name}.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Insufficient stock available.");
                    return false;
                }
            }

            public int GetStock()
            {
                return _stockQuantity;
            }
        }
        static void Main(string[] args)
        {
            Product laptop = new Product("Laptop", 800, 10);
            laptop.Purchase(3);
            Console.WriteLine($"Remaining stock: {laptop.GetStock()}");
        }
    }
}
