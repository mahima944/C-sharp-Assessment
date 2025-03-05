using System;

namespace ConsoleApp4
{
 
    class Account
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a general account...");
        }
    }
    

    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        
        public sealed override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Console.WriteLine($"{AccountHolder}'s interest amount: {interest:C}");
        }
    }
}