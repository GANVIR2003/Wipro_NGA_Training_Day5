// See https://aka.ms/new-console-template for more information
using System;
using Day5_Program3.CustomExceptions;

namespace Day5_Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            BankAccount account = new BankAccount();

            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                userService.ValidateAge(age);

                Console.WriteLine("\nEnter withdrawal amount:");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Age Error: " + ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Balance Error: " + ex.Message);
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine("Limit Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Process completed.");
            }
        }
    }
}
