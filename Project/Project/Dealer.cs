/*
 * Preston Wa, Hamza Hussain, Kevin Ma
 * May 27, 2018
 * Stores details of a Dealer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Dealer : PlayerBlackjack
    {
        /// <summary>
        /// Blanks Dealer constructor
        /// </summary>
        public Dealer() : this("")
        { }

        /// <summary>
        /// Creates a dealer with the given name
        /// </summary>
        public Dealer(string name) : base(name)
        { }
    }
}
