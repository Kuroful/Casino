/*
 * Preston Wan, Hamza Hussain and Kevin Ma
 * May 26, 2018
 * Stores details of a HandBlackjack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HandBlackjack : Hand
    {
        /// <summary>
        /// Creates a hand for blackjack
        /// </summary>
        public HandBlackjack()
        {
            HandOfCards = GenerateHand();
        }

        /// <summary>
        /// Generates hand
        /// </summary>
        public override List<Cards> GenerateHand()
        {
            BlackjackDeck();
            for (int i = 0; i < 2; i++)
            {
                HandOfCards.Add(generatedDeck.Pop());
            }
            return HandOfCards;

            
        }

        /// <summary>
        /// Generates a blackjack deck to be used for the hand
        /// </summary>
        private void BlackjackDeck()
        {
            generatedDeck = GenerateBlackjackDeck();
        }
    }
}
