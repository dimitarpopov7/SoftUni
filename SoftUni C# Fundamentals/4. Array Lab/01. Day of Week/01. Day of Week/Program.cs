using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        public static void Main()
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int n = int.Parse(Console.ReadLine());
            if (n <= days.Length && n > 0)
            {
                Console.WriteLine(days[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
