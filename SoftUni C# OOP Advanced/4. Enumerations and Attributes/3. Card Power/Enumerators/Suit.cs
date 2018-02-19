namespace _3.Card_Power.Enums
{
    using Attributes;
    [TypeAttributes(Category ="Enueration",Type ="Suit",Description ="Provides suit constants for a Card class.")]
    public enum Suit
    {
        Clubs,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}