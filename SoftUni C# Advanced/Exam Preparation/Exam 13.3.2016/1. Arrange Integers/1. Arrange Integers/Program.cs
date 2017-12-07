namespace _1.Arrange_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var names = new Queue<string>();
            foreach (var num in numbers)
            {
                var fullName = string.Empty;
                foreach (char digit in num)
                {
                    var name = string.Empty;
                    switch (digit)
                    {
                        case '1':
                            name = "one";
                            break;
                        case '2':
                            name = "two";
                            break;
                        case '3':
                            name = "tree";
                            break;
                        case '4':
                            name = "four";
                            break;
                        case '5':
                            name = "five";
                            break;
                        case '6':
                            name = "six";
                            break;
                        case '7':
                            name = "seven";
                            break;
                        case '8':
                            name = "eight";
                            break;
                        case '9':
                            name = "nine";
                            break;
                        case '0':
                            name = "zero";
                            break;
                    }
                    fullName += $"{name}-";
                }
                names.Enqueue(fullName);
            }
            var orderList = new Queue<string>(names.OrderBy(x => x));
            var result = new Queue<string>();
            foreach (var writtenNum in orderList)
            {
                var digits = writtenNum.TrimEnd('-').Split('-').ToList();
                var fullNumber = string.Empty;
                foreach (var digit in digits)
                {
                    var number = string.Empty;
                    switch (digit)
                    {
                        case "one":
                            number = "1";
                            break;
                        case "two":
                            number = "2";
                            break;
                        case "tree":
                            number = "3";
                            break;
                        case "four":
                            number = "4";
                            break;
                        case "five":
                            number = "5";
                            break;
                        case "six":
                            number = "6";
                            break;
                        case "seven":
                            number = "7";
                            break;
                        case "eight":
                            number = "8";
                            break;
                        case "nine":
                            number = "9";
                            break;
                        case "zero":
                            number = "0";
                            break;
                    }
                    fullNumber += number;
                }
                result.Enqueue(fullNumber);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}