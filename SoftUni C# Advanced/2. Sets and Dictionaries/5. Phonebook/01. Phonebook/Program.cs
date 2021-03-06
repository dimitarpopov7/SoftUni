﻿namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            while (true)
            {
                var entry = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                if (entry[0] == "A")
                {
                    phonebook[$"{entry[1]}"] = ($"{entry[2]}");
                }
                else if (entry[0] == "S")
                {
                    if (phonebook.ContainsKey(entry[1]))
                    {
                        Console.WriteLine($"{entry[1]} -> {phonebook[entry[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {entry[1]} does not exist.");
                    }
                }
                else if (entry[0] == "END")
                {
                    return;
                }
            }
        }
    }
}
