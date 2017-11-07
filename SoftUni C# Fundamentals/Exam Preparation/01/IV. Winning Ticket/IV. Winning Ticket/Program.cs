namespace IV.Winning_Ticket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        {
            var ticketInfo = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x=>x.Trim())
                .ToList();            
            int signOneCount = 0;
            int signTwoCount = 0;            
            foreach (var ticket in ticketInfo)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var regex = new Regex(@"(\${6,10}|@{6,10}|#{6,10}|\^{6,10})");
                    var matches=regex.Matches(ticket);                    
                    if (matches.Count>1)
                    {
                        string firstSign=matches[0].ToString();
                        string secondSign = matches[1].ToString();
                        signOneCount = firstSign.Length;
                        signTwoCount = secondSign.Length;
                        int minSignLenght = Math.Min(signOneCount, signTwoCount);                        
                        if (firstSign[0] == secondSign[0]&&(minSignLenght>5&&minSignLenght<10))
                        {
                            
                            Console.WriteLine($"ticket \"{ticket}\" - {minSignLenght}{firstSign[0]}");
                        }
                        else if(firstSign[0] == secondSign[0] && minSignLenght >= 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {minSignLenght}{firstSign[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
