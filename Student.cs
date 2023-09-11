using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using home_06Sep.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace home_06Sep
{
    internal class Student
    { 
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

        public Student(string name, string surname, string patronymic, DateTime birthday, int gradeCount = 10)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _birthday = birthday;

            _address = new Address();
            _tel = "not given";

            _homeworkGrades = new double[gradeCount];
            _examGrades = new double[gradeCount];
            _classworkGrades = new double[gradeCount];
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
    }
}
