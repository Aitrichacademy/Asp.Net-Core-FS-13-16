namespace encap_4
{
    internal class Program
    {
        class Person
        {
            private int _age;

            public int Age
            {
                get { return _age; }
                set
                {
                    if (value > 0) 
                    {
                        _age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age must be greater than 0.");
                    }
                }
            }

            public void ShowAge()
            {
                Console.WriteLine("Age: " + _age);
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 25; 
            person.ShowAge(); 

            person.Age = -5; 
            person.ShowAge();  
        }
    }
}
