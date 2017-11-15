namespace _09.Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var shadowmourne = new Dictionary<string, int>();
            var valanyr = new Dictionary<string, int>();
            var dragonwrath = new Dictionary<string, int>();
            var junk = new SortedDictionary<string, int>();
            shadowmourne["shards"] = 0;
            valanyr["fragments"] = 0;
            dragonwrath["motes"] = 0;
            var entry = new List<string>();
            while (true)
            {
                entry = Console.ReadLine().ToLower().Split(' ').ToList();
                for (int i = 1; i < entry.Count; i=i+2)
                {
                    if (entry[i]=="shards")
                    {
                        shadowmourne["shards"] += Convert.ToInt32(entry[i - 1]);
                        foreach (var item in shadowmourne)
                        {
                            int shardsCount = item.Value;
                            if (shardsCount>=250)
                            {
                                shadowmourne["shards"] = item.Value - 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                goto Result;
                            }
                        }                        
                    }
                    else if (entry[i]=="fragments")
                    {
                        valanyr["fragments"] += Convert.ToInt32(entry[i - 1]);
                        foreach (var item in valanyr)
                        {
                            int fragmentsCount = item.Value;
                            if (fragmentsCount >= 250)
                            {
                                valanyr["fragments"] = item.Value - 250;
                                Console.WriteLine("Valanyr obtained!");
                                goto Result;
                            }
                        }
                    }
                    else if (entry[i]=="motes")
                    {
                        dragonwrath["motes"] += Convert.ToInt32(entry[i - 1]);
                        foreach (var item in dragonwrath)
                        {
                            int motesCount = item.Value;
                            if (motesCount >= 250)
                            {
                                dragonwrath["motes"] = item.Value - 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                goto Result;
                            }
                        }
                    }
                    else
                    {
                        junk[entry[i]] = Convert.ToInt32(entry[i - 1]);
                    }
                }
            }
            Result:
            int motesNum = 0;
            int shardsNum = 0;
            int fragmentNum = 0;
            var endResultInfo = new SortedDictionary<string, int>();

            foreach (var item in dragonwrath)
            {
                motesNum = item.Value;
            }
            foreach (var item in valanyr)
            {
                fragmentNum = item.Value;
            }
            foreach (var item in shadowmourne)
            {
                shardsNum = item.Value;
            }
            endResultInfo.Add("shards",shardsNum);
            endResultInfo.Add("motes", motesNum);
            endResultInfo.Add("fragments", fragmentNum);
            foreach (var item in endResultInfo.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
