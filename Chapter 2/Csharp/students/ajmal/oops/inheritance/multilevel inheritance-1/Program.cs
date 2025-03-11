namespace multilevel_inheritance_1
{
    internal class Program
    {
        class Animal
        {
            public void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }

        class Mammal : Animal
        {
            public void Speak()
            {
                Console.WriteLine("Mammal makes a generic sound.");
            }
        }

        class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("Dog barks: Woof! Woof!");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog();

            
            myDog.MakeSound(); 
            myDog.Speak();     
            myDog.Bark();     

            Console.ReadLine();
        }
    }
}
