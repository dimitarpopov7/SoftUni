namespace String_Practice
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    public class Program
    {
        public static void Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            //comparing 
            string name = "Pesho";
            string nameAnother = "pesho";
            Console.WriteLine(name==nameAnother);//no need for if..


            string a = "a";
            string b = "A";
            string c = "c";

            int result = string.Compare(a, b,true);//compares result==0 if a=b, result<0 when "a" is before "b"// TRUE does not differentiate capital and lower cases..
            int result2 = string.Compare(a, b,false);
            int result3 = string.Compare(c, a);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            
            //add strings
            string text = "text";
            string addText = " another ";

            Console.WriteLine(text+addText+100);
            //find index of a string in string, returns -1 if string does not contain string

            string shano = "shano manqk";
            string test = "shano";

            Console.WriteLine($"index of shano is {shano.IndexOf(test)}");

            //saves unique values
            var set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2);
            set.Add(1);
            foreach (var hash in set)
            {
                Console.WriteLine(hash);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);//depends on PC to PC

        }
    }
}
