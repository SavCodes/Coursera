using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();

            // tell the deck to shuffle and print itself
            deck.Shuffle();
            deck.Print();

            // take the top card from the deck and print the card rank and suit
            Card topCard = deck.TakeTopCard();
            Console.WriteLine(topCard.Rank);
            Console.WriteLine(topCard.Suit);

            // take the top card from the deck and print the card rank and suit
            Card nextCard = deck.TakeTopCard();
            Console.WriteLine(nextCard.Rank);
            Console.WriteLine(nextCard.Suit);
        }
    }
}
