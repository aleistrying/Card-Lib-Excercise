using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
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
            // take the top card from the deck and print the card rank and suit
            Console.WriteLine();
            Card d1 = deck.TakeTopCard();
            Card d2 = deck.TakeTopCard();
            Console.WriteLine(d1.Rank + " of " + d1.Suit);
            Console.WriteLine(d2.Rank + " of " + d2.Suit);
            Console.ReadLine();
            // take the top card from the deck and print the card rank and suit
        }
    }
}
