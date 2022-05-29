using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    /// <summary>
    /// aCard class represents a physical card in text form, holds value, face and suit
    /// </summary>
    class aCard
    {
        /// <summary>
        /// represents numeric value for the card
        /// </summary>
        private int value;

        /// <summary>
        /// represents face of card
        /// </summary>
        private string face;

        /// <summary>
        /// represents suit for card
        /// </summary>
        private string suit;

        /// <summary>
        /// Constroctor for aCard that takes the value and suit
        /// </summary>
        /// <param name="val"></param> numeric value for card
        /// <param name="s"></param> suit for card
        public aCard(int val, string s)
        {
            value = val;
            suit = s;
            face = value.ToString();
        }


        /// <summary>
        /// Constructor for card that takes face and suit
        /// </summary>
        /// <param name="f"></param> string name of face
        /// <param name="s"></param> suit for card
        public aCard(string f, string s)
        {
            face = f;
            suit = s;

            //assign values for face cards
            if (face == "Ace" || face == "Jack" || face == "Queen" || face == "King")
                value = 11;
            else
                value = 0;
        }

        /// <summary>
        /// displays value and suit of card
        /// </summary>
        /// <returns>string value with face and suit</returns>
        public string display()
        {
            return face + " of " + suit;
        }

        /// <summary>
        /// gets the value of a card
        /// </summary>
        /// <returns>returns int value of card</returns>
        public int getValue()
        {
            return value;
        }

        /// <summary>
        /// gets face of card
        /// </summary>
        /// <returns> returns string face of card</returns>
        public string getFace()
        {
            return face;
        }

        /// <summary>
        /// sets the value of a card, used for adjusting an Ace from 11 to 1
        /// </summary>
        /// <param name="v">int value to set card to</param>
        public void setValue(int v)
        {
            value = v;
        }
    }
}
