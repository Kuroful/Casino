// Kevin Hamza and Preston
// May 28 2018
// Menu Screen Code
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;        // needed for File Input and Output
namespace Project
{
    public partial class Form1 : Form
    {
        // Different game states
        private const int GAMESTATE_MENU = 0;
        private const int GAMESTATE_ABOUT = 1;
        private const int GAMESTATE_INSTRUTIONS = 2;
        // current game state 
        public int gameState = GAMESTATE_MENU;
        // extension of the file to create the full file name 
        const string DEFAULT_FILE_EXTENSION = "txt";

        // Graphics data of casino background
        Point casinoLocation;
        Size casinoSize;
        Rectangle casinoBoundary;

        // Graphics data of casino title
        Point casinoTitleLocation;
        Size casinoTitleSize;
        Rectangle casinoTitleBoundary;

        // Graphics data of the location
        Point aboutLocation;
        Size aboutSize;
        Rectangle aboutBoundary;

        // amount of money the player starts off with 
        int money = 5000;
        // Create a form for blackjack
        Blackjack frmBlackjack;
        // create a form for war
        War frmWar;
        // Create a menu object 
        Menu menu = new Menu();
        // create a player object for the user
        UserPlayer player;

        public Form1()
        {
            InitializeComponent();
            Graphics();
            OptionsInvisible();

        }

        
        public void Graphics()
        {
            // Graphics of the casino background
            casinoLocation = new Point(0, 0);
            casinoSize = new Size(1280, 720);
            casinoBoundary = new Rectangle(casinoLocation, casinoSize);
            // Graphics of the casino title
            casinoTitleLocation = new Point(290, 100);
            casinoTitleSize = new Size(800, 100);
            casinoTitleBoundary = new Rectangle(casinoTitleLocation, casinoTitleSize);
            // Graphics about Hsiung
            aboutLocation = new Point(200, 80);
            aboutSize = new Size(900, 400);
            aboutBoundary = new Rectangle(aboutLocation, aboutSize);
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // start the game 
            menu.StartGame();
        }

        // Makes the menu buttons invisible 
        public void OptionsInvisible()
        {
            // make the following options disappear 
            btnStartGame.Visible = false;
            btnAbout.Visible = false;
            btnBack.Visible = false;
            lblText.Visible = false;
            // When in the about screen, make the back button appear 
            if (gameState == GAMESTATE_ABOUT)
            {
                btnBack.Visible = true;
                
            }
           
           
          
        }
        // Makes all the menu buttons visible 
        public void OptionsVisible()
        {
            btnStartGame.Visible = true;
            btnLoad.Visible = false;
            btnSaveUsername.Visible = false;
            btnAbout.Visible = true;
            lblUsername.Visible = false;
            lblText.Visible = true;
            txtUsername.Visible = false;
            btnBack.Visible = false;
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            // changes the game state to the about screen where you learn about the character and goal
            gameState = GAMESTATE_ABOUT;
            // make the buttons and unncessary things invisible 
            OptionsInvisible();
            Refresh();
        }

        private void btnStartBlackjack_Click(object sender, EventArgs e)
        {
            // Make blackjack game appear
            frmBlackjack = new Blackjack();
            frmBlackjack.Show();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            // If the game state changes to GAMESTATE_ABOUT, display the information of character and objective
            if (gameState == GAMESTATE_ABOUT)
            {
                e.Graphics.DrawImage(Properties.Resources.TrueAboutTwo, aboutBoundary);
            }
            // If the game state changes back to GAMESTATE_MENU, display the casino title and menu
            else
            {
                e.Graphics.DrawImage(Properties.Resources.CasinoBackgroundTwo, casinoBoundary);
                e.Graphics.DrawImage(Properties.Resources.CasinoTitle, casinoTitleBoundary);
            }
        }

 

        private void btnStartWar_Click(object sender, EventArgs e)
        {
            frmWar = new War();
            frmWar.Show();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Load the game
            LoadGame();
            // Make the options needed visible 
            OptionsVisible();
        }
        /// <summary>
        /// Saves the file of the player information
        /// </summary>
        public void SaveGame()
        {
            // create a user with their name and money 
            player = new Project.UserPlayer(txtUsername.Text,money); 
            // Attempt to save player information
            try
            {
                menu.SavePlayer(player);

            }
            // Cannot save the file, show error message
            catch (Exception ex)
            {
                MessageBox.Show("Could not save file.", "Unknown Error");

            }
            // Display welcome message with the player's name
            lblText.Text = "Welcome " + player.Name + "!";
            
        }

        /// <summary>
        /// Loads the file of the player
        /// </summary>
        public void LoadGame()
        {
            // Attempt to load player information
            try
            {
                player = menu.LoadPlayer();
            }
            // Display error message due to not be able to load the file
            catch (Exception ex)
            {
                MessageBox.Show("Could not Load file.", "Unknown Error");
            }
            // Display welcome message with the player's name 
            lblText.Text = "Welcome back " + player.Name + "!" ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {
            // Saves the username of the player and make the options that are needed appear
            if (txtUsername.Text !="")
            {
                OptionsVisible();
                SaveGame();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Reverts the graphics back to the menu graphics
            gameState = GAMESTATE_MENU;
            // Makes all the menu buttons visible 
            OptionsVisible();
            // Refreshes the graphics of the menu
            Refresh();
        }

      
    }
}

