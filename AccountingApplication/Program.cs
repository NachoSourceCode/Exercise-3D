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
            // define menu options
            Console.WriteLine(" 1) Check Balances\n 2) View Account(s)\n " +
                "3) Enter Transaction\n 4) View Reports\n");
            //present user with menu options.
            Console.WriteLine("Please choose a menu option:");
            ////get input
            var option = int.Parse(Console.ReadLine());
            //act on input
            // var selectedCheckBalances = checkBalances();
            /*
            if (option == 1)
            {
                var selectedCheckBalances = checkBalances();
            }
            else if (option == 2)
            {
                var selectedViewAccounts = viewAccounts()
            }
            else if (option == 3)
            {
                var selectedEnterTransaction = enterTransaction();
            }
            else if (option == 4)
            {
                var selectedViewReports = viewReports();
            }
            else
            {
                Console.WriteLine("You did not select a valid menu option.");
                Console.WriteLine("Please choose a menu option:");
            }
            */
            //if (option (>= 1) && (<= 4));
            // Create argument to go to a method based on an option selected.
        }
        /*
        // create main menu
        int mainMenu()
        {
            char mMenu = option1, option2, option3, option4; 
        }
        */
        // create check balances method
     /* static int checkBalances()
        {
            Console.WriteLine(" 1) Account(s)\n 2) Return to Main Menu\n");
            Console.WriteLine("Please select a menu option:");
            
        }
     */
      /*static int viewAccounts()
        {

        }*/
        // create enter transaction method
        /*
        static int enterTransaction()
        {

        }
        // create veiw reports method.
        static int viewReports()
        {

        }
        */
    }
}
