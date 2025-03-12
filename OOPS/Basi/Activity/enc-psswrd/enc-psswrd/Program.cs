namespace enc_psswrd
{
    internal class Program
    {

        //1.Secure Login System

        //class User
        //{
        //    private string _password;

        //    public void SetPassword(string password)
        //    {
        //        _password = password;
        //    }

        //    public void Login(string enteredPassword)
        //    {
        //        if (enteredPassword == _password)
        //        {
        //            Console.WriteLine("Login Successful");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Incorrect Password");
        //        }
        //    }
        //}

        //class program
        //{
        //    static void Main()
        //    {
        //        User user = new User();
        //        user.SetPassword("secure123");

        //        user.Login("wrongpass");   // Output: Incorrect Password
        //        user.Login("secure123");   // Output: Login Successful
        //    }
        //}

        //2.ncapsulated Temperature Converter


        class Temperature
        {
            private double _celsius;

            public double Celsius
            {
                get { return _celsius; }
                set
                {
                    if (value >= -100 && value <= 100)
                        _celsius = value;
                }
            }

            public double Fahrenheit
            {
                get { return (_celsius * 9 / 5) + 32; }
            }
        }

        class program
        {
            static void Main()
            {
                Temperature temp = new Temperature();
                temp.Celsius = 25;

                Console.WriteLine("Celsius: " + temp.Celsius);
                Console.WriteLine("Fahrenheit: " + temp.Fahrenheit);
            }
        }
    }
}
