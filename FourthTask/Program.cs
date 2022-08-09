using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
            string[] zodiacSigns = { "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог" };

            int birthdayDay;
            int birthdayMonth;
            int birthdayYear;

            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

        BirthdayEntering:
            Console.WriteLine("Укажите Вашу дату рождения в формате дд.мм.гггг:");
            string birthdayString = Console.ReadLine();
            string[] birthdaySubstring = birthdayString.Split('.');

            Console.WriteLine(birthdaySubstring);

            if (birthdaySubstring.Length == 3)
            {
                birthdayDay = int.Parse(birthdaySubstring[0]);
                birthdayMonth = int.Parse(birthdaySubstring[1]);
                birthdayYear = int.Parse(birthdaySubstring[2]);
                if (12 - birthdayMonth < 0 || 31 - birthdayDay < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Вы указали неверную дату!");
                    goto BirthdayEntering;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы указали неверную дату!");
                goto BirthdayEntering;
            }

            int zodiacSignIndex = ZodiacIndexSearch(birthdayDay, birthdayMonth);

            
            if (zodiacSignIndex > 0)
            {
                Console.Clear();
                Console.WriteLine("Доброго времени суток {0}!\nВаша дата рождения {1} {2}\nВаш возраст: {3}\nСоответственно Ваш знак зодиака: {4}\n", name, birthdayDay, months[birthdayMonth - 1], AgeCalculator(birthdayDay, birthdayMonth, birthdayYear), zodiacSigns[zodiacSignIndex - 1]);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы указали неверную дату!");
                goto BirthdayEntering;
            }
        }

        static int AgeCalculator(int birthdayDay, int birthdayMonth, int birthdayYear)
        {
            int todayDay = DateTime.Today.Day;
            int todayMonth = DateTime.Today.Month;
            int todayYear = DateTime.Today.Year;

            if (birthdayMonth - todayMonth == 0)
            {
                if (birthdayDay - todayDay <= 0)
                {
                    return todayYear - birthdayYear;
                }
                else
                {
                    return todayYear - birthdayYear - 1;
                }
            }
            else if (birthdayMonth - todayMonth < 0)
            {
                return todayYear - birthdayYear;
            }
            else
            {
                return todayYear - birthdayYear - 1;
            }
        }

        static int ZodiacIndexSearch(int birthdayDay, int birthdayMonth)
        {
            if (((birthdayDay >= 21) && (birthdayMonth == 1)) || ((birthdayDay <= 18) && (birthdayMonth == 2)))
            {
                return 1;
            }
            else if (((birthdayDay >= 19) && (birthdayMonth == 2)) || ((birthdayDay <= 20) && (birthdayMonth == 3)))
            {
                return 2;
            }
            else if (((birthdayDay >= 21) && (birthdayMonth == 3)) || ((birthdayDay <= 19) && (birthdayMonth == 4)))
            {
                return 3;
            }
            else if (((birthdayDay >= 20) && (birthdayMonth == 4)) || ((birthdayDay <= 20) && (birthdayMonth == 5)))
            {
                return 4;
            }
            else if (((birthdayDay >= 21) && (birthdayMonth == 5)) || ((birthdayDay <= 21) && (birthdayMonth == 6)))
            {
                return 5;
            }
            else if (((birthdayDay >= 22) && (birthdayMonth == 6)) || ((birthdayDay <= 22) && (birthdayMonth == 7)))
            {
                return 6;
            }
            else if (((birthdayDay >= 23) && (birthdayMonth == 7)) || ((birthdayDay <= 22) && (birthdayMonth == 8)))
            {
                return 7;
            }
            else if (((birthdayDay >= 23) && (birthdayMonth == 8)) || ((birthdayDay <= 22) && (birthdayMonth == 9)))
            {
                return 8;
            }
            else if (((birthdayDay >= 23) && (birthdayMonth == 9)) || ((birthdayDay <= 23) && (birthdayMonth == 10)))
            {
                return 9;
            }
            else if (((birthdayDay >= 24) && (birthdayMonth == 10)) || ((birthdayDay <= 22) && (birthdayMonth == 11)))
            {
                return 10;
            }
            else if (((birthdayDay >= 23) && (birthdayMonth == 11)) || ((birthdayDay <= 21) && (birthdayMonth == 12)))
            {
                return 11;
            }
            else if (((birthdayDay >= 22) && (birthdayMonth == 12)) || ((birthdayDay <= 20) && (birthdayMonth == 1)))
            {
                return 12;
            }
            else return 0;
        }
    }
}
