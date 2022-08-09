using System;

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxInRow = 3;
            int imagesAmount = 52;
            int filledRows = imagesAmount / maxInRow;
            int overageImages = imagesAmount - filledRows * maxInRow;

            Console.WriteLine("Максимальное кол-во картинок в ряду: {0}\nИмеющееся кол-во картинок: {1}\nКол-во заполненых рядов: {2}\nКол-во картинок в избытке: {3}", maxInRow, imagesAmount, filledRows, overageImages);
        }
    }
}
