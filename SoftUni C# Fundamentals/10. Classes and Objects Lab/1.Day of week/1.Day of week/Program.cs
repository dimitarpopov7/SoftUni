namespace _1.Day_of_week
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] entry = Console.ReadLine().Split('-');
            int day = Convert.ToInt32(entry[0]);
            int month = Convert.ToInt32(entry[1]);
            int year = Convert.ToInt32(entry[2]);
            DateTime result = new DateTime(year, month, day);
            Console.WriteLine(result.DayOfWeek);
        }
    }
}
