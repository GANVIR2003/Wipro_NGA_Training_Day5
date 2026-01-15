using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Program3
{
    public class CustomException
    {

        public InvalidAgeException(string message) : base(message) { }
    }

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message) { }
    }
}
    
