namespace _01.Working_Days
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int count = 0;
            var holiday = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),                
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),                
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy",CultureInfo.InvariantCulture)
            };
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var currentDay = i.DayOfWeek;
                var checkDate = new DateTime(2016, i.Month, i.Day);//trick  for LEAP YEARS
                if (currentDay != DayOfWeek.Saturday && currentDay != DayOfWeek.Sunday && !holiday.Contains(checkDate))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
