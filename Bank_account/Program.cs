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

            //Makes Client and Accounts
            Random rand = new Random();
            List<Client> clientList = new List<Client>();
            List<Checking> checkingList = new List<Checking>();
            List<Savings> savingsList = new List<Savings>();

            clientList.Add(ClientMaker());
            checkingList.Add(new Checking(clientList[0], 5000));
            savingsList.Add(new Savings(clientList[0], 500));        


            //This is the flag for the do-while loop that most of the program runs in
            bool goAgain = true;

            do
            {
                //This prints the menu for the banking options
                MenuPrinter();

                int userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (userChoice)
                {
                    //checks user info
                    case 1:
                        clientList[0].ViewClientInfo();
                        break;

                    //Views account balance
                    case 2:
                        //This prints the submenu for choosing between checkings and savings
                        SubMenuPrinter();

                        char userChoice2 = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (userChoice2)
                        {
                            case 'a':
                                checkingList[0].ViewBalance();
                                break;
                            case 'b':
                                savingsList[0].ViewBalance();
                                break;
                            default:
                                break;
                        }
                        break;

                    //Deposits
                    case 3:
                        SubMenuPrinter();

                        userChoice2 = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (userChoice2)
                        {
                            case 'a':
                                Console.WriteLine("How much would you like to deposit?");
                                Console.WriteLine();
                                double numDeposited = double.Parse(Console.ReadLine());
                                checkingList[0].Deposit(numDeposited);
                                Console.WriteLine();
                                checkingList[0].ViewBalance();
                                break;
                            case 'b':
                                Console.WriteLine("How much would you like to deposit?");
                                Console.WriteLine();
                                numDeposited = double.Parse(Console.ReadLine());
                                savingsList[0].Deposit(numDeposited);
                                Console.WriteLine();
                                savingsList[0].ViewBalance();
                                break;
                            default:
                                break;
                        }
                        break;

                    //Withdrawals
                    case 4:
                        SubMenuPrinter();

                        userChoice2 = char.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (userChoice2)
                        {
                            case 'a':
                                Console.WriteLine("How much would you like to withdraw?");
                                Console.WriteLine();
                                double numWithdrawn = double.Parse(Console.ReadLine());
                                checkingList[0].Withdraw(numWithdrawn);
                                Console.WriteLine();
                                checkingList[0].ViewBalance();
                                break;
                            case 'b':
                                Console.WriteLine("How much would you like to withdraw?");
                                Console.WriteLine();
                                numWithdrawn = double.Parse(Console.ReadLine());
                                savingsList[0].Withdraw(numWithdrawn);
                                Console.WriteLine();
                                savingsList[0].ViewBalance();
                                break;
                            default:
                                break;
                        }
                        break;
                    
                    //Exits
                    case 5:
                        goAgain = false;
                        break;

                    default:
                        MenuPrinter();

                        userChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                }
            }
            while (goAgain);
            
            Console.WriteLine("Have a nice day!");

        }
        public static void MenuPrinter()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the number for your transaction type");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
        }
        public static void SubMenuPrinter()
        {
            Console.WriteLine("a. Checking Account");
            Console.WriteLine("b. Savings Account");
            Console.WriteLine();
        }
        public static Client ClientMaker()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your unique user name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your account number?");
            int acctNum = int.Parse(Console.ReadLine());

            Client newClient = new Client(name, userName, acctNum);

            return newClient;
        }
    }
}
