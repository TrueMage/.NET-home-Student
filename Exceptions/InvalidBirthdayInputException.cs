using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep.Exceptions
{
    internal class InvalidBirthdayInputException : Exception
    {
        public InvalidBirthdayInputException() { }
        public InvalidBirthdayInputException(string message) : base(message) { }
        public InvalidBirthdayInputException(string message, Exception inner)
        : base(message, inner) { }
    }
}
