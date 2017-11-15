namespace _08.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int rotations = int.Parse(Console.ReadLine());
            var userIpDuration = new SortedDictionary<string, Dictionary<string,int>>();
            for (int i = 0; i < rotations; i++)
            {
                var entry=Console.ReadLine().Split(' ').ToList();
                var ipAddress = entry[0];
                var userName = entry[1];
                var duration = int.Parse(entry[2]);
                var ipList = new Dictionary<string,int>();
                if (!userIpDuration.ContainsKey(userName))
                {
                    ipList[ipAddress] = duration;
                    userIpDuration[userName]=ipList;
                }
                else
                {
                    ipList = userIpDuration[userName];
                    if (!ipList.ContainsKey(ipAddress))
                    {
                        ipList[ipAddress] = duration;
                        userIpDuration[userName] = ipList;
                    }
                    else
                    {
                        ipList[ipAddress] += duration;
                    }                    
                }
            }
            foreach (var user in userIpDuration)
            {
                var totalDuration = new List<int>();
                var ipAddresses=new List<string>();
                ipAddresses = user.Value.Select(x=>x.Key).OrderBy(x=>x).ToList();
                totalDuration = user.Value.Select(x=>x.Value).ToList();
                Console.Write($"{user.Key}: {totalDuration.Sum()} ");
                Console.WriteLine($"[{string.Join(", ", ipAddresses)}]");
            }
        }
    }
}
