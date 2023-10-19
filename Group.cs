using home_06Sep.Exceptions;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace home_06Sep
{
    internal class Group
    {
        Random random = new Random();
        private static int _count = 0;

        private int _id;
        private string _name;
        private string _spec;
        private List<Student> _students;

        #region Constructors
        public Group(int count = 10)
        {
            _id = _count++;
            _name = "П" + random.Next(1, 100);
            _spec = ".net";

            _students = new List<Student> { };
            for (int i = 0; i < count; i++)
            {
                _students.Add(new Student());
            }
            _students.Sort();
        }

        public Group(string name, string specialization, List<Student> students)
        {
            _id = _count++;
            _name = name;
            _spec = specialization;
            _students = students;
        }

        public Group(Group group)
        {
            _id = _count++;
            _name = group._name;
            _spec = group._spec;
            _students = group._students;
        }

        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value.Length >= 20) throw new StringIsTooLongException("Name's length can't exceed 20");
                _name = value;
            }
        }

        public string Spec
        {
            get { return _spec; }
            set {
                if (value.Length >= 20) throw new StringIsTooLongException("Name's length can't exceed 20");
                _spec = value;
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Prints information about the group and students
        /// </summary>
        public void PrintAll()
        {
            Console.WriteLine("#" + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Specialization: " + _spec);
            Console.WriteLine("Students:\n");
            int c = 0;
            foreach (Student student in _students)
            {
                Console.WriteLine("#" + c++);
                student.printInfo();
            }
            Console.WriteLine("\n\n");
        }
        /// <summary>
        /// Adds new student in the group
        /// </summary>
        public void AddNewStudent(Student newStudent)
        {
            _students.Add(newStudent);
        }

        /// <summary>
        /// Transfer a student with same id into the new group
        /// </summary>
        public void TransferStudent(int id, Group newGroup)
        {
            newGroup.AddNewStudent(_students[id]);
            _students.RemoveAt(id);   
        }

        /// <summary>
        /// Removes students who did not pass exams
        /// </summary>
        public void RemoveFailedStudents()
        {
            List<Student> unpassed = new List<Student>();
            foreach (Student student in _students)
            {
                if (student.getAverageExam() < 6) unpassed.Add(student);
            }

            foreach (Student student in unpassed)
            {
                _students.Remove(student);
            }
        }

        /// <summary>
        /// Removes a student with lowest homeworks score
        /// </summary>
        public void RemoveWLowestScoreStudent()
        {
            if (_students.Count() == 0) throw new EmptyGroupException("The group doesn't have any students in itself");

            Student lowestScore = _students[0];

            for (int i = 1; i < _students.Count(); i++)
            {
               if(lowestScore.getAverageHomework() < _students[i].getAverageHomework()) lowestScore = _students[i];
            }

            _students.Remove(lowestScore);
        }

        /// <summary>
        /// Changes information about the group
        /// </summary>
        public void Edit()
        {
            Console.Write("New name = ");
            string newName = Console.ReadLine();
            if(newName.Length != 0) Name = newName;

            Console.Write("New specialization = ");
            string newSpec = Console.ReadLine();
            if (newSpec.Length != 0) Spec = newSpec;
        }
        #endregion
    }
}
