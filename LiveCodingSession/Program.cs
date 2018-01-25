/*
The system shall:

Implement double-entry/two-column accounting.

Store data using SQLite

- Provide a text-based user interface (TUI)

- Provide the following hard-coded accounts:
  Assets
  Equities
  Revenue
  Expenses
  Liabilities
  Gains
  Losses

Work on a concept of balanced credits and debits

Provide a method of ensuring balance between credits and debits

/ Present account balances upon request

Allow entry of a transaction with the following data:
  Identifier
  Description (stretch goal)
  USD Amount
  Credit or debit
  Associated account
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoColumnAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            var done = false;

            do
            {
                printMainMenu();
                done = actOnInput(elicitUserInput());
            } while (!done);
        }

        private static void printMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("----------");
            Console.WriteLine("1) Enter a Transaction");
            Console.WriteLine("2) Show Account Balances");
            Console.WriteLine("3) View Reports");
            Console.WriteLine("0) Exit the program"); // Zero is the universal "leave" command
        }

        // Elicits input from the user
        // Ensures input value is a valid integer
        private static int elicitUserInput()
        {
            var validInput = false;
            int val = 0;

            do
            {
                Console.Write("Please make your selection: ");

                try
                {
                    val = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException ex)
                {
                    Console.Write("Invalid selection. ");
                }
            } while (!validInput);

            return val;
        }

        // Returns whether or not the user selected to leave
        private static bool actOnInput(int selection)
        {
            var userWantsToLeave = false;

            switch (selection)
            {
                case 1:
                    enterATransaction();
                    break;
                case 2:
                    showAccountBalances();
                    break;
                case 3:
                    viewReports();
                    break;
                case 0:
                    userWantsToLeave = true;
                    break;
            }

            return userWantsToLeave; // Did not select to leave
        }

        private static void enterATransaction()
        {
            throw new NotImplementedException();

            Console.Clear();

            Console.Write("Enter an identifier for this transaction: ");
            var identifer = Console.ReadLine();

            Console.WriteLine("Enter a description for this transaction");
            var description = Console.ReadLine();

            // Try to elicit valid amount from the user
            decimal amount = elicitAmount();

            // Elicit the following
            //  - Credit or debit
            //  - Associated account

            // Ask for credit account
            // Use the account picker

            // Ask for debit account
            // Use the account picker

            // Store in SQLite
        }

        private static decimal elicitAmount()
        {
            var validInput = false;
            decimal amount = 0.0m;

            do
            {
                try
                {
                    Console.Write("Enter an amount in USD: $");
                    amount = decimal.Parse(Console.ReadLine());

                    if (amount > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Amount must be positive. ");
                    }
                }
                catch (FormatException ex)
                {
                    Console.Write("Invalid amount entered. ");
                }
            } while (!validInput);

            return amount;
        }

        private static void showAccountBalances()
        {
            throw new NotImplementedException();

            // Do an SQL query

            // Extract Balances (0.0m is a placeholder)
            decimal assetsBalance = 0.0m;
            decimal equitiesBalance = 0.0m;
            decimal revenueBalance = 0.0m;
            decimal expensesBalance = 0.0m;
            decimal liabilitiesBalance = 0.0m;
            decimal gainsBalance = 0.0m;
            decimal lossesBalance = 0.0m;

            Console.Clear();
            Console.WriteLine($"Assets: {assetsBalance}");
            Console.WriteLine($"Equities: {equitiesBalance}");
            Console.WriteLine($"Revenue: {revenueBalance}");
            Console.WriteLine($"Expenses: {expensesBalance}");
            Console.WriteLine($"Liabilities: {liabilitiesBalance}");
            Console.WriteLine($"Gains: {gainsBalance}");
            Console.WriteLine($"Losses: {lossesBalance}");
            Console.Write("\nPress enter to return...");
            Console.ReadLine();
        }

        private static void viewReports()
        {
            throw new NotImplementedException();
        }
    }
}

