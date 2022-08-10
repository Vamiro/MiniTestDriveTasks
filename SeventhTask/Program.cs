using System;

namespace SeventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int playersMoney;
            int playersCrystals = 0;
            int crystalPrice = random.Next(5, 15);
            int crystalsAmountToBuy = 0;
            int maximumCrystalsToBuy;

            Console.WriteLine("Сколько у тебя с собой золота?");
            playersMoney = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Я продаю кристалы по цене {0} золота за штуку", crystalPrice);
            maximumCrystalsToBuy = playersMoney / crystalPrice;

            if (maximumCrystalsToBuy > 0)
            {
                Console.WriteLine("Максимальное кол-во кристалов которые ты можешь купить составляет: {0}\nСколько кристалов ты хочешь купить ?", maximumCrystalsToBuy);
                crystalsAmountToBuy = Convert.ToInt32(Console.ReadLine());

                if (crystalsAmountToBuy <= 0)
                {
                    Console.WriteLine("В следующий раз решайся на покупку.");
                }
                else if (crystalsAmountToBuy > maximumCrystalsToBuy)
                {
                    Console.WriteLine("Боюсь ты не можешь столько позволить...");
                }
                else
                {
                    playersMoney -= crystalsAmountToBuy * crystalPrice;
                    playersCrystals += crystalsAmountToBuy;
                    Console.WriteLine("Приятно иметь с тобой дело!\nЗолото: {0}; Кристалы {1}", playersMoney, playersCrystals);
                }
            }
            else
            {
                Console.WriteLine("Поднакопи золота и приходи в другой раз!)");
            }
        }
    }
}
