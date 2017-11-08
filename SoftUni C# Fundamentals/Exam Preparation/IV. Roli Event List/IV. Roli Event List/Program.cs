namespace IV.Roli_Event_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {        
        public static void Main()
        {            
            var entry = Console.ReadLine();
            var eventList = new Dictionary<int, Event>();
            while(entry!= "Time for Code")
            {
                var command = entry.Split().ToList();
                string eventValid = command[1];
                if (eventValid[0]!='#')
                {
                    entry = Console.ReadLine();
                    continue;
                }
                else
                {
                    int id = int.Parse(command[0]);
                    string eventt = command[1].Substring(1);
                    var guestList = new SortedSet<string>();
                    for (int i = 2; i < command.Count; i++)
                    {
                        guestList.Add(command[i]);
                    }
                    if (!eventList.ContainsKey(id))
                    {                        
                        var currentEvent = new Event();
                        currentEvent.EventName = eventt;
                        currentEvent.GuestList = guestList;
                        eventList[id] = currentEvent;
                    }
                    else
                    {
                        if (eventList[id].EventName.Contains(eventt))
                        {
                            foreach (var guest in guestList)
                            {
                                eventList[id].GuestList.Add(guest);
                            }
                        }
                    }                    
                }
                entry = Console.ReadLine();
            }
            foreach (var id in eventList.OrderByDescending(x=>x.Value.GuestList.Count).ThenBy(x=>x.Value.EventName))
            {
                int participantCount = id.Value.GuestList.Count;
                Console.WriteLine($"{id.Value.EventName} - {participantCount}");
                foreach (var participant in id.Value.GuestList)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
