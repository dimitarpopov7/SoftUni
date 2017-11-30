namespace _1.Action_Print
{
    using System;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            var names = Console.ReadLine();
            Action<string> namePrint =PrintNames;
            namePrint(names);
            //with Linq
        //    Action<string> NamePrint = x => names.Split(' ').ToList().ForEach(c => Console.WriteLine(c));
        //    NamePrint(names);
        }
        public static void PrintNames(string names)
        {
            var listNames = names.Split(' ').ToList();
            foreach (var name in listNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
