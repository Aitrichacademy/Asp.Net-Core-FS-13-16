namespace method_overriding
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
                return 1.5; 
            }
        }

        static void Main(string[] args)
        {
            BankAccount generalAccount = new BankAccount();
            BankAccount savings = new SavingsAccount();
            BankAccount current = new CurrentAccount();

            Console.WriteLine($"General Account Interest Rate: {generalAccount.GetInterestRate()}%");
            Console.WriteLine($"Savings Account Interest Rate: {savings.GetInterestRate()}%");
            Console.WriteLine($"Current Account Interest Rate: {current.GetInterestRate()}%");

            
            SavingsAccount mySavings = new SavingsAccount();
            Console.WriteLine($"My Savings Account Interest Rate: {mySavings.GetInterestRate()}%");

            CurrentAccount myCurrent = new CurrentAccount();
            Console.WriteLine($"My Current Account Interest Rate: {myCurrent.GetInterestRate()}%");

            Console.ReadLine();
        }
    }
}
