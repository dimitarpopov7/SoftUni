namespace _10.Predicate_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var initialGuests = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<List<string>, List<string>, List<string>> Modification=Modify;

            while (command[0]!="Party!")
            {
                initialGuests = Modification(initialGuests, command);
                command = Console.ReadLine().Split().ToList();
            }
            if (initialGuests.Count > 0)
            {
                Console.Write(string.Join(", ", initialGuests));
                Console.WriteLine(" are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        public static List<string> Modify(List<string> guestList,List<string> command)
        {
            var modifiedList = new List<string>();
            if (command[0] == "Remove")
            {
                if (command[1] == "StartsWith")
                {
                    foreach (var name in guestList)
                    {
                        if (!name.StartsWith(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
                else if (command[1] == "EndsWith")
                {
                    foreach (var name in guestList)
                    {
                        if (!name.EndsWith(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
                else if (command[1] == "Length")
                {
                    foreach (var name in guestList)
                    {
                        if (name.Length != int.Parse(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
            }
            else if (command[0] == "Double")
            {

                if (command[1] == "StartsWith")
                {
                    foreach (var name in guestList)
                    {
                        modifiedList.Add(name);
                        if (name.StartsWith(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
                else if (command[1] == "EndsWith")
                {
                    foreach (var name in guestList)
                    {
                        modifiedList.Add(name);
                        if (name.EndsWith(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
                else if (command[1] == "Length")
                {
                    foreach (var name in guestList)
                    {
                        modifiedList.Add(name);
                        if (name.Length == int.Parse(command[2]))
                        {
                            modifiedList.Add(name);
                        }
                    }
                }
            }
            return modifiedList;
        }
    }
}
