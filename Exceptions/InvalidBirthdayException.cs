using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep.Exceptions
{
    internal class InvalidBirthdayException : Exception
    {
        public InvalidBirthdayException() { }
        public InvalidBirthdayException(string message) : base(message) { }
        public InvalidBirthdayException(string message, Exception inner)
        : base(message, inner) { }
    }
}
