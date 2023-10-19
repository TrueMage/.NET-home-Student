using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep.Exceptions
{
    internal class EmptyGroupException : Exception
    {
        public EmptyGroupException() { }
        public EmptyGroupException(string message) : base(message) { }
        public EmptyGroupException(string message, Exception inner)
        : base(message, inner) { }
    }
}
