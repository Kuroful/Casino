// Kevin Hamza and Preston
// May 27th 2018
// Casino Map class 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class CasinoMap : Form
    {
        const string DEFAULT_FILE_EXTENSION = "txt";

        UserPlayer userPlayer;
        // Set up Player graphics
        Point userLocation;
        Size userSize;
        Rectangle userBoundary;
        // Set up casino background graphics
        Point casinoLocation;
        Size casinoSize;
        Rectangle casinoBoundary;
        // Set up location of blackjack table
        Point blackjackLocation;
        Size blackjackSize;
        Rectangle blackjackBoundary;
        // Set up location of the war table
        Point warLocation;
        Size warSize;
        Rectangle warBoundary;
        // Set up location of the exit
        Point exitLocation;
        Size exitSize;
        Rectangle exitBoundary;
        // Call menu for loading player information and saving player information
        Menu menu = new Menu();

        //Forms for both games
        Blackjack frmBlackjack;
        War frmWar;
        //User movement
        private bool userUp, userDown, userLeft, userRight;


        public CasinoMap()
        {
            

            InitializeComponent();
            Graphics();
            LoadScreen();
            WinLoseCondition();
            
          
            
            
        }
        // Checks to see if you are bankrupt or if you have enough money to win
        private void WinLoseCondition()
        {
            // if you have no money left you lose!
            if (userPlayer.Money == 0)
            {
                MessageBox.Show("You have no more money! You lose! ");
                Application.Exit();
            }
            else if (userPlayer.Money >= 100000)
            {
                MessageBox.Show("You have won enough money to save your family! Congratulations!");
                Application.Exit();
            }
        }
        // Load player information 
        private void LoadScreen()
        {
            userPlayer = new UserPlayer();
            userPlayer = menu.LoadPlayer();
            lblUserMoney.Text = "Current Money: $" + userPlayer.Money;
        }
        // Display graphics of the casino map
        private void Graphics()
        {
            // Graphics of the player
            userLocation = new Point(100, 100);
            userSize = new Size(100, 70);
            userBoundary = new Rectangle(userLocation, userSize);
            // Graphics of the casino map
            casinoLocation = new Point(0, 0);
            casinoSize = new Size(1280, 720);
            casinoBoundary = new Rectangle(casinoLocation, casinoSize);
            // Blackjack Boundary
            blackjackLocation = new Point(815, 400);
            blackjackSize = new Size(115, 180);
            blackjackBoundary = new Rectangle(blackjackLocation, blackjackSize);
            // War Boundary
            warLocation = new Point(1050, 400);
            warSize = new Size(115, 180);
            warBoundary = new Rectangle(warLocation, warSize);
            // Exit Boundary
            exitLocation = new Point(640, 650);
            exitSize = new Size(112, 60);
            exitBoundary = new Rectangle(exitLocation, exitSize);
            // Display labels of where blackjack is
            lblBlackjack.Show();
            lblBlackjack.Location = new Point(700, 400);
            // Display labels of where war is
            lblWar.Show();
            lblWar.Location = new Point(1100, 375);
            // Display labels of where the exit is
            lblExit.Show();
            lblExit.Location = new Point(660, 660);

        }
        // Checks boundaries of the casino map
        private void Boundary()
        {
            // Make sure the user does not go past the boundaries
            if (userLocation.Y + userSize.Height > ClientSize.Height)
            {
                userLocation.Y = ClientSize.Height - userSize.Height;
            }
            else if (userLocation.Y < 0)
            {
                userLocation.Y = 0;
            }
            else if (userLocation.X + userSize.Width > ClientSize.Width)
            {
                userLocation.X = ClientSize.Width - userSize.Width;
            }
            else if (userLocation.X < 0)
            {
                userLocation.X = 0;
            }
            
            // If player touches the blackjack table, blackjack game will start
            if (userBoundary.IntersectsWith(blackjackBoundary))
            {
                frmBlackjack = new Blackjack();
                frmBlackjack.Show();
                Close();
            }
            // If player touches the war table, war game will start
            else if (userBoundary.IntersectsWith(warBoundary))
            {
                frmWar = new War();
                frmWar.Show();
                Close();
               
            }
            // If the player touches the exit, you can leave the casino with your money
            else if (userBoundary.IntersectsWith(exitBoundary))
            {
                ForceStop();
                userLocation.X = 0;
                userLocation.Y = 0;
                // Dialogue box comes up to encourage you to not leave
                if (MessageBox.Show("Leaving so soon?", "Exiting game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
               
            }
            // Update location of the user
            userBoundary.Location = userLocation;

        }
       
        protected override void OnPaint(PaintEventArgs e)
        {           
            base.OnPaint(e);
            // Draws the background of the game
            e.Graphics.DrawImage(Properties.Resources.CasinoMap, casinoBoundary);
            // draws the graphics of the user
            e.Graphics.DrawImage(Properties.Resources.Player, userBoundary);
        }
        
        #region Movement

        private void TmrMovement_Tick(object sender, EventArgs e)
        {
            // speed of the player
            PlayerSpeed();
            // check boundaries so user cannot cross it
            Boundary();
            Refresh();
        }      

        private void CasinoMap_KeyDown(object sender, KeyEventArgs e)
        {
            // player moves up
            if (e.KeyCode == Keys.W)
            {
                userUp = true;
            }
            // player moves left
            else if (e.KeyCode == Keys.A)
            {
                userLeft = true;
            }
            // player moves down
            else if (e.KeyCode == Keys.S)
            {
                userDown = true;
            }
            // player moves right
            else if (e.KeyCode == Keys.D)
            {
                userRight = true;
            }
            
        }
        private void CasinoMap_KeyUp(object sender, KeyEventArgs e)
        {
            // player stops moving up
            if (e.KeyCode == Keys.W)
            {
                userUp = false;
            }
            // player stops moving left
            else if (e.KeyCode == Keys.A)
            {
                userLeft = false;
            }
            // player stops moving down
            else if (e.KeyCode == Keys.S)
            {
                userDown = false;
            }
            // player stops moving right
            else if (e.KeyCode == Keys.D)
            {
                userRight = false;
            }
        }
        // Forces the player to stop after touching the exit
        private void ForceStop()
        {
            userRight = false;
            userUp = false;
            userDown = false;
            userRight = false;
        }
        private void PlayerSpeed()
        {
            // users normal speed up
            if (userUp == true)
            {
                userLocation.Y -= 15;
            }
            // users normal speed down
            else if (userDown == true)
            {
                userLocation.Y += 15;
            }
            // users normal speed left
            else if (userLeft == true)
            {
                userLocation.X -= 15;
            }
            // users normal speed right
            else if (userRight == true)
            {
                userLocation.X += 15;
            }
            // updates location of player
            userBoundary.Location = userLocation;
        }
        #endregion
    }
}
