using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_06Sep
{
    internal class GroupEnum : IEnumerator
    { // https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-7.0
        public List<Student> _students;
        private int _position = -1;

        public GroupEnum(List<Student> list)
        {
            _students = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _students.Count());
        }

        public void Reset()
        {
            _position = -1;
        }

        public Student Current
        {
            get
            {
                try
                {
                    return _students[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
