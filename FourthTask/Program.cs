using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

            Birthday birthday = new Birthday();
            ZodiacSing zodiacSing = new ZodiacSing(birthday.DateOfBirthday);
            Console.WriteLine("Доброго времени суток {0}!'\n\nВаша дата рождения {1} {2},\nСоответственно ваш знак зодиака: {4},\nА ваш возраст: {3}!\n", name, birthday.DateOfBirthday.Day, birthday.GetMonthName(), birthday.CalculateAge(), zodiacSing.SearchZodiacSingName());
        }
    }
}
