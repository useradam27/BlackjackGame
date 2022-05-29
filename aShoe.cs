using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// aShoe class represents a physical shoe, which holds multiple decks of cards.
    /// Inherits aRandomVariable, to use static random object
    /// </summary>
    class aShoe : aRandomVariable, IDrawCard
    {
        /// <summary>
        /// number of decks to create shoe
        /// </summary>
        private int deckSize;

        /// <summary>
        /// stack of all the cards
        /// </summary>
        private Stack<aCard> allCards;
        
        /// <summary>
        /// temp deck used for deck creation
        /// </summary>
        private aDeckOfCards tempDeck;

        /// <summary>
        /// master deck used to hold all cards
        /// </summary>
        private aCard[] masterDeck;

        /// <summary>
        /// Constructor to create shoe with number of decks, and seed value
        /// </summary>
        /// <param name="num"> number of decks to create in shoe</param>
        /// <param name="s"> seed value for random object</param>
        public aShoe(int num, int s)
        {
            random = new Random(s);
            deckSize = num;
            allCards = new Stack<aCard>();

            //masterDeck made with size of all cards
            masterDeck = new aCard[deckSize*52];

            //Creates each deck and adds cards to master deck
            int count = 0;
            for (int i = 0; i < deckSize; i++)
            {
                tempDeck = new aDeckOfCards(999);
                tempDeck.shuffle();
                for (int j = 0; j < 52; j++)
                {
                    masterDeck[count] = tempDeck.deck[j];
                    count++;
                }
            }

            //master deck gets shuffled
            shuffle();

            //master deck gets copied to stack
            for(int i = 0; i < masterDeck.Length; i++)
            {
                allCards.Push(masterDeck[i]);
            }
        }

        /// <summary>
        /// shuffles the master deck
        /// </summary>
        public void shuffle()
        {
            int n = masterDeck.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                aCard val = masterDeck[k];
                masterDeck[k] = masterDeck[n];
                masterDeck[n] = val;
            }
        }

        /// <summary>
        /// draws card from master deck, restarts shoe if cards run out
        /// </summary>
        /// <returns>aCard object</returns>
        public aCard Draw()
        {
            if (allCards.Count == 0)
                resetShoe();
            return allCards.Pop();
        }

        /// <summary>
        /// restarts the shoe without having to remake shoe object
        /// Used when user hits reset, or when shoe runs out of cards
        /// </summary>
        public void resetShoe()
        {
            allCards = new Stack<aCard>();

            masterDeck = new aCard[deckSize*52];

            int count = 0;
            for (int i = 0; i < deckSize; i++)
            {
                tempDeck = new aDeckOfCards(999);
                tempDeck.shuffle();
                for (int j = 0; j < 52; j++)
                {
                    masterDeck[count] = tempDeck.deck[j];
                }
            }

            shuffle(); //shuffles the master deck

            for (int i = 0; i < masterDeck.Length; i++)
            {
                allCards.Push(masterDeck[i]);
            }

        }
    }
}
