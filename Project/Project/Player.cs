/*
 * Preston Wan, Hamza Hussain, Kevin Ma
 * May 27, 2018
 * Stores details of a Player. Abstract class used to construct players for each game
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Project
{
    abstract class Player
    {
        // the number of times the player has won a game
        private int numberOfWins;
        /// <summary>
        /// The number of times the player has won a game
        /// </summary>
        public int NumberOfWins
        {
            get { return numberOfWins; }

            set { numberOfWins = value; }
        }

        // the player's name
        protected string name;
        /// <summary>
        /// The player's name
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        
        // the player's hand
        protected Hand hand;
        /// <summary>
        /// The player's hand
        /// </summary>
        public Hand Hand { get { return hand; } set { hand = value; } }

        // the player's money
        protected int money;
        /// <summary>
        /// The player's money
        /// </summary>
        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        /// <summary>
        /// Create a new player with the given name
        /// </summary>
        public Player(string name)
        {
            this.name = Name;
            this.money = Money;
        }

        /// <summary>
        /// Blank Player constructor
        /// </summary>
        public Player()
            : this("")
        { }
    }
}
