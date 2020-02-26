/*
 * Preston Wan, Hamza Hussain, Kevin Ma
 * May 27, 2018
 * Stores details of a PlayerBlackjack
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project
{
    class PlayerBlackjack : Player
    {
        /// <summary>
        /// Blank PlayerBlackjack constructor
        /// </summary>
        public PlayerBlackjack() : this("")
        { }

        /// <summary>
        /// Create a new player for blackjack with given name
        /// </summary>
        public PlayerBlackjack(string name) : base(name)
        {
            int money = this.Money;
            hand = new HandBlackjack();
        }

        /// <summary>
        /// Get's the player's card sum
        /// </summary>
        /// <returns>Card sum from the player's hand</returns>
        public int GetCardSum()
        {
            return hand.CalcCardSum();
        }

        /// <summary>
        /// Adds a card to the player's hand
        /// </summary>
        /// <param name="deck">Deck that the card is drawn from</param>
        public virtual void Hit(Deck deck)
        {
            hand.AddCard(hand);
        }

        // whether the player has bust
        protected bool isBust;
        /// <summary>
        /// Whether the player has bust
        /// </summary>
        public bool IsBust { get { return isBust; } }

        /// <summary>
        /// Calculates whether the player has bust
        /// </summary>
        /// <returns></returns>
        public bool Bust()
        {
            // true if the player's card sum exceeds 21
            if (GetCardSum() > 21)
            {
                return isBust = true;
            }
            // false if not
            else
            {
                return isBust = false;
            }
        }

        // whether the player playing
        protected bool isPlaying;
        /// <summary>
        /// Whether the player is playing
        /// </summary>
        public bool IsPlaying { get { return isPlaying; } }

        /// <summary>
        /// Indicates that the player is not playing anymore
        /// </summary>
        public void Stand()
        {
            isPlaying = false;
        }

        /// <summary>
        /// Check against the dealer to see if the player has won
        /// </summary>
        /// <param name="dealer">The dealer in the game</param>
        /// <returns>If the player has won the game</returns>
        public bool IsWinner(Dealer dealer)
        {
            // player wins if the dealer busts
            if (dealer.Bust())
            {
                return true;
            }

            // check if the player has not bust
            if (!isPlaying && !Bust())
            {
                // check to see if the player's card sum is greater than the dealer's
                if (this.GetCardSum() > dealer.GetCardSum())
                {
                    return true;
                }
            }
            // false if player hasn't won
            return false;
        }
    }
}
