namespace Encapsulation
{
    internal class Program
    {
        public class Bankaccount
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


            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited : {amount}");
                }
                else
                {
                    Console.WriteLine("Invalid Deposite");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdraw : {amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }
        }
        static void Main(string[] args)
        {
            Bankaccount myAccount = new Bankaccount();
            myAccount.Deposit(1000);
            myAccount.Withdraw(50);

            Console.WriteLine($"Final Balance : {myAccount.Balance}");
        }
    }
}