namespace _08.Letters_Change_Numbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine()
                .Split(new string[] {" ","\t" },StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            double result = 0;
            try
            {
                foreach (string item in entry)
                {
                    double numberManipulation = 0.0;
                    double number = Convert.ToDouble(item.Substring(1, item.Length - 2));
                    var currentString = item.ToCharArray();
                    if (char.IsLower(currentString[0]))
                    {
                        int charIndex = currentString[0] - 96;
                        numberManipulation = number * charIndex;
                    }
                    else
                    {
                        int charIndex = currentString[0] - 64;
                        numberManipulation = number / charIndex;
                    }
                    int indexOfLastChar = currentString.Length - 1;
                    if (char.IsLower(currentString[indexOfLastChar]))
                    {
                        int charIndex = currentString[indexOfLastChar] - 96;
                        numberManipulation = numberManipulation + charIndex;
                    }
                    else
                    {
                        int charIndex = currentString[indexOfLastChar] - 64;
                        numberManipulation = numberManipulation - charIndex;
                    }
                    result += numberManipulation;
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{result:f2}");
                return;
            }            
            Console.WriteLine($"{result:f2}");
        }
    }
}
