using System.Runtime.CompilerServices;

namespace workshopadmin
{
    internal class Program
    {
        struct adminprofile;
        public string fullname;
        public string username;
        public string email;


        static void Main(string[] args)
        {
            List<adminprofile> adminlist = new List<adminprofile>();
            string ch;
            Console.WriteLine("------------------------------WELCOME ADMIN PROFILE-----------------/n");
            Console.Write("-----------------------------------------/n");

            do
            {
                Console.WriteLine("enter the option");
                Console.WriteLine("A--Register as admin");
                Console.WriteLine("d----Admin profile");

                string command = Console.ReadLine().ToUpper();
                switch (command)
                {

                    case "A":
                        {
                            adminprofile newadmin = new adminprofile();
                            Console.WriteLine("enter the user name");
                            newadmin.fullname = Console.ReadLine();
                            Console.WriteLine("enter the username of admin");
                            newadmin.username = Console.ReadLine();
                            Console.WriteLine("enter the email");
                            newadmin.email = Console.ReadLine();

                            adminlist.Add(newadmin);
                            Console.WriteLine("/nAdmin registered successfully!/n");
                            break;

                        }
                    case "D":
                        {
                            if (adminlist.Count == 0)
                            {
                                Console.WriteLine("/n admin registerd");
                            }
                            else
                            {
                                Console.WriteLine("/n------------------------------list of admins------------------/n");
                                foreach (var admin in adminlist)
                                {
                                    Console.WriteLine($"Name:{admin.fullname}");
                                    Console.WriteLine($"username:{admin.username}");
                                    Console.WriteLine($"email:{admin.email}");
                                }

                                break;

                                default:
                                    Console.WriteLine("invalid try again");
                                break;

                            }
                            Console.WriteLine("/n do you want continue(y/n)");
                            ch = Console.ReadLine().ToUpper();



                        }
                      
                }
               
            }

            while (ch == "y");
        }
    }
}
