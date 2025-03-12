using System;

namespace Encapsulation1
{
    class User
    {
        private string _password;

        public void SetPassword(string password)
        {
            _password = password;
        }

        public void Login(string enteredPassword)
        {
            Console.WriteLine(enteredPassword == _password ? "Login Successful" : "Incorrect Password");
        }
    }

    class Program
    {
        static void Main()
        {
            User user = new User();
            user.SetPassword("secure123");
            user.Login("wrongpass");
            user.Login("secure123");
        }
    }
}
