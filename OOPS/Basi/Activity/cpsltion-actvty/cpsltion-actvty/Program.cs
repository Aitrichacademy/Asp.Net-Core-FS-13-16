namespace cpsltion_actvty
{
    internal class Program
    {

        //3.Online Shopping Cart

        //class Product
        //{
        //    private string _name;
        //    private double _price;
        //    private int _stockQuantity;

        //    public Product(string name, double price, int stockQuantity)
        //    {
        //        _name = name;
        //        _price = price;
        //        _stockQuantity = stockQuantity;
        //    }

        //    public string Name { get { return _name; } }
        //    public double Price { get { return _price; } }

        //    public void Purchase(int quantity)
        //    {
        //        if (quantity <= _stockQuantity)
        //        {
        //            _stockQuantity -= quantity;
        //            Console.WriteLine(quantity + " units purchased.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not enough stock available.");
        //        }
        //    }

        //    public int GetStock()
        //    {
        //        return _stockQuantity;
        //    }
        //}

        //class program
        //{
        //    static void Main()
        //    {
        //        Product laptop = new Product("Laptop", 800, 10);

        //        laptop.Purchase(3);  
        //        Console.WriteLine("Remaining Stock: " + laptop.GetStock());  
        //    }
        //}

        //4.Basic Property Implementation

        class Person
        {
            private int _age;

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value > 0)
                        _age = value;
                }
            }

            public void ShowAge()
            {
                Console.WriteLine("Age: " + _age);
            }
        }

        class program
        {
            static void Main()
            {
                Person person = new Person();
                person.Age = 25;
                person.ShowAge(); 
            }
        }
    }
}
