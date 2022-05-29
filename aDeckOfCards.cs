using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// aDeckOfCards class represents a physical deck of cards, generates 52 aCard objects.
    /// Inherits aRandomVariable to use static random object
    /// </summary>
    class aDeckOfCards : aRandomVariable
    {
        /// <summary>
        /// array of aCard to hold all the cards
        /// </summary>
        public aCard[] deck;

        /// <summary>
        /// array to hold all suit values
        /// </summary>
        private string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };

        /// <summary>
        /// Constructor for aDeckOfCards to create deck, accepts seed value
        /// </summary>
        /// <param name="s">seed value to create random object with</param>
        public aDeckOfCards(int s)
        {
            int seed = s;
            random = new Random(seed);
            int count = 0;
            deck = new aCard[52];

            //creates a card for each value on each suit
            for (int i = 0; i < 4; i++)
            {
                
                for (int j = 1; j <= 13; j++)
                {
                    //11,12, and 13 create face cards
                    if (j == 1)
                        deck[count] = new aCard("Ace",suits[i]);
                    else if (j == 11)
                        deck[count] = new aCard("Jack", suits[i]);
                    else if (j == 12)
                        deck[count] = new aCard("Queen", suits[i]);
                    else if (j == 13)
                        deck[count] = new aCard("King", suits[i]);
                    else
                        deck[count] = new aCard(j, suits[i]);

                    count++;
                }
            }
        }

        /// <summary>
        /// Chooses a random card, used for testing purposes
        /// </summary>
        /// <returns>aCard object in deck</returns>
        public aCard Draw()
        {
            int val = random.Next(0, deck.Length);
            return deck[val];
        }

        /// <summary>
        /// shuffles deck
        /// </summary>
        public void shuffle()
        {
            int n = deck.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                aCard val = deck[k];
                deck[k] = deck[n];
                deck[n] = val;
            }
        }

        /// <summary>
        /// displays deck, used for testing
        /// </summary>
        public void displayDeck()
        {
            for (int i = 0; i < deck.Length; i++)
                Console.WriteLine(deck[i].display() + "\n");
        }

    }
}
