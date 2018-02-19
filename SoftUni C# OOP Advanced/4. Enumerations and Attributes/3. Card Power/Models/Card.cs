namespace _3.Card_Power.Models
{
    using System;
    using Enums;
    public class Card : IComparable<Card>
    {
        public Rank rank;
        public Suit suit;
        public int CardPower;

        public Card(Rank rankOfCard, Suit suitOfCard)
        {
            this.rank = rankOfCard;
            this.suit = suitOfCard;
            CardPower = (int)this.rank + (int)this.suit;
        }

        public int CompareTo(Card other)
        {
            return this.CardPower.CompareTo(other.CardPower);
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {CardPower}";
        }
    }
}