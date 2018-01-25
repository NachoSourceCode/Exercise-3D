/* The system shall:
    Implement double-entry/two-column accounting.
    Store data using SQLite
    Provide a text-based user interface (TUI)
    Provide the following hard-coded accounts:
        Assets
        Liabilities
        Equities
        Revenue
        Expenses
        Gains
        Losses
    Work on a concept of balanced credits and debits
    Provide a method of ensuring balance between credits and debits
    Present account balances upon request
    Allow entry of a transaction with the following data:
        Identifier
        Description (stretch goal)
        USD Amount
        Credit or debit
        Associated account
  Stretch Goals:
    Basic reports
    Transaction descriptions
*/
//REMEMBER: If applied this commit will...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApplication
{
    //static methods so that main can call the other methods called in ' Program ' class.
    class Program
    {
        static void Main(string[] args)
        {
            var userDone = false;

            do
            {
                displayMainMenu();
                userDone = directUserInput(elicitUserInput());
            }
            while (!userDone);
           
        }
        private static void displayMainMenu()
        {
            Console.Clear();
            Console.WriteLine(" MAIN MENU");
            Console.WriteLine("  1) Check Reports");
            Console.WriteLine("  2) Check Account(s)");
            Console.WriteLine("  3) Enter Transaction");
            Console.WriteLine("  4) Exit Program", '\n');
        }
        public static int elicitUserInput()
        {
            var validInput = false;
            int storedVal = 0;

            do
            {
                Console.Write("Please choose a menu option: ");

                try
                {
                    storedVal = int.Parse(Console.ReadLine());

                }
                catch (FormatException ex)
                {
                    Console.Write("Invalid slection. Please choose again.");
                }
            }
            while ((storedVal < 1) || (storedVal > 4));
            
            return storedVal;
            
        }
        public static bool directUserInput(int selection)
        {
            var userWantsToLeave = false;
            
            switch (selection)
            {
                case 1:
                    userWantsToLeave = CheckReports();
                    break;
                case 2:
                    userWantsToLeave = CheckAccountBalances();
                    break;
                case 3:
                    userWantsToLeave = EnterTransaction();
                    break;
                case 4:
                    userWantsToLeave = true;
                    break;
            }
            return userWantsToLeave;
        }
        private static bool CheckReports()
        {
            //throw new NotImplementedException();
            //Display view all ledgers
            //Display select ledger
            //illicit input
            Console.Clear();
            Console.WriteLine(" View Reports    ");
            Console.WriteLine("  1) Main Menu");
            Console.WriteLine("  2) Exit Program");
            Console.Write(" Please select a menu option:");
            return (int.Parse(Console.ReadLine())) == 2;
        }
        private static bool CheckAccountBalances()
        {
            //throw new NotImplementedException();
            //sql query output of a list of account(s) and their balances.
            //display general client account(s) and it's info.
            Console.Clear();
            Console.WriteLine(" General Client Account(s):    ");
            Console.WriteLine("  1) Main Menu");
            Console.WriteLine("  2) Exit Program");
            Console.Write(" Please select a menu option:");
            return int.Parse(Console.ReadLine()) == 2;
            
        }
        private static bool EnterTransaction()
        {
            Console.Clear();
            Console.WriteLine(" Transaction(s) Menu    ");
            Console.WriteLine("  1) Add Account");
            Console.WriteLine("  2) Remove Account");
            Console.WriteLine("  3) Edit Account");
            Console.WriteLine("  4) Main Menu");
            Console.WriteLine("  5) Exit Program");
            Console.Write(" Please select a menu option:");
            return int.Parse(Console.ReadLine()) == 5;
        }
    }
}