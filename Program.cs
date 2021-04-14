using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            var cardSuites = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var cardNumbers = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            var deck = new List<string>();


            for (var indexSuites = 0; indexSuites < cardSuites.Count; indexSuites++)
            {
                for (var indexNumbers = 0; indexNumbers < cardNumbers.Count; indexNumbers++)
                {
                    var card = $"{cardNumbers[indexNumbers]} of {cardSuites[indexSuites]}";
                    deck.Add(card);
                }
            }


            var numberOfCards = (deck.Count);


            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                var rightCard = deck[rightIndex];
                deck[rightIndex] = deck[leftIndex];
                deck[leftIndex] = rightCard;


                foreach (var ShuffledDeck in deck)
                {
                    Console.WriteLine($"{ShuffledDeck}");
                }

            }

        }
    }
}
