using System;
struct Account
{
        public int AccountNumber;
        public string HolderName;
        public double Balance;
    }
   class Bankingsystem
    {
        static void Main()
        {
          
        Account[] Accounts = new Account[2];

                for (int i = 0; i < Accounts.Length; i++)
                {
                    Console.WriteLine($"Enter Account details {i+1}");
                    Console.WriteLine("Account Number : ");
                    Accounts[i].AccountNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Account Holder Name : ");
                    Accounts[i].HolderName = (Console.ReadLine());
                    Console.WriteLine("Account Balance : ");
                    Accounts[i].Balance = Convert.ToDouble(Console.ReadLine());
                }


                
            Console.WriteLine("search account by account number :");
            int searchCode = int.Parse(Console.ReadLine());
            bool match = false;





            foreach (var A in Accounts)
              {
                if (A.AccountNumber == searchCode)
              {
                Console.WriteLine($"Account Number:{A.AccountNumber}");
                Console.WriteLine($"Account Holder name:{A.HolderName}");
                Console.WriteLine($"Account Balance:{A.Balance}");
                match = true;
                break;
              }
    
         }
        if(!match)
        {
            Console.WriteLine("not matched");
        }
    }


    }

    
 

       
