namespace Encapsulation
{
    internal class Program
    {
        public class BankAccount
        {
            private double balance;

            public double Balance
            {
                get { return balance; }

                private set
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }
                }
            }

            public void deposit(double amount) 
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Deposited : {amount}");
                }
                else
                {
                    Console.WriteLine("INVALID DEPOSIT");
                }
            }

            public void withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdraw : { amount}");
                }
                else
                { 
                    Console.WriteLine("insufficient balance");
                }
            }
        }
        static void Main (string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.deposit(7500);
            myAccount.withdraw(5000);

            Console.WriteLine($"Final Balance : {myAccount.Balance}");
        }
    }
}
