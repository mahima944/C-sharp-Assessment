using System;

namespace ConsoleApp3
{
    public class Bank
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public static double InterestRate { get; private set; } = 3.5;  

        public Bank(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        
        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        
        public void Display()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}, Interest Rate: {InterestRate}%");
        }
    }
}
