namespace _06.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var users = new SortedDictionary<string, List<string>>();
            var ipOccurance = new SortedDictionary<string, int>();
            while (true)
            {
                List<string> entry = Console.ReadLine().Split(' ').ToList();
                if (entry[0] == "end")
                {
                    break;
                }
                string userName = entry[2].Substring(5);
                string userIP = entry[0].Substring(3);
                int count = 0;
                if (!users.ContainsKey(userName))
                {
                    users[userName] = new List<string>();
                    users[userName].Add(userIP);
                    ipOccurance.Add(userIP, count);
                }
                if (users.ContainsKey(userName) && (!users[userName].Contains(userIP)))
                {
                    users[userName].Add(userIP);
                    count = 1;
                    ipOccurance[userIP] = count;
                }
                else if (users.ContainsKey(userName) && users[userName].Contains(userIP))
                {
                    ipOccurance[userIP] += 1;
                }
            }
            foreach (var user in users)
            {
                var userNames = user.Key;
                var ipNum = user.Value;


                Console.WriteLine(userNames + ": ");
                for (int i = 0; i < ipNum.Count; i++)
                {
                    if (i != ipNum.Count - 1)
                    {
                        if (ipOccurance.ContainsKey(ipNum[i]))
                        {
                            var occurances = ipOccurance[ipNum[i]];
                            Console.Write($"{ipNum[i]} => {occurances}, ");
                        }
                    }
                    else
                    {
                        if (ipOccurance.ContainsKey(ipNum[i]))
                        {
                            var occurances = ipOccurance[ipNum[i]];
                            Console.WriteLine($"{ipNum[i]} => {occurances}.");
                        }
                    }
                }
            }
        }
    }
}

