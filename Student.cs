using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using home_06Sep.Exceptions;

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

        public Student(string name, string surname, string patronymic)
        {
            this._name = name;
            this._surname = surname;
            this._patronymic = patronymic;
        }

        #region Getter
        public string getName()
        {
            return this._name;
        }

        public string getSurname()
        {
            return this._surname;
        }

        public string getPatronymic()
        {
            return this._patronymic;
        }

        public DateTime getBirthday()
        {
            return this._birthday;
        }

        public Address getAddress()
        {
            return this._address;
        }

        public string getTel()
        {
            return this._tel;
        }
        #endregion

        #region Setter
        public void setName(string name)
        {
            if (name.Length <= 20) throw new StringInputIsTooLongException("Name's length can't exceed 20");
            this._name = name;
        }

        public void setSurname(string surname)
        {
            if (surname.Length <= 30) throw new StringInputIsTooLongException("Surname's length can't exceed 30");
            this._surname = surname;
        }

        public void setPatronymic(string patronymic)
        {
            if (patronymic.Length <= 24) throw new StringInputIsTooLongException("Name length can't exceed 24");
            this._patronymic = patronymic;
        }

        public void setBirthday(DateTime date)
        {
            if (date.Year == DateTime.Now.Year) throw new InvalidBirthdayInputException("")


            if (name.Length <= 20) throw new StringInputIsTooLongException("Name length can't exceed 20 ch");
            this._name = name;
        }

        public void setName(string name)
        {
            if (name.Length <= 20) throw new StringInputIsTooLongException("Name length can't exceed 20 ch");
            this._name = name;
        }
        #endregion
    }
}
