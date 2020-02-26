/*
 * Preston Wan, Hamza Hussain and Kevin Ma
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HandWar : Hand
    {
        // the stack of cards used as a hand
        private Stack<Cards> stackOfCards;
        /// <summary>
        /// The stack of cards used as a hand
        /// </summary>
        public Stack<Cards> StackOfCards { get { return stackOfCards; } }

        /// <summary>
        /// Creates a hand for war
        /// </summary>
        public HandWar()
        {
            stackOfCards = new Stack<Cards>(GenerateHand());
           
        }

        /// <summary>
        /// Creates a hand based on the requirements for war
        /// </summary>
        /// <returns>A War Deck</returns>
        public override List<Cards> GenerateHand()
        {

            WarDeck();

            for (int i = 0; i < 26; i++)
            {
                HandOfCards.Add(generatedDeck.Pop());
            }
            return HandOfCards;
        }

        /// <summary>
        /// Creates the war specific deck to be used for the hand
        /// </summary>
        private void WarDeck()
        {
            generatedDeck = GenerateWarDeck();
        }
    }
}
