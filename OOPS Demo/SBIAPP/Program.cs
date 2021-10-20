using System;
using BankLibrary;

namespace SBIAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.AccHolderName = "Dhara";

            // bank.Balance = 2000;

            Console.WriteLine(bank);

            bank.Deposit(5000);

            Console.WriteLine(bank.ToString());

            bank.Withdraw(3000);

            Console.WriteLine(bank.ToString());

            Console.WriteLine("_________________________");

            Bank bank1 = new Bank("Komal", 2000);

            Console.WriteLine(bank1.ToString()); Savings savings = new Savings();

            Console.WriteLine(savings); Savings savings1 = new Savings("Pratham", 1000);

            Console.WriteLine(savings1);

            try
            {
                savings1.Withdraw(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();

            Savings savings2 = new Savings("Darshan", 2000);
            Console.WriteLine(savings2);
            Console.WriteLine("Amount " + savings2.CalculateInterest());
        }
    } 
}

