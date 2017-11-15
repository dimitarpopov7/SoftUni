namespace _10.Serbian_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var townSingerProft = new Dictionary<string, Dictionary<string, int>>();
            var singerProfit = new Dictionary<string, int>();
            while (true)
            {
                string singer = string.Empty;
                string place = string.Empty;
                int ticketPrice = 0;
                int ticketSold = 0;
                int profit = 0;
                Start:
                var entry = Console.ReadLine().Split('@').ToList();
                if (entry[0] == "End")
                {
                    break;
                }
                var secondBit = entry[1].Split(' ').ToList();
                if (secondBit.Count < 3||!entry[0].EndsWith(" "))
                {
                    goto Start;
                }
                else
                {
                    singer = entry[0].TrimEnd();
                    var remainingString = entry[1].Split(' ').ToList();
                    ticketPrice = Convert.ToInt32(remainingString[remainingString.Count - 2]);
                    ticketSold = Convert.ToInt32(remainingString[remainingString.Count - 1]);
                    profit = ticketPrice * ticketSold;
                    remainingString.RemoveRange(remainingString.Count - 2, 2);
                    place = (string.Join(" ", remainingString));
                    if (!townSingerProft.ContainsKey(place))
                    {                        
                            singerProfit[singer] = profit;
                            townSingerProft[place] = singerProfit;
                    }
                    else
                    {

                        singerProfit = townSingerProft[place];
                        if(!singerProfit.ContainsKey(singer))
                        {
                            singerProfit[singer] = profit;
                            townSingerProft[place]=singerProfit;
                        }
                        else if (singerProfit.ContainsKey(singer))
                        {
                            singerProfit[singer] += profit;
                            townSingerProft[place] = singerProfit;
                        }
                    }                    
                }
                singerProfit = new Dictionary<string, int>();
            }
            foreach (var place in townSingerProft)
            {
                string venuePlace = place.Key;
                Console.WriteLine(venuePlace);
                singerProfit = townSingerProft[venuePlace];
                foreach (var performer in singerProfit.OrderByDescending(x => x.Value))
                {
                    string singerName = performer.Key;
                    int profitMade = performer.Value;
                    Console.WriteLine($"#  {singerName} -> {profitMade}");
                }
            }
        }
    }
}
