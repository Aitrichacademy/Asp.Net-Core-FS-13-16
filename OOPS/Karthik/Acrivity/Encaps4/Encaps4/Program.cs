namespace Encaps4
{
    internal class Program
    {
        class Person
        {
            private int _age;

            public int Age
            {
                get { return _age; }
                set { if (value > 0) _age = value; }
            }

            public void ShowAge()
            {
                Console.WriteLine("Age: " + _age);
            }
        }
        static void Main()
            {
                Person person = new Person();
                person.Age = 25;
                person.ShowAge();
            }
        }
    }

