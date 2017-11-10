using System;namespace I.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {            
            double cash = double.Parse(Console.ReadLine());
            int guestNum = int.Parse(Console.ReadLine());
            double bananaPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());
            var priceDessert = 2 * bananaPrice + 4 * eggPrice + 0.2 * berriesPrice;
            var numberDesserts = 0;
            if (guestNum % 6 != 0)
            {
                numberDesserts = guestNum / 6 + 1;
            }
            else
            {
                numberDesserts = guestNum / 6;
            }
            var moneyNeeded = priceDessert * numberDesserts;
            if (moneyNeeded > cash)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded-cash):f2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
        }
    }
}
