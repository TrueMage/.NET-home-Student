using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep.Exceptions
{
    internal class StringInputIsTooLongException : Exception
    {
        public StringInputIsTooLongException() { }
        public StringInputIsTooLongException(string message) : base(message) { }
        public StringInputIsTooLongException(string message, Exception inner)
        : base(message, inner){}
    }
}
