using System;

namespace SixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxImagesInRow = 3;
            int imagesAmount = 52;
            int filledRows = imagesAmount / maxImagesInRow;
            int overageImages = imagesAmount - filledRows * maxImagesInRow;

            Console.WriteLine("Максимальное кол-во картинок в ряду: {0}\nИмеющееся кол-во картинок: {1}\nКол-во заполненых рядов: {2}\nКол-во картинок в избытке: {3}", maxImagesInRow, imagesAmount, filledRows, overageImages);
        }
    }
}
