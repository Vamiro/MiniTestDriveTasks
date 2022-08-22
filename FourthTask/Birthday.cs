using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FourthTask
{
    class Birthday
    {
        public string[] MonthsNames = new string[]
        {
            "Января",
            "Февраля",
            "Марта",
            "Апреля",
            "Мая",
            "Июня",
            "Июля",
            "Августа",
            "Сентября",
            "Октября",
            "Ноября",
            "Декабря"
        };

        public DateTime DateOfBirthday { get; private set; }

        public Birthday(DateTime birthday) {
            DateOfBirthday = birthday;
        }
    
        public string GetMonthName()
        {
            return MonthsNames[DateOfBirthday.Month-1];
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

        public static bool TryParse(string inputDate, out Birthday birthday)
        {
            birthday = DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, DateTimeStyles.None,
                out var parsedDateOfBirthday) 
                ? new Birthday(parsedDateOfBirthday) : null;
            return birthday != null;
        }

        public void AddDay(int offset)
        {
            DateOfBirthday = DateOfBirthday.AddDays(offset);
        }
    }
}
