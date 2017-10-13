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
            Console.WriteLine();

            int userChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userChoice)
            {
                case 1:
                    client1.ViewClientInfo();
                    break;

                case 2:
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    Console.WriteLine();

                    char userChoice2 = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                    switch (userChoice2)
                    {
                        case 'a':
                            checking1.ViewBalance();
                            break;
                        case 'b':
                            savings1.ViewBalance();
                            break;
                        default:
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    Console.WriteLine();

                    userChoice2 = char.Parse(Console.ReadLine());
                    Console.WriteLine();
                    
                    switch (userChoice2)
                    {
                        case 'a':
                            Console.WriteLine("How much would you like to deposit?");
                            double numDeposited = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $" + checking1.Deposit(numDeposited)+ ".");
                            break;
                        case 'b':
                            Console.WriteLine("How much would you like to deposit?");
                            numDeposited = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $" + savings1.Deposit(numDeposited) + ".");
                            break;
                        default:
                            break;
                    }
                    break;

                case 4:

                case 5:
                    goAgain = "no";
                    break;

                default:
                    Console.WriteLine("Please choose a valid number");
                    Console.WriteLine("Please enter the number for your transaction type");
                    Console.WriteLine("1. View Client Information");
                    Console.WriteLine("2. View Account Balance");
                    Console.WriteLine("3. Deposit Funds");
                    Console.WriteLine("4. Withdraw Funds");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();

                    userChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    break;


            }
            //}
            //while (goAgain == "yes" || goAgain == "y");
        }
    }
}
