//Hamza, Kevin and Preston
//May 26
//Information for all the cards to be used throughout the program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Project
{
    class Cards
    {
        //Stores all the suits of the cards
        public enum SUIT
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }
      
        //Stores all the different cards
        public enum CARDNAME
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace            
        }
        
        //Gets the 'rank' or value of the card
        private int cardRank;
        public int CardRank
        {
            get { return cardRank; }

            set { cardRank = value; }
        }

        //Gets the suit of the card
        private string cardSuit;
        public string CardSuit
        {
            get { return cardSuit; }

            private set { cardSuit = value; }
        }

        //Gets the name of the card
        private string cardName;
        public string CardName
        {
            get { return cardName; }
        }

        /// <summary>
        /// Blank Card constructor
        /// </summary>
        public Cards() : this("", 0, "")
        { }

        /// <summary>
        /// Creates a card with given suit, rank and name
        /// </summary>
        public Cards(string suit, int rank, string name)
        {
            this.cardSuit = suit;
            this.cardRank = rank;
            this.cardName = name;
        }   

        /// <summary>
        /// Gets the image of the correspoinding card generated
        /// </summary>
        /// <returns>The image of the card</returns>
        public Image DrawCard()
        {
            //'Draws' the image
            System.Drawing.Image cardImage = System.Drawing.Image.FromFile("Resources/" + cardName + "Of" + cardSuit + ".png");
            return cardImage;
        }       
    }
}
