namespace CodeSmell.StatementCodeSmells
{
    /* 
    // Brief :
    // Overuse of primitie, instead of better abstractions or data
    // structures, results in excess code required to enforce constraints.
       
    // My understand :   
    // 1. 直接使用double代表金錢或int代表年齡是不好的,應該設計一個Money class或Person class.
       
    // Question : 
    // 1. 為何PrimitiveObsession是Bloaters type?
    // 2. 這邊的理解有問題,待在確認修改 (影片用AddHoliday(7,4)說明)
    */
    class SmellPrimitiveObsession //Code smells type : Bloaters
    {
        public void BadCode()
        {
            //I don't know what 5 and 1 mean.
            //Maybe 5 for day and 1 for month.
            AddHoliday(5, 1);//labor day
        }

        public void GoodeCode()
        {
            //1.Introduce named variable
            Date laborDay = new Date(5, 1);
            AddHoliday(laborDay);

            //2.Use Named Arguments (C# 4.0 and above can be used)
            Date childrensDay = new Date(month: 4, day: 4);
            AddHoliday(childrensDay);

            //3.Replace primitive with constant
            Date peaceMemorialDay = new Date(Constants.Month.FEBRUARY, Constants.Day.Day_28);
            AddHoliday(peaceMemorialDay);

            //4.Replace primitive with Enum/SmartEnum
            AddHolidayEnum(Enums.Month.MAY, Enums.Day.Day_23);
            AddHolidayEnum(0, 0); // but we can pass in invaild values.

            //We can use SmartEnum to solve this. (need to install Ardalis.SmartEnum)
            //public sealed class MonthEnum : SmartEnum<MonthEnum>
            //{
            //    public static readonly MonthEnum January = new MonthEnum(nameof(January), 1, "Jan");
            //    public string ShortName { get; set; }
            //}
        }

        private void AddHoliday(int month, int day)
        {
            //implenment
        }

        private void AddHoliday(Date date)
        {
            //implenment
        }

        private void AddHolidayEnum(Enums.Month month, Enums.Day day)
        {
            //implenment
        }

        private class Date
        {
            public Date(int month, int day)
            {
            }
        }

        private static class Constants
        {
            public static class Month
            {
                public const int JANUARY = 1;
                public const int FEBRUARY = 2;
                public const int MARCH = 3;
                public const int APRIL = 4;
                public const int MAY = 5;
                public const int JUNE = 6;
                public const int JULY = 7;
                public const int AUGUST = 8;
                public const int SEPTEMBER = 9;
                public const int OCTOBER = 10;
                public const int NOVEMBER = 11;
                public const int DECEMBER = 12;
            }

            public static class Day
            {
                public const int Day_1 = 1;
                public const int Day_2 = 2;
                public const int Day_3 = 3;
                public const int Day_4 = 4;
                public const int Day_5 = 5;
                public const int Day_6 = 6;
                public const int Day_7 = 7;
                public const int Day_8 = 8;
                public const int Day_9 = 9;
                public const int Day_10 = 10;
                public const int Day_11 = 11;
                public const int Day_12 = 12;
                public const int Day_13 = 13;
                public const int Day_14 = 14;
                public const int Day_15 = 15;
                public const int Day_16 = 16;
                public const int Day_17 = 17;
                public const int Day_18 = 18;
                public const int Day_19 = 19;
                public const int Day_20 = 20;
                public const int Day_21 = 21;
                public const int Day_22 = 22;
                public const int Day_23 = 23;
                public const int Day_24 = 24;
                public const int Day_25 = 25;
                public const int Day_26 = 26;
                public const int Day_27 = 27;
                public const int Day_28 = 28;
                public const int Day_29 = 29;
                public const int Day_30 = 30;
                public const int Day_31 = 31;
            }
        }
        private static class Enums
        {
            public enum Month
            {
                JANUARY = 1,
                FEBRUARY = 2,
                MARCH = 3,
                APRIL = 4,
                MAY = 5,
                JUNE = 6,
                JULY = 7,
                AUGUST = 8,
                SEPTEMBER = 9,
                OCTOBER = 10,
                NOVEMBER = 11,
                DECEMBER = 12
            }

            public enum Day
            {
                Day_1 = 1,
                Day_2 = 2,
                Day_3 = 3,
                Day_4 = 4,
                Day_5 = 5,
                Day_6 = 6,
                Day_7 = 7,
                Day_8 = 8,
                Day_9 = 9,
                Day_10 = 10,
                Day_11 = 11,
                Day_12 = 12,
                Day_13 = 13,
                Day_14 = 14,
                Day_15 = 15,
                Day_16 = 16,
                Day_17 = 17,
                Day_18 = 18,
                Day_19 = 19,
                Day_20 = 20,
                Day_21 = 21,
                Day_22 = 22,
                Day_23 = 23,
                Day_24 = 24,
                Day_25 = 25,
                Day_26 = 26,
                Day_27 = 27,
                Day_28 = 28,
                Day_29 = 29,
                Day_30 = 30,
                Day_31 = 31
            }
        }
    }
}
