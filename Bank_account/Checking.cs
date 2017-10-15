using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    class Checking: Account
    { 
        public Checking()
        {

        }
        public Checking(Client client, double balance)
        {
            this.acctNum = client.UserNum;
            this.balance = balance;

            this.acctType = "Checking Account";
        }

        public override void ViewBalance()
        {
            Console.WriteLine("The account balance for {0}: {1} is ${2}.", acctType, acctNum, Math.Round(balance, 2));
        }
    }
}
