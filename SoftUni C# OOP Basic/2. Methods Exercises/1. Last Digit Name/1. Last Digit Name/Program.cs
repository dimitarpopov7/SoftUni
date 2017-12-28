namespace _1.Last_Digit_Name
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var number = new Number(num);
            number.PrintLastDigit();
        }
    }
}