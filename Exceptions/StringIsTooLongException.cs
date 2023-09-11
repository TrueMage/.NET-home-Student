using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep.Exceptions
{
    internal class StringIsTooLongException : Exception
    {
        public StringIsTooLongException() { }
        public StringIsTooLongException(string message) : base(message) { }
        public StringIsTooLongException(string message, Exception inner)
        : base(message, inner){}
    }
}
