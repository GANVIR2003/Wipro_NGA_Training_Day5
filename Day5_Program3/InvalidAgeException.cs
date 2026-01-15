using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Program3
{
    internal class InvalidAgeException: Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
}
   
