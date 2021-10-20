using System;

namespace BankLibrary
{
    public class Savings : Bank, IInterest
    {
        public Savings()
        {

        }
        public Savings(string name, double amount) : base(name, amount)
        {

        }
        public double CalculateInterest()
        {
            return Balance * 0.1;
        }

        public override void Withdraw(double amount)
        {
            if ((Balance - amount) > 0)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Balance not enough. Cannot withdraw");
            }
        }

    }

}

