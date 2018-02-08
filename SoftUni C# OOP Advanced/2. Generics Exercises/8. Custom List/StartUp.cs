namespace _8.Custom_List
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var list = new CustomList<string>();
            var entry = Console.ReadLine().Split().ToList();
            while (entry[0] != "END")
            {
                switch (entry[0])
                {
                    case "Add":
                        list.Add(entry[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(entry[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(entry[1]), int.Parse(entry[2]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Containts(entry[1]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(entry[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        Console.WriteLine(list.Print());
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                }
                entry = Console.ReadLine().Split().ToList();
            }
        }
    }
}
