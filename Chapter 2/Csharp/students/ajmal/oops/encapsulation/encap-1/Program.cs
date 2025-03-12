namespace encap_1
{
    internal class Program
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
                if (enteredPassword == _password)
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                }
            }
        }
        static void Main(string[] args)
        {
            User user = new User();
            user.SetPassword("secure123");

            user.Login("wrongpass");  
            user.Login("secure123");   
        }
    }
}
