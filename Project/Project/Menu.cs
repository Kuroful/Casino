using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Menu
    {
        /// <summary>
        /// stores options of the menu
        /// </summary>
        public Menu()
        {    }
        // create casino map
        CasinoMap frmCasinoMap;
        // part of file name to create full file name
        const string DEFAULT_FILE_EXTENSION = "txt";


        /// <summary>
        /// Starts the game
        /// </summary>
        public void StartGame()
        {
            frmCasinoMap = new CasinoMap();
            frmCasinoMap.Show();
        }

        
        
        

        #region Save and Load

        /// <summary>
        /// Saves the file of the player information
        /// </summary>
        public void SavePlayer(UserPlayer player)
        {
            // Create the file name 
            string fileName = "CASINOSAVE." + DEFAULT_FILE_EXTENSION;
            // create a new file for output 
            using (StreamWriter file = new StreamWriter(fileName))
            {
                // save players name
                file.WriteLine(player.Name);
                // save the players money 
                file.WriteLine(player.Money);
            }

          
        }
        /// <summary>
        /// Loads the user information from the file using streamreader
        /// </summary>
        /// <returns> information about the user </returns>
        public UserPlayer LoadPlayer()
        {
            // name of the file 
            string fileName = "CASINOSAVE." + DEFAULT_FILE_EXTENSION;
            // load and read  a file 
            using (StreamReader file = new StreamReader(fileName))
            {
                // string to store name
                string name = "";
                // integer to store money
                int money = 0;
                while (file.Peek() != -1)
                {
                    // read name of user
                    name = file.ReadLine();
                    // read amount of money user has 
                    int.TryParse(file.ReadLine(), out money);
                }
                // create player object to contain name and money 
                UserPlayer player = new UserPlayer(name, money);
                // return user information 
                return player;
            }
           
        }

        #endregion


        /// <summary>
        /// Closes the program
        /// </summary>
        public void ExitApplication()
        {
            Environment.Exit(0);
        }


    }
}
