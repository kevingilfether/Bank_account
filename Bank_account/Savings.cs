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

        public Savings(Client client, double balance)
        {
            this.acctNum = client.UserNum;
            this.balance = balance;

            this.acctType = "Savings Account";
            this.acctMin = 100.00d;
        }

        public override void ViewBalance()
        {
            Console.WriteLine("The account balance for {0}: {1} is ${2}.", acctType, acctNum, Math.Round(balance, 2));
        }
        //This is the method to make sure that a withdrawal beyond the minimum isn't allowed!
        public override double Withdraw(double numWithdrawn)
        {
            double maxAllowedDraw = balance - acctMin;
            if (numWithdrawn > maxAllowedDraw)
            {
                Console.WriteLine("Please try your withdrawal again, leaving at least $" + acctMin + " in your account.");
                Console.WriteLine("You may withdraw a maximum of $" + maxAllowedDraw + " without making a new deposit.");
                return balance;
            }
            else
                return base.Withdraw(numWithdrawn);

        }


    }
}
