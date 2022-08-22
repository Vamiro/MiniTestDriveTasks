using System;

namespace FourthTask
{
    class ZodiacSing
    {
        DateTime DateOfBirthday { get; }

        public ZodiacSing(DateTime DateOfBirthday)
        {
            this.DateOfBirthday = DateOfBirthday;
        }

        public ZodiacSings SearchZodiacSingName()
        {
            int month = DateOfBirthday.Month;
            int day = DateOfBirthday.Day;

            switch (month)
            {
                case 1:
                    if (day <= 19)
                        return (ZodiacSings)12;
                    else
                        return (ZodiacSings)1;

                case 2:
                    if (day <= 18)
                        return (ZodiacSings)1;
                    else
                        return (ZodiacSings)2;
                case 3:
                    if (day <= 20)
                        return (ZodiacSings)2;
                    else
                        return (ZodiacSings)3;
                case 4:
                    if (day <= 19)
                        return (ZodiacSings)3;
                    else
                        return (ZodiacSings)4;
                case 5:
                    if (day <= 20)
                        return (ZodiacSings)4;
                    else
                        return (ZodiacSings)5;
                case 6:
                    if (day <= 20)
                        return (ZodiacSings)5;
                    else
                        return (ZodiacSings)6;
                case 7:
                    if (day <= 22)
                        return (ZodiacSings)6;
                    else
                        return (ZodiacSings)7;
                case 8:
                    if (day <= 22)
                        return (ZodiacSings)7;
                    else
                        return (ZodiacSings)8;
                case 9:
                    if (day <= 22)
                        return (ZodiacSings)8;
                    else
                        return (ZodiacSings)9;
                case 10:
                    if (day <= 22)
                        return (ZodiacSings)9;
                    else
                        return (ZodiacSings)10;
                case 11:
                    if (day <= 21)
                        return (ZodiacSings)10;
                    else
                        return (ZodiacSings)11;
                case 12:
                    if (day <= 21)
                        return (ZodiacSings)11;
                    else
                        return (ZodiacSings)12;;
            }
            return 0;
        }
    }
}
