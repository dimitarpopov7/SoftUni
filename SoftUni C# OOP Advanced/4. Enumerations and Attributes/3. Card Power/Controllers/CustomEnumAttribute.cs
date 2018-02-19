namespace _3.Card_Power.Controllers
{
    using System;
    using Enums;

    public class CustomEnumAttribute
    {
        public void Run()
        {
            string wantedEnumType = Console.ReadLine();
            var wantedEnum = wantedEnumType == "Rank" ? typeof(Rank) : typeof(Suit);
            var attribute = wantedEnum.GetCustomAttributes(false);
            Console.WriteLine(string.Join(Environment.NewLine,attribute));
        }

    }
}
