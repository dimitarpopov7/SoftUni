namespace _2.Number_in_Reversed_Order
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var num = Console.ReadLine();
            var number = new Number(num);
            number.ReverseNum();
        }
    }
}