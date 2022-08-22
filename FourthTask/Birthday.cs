using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FourthTask
{
    class Birthday
    {
        public DateTime DateOfBirthday { get; }

        public Birthday() {
            DateOfBirthday = ParseInputBirthday();
        }
        
        public DateTime ParseInputBirthday()
        {
            DateTime parsedDateOfBirthday;
            string inputDate;

            do
            {
                Console.WriteLine("Укажите Вашу дату рождения в формате дд.мм.гггг:");
                inputDate = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, DateTimeStyles.None, out parsedDateOfBirthday));
            return parsedDateOfBirthday;
        }

        public MonthsNames GetMonthName()
        {
            MonthsNames monthName = (MonthsNames)DateOfBirthday.Month;
            return monthName;
        }

        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirthday.Year;

            if (DateOfBirthday.Date > today.AddYears(-age)) age--;
            return age;
        }

        public void PrintDate()
        {
            Console.WriteLine(DateOfBirthday);
        }

    }
}
