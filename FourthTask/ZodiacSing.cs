namespace FourthTask
{
    class ZodiacSing
    {
        public Birthday Birthday { get; }

        public struct ZodiacInfo
        {
            public int Day;
            public string Sing;
        }

        private static ZodiacInfo[] _zodiacs = {
            new ZodiacInfo {Day = 20, Sing = "Водолей"},
            new ZodiacInfo {Day = 19, Sing = "Рыбы"},
            new ZodiacInfo {Day = 21, Sing = "Овен"},
            new ZodiacInfo {Day = 21, Sing = "Телец"},
            new ZodiacInfo {Day = 21, Sing = "Близнецы"},
            new ZodiacInfo {Day = 21, Sing = "Рак"},
            new ZodiacInfo {Day = 23, Sing = "Лев"},
            new ZodiacInfo {Day = 23, Sing = "Дева"},
            new ZodiacInfo {Day = 23, Sing = "Весы"},
            new ZodiacInfo {Day = 23, Sing = "Скорпион"},
            new ZodiacInfo {Day = 22, Sing = "Стрелец"},
            new ZodiacInfo {Day = 22, Sing = "Козерог"},

        };
        
        public ZodiacSing(Birthday birthday)
        {
            Birthday = birthday;
        }
        
        public string SearchZodiacSingName()
        {
            var dateOfBirthday = Birthday.DateOfBirthday;
            int month = dateOfBirthday.Month - 1;
            int day = dateOfBirthday.Day;

            var info = _zodiacs[month];
            if (day < info.Day) 
                info = _zodiacs[(month + _zodiacs.Length - 1) % _zodiacs.Length];

            return info.Sing;
        }
    }
}
