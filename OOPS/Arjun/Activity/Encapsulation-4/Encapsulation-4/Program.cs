using System;

namespace Encapsulation4
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
            Console.WriteLine($"Age: {_age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.Age = 25;
            person.ShowAge();
        }
    }
}
