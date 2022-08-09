using System;

namespace SeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int money;
            int crystals = 0;
            int crystalPrice = rand.Next(5, 15);
            int crystalsAmount = 0;
            int maxToBuy;

            Console.WriteLine("Сколько у тебя с собой золота?");
            money = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Я продаю кристалы по цене {0} золота за штуку", crystalPrice);
            maxToBuy = money / crystalPrice;

            if (maxToBuy > 0)
            {
                Console.WriteLine("Максимальное кол-во кристалов которые ты можешь купить составляет: {0}\nСколько кристалов ты хочешь купить ?", maxToBuy);
                crystalsAmount = Convert.ToInt32(Console.ReadLine());

                if (crystalsAmount <= 0)
                {
                    Console.WriteLine("В следующий раз решайся на покупку.");
                }
                else if (crystalsAmount > maxToBuy)
                {
                    Console.WriteLine("Боюсь ты не можешь столько позволить...");
                }
                else
                {
                    money -= crystalsAmount * crystalPrice;
                    crystals += crystalsAmount;
                    Console.WriteLine("Приятно иметь с тобой дело!\nЗолото: {0}; Кристалы {1}", money, crystals);
                }
            }
            else
            {
                Console.WriteLine("Поднакопи золота и приходи в другой раз!)");
            }
        }
    }
}
