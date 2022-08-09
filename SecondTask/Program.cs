﻿using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Тип целого числа со знаком. Диапазон: [−2 147 483 648, +2 147 483 647].
            int integerVariable = -2147483648;

            // Тип целого числа без знака. Диапазон: [0, +4 294 967 295].
            uint unsignedIntegerVariable = 4294967295;

            //  Тип длинного целого числа со знаком. Диапазон: [−9 223 372 036 854 775 808, +9 223 372 036 854 775 807].
            long longVariable = 9223372036854775807;

            // Тип длинного целого числа без знака. Диапазон: [0, 18 446 744 073 709 551 615].
            ulong unsignedLongVariable = 18446744073709551615;

            // Тип вещественного числа с плавающей запятой, обычно называемый типом числа двойной точности с плавающей запятой.
            double doubleVariable = 1.01;

            // Тип вещественного числа с плавающей запятой, обычно называемый типом числа одинарной точности с плавающей запятой.
            // В отличие от float и double, может быть 80-битным форматом с плавающей запятой.
            float floatVariable = 7.07f;

            // Тип целочисленный, самый маленький из возможных адресуемых типов. Может содержать базовый набор символов.
            char charVariable = 'A';

            // Тип строка (ссылочный тип, массив элементов типа Char).
            string stringVariable = "I'm Junior";

            // Тип представляющий логическое значение: true или false [1, 0].
            bool booleanVariable = true;

            // Тип маленького целого числа без знака.  Диапазон: [0, 255].
            byte byteVariable = 255;
            
            
        }
    }
}
