namespace III.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;    
    public class Program
    {
        public static void Main()
        {
            var deamonNames = Console.ReadLine().Split(new string[] { ", "," ","\n\r" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string lettersExtract = @"[A-Za-z]";
            string digitExtract = @"(\-|\+)*([0-9]+\.)*[0-9]+";
            var signExtract = @"\*|\/";
            var regex1 = new Regex(digitExtract);
            var regex2 = new Regex(lettersExtract);
            var regex3 = new Regex(signExtract);
            var deamonList = new List<Deamon>();
            
            foreach (var name in deamonNames)
            {
                var lettersList = new List<char>();
                var digitsList = new List<double>();
                var signList = new List<char>();
                var digits = regex1.Matches(name);
                var letters = regex2.Matches(name);
                var signs = regex3.Matches(name);
                var currentDeamon = new Deamon();
                foreach (Match letter in letters)
                {
                    var character = Convert.ToString(letter);
                    var charr = Convert.ToChar(character);
                    lettersList.Add(charr);
                }
                if (lettersList.Count == 0)
                {
                    break;
                }
                foreach (Match digit in digits)
                {
                    var number = Convert.ToString(digit);
                    var num = Convert.ToDouble(number);
                    digitsList.Add(num);
                }
                foreach (Match sign in signs)
                {
                    var znak = Convert.ToString(sign);
                    var znakk = Convert.ToChar(znak);
                    signList.Add(znakk);
                }
                currentDeamon.Name = name.ToString();
                currentDeamon.LettesList = lettersList;                
                currentDeamon.DigitsList = digitsList;
                currentDeamon.SignList = signList;
                deamonList.Add(currentDeamon);
            }            
            foreach (var deamon in deamonList.OrderBy(x=>x.Name))
            {
                int health = 0;
                double damage = 0.0;
                foreach (var letter in deamon.LettesList)
                {
                    health += (int)letter;
                }
                foreach (var digit in deamon.DigitsList)
                {
                    damage += digit;
                }
                foreach (var sign in deamon.SignList)
                {
                    if (sign == '*')
                    {
                        damage *= 2;
                    }
                    else if (sign == '/')
                    {
                        damage/=2;
                    }
                }
                Console.WriteLine($"{ deamon.Name} - {health} health, {damage:f2} damage");
            }
        }
    }
}
