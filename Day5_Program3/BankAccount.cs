using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Program3
{
    public class BankAccount
    {
        private decimal balance = 5000;
        private decimal dailyLimit = 2000;
        private decimal totalWithdrawnToday = 0;

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance.");
            }

            if (totalWithdrawnToday + amount > dailyLimit)
            {
                throw new DailyLimitExceededException("Daily withdrawal limit exceeded.");
            }

            balance -= amount;
            totalWithdrawnToday += amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining balance: " + balance);
        }
    }
}
    
