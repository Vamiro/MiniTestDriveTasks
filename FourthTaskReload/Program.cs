using System;

namespace FourthTaskReload
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string birthday;
            string zodiacSing;
            string country;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Какая ваша дата рождения?");
            birthday = Console.ReadLine();
            Console.WriteLine("Какой ваш знак зодиака?");
            zodiacSing = Console.ReadLine();
            Console.WriteLine("Откуда вы родом?");
            country = Console.ReadLine();
            Console.WriteLine("Доброго времени суток {0}!\nВы родились: {1}.\nВаш знак зодиака {2}.\nВаша родина это {3}.", name, birthday, zodiacSing, country);
        }
    }
}
