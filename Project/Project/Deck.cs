//Hamza, Preston and Kevin
//May 26
//Deck class that creates the deck for both games to be used in the following Hand classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Deck : Cards
    {
        //Min value of a card in a deck is 2
        private const int MIN_CARD_VALUE = 2;
        private Random shuffleDeck = new Random();

        public Deck()
        {
            //Initializes the deck array of cards
            deck = new Cards[MAX_CARDS];
        }

        //Maximum of 52 cards in a deck
        private const int MAX_CARDS = 52;

        //Stores the deck -- Used as a stack since only the first card from the deck can be taken at a time
        public Stack<Cards> generatedDeck = new Stack<Cards>();


        private Cards[] deck;
        public Cards[] GetDeck
        {
            get { return deck; }
        }



        /// <summary>
        /// Generates a deck for use in Blackjack
        /// </summary>
        /// <returns>The generated deck</returns>
        public Stack<Cards> GenerateBlackjackDeck()
        {
            //Stores the current amount of cards in the deck
            int currentCards = 0;

            //Iterate through each of the 4 suits 
            foreach (SUIT suit in Enum.GetValues(typeof(SUIT)))
            {
                int value = MIN_CARD_VALUE;

                //Iterate through each of the 13 cards
                foreach (CARDNAME cardName in Enum.GetValues(typeof(CARDNAME)))
                {
                    //If the card is a royal, then the value must be 10
                    if (value > 10 && cardName != CARDNAME.Ace)
                    {
                        value = 10;
                    }
                    //else if (cardName == CARDNAME.Ace)
                    {
                       // value = 11;
                    }

                    //Add the current card comprised of a suit and value (rank)
                    deck[currentCards] = new Cards(suit.ToString(), value, cardName.ToString());
                    //Increment the current counter for the number of cards in the deck by 1
                    currentCards++;
                    //Increase the value of the cards by 1
                    value++;

                    //If there are more than 52 cards, then the deck is complete
                    if (currentCards == MAX_CARDS)
                    {
                        break;
                    }
                }
            }
            //Shuffle the cards in the deck
            Shuffle();
            return generatedDeck;
        }



        /// <summary>
        /// Generates a deck for the War game
        /// </summary>
        public Stack<Cards> GenerateWarDeck()
        {
            int currentCards = 0;

            foreach (SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                int value = MIN_CARD_VALUE;

                foreach (CARDNAME cardName in Enum.GetValues(typeof(CARDNAME)))
                {
                    //Add the current card comprised of a suit and value (rank)
                    deck[currentCards] = new Cards(s.ToString(), value, cardName.ToString());
                    currentCards++;
                    value++;
                    //If there are more than 52 cards, then the deck is complete
                    if (currentCards == MAX_CARDS)
                    {
                        break;
                    }
                }
            }
            //Shuffle the cards in the deck
            Shuffle();

            return generatedDeck;
        }


        /// <summary>
        /// Takes the current deck, and rearranges the cards so they are not in order
        /// </summary>
        private void Shuffle()
        {
            List<Cards> deckList = deck.ToList<Cards>();

            for (int shuffle = 0; shuffle < 100; shuffle++)
            {
                for (int i = 0; i < deckList.Count(); i++)
                {
                    int nextCard = shuffleDeck.Next(1, 20);

                    //Rearranges the cards
                    Cards card = deckList[i];
                    deckList[i] = deckList[nextCard];
                    deckList[nextCard] = card;
                }
            }
            //Creates a stack from the newly shuffled deck
            generatedDeck = new Stack<Cards>(deckList);
        }
    }
}
