using System;

namespace BankApp
{
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Constructor
        public BankAccount(string accNumber, double initialBalance)
        {
            accountNumber = accNumber;
            if (initialBalance > 0)
            {
                balance = initialBalance;
            }
            else
            {
                throw new ArgumentException("Initial balance must be greater than 0.");
            }
        }

        // Public property: AccountNumber (read-only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property: Balance (read-only outside, private set)
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be zero or negative.");
                }
            }
        }

        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than 0.");
            }
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. Remaining Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount. Check your balance.");
            }
        }
    }
}
