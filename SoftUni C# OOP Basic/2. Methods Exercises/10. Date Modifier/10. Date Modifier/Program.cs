namespace _10.Date_Modifier
{
    using System;
    using System.Globalization;
    public class Program
    {
        public static void Main()
        {
            string entryOne = Console.ReadLine();
            var entryTwo = Console.ReadLine();
            var date1= DateTime.ParseExact(entryOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            var date2= DateTime.ParseExact(entryTwo, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan difference = date1.Subtract(date2);
            Console.WriteLine(Math.Abs(difference.TotalDays));
        }
    }
}