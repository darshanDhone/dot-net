using System;
namespace BankLibrary
{
    public class Bank
    {
        private string accHolderName;

        public string AccHolderName
        {
            get
            {
                return accHolderName;
            }
            set
            {
                accHolderName = value;
            }
        }

        private double balance;
        public double Balance
        {
            get
            {
                return balance;
            }
            protected set
            {
                balance = value;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public override string ToString()
        {
            return string.Format($"Account Holder Name:{accHolderName},Balance:{Balance}");
        }
        public Bank()
        {
            Balance = 1000;
        }
        public Bank(String name, double amount)
        {
            this.AccHolderName = name;
            this.Balance = amount;
        }
    }
}

