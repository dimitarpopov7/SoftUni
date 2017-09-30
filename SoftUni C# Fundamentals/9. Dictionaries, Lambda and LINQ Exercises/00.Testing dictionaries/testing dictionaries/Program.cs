namespace testing_dictionaries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            var dict1 = new Dictionary<string, Dictionary<string, int>>();
            var dict2 = new Dictionary<string, int>();
            dict2["Dimitar"] = 180;
            dict1["Popovi"] = dict2;
            dict2 = new Dictionary<string, int>();//deletes Dimitar height Info
            dict2 = dict1["popa"];//Copies Dimitar height Info to the deleted Dictionary
            List<int> dimitarHeight = dict1.Select(x => x.Value.Sum(y => y.Value)).ToList();//Enters the dictonary 1 and then enteres dictioanry 2
            Console.WriteLine(dimitarHeight.Sum());//prints Dimitar Height
        }
    }
}
