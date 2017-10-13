using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    class Savings : Account
    {
        private double acctMin;

        public double AcctMin
        {
            get { return this.acctMin; }
        }

        public Savings()
        {

        }

        public Savings(int acctNum, double balance)
        {
            this.acctNum = acctNum;
            this.balance = balance;

            this.acctType = "Savings Account";
            this.acctMin = 100.00d;
        }

        public override void ViewBalance()
        {
            Console.WriteLine("The account balance for {0}: {1} is ${3}.", acctType, acctNum, Math.Round(balance, 2));
        }
        //This is the method to make sure that a withdrawal beyond the minimum isn't allowed!
        public override double Withdraw(double numWithdrawn)
        {
            if (base.Withdraw(numWithdrawn) > acctMin)
                return base.Withdraw(numWithdrawn);
            else
            {
                Console.WriteLine("You've tried to withdraw more than the maximum of $" + (balance - acctMin) + ".");
                Console.WriteLine("Please try your withdrawal again, leaving at least $" + acctMin + "in your account.")
                return balance;
            }
        }


    }
}
