namespace _3.Card_Power.Controllers
{
    using System;
    using System.Linq;
    using Enums;
    using Models;
    using System.Collections.Generic;
    
    public class CardGame
    {
        public void Run()
        {
            string playerOne, playerTwo;
            HashSet<Card> firstPlayerCards, secondPlayerCards;
            SortBothPlayers(out playerOne, out playerTwo, out firstPlayerCards, out secondPlayerCards);
            SettleTheWinner(playerOne, playerTwo, firstPlayerCards, secondPlayerCards);
        }

        private static void SettleTheWinner(string playerOne, string playerTwo, HashSet<Card> firstPlayerCards, HashSet<Card> secondPlayerCards)
        {
            Card highestCardOfPlayerOne = firstPlayerCards
                                          .OrderByDescending(c => c.CardPower)
                                          .FirstOrDefault();
            Card highestCardOfPlayerTwo = secondPlayerCards
                                          .OrderByDescending(c => c.CardPower)
                                          .FirstOrDefault();
            Console.WriteLine((highestCardOfPlayerOne
                .CompareTo(highestCardOfPlayerTwo) > 0)
                ? $"{playerOne} wins with {highestCardOfPlayerOne.rank} of {highestCardOfPlayerOne.suit}."
                : $"{playerTwo} wins with {highestCardOfPlayerTwo.rank} of {highestCardOfPlayerTwo.suit}.");
        }

        private static void SortBothPlayers(out string playerOne, out string playerTwo, out HashSet<Card> firstPlayerCards, out HashSet<Card> secondPlayerCards)
        {
            playerOne = Console.ReadLine();
            playerTwo = Console.ReadLine();
            firstPlayerCards = new HashSet<Card>();
            secondPlayerCards = new HashSet<Card>();
            SetPlayerDeck(firstPlayerCards);
            SetPlayerDeck(secondPlayerCards);
        }

        private static void SetPlayerDeck(HashSet<Card> PlayerCards)
        {
            while (PlayerCards.Count<5)
            {
                Card currentCard = new Card(Rank.Ace, Suit.Clubs);
                try
                {
                    var cardInfo = Console.ReadLine().Split();
                    Rank rank = (Rank)Enum.Parse(typeof(Rank), cardInfo[0]);
                    Suit suit = (Suit)Enum.Parse(typeof(Suit), cardInfo[2]);
                    var currentCard1 = new Card(rank, suit);
                    currentCard = currentCard1;
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
                try
                {
                    if (PlayerCards.Any(c => c.CompareTo(currentCard)==0))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        PlayerCards.Add(currentCard);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Card is not in the deck.");
                }
            }
        }
    }
}