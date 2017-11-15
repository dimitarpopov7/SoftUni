namespace _1.Unique_Usernames
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                uniqueUsernames.Add(name);
            }
            foreach (var username in uniqueUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
