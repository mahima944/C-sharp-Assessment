using System;

namespace ConsoleApp3
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance >= 0)
                balance = initialBalance;
            else
                Console.WriteLine("Initial balance cannot be negative.");
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid amount.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
