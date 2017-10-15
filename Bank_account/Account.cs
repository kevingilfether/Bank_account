using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    abstract class Account
    {
        //This is the abstract parent class for all
        //accounts. The fields are inherited by both checking
        //and savings classes;
        protected int acctNum;
        protected double balance;
        protected string acctType;

        public int AcctNum
        {
            get { return this.acctNum; }
        }
        public double Balance
        {
            get { return this.balance; }
        }
        public string AcctType
        {
            get { return this.acctType; }
        }

        public Account()
        {

        }

        //Deposit and Withdraw methods - virtual to facilitate overrides
        public virtual double Deposit(double numDeposited)
        {
            balance += numDeposited;
            return balance;
        }
        public virtual double Withdraw(double numWithdrawn)
        {
            balance -= numWithdrawn;
            return balance;
        }
        //Abstract ViewBalance method
        public abstract void ViewBalance();
    }
}
