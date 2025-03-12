
namespace Abstract_2
{
    internal class Program
    {
        //public interface IAnimal
        //{
        //    string Name { get; set; }
        //    void MakeSound();
        //}

        //public class Dog : IAnimal
        //{
        //    public string Name { get; set; }

        //    public void MakeSound()
        //    {
        //        Console.WriteLine("Dog barks");
        //    }
        //}

        //public class Programme 
        //{
        //    public static void Main(string[] args)
        //    {
        //        Dog dog = new Dog();
        //        dog.Name = "Buddy";
        //        Console.WriteLine(dog.Name);
        //        dog.MakeSound();
        //    }
        //}
        interface IPrintable
        {
            void Print();
        }

        // Define the ISavable interface
        interface ISavable
        {
            void Save();
        }

        // Implement both interfaces in the Document class
        class Document : IPrintable, ISavable
        {
            public void Print()
            {
                Console.WriteLine("Printing document");
            }

            public void Save()
            {
                Console.WriteLine("Saving document");
            }
        }

        class Programme
        {
            static void Main()
            {
                // Create an object of Document
                Document doc = new Document();

                // Call both methods
                doc.Print();
                doc.Save();
            }
        }
    }
}