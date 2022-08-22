using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Укажите Вашу дату рождения в формате дд.мм.гггг:");
            
            Birthday birthday = null;
            while (birthday == null)
            {
                var inputDate = Console.ReadLine();
                if (Birthday.TryParse(inputDate, out birthday))
                    break;
                
                Console.WriteLine($"Дата {inputDate} имеет неправильный формат");
            }

            ZodiacSing zodiacSing = new ZodiacSing(birthday);
            Console.WriteLine("Доброго времени суток {0}!'\n\nВаша дата рождения {1} {2},\nСоответственно ваш знак зодиака: {4},\nА ваш возраст: {3}!\n", name, birthday.DateOfBirthday.Day, birthday.GetMonthName(), birthday.CalculateAge(), zodiacSing.SearchZodiacSingName());
            
        }
    }
}
