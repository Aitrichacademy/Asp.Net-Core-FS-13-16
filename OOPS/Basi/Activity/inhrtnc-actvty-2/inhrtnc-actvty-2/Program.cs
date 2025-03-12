namespace inhrtnc_actvty_2
{
    internal class Program
    {
       

        class BankAccount
        {
        public virtual double GetInterestRate()
            {
            return 3.5; 
            }
        }

        class SavingsAccount : BankAccount
        {
        public override double GetInterestRate()
            {       
            return 5.0; 
            }
        }

        class CurrentAccount : BankAccount
    {
        public override double GetInterestRate()
        {
            return 2.0; 
        }
    }

    class program
        {
                static void Main()
            {
                BankAccount acc1 = new SavingsAccount();
                BankAccount acc2 = new CurrentAccount();

                Console.WriteLine("Savings Account Interest Rate: " + acc1.GetInterestRate());
                Console.WriteLine("Current Account Interest Rate: " + acc2.GetInterestRate());
            }
        }

    }
}
