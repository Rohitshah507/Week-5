using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account object
            BankAccount myAccount = new BankAccount("ACC12345", 1000);

            // Display account number
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance:C}\n");

            // Deposit money
            myAccount.Deposit(500);

            // Withdraw money
            myAccount.Withdraw(300);

            // Print remaining balance
            Console.WriteLine($"\nRemaining Balance: {myAccount.Balance:C}");
        }
    }
}
