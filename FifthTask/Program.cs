using System;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Пупкин";
            string surname = "Василий";
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nЧто-то тут не так...", name, surname);
            (name, surname) = (surname, name);
            Console.WriteLine("Имя: {0}\nФамилия: {1}", name, surname);
        }
    }
}
