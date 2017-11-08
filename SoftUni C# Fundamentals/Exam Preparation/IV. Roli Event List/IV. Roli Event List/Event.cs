namespace IV.Roli_Event_List
{
    using System.Collections.Generic;
    public class Event
    {
        public string EventName { get; set; }
        public SortedSet<string> GuestList { get; set; }
    }
}
