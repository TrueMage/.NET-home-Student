using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using home_06Sep.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace home_06Sep
{
    internal class Student : IComparable
    {
        #region Comparers
        public class NameComparer : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student student1, Student student2)
            {
                if (student2 != null && student1 != null)
                    return student1._name.CompareTo(student2._name);
                else
                    throw new ArgumentException("Objects are not Student");
            }
        }

        public class DateComparer : IComparer<Student>
        {
            int IComparer<Student>.Compare(Student student1, Student student2)
            {
                if (student2 != null && student1 != null)
                    return student1._birthday.CompareTo(student2._birthday);
                else
                    throw new ArgumentException("Objects are not Student");
            }
        }
        #endregion

        Random random = new Random();
        #region Info
        private string _name;
        private string _surname;
        private string _patronymic;

        private DateTime _birthday;

        private Address _address;
        private string _tel;
        #endregion

        #region GRADES ARRAYS
        private double[] _homeworkGrades;
        private double[] _examGrades;
        private double[] _classworkGrades;
        #endregion

        #region Constructors

        public Student(int gradeCount = 10)
        {
            _name = GetRandomName();
            _surname = GetRandomSurname();
            _patronymic = GetRandomPatronymic();

            DateTime date = new DateTime(random.Next(2003, 2008), random.Next(1, 12), random.Next(1, 28));
            _birthday = date;

            _address = new Address();
            _tel = "not given";

            _homeworkGrades = new double[gradeCount];
            for (int i = 0; i < _homeworkGrades.Length; i++)
            {
                _homeworkGrades[i] = random.Next(0, 12);
            }

            _examGrades = new double[gradeCount];
            for (int i = 0; i < _examGrades.Length; i++)
            {
                _examGrades[i] = random.Next(0, 12);
            }

            _classworkGrades = new double[gradeCount];
            for (int i = 0; i < _classworkGrades.Length; i++)
            {
                _classworkGrades[i] = random.Next(0, 12);
            }
        }


        public Student(string name, string surname, string patronymic, DateTime birthday, int gradeCount = 10)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _birthday = birthday;

            _address = new Address();
            _tel = "not given";

            _homeworkGrades = new double[gradeCount];
            for(int i = 0; i < _homeworkGrades.Length; i++)
            {
                _homeworkGrades[i] = random.Next(0, 12);
            }

            _examGrades = new double[gradeCount];
            for (int i = 0; i < _examGrades.Length; i++)
            {
                _examGrades[i] = random.Next(0, 12);
            }

            _classworkGrades = new double[gradeCount];
            for (int i = 0; i < _classworkGrades.Length; i++)
            {
                _classworkGrades[i] = random.Next(0, 12);
            }
        }

        public Student(string name, string surname, string patronymic, DateTime birthday, Address address, string tel, int gradeCount = 10)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _birthday = birthday;

            _address = address;
            _tel = tel;

            _homeworkGrades = new double[gradeCount];
            _examGrades = new double[gradeCount];
            _classworkGrades = new double[gradeCount];
        }
        #endregion

        #region Getter
        public string getName()
        {
            return _name;
        }

        public string getSurname()
        {
            return _surname;
        }

        public string getPatronymic()
        {
            return _patronymic;
        }

        public DateTime getBirthday()
        {
            return _birthday;
        }

        public Address getAddress()
        {
            return _address;
        }

        public string getTel()
        {
            return _tel;
        }

        public double[] getHomeworkGrades()
        {
            return _homeworkGrades;
        }
        public double[] getExamGrades()
        {
            return _examGrades;
        }
        public double[] getClassworkGrades()
        {
            return _classworkGrades;
        }

        #endregion

        #region Setter
        public void setName(string name)
        {
            if (name.Length >= 20) throw new StringIsTooLongException("Name's length can't exceed 20");
            _name = name;
        }

        public void setSurname(string surname)
        {
            if (surname.Length >= 30) throw new StringIsTooLongException("Surname's length can't exceed 30");
            _surname = surname;
        }

        public void setPatronymic(string patronymic)
        {
            if (patronymic.Length >= 24) throw new StringIsTooLongException("Name length can't exceed 24");
            _patronymic = patronymic;
        }

        public void setBirthday(DateTime date)
        {
            if (date.Year == DateTime.Now.Year) throw new InvalidBirthdayException();
            if (date.Year > 2017) throw new InvalidBirthdayException();
            _birthday = date;
        }

        public void setAddress(Address address)
        {
            _address = address;
        }

        public void setTel(string tel)
        {
            if (tel.Length >= 15) throw new StringIsTooLongException("Telephone number length can't exceed 15 ch");
            _tel = tel;
        }

        public void setHomeworkGrades(double[] array)
        {
            _homeworkGrades = array;
        }
        public void setExamGrades(double[] array)
        {
            _examGrades = array;
        }
        public void setClassworkGrades(double[] array)
        {
            _classworkGrades = array;
        }

        #endregion

        #region Overloading

        public static bool operator true(Student a)
        {
            return a.getAverageHomework() >= 7;
        }

        public static bool operator false(Student a)
        {
            return a.getAverageHomework() < 7;
        }


        public static bool operator ==(Student a, Student b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (((object)a == null) || ((object)b == null)) return false;

            return a.getAverageHomework() == b.getAverageHomework();
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }


        public static bool operator <(Student a, Student b)
        {
            return a.getAverageHomework() < b.getAverageHomework();
        }

        public static bool operator >(Student a, Student b)
        {
            return a.getAverageHomework() > b.getAverageHomework();
        }

        public static bool operator <=(Student a, Student b)
        {
            return a.getAverageHomework() <= b.getAverageHomework();
        }

        public static bool operator >=(Student a, Student b)
        {
            return a.getAverageHomework() >= b.getAverageHomework();
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set {
                setName(value);
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                setSurname(value);
            }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                setPatronymic(value);
            }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { setBirthday(value); }
        }

        public Address Address // Немного неудачно вышло
        {
            get { return Address; }
            set { setAddress(value); }
        }

        public string Tel
        {
            get { return _tel; }
            set { setTel(value); }
        }

        public double[] HomeworkGrades
        {
            get { return _homeworkGrades; }
            set { setHomeworkGrades(value); }
        }
        public double[] ExamGrades
        {
            get { return _examGrades; }
            set { setExamGrades(value); }
        }
        public double[] ClassworkGrades
        {
            get { return _classworkGrades; }
            set { setClassworkGrades(value); }
        }
        #endregion

        #region Public Methods
        public double getAverageHomework()
        {
            double sum = 0;
            foreach(double grade in _homeworkGrades)
            {
                sum += grade;
            }
            return sum / _homeworkGrades.Length;
        }

        public double getAverageExam()
        {
            double sum = 0;
            foreach (double grade in _examGrades)
            {
                sum += grade;
            }
            return sum / _examGrades.Length;
        }

        public void printInfo()
        {
            Console.WriteLine($"Student {_name} {_surname} {_patronymic}");
            Console.WriteLine($"Birthday {_birthday.Date}");
            Console.Write($"Address ");
            _address.print();
            Console.WriteLine($"Tel {_tel}");

            Console.WriteLine("Grades\n");

            Console.WriteLine("Homework");
            foreach (double grade in _homeworkGrades)
            {
                Console.Write(grade + "\t");
            }

            Console.WriteLine("\nExams");
            foreach (double grade in _examGrades)
            {
                Console.Write(grade + "\t");
            }

            Console.WriteLine("\nClasswork");
            foreach (double grade in _classworkGrades)
            {
                Console.Write(grade + "\t");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Changes information about the student
        /// </summary>
        public void Edit(Address? address)
        {
            Console.Write("New name = ");
            string newName = Console.ReadLine() ?? _name; // Я знаю, что это не совсем хороший вариант, потому что если нового имени не будет, то код поставит старое, и программе
                                                          // придётся менять старое имя на старое, что чутка бессмысленно, но я хотел похвастаться использованием ??
            setName(newName);

            Console.Write("New surname = ");
            string newSurname = Console.ReadLine() ?? _surname;
            setSurname(newSurname);

            Console.Write("New patronymic = ");
            string newPatron = Console.ReadLine() ?? _patronymic;
            setSurname(newPatron);

            Console.Write("New tel = ");
            string newTel = Console.ReadLine() ?? _tel;
            setTel(newTel);

            if(address != null) setAddress(address);
        }
        #endregion

        #region Private Methods
        private string GetRandomName()
        {
            Random random = new Random();

            string[] names = new string[8]
            {
                "Олег",
                "Андрей",
                "Дмитрий",
                "Василий",
                "Егор",
                "Никита",
                "Марк",
                "Игорь"
            };

            return names[random.Next(0, names.Length)];
        }

        private string GetRandomSurname()
        {
            Random random = new Random();

            string[] names = new string[10]
            {
                "Храмцов",
                "Громанчук",
                "Анохин",
                "Толмачов",
                "Кобзар",
                "Загоруйко",
                "Морозов",
                "Бутурлакин",
                "Ткаченко",
                "Кирлан"
            };

            return names[random.Next(0, names.Length)];
        }

        private string GetRandomPatronymic()
        {
            Random random = new Random();

            string[] patronymic = new string[4]
            {
                "Дмитриевич",
                "Никитович",
                "Валерьевич",
                "Николаевич"
            };

            return patronymic[random.Next(0, patronymic.Length)];
        }
        #endregion

        #region IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student Student2 = obj as Student;

            if (Student2 != null)
                return this._surname.CompareTo(Student2._surname);
            else
                throw new ArgumentException("Object is not a Student");
        }
        #endregion
    }
}
