using home_06Sep.Exceptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace home_06Sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            if (name.Length >= 20) throw new StringIsTooLongException("Name's length can't exceed 20");
            Console.Clear();

            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            if (surname.Length >= 30) throw new StringIsTooLongException("Surname's length can't exceed 30");
            Console.Clear();

            Console.WriteLine("Patronymic: ");
            string patronymic = Console.ReadLine();
            if (patronymic.Length >= 24) throw new StringIsTooLongException("Name length can't exceed 24");
            Console.Clear();

            Console.WriteLine("Birthday (11.09.2023): ");
            string birthday = Console.ReadLine();
            Console.Clear();

            string[] birthdayArray = birthday.Split('.');
            DateTime birthdayFormatted = new DateTime(Convert.ToInt32(birthdayArray[2]), Convert.ToInt32(birthdayArray[1]), Convert.ToInt32(birthdayArray[0]));
            if (birthdayFormatted.Year == DateTime.Now.Year) throw new InvalidBirthdayException();
            if (birthdayFormatted.Year > 2017) throw new InvalidBirthdayException();

            Console.WriteLine("Tel. number: ");
            string tel = Console.ReadLine();
            if (tel.Length >= 15) throw new StringIsTooLongException("Telephone number length can't exceed 15 ch");
            Console.Clear();

            Student s = new Student(name, surname, patronymic, birthdayFormatted);
            s.setTel(tel);

            s.printInfo();

            s.setAddress(new Address("Kosmonavtov 44", "Odessa", "65017", "Ukraine"));
            s.printInfo();
        }
    }
}