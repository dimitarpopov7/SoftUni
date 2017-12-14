namespace _1.Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToList();
            var carList = new SortedSet<string>();
            while (entry[0] != "END")
            {
                if (entry[0] == "IN")
                {
                    carList.Add(entry[1]);
                }
                else
                {
                    carList.Remove(entry[1]);
                }
                entry = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            if (carList.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in carList)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
