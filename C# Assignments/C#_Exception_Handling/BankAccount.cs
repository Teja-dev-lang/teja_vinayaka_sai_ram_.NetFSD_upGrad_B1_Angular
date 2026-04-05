using System;

namespace ExceptionHandlingAssignment
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public static double Balance;
        public char TransactionType { get; set; } // d = deposit, c = withdraw
        public double TransactionAmount { get; set; }

        public BankAccount(int accNo, string name, double balance, char type, double amount)
        {
            AccountNumber = accNo;
            Name = name;
            Balance = balance;
            TransactionType = type;
            TransactionAmount = amount;
        }

        public void ProcessTransaction()
        {
            if (TransactionType == 'd')
            {
                Balance += TransactionAmount;
                Console.WriteLine($"Deposited: {TransactionAmount}, Balance: {Balance}");
            }
            else if (TransactionType == 'c')
            {
                if ((Balance - TransactionAmount) < 500)
                {
                    throw new CheckBalanceException("Withdrawal failed: Minimum balance 500 must be maintained.");
                }

                Balance -= TransactionAmount;
                Console.WriteLine($"Withdrawn: {TransactionAmount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid transaction type");
            }
        }
    }

    public class CheckBalanceException : Exception
    {
        public CheckBalanceException(string message) : base(message) { }
    }

    public class Program
    {
        public static void Main()
        {
            BankAccount a = new BankAccount(1234, "Teja", 20000,'c',30000);

            try
            {
                a.ProcessTransaction();
            }
            catch (CheckBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}