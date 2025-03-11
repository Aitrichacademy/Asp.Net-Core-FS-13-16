namespace Encaps1
{
    internal class Program
    {
        public class User
        {
            public string password;

            public void SetPassword(string pass)
            {
                password = pass;
            }

            public void Login(string input)
            {
                if (input == password)
                {


                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }

            static void Main()
            {
                User user = new User();
                user.SetPassword("secure123");
                user.Login("wrongpass");
                user.Login("secure123");
            }
        }
    }
}
