using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthsName = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
            string[] zodiacSigns = { "Водолей", "Рыбы", "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог" };
            string birthdayString;
            string[] birthdaySubstring;

            int birthdayDay;
            int birthdayMonth;
            int birthdayYear;
            int zodiacSignIndex;

            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
      
            while (true)
            {
                Console.WriteLine("Укажите Вашу дату рождения в формате дд.мм.гггг:");
                birthdayString = Console.ReadLine();
                birthdaySubstring = birthdayString.Split('.');

                if (birthdaySubstring.Length == 3)
                {
                    birthdayDay = int.Parse(birthdaySubstring[0]);
                    birthdayMonth = int.Parse(birthdaySubstring[1]);
                    birthdayYear = int.Parse(birthdaySubstring[2]);

                    if (12 - birthdayMonth < 0 || 31 - birthdayDay < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы указали неверную дату!");
                        continue;
                    }
                    else
                    {
                        zodiacSignIndex = SearchZodiacIndex(birthdayDay, birthdayMonth);

                        if (zodiacSignIndex > 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Доброго времени суток {0}!\nВаша дата рождения {1} {2}\nВаш возраст: {3}\nСоответственно Ваш знак зодиака: {4}\n", name, birthdayDay, monthsName[birthdayMonth - 1], CalculateAge(birthdayDay, birthdayMonth, birthdayYear), zodiacSigns[zodiacSignIndex - 1]);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Вы указали неверную дату!");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Вы указали неверную дату!");
                    continue;
                }
            }    
        }

        static int CalculateAge(int birthdayDay, int birthdayMonth, int birthdayYear)
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

        static int SearchZodiacIndex(int birthdayDay, int birthdayMonth)
        {
            int[,] zodiacSingsDates = new int[,] { { 21, 1, 18, 2 }, { 19, 2, 20, 3 }, { 21, 3, 18, 4 }, { 20, 4, 20, 5 }, { 21, 5, 21, 6 }, { 22, 6, 22, 7 }, { 23, 7, 22, 8 }, { 23, 8, 22, 9 }, { 23, 9, 23, 10 }, { 24, 10, 22, 11 }, { 23, 11, 21, 12 }, { 22, 12, 20, 1 } };

            if (((birthdayDay >= zodiacSingsDates[0, 0]) && (birthdayMonth == zodiacSingsDates[0, 1])) || ((birthdayDay <= zodiacSingsDates[0, 2]) && (birthdayMonth == zodiacSingsDates[0, 4])))
            {
                return 1;
            }
            else if (((birthdayDay >= zodiacSingsDates[1, 0]) && (birthdayMonth == zodiacSingsDates[1, 1])) || ((birthdayDay <= zodiacSingsDates[1, 2]) && (birthdayMonth == zodiacSingsDates[1, 4])))
            {
                return 2;
            }
            else if (((birthdayDay >= zodiacSingsDates[2, 0]) && (birthdayMonth == zodiacSingsDates[2, 1])) || ((birthdayDay <= zodiacSingsDates[2, 2]) && (birthdayMonth == zodiacSingsDates[2, 4])))
            {
                return 3;
            }
            else if (((birthdayDay >= zodiacSingsDates[3, 0]) && (birthdayMonth == zodiacSingsDates[3, 1])) || ((birthdayDay <= zodiacSingsDates[3, 2]) && (birthdayMonth == zodiacSingsDates[3, 4])))
            {
                return 4;
            }
            else if (((birthdayDay >= zodiacSingsDates[4, 0]) && (birthdayMonth == zodiacSingsDates[4, 1])) || ((birthdayDay <= zodiacSingsDates[4, 2]) && (birthdayMonth == zodiacSingsDates[4, 4])))
            {
                return 5;
            }
            else if (((birthdayDay >= zodiacSingsDates[5, 0]) && (birthdayMonth == zodiacSingsDates[5, 1])) || ((birthdayDay <= zodiacSingsDates[5, 2]) && (birthdayMonth == zodiacSingsDates[5, 4])))
            {
                return 6;
            }
            else if (((birthdayDay >= zodiacSingsDates[6, 0]) && (birthdayMonth == zodiacSingsDates[6, 1])) || ((birthdayDay <= zodiacSingsDates[6, 2]) && (birthdayMonth == zodiacSingsDates[6, 4])))
            {
                return 7;
            }
            else if (((birthdayDay >= zodiacSingsDates[7, 0]) && (birthdayMonth == zodiacSingsDates[7, 1])) || ((birthdayDay <= zodiacSingsDates[7, 2]) && (birthdayMonth == zodiacSingsDates[7, 4])))
            {
                return 8;
            }
            else if (((birthdayDay >= zodiacSingsDates[8, 0]) && (birthdayMonth == zodiacSingsDates[8, 1])) || ((birthdayDay <= zodiacSingsDates[8, 2]) && (birthdayMonth == zodiacSingsDates[8, 4])))
            {
                return 9;
            }
            else if (((birthdayDay >= zodiacSingsDates[9, 0]) && (birthdayMonth == zodiacSingsDates[9, 1])) || ((birthdayDay <= zodiacSingsDates[9, 2]) && (birthdayMonth == zodiacSingsDates[9, 4])))
            {
                return 10;
            }
            else if (((birthdayDay >= zodiacSingsDates[10, 0]) && (birthdayMonth == zodiacSingsDates[10, 1])) || ((birthdayDay <= zodiacSingsDates[10, 2]) && (birthdayMonth == zodiacSingsDates[10, 4])))
            {
                return 11;
            }
            else if (((birthdayDay >= zodiacSingsDates[11, 0]) && (birthdayMonth == zodiacSingsDates[11, 1])) || ((birthdayDay <= zodiacSingsDates[11, 2]) && (birthdayMonth == zodiacSingsDates[11, 4])))
            {
                return 12;
            }
            else
            {
                return 0;
            }
        }
    }
}
