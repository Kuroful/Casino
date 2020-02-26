using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class UserPlayer
    {
        // set the name of the player
        private string name;
        // get player name
        public string Name { get { return name; } }

        // set the money of the player
        private int money;
        // get player money
        public int Money { get { return money; } }


        public UserPlayer() : this("", 5000)
        { }

        

        public UserPlayer(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
    }
}
