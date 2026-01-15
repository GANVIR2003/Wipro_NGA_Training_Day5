// See https://aka.ms/new-console-template for more information
using System;

namespace Day5_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Make Transaction");
                Console.WriteLine("2. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter transaction amount:");
                        decimal amount = Convert.ToDecimal(Console.ReadLine());

                        try
                        {
                            account.MakeTransaction(amount);
                        }
                        catch (DailyLimitExceeded ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Remaining balance: " + account.RemainingBalance);
                        }

                        break;

                    case 2:
                        exit = true;
                        Console.WriteLine("Thank you. Exiting application.");
                        break;

                    default:
                        Console.WriteLine("Transaction limit Exceeded,Enter your new transaction amount");
                        break;
                }
            }
        }
    }
}