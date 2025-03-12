namespace inhertnc_actvty
{
    internal class Program
    {
        //class Shape
        //{
        //    public void Display()
        //    {
        //        Console.WriteLine("This is a shape.");
        //    }
        //}

        //class Circle : Shape
        //{
        //    public double Radius { get; set; }

        //    public double CalculateArea()
        //    {
        //        return Math.PI * Radius * Radius;
        //    }
        //}

        //class program
        //{
        //    static void Main()
        //    {
        //        Circle circle = new Circle();
        //        circle.Radius = 5;

        //        circle.Display();  // Calling base class method
        //        Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        //    }
        //}

        class Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }

        class Mammal : Animal
        {
            public void FeedMilk()
            {
                Console.WriteLine("Mammal feeds milk.");
            }
        }

        class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("Dog barks: Woof! Woof!");
            }
        }

        class program
        {
            static void Main()
            {
                Dog dog = new Dog();

                dog.MakeSound();  // From Animal
                dog.FeedMilk();   // From Mammal
                dog.Bark();       // From Dog
            }
        }

    }
}
