using System;

namespace Inheritence5
{
    class BankAccount
    {
        public virtual double GetInterestRate()
        {
            return 0;
        }
    }

    class SavingsAccount : BankAccount
    {
        public override double GetInterestRate()
        {
            return 5;
        }
    }

    class CurrentAccount : BankAccount
    {
        public override double GetInterestRate()
        {
            return 3;
        }
    }
}