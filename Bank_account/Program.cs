using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=PBwAxmrE194

            //This is the copy for when a user first starts their program
            Console.WriteLine("Welcome to United Banking Software!");
            Console.WriteLine();
            Console.WriteLine("Please enter the number for your transaction type");

            //Makes Client and Accounts
            Random rand = new Random();
            Client client1 = new Client("Kurt", "krussell", rand.Next(10000, 100000));
            Checking checking1 = new Checking(rand.Next(1000, 10000), 5000);
            Savings savings1 = new Savings(rand.Next(1000, 10000), 500);

            string goAgain;

            Console.WriteLine("Please enter the number for your transaction type");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    client1.ViewClientInfo();
                    break;
                case 2:

                case 3:

                case 4:

                case 5:
                    goAgain = "no";
                    break;


            }
            //}
            //while (goAgain == "yes" || goAgain == "y");
        }
    }
}
