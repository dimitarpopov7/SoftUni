namespace II.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            string separator = ", ";
            var participants = Console.ReadLine()
                .Split(new string[] { separator }, StringSplitOptions.None)
                .Select(x=>x.Trim())
                .Distinct()
                .ToList();           
            var songs = Console.ReadLine()
                .Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Distinct()
                .ToList();            
            string entry = Console.ReadLine();
            var awardsRecord = new SortedDictionary<string, List<string>>();
            while (entry != "dawn")
            {
                var entryBreakDown = entry
                    .Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = entryBreakDown[0];
                string song = entryBreakDown[1];
                string award = entryBreakDown[2];
                if (participants.Contains(entryBreakDown[0]) && songs.Contains(entryBreakDown[1]))
                {
                    if (!awardsRecord.ContainsKey(name))
                    {
                        var currentAwards = new List<string>();
                        currentAwards.Add(award);
                        awardsRecord[name] = currentAwards;
                    }
                    else
                    {
                        var previousAwards = awardsRecord[name];
                        previousAwards.Add(award);
                        awardsRecord[name] = previousAwards;
                    }
                }
                entry = Console.ReadLine();
            }
            var finalList = awardsRecord.ToDictionary(name => name.Key, awards => awards.Value.Distinct().ToList());
            if (finalList.Keys.Count > 0)
            {
                foreach (var participant in finalList.OrderByDescending(x => x.Value.Count))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
