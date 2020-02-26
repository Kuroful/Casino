//Hamza , Preston, Kevin

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project
{
    abstract class Hand : Deck
    {
        //Gets the number of cards in the hand
        private int numberOfCards;
        public int NumberOfCards { get { return numberOfCards; } }

        //Gets the value of the current card at the 'top' of the hand
        private int valueOfCard;
        public int ValueOfCard
        {
            get { return valueOfCard; }

            set { valueOfCard = value; }
        }

        //Creates a list to store all of the players cards
        private List<Cards> handOfCards = new List<Cards>();
        public List<Cards> HandOfCards
        {
            get { return handOfCards; }

            set { handOfCards = value; }
        }

        /// <summary>
        /// Stores all the images of the cards in the current hand
        /// </summary>
        /// <returns>The array of images</returns>
        public Image[] DrawHand()
        {
            Image[] handImage = new Image[HandOfCards.Count()];

            //Loops through all the cards in the hand and gathers their images
            for (int i = 0; i < HandOfCards.Count(); i++)
            {
                handImage[i] = HandOfCards[i].DrawCard();
            }

            return handImage;
        }



        /// <summary>
        /// Generates a new hand
        /// </summary>
        public Hand()
        {
        }

        /// <summary>
        /// Creates a hand
        /// </summary>
        /// <returns>Returns the generated hand</returns>
        public virtual List<Cards> GenerateHand()
        {
            //Goes through the deck and adds the first 5 cards  
            for (int i = 0; i < 5; i++)
            {
                handOfCards.Add(generatedDeck.Pop());
            }
            return handOfCards;
        }


        /// <summary>
        /// Adds a card to the current hand
        /// </summary>
        /// <param name="currentHand">The hand of the current player</param>
        public virtual void AddCard(Hand currentHand)
        {
            currentHand.HandOfCards.Add(generatedDeck.Pop());
        }

        /// <summary>
        /// Calculates the sum of the all the cards in the current hand
        /// </summary>
        /// <returns>The sum of the cards</returns>
        public int CalcCardSum()
        {

            int sum = 0;

            if (HandOfCards.Count() != 0)
            {
                for (int i = 0; i < HandOfCards.Count; i++)
                {
                    sum += HandOfCards[i].CardRank;
                }
            }

            return sum;
        }
    }
}
