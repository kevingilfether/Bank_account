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
        private int userNum;

        public string Name
        {
            get { return this.name; }
        }
        public string UserName
        {
            get { return this.userName; }
        }
        public int UserNum
        {
            get { return this.userNum; }
        }

        public Client()
        {

        }

        public Client(string name, string userName, int userNum)
        {
            this.name = name;
            this.userName = userName;
            this.userNum = userNum;
        }
        
        //This is the method to print client information
        public void ViewClientInfo()
        {
            Console.WriteLine(Name + " --- " + userName + " --- " + userNum);
        }

    }
}
