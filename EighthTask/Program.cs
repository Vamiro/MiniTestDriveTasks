using System;

namespace EighthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingTimeInMinutes = 10;
            int queue;
            int resultTimeInMinutes;
            int minute = 1;
            int hourInMinutes = minute * 60;
            int dayInMinutes = hourInMinutes * 24;
            int yearInMinutes = dayInMinutes * 365;

            string resultOutput = "";

            Console.WriteLine("Сколько старушек в очереди?");
            queue = Convert.ToInt32(Console.ReadLine());

            if (queue == 0)
            {
                Console.WriteLine("Чего стоишь? Проходи!");
            }
            else
            {
                resultTimeInMinutes = queue * waitingTimeInMinutes;

                if (resultTimeInMinutes - yearInMinutes >= 0)
                {
                    int yearsToWait = resultTimeInMinutes / yearInMinutes;
                    resultOutput += " Год: " + yearsToWait;
                    resultTimeInMinutes %= yearInMinutes;
                }

                if (resultTimeInMinutes - dayInMinutes >= 0)
                {
                    int daysToWait = resultTimeInMinutes / dayInMinutes;
                    resultOutput += " День: " + daysToWait;
                    resultTimeInMinutes %= dayInMinutes;
                }

                if (resultTimeInMinutes - hourInMinutes >= 0)
                {
                    int hoursToWait = resultTimeInMinutes / hourInMinutes;
                    resultOutput += " Час: " + hoursToWait;
                    resultTimeInMinutes %= hourInMinutes;
                }

                if (resultTimeInMinutes != 0)
                {
                    resultOutput += " Минута: " + resultTimeInMinutes;
                    resultTimeInMinutes = 0;
                }
                resultOutput = resultOutput.Substring(1);
                Console.WriteLine("Вы должны стоять в очереди:\n{0}", resultOutput);
            }
        }
    }
}
