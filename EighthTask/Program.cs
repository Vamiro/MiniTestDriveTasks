using System;

namespace EighthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingTime = 10;
            int queue;
            int resultTime;

            string resultOutput = "";

            Console.WriteLine("Сколько старушек в очереди?");
            queue = Convert.ToInt32(Console.ReadLine());
            if (queue == 0)
            {
                Console.WriteLine("Чего стоишь? Проходи!");
            }
            else
            {
                resultTime = queue * waitingTime;

                if (resultTime - 524160 >= 0)
                {
                    int years = resultTime / 524160;
                    resultOutput += "года: " + years;
                    resultTime -= years * 524160;
                }
                if (resultTime - 1440 >= 0)
                {
                    int days = resultTime / 1440;
                    resultOutput += " дни: " + days;
                    resultTime -= days * 1440;
                }
                if (resultTime - 60 >= 0)
                {
                    int hours = resultTime / 60;
                    resultOutput += " часа: " + hours;
                    resultTime -= hours * 60;
                }
                if (resultTime != 0)
                {
                    resultOutput += " минуты: " + resultTime;
                    resultTime = 0;
                }
            }
            Console.WriteLine("Вы должны стоять в очереди:\n{0}", resultOutput);

        }
    }
}
