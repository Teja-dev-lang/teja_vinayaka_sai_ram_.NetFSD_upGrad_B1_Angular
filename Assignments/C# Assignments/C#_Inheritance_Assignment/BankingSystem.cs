using System;
using System.Collections.Generic;
using System.Text;

namespace C__Inheritance_Assignment
{
     class Account
    {
        public int AccountNumber;
        public int Balance;
        public Account(int AccountNumber,int Balance)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }
        public void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation\n");
        }
    }
    class Saving_Account : Account
    {
        public Saving_Account(int AccountNumber, int Balance) : base(AccountNumber, Balance) { }
        public new void CalculateInterest()
        {
            Console.WriteLine("Savings account interest calculation\n");
        }

    }

    class CurrentAccount : Account
    {
        public CurrentAccount(int AccountNumber, int Balance) : base(AccountNumber, Balance) { }
        public new void CalculateInterest()
        {
            Console.WriteLine("Current account interest calculation\n");
        }

    }
}
