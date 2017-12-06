namespace _02.Cubic_s_Rube
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            int count = 0;
            var input = Console.ReadLine().Split().ToList();
            while(input[0]!="Analyze")
            {
                var intList = new List<int>();
                input.ForEach(x => intList.Add(int.Parse(x)));
                if (   intList[0] >= 0 && intList[0] < n 
                    && intList[1] >= 0 && intList[1] < n 
                    && intList[2] >= 0 && intList[2] < n
                    && intList[3]!=0)
                {
                    sum += intList[3];
                    count++;
                }
                input = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(sum);
            Console.WriteLine(Math.Pow(n,3)-count);
        }
    }
}
