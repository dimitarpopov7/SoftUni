namespace _3.Card_Power.Controllers
{
    using System;
    using Models;
    public class CompareTo
    {
        public void Run()
        {
            Card card = ReturnPower.GetCard();
            Card cardToCompare = ReturnPower.GetCard();
            Console.WriteLine((card.CompareTo(cardToCompare) > 0) ? card : cardToCompare);
        }
    }
}
