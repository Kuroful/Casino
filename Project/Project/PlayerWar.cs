/*
 * Preston Wan, Hamza Hussain, Kevin Ma
 * May 27, 2018
 * Stores details of a PlayerWar
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PlayerWar : Player
    {
        /// <summary>
        /// Blank PlayerWar constructor
        /// </summary>
        public PlayerWar() : this("")
        { }

        /// <summary>
        /// Creates a new player for war with given name
        /// </summary>
        public PlayerWar(string name) : base(name)
        {
            hand = new HandWar();
            this.name = Name;
        }       
    }
}
