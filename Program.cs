using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {


            var random = new Random();

            var cardSuites = new List<string>() { "Hearts", "Diamonds", "Spades", "Clubs" };
            var cardNumbers = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };

            int index = random.Next(cardSuites.Count);

            Console.WriteLine(cardNumbers[index] + " of " + cardSuites[index]);



        }
    }
}
