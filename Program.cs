using home_06Sep.Exceptions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace home_06Sep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Лучшее закоментить вывод оценок в Student в printInfo для проверки первых

            // Add new Student 
            Group group = new Group(4);
            group.PrintAll();

            group.AddNewStudent(new Student());
            group.PrintAll();

            // Transfer
            Group groupB = new Group(2);
            groupB.PrintAll();

            group.TransferStudent(0, groupB);
            group.PrintAll();
            groupB.PrintAll();

            // Remove unpassed

            group.RemoveFailedStudents();
            group.PrintAll();

            // Remove student w lowest score

            group.RemoveWLowestScoreStudent();
            group.PrintAll();


            /*Console.WriteLine("Name: ");
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
            s.printInfo();*/

            /*  Student a = new Student("", "", "", new DateTime(2003, 12, 13));
              Student s = new Student("", "", "", new DateTime(2003, 12, 13));

              double[] gradesA = new double[] { 3, 5, 10, 5, 4 };
              double[] gradesS = new double[] { 10, 8, 10, 10, 9 };

              a.HomeworkGrades = gradesA;
              s.HomeworkGrades = gradesS;

              Console.WriteLine($"A < S = {a < s}");

              if(a) Console.WriteLine("a > 7");
              else Console.WriteLine("a < 7");*/

            //grades[4] += 5;
            //s.printInfo();
        }
    }
}