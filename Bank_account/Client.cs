using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    class Client
    {
        //This is the class representing a client at the bank

        private string name;
        private string userName;
        private int acctNum;

        public string Name
        {
            get { return this.name; }
        }
        public string UserName
        {
            get { return this.userName; }
        }
        public int AcctNum
        {
            get { return this.acctNum; }
        }

        public Client()
        {

        }

        public Client(string name, string userName, int acctNum)
        {
            this.name = name;
            this.userName = userName;
            this.acctNum = acctNum;
        }
        public void ViewClientInfo()
        {
            Console.WriteLine(Name + " --- " + userName + " --- " + acctNum);
        }

    }
}
