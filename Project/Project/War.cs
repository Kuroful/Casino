//Hamza, Preston, Kevin
//May 26
//The game mechanics for "War"

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
    public partial class War : Form
    {

        //Initializing the player and comptuer
        Player player = new PlayerWar();
        Player computerPlayer = new PlayerWar();
        // create menu object
        Menu menu = new Project.Menu();
        //Initializing the hands for both player and computer
        Hand playerHand, computerHand;
        //File output
        const string DEFAULT_FILE_EXTENSION = "txt";
        //Storing the images for both player and computer hand
        Image[] playerCard, computerCard;

        //Player information
        string name;
        int money;
        int betAmount;

        //Indicators for various stages of the game
        bool drawCard = false;
        bool startRound = false;
        bool middleOfGame = false;
        int countdown;
        int currentCard = 0;
        int playerWins = 0;
        int computerWins = 0;

        //Gamestates
        int gameState = GAME_MENU;
        const int GAME_MENU = 1;
        const int GAME_START = 2;
        const int GAME_INSTRUCTIONS = 3;
        // Background graphics
        PointF backgroundLocation;
        SizeF backgroundSize;
        RectangleF backgroundBoundary;
        UserPlayer character;


        #region Game Mechanics
        public War()
        {
            InitializeComponent();
            // Attempt to load player information
            try
            {

                character = menu.LoadPlayer();
                name = character.Name;
                money = character.Money;
            }
            // Display error message due to not be able to load the file
            catch (Exception ex)
            {
                MessageBox.Show("Could not Load file.", "Unknown Error");
            }

            // Display current money 
            lblBettingAmount.Text = "Please enter your betting amount\n Your current money is $" + money;



        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void Start()
        {
            //Creates new hand for the player
            playerHand = new HandWar();
            playerCard = playerHand.DrawHand();
            //Creates new hand for the computer
            computerHand = new HandWar();
            computerCard = computerHand.DrawHand();
        }

        /// <summary>
        /// Runs the game and the final result screen
        /// </summary>
        public void Game()
        {
            //Starts the round
            Battle();
            //If the player wins, then they recieve the money they bet. 
            if (WinCondition())
            {
                middleOfGame = false;
                MessageBox.Show("Your current money is now $" + money);
                try
                {
                    UserPlayer character = new Project.UserPlayer(name, money);
                    MessageBox.Show("You saved the game " + character.Name);
                    menu.SavePlayer(character);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving");
                }

            }


        }

        /// <summary>
        /// Determines which player's card value is better
        /// </summary>
        public void Battle()
        {
            //Stores the values of the player and computers current cards
            playerHand.ValueOfCard = playerHand.HandOfCards[currentCard].CardRank;
            computerHand.ValueOfCard = computerHand.HandOfCards[currentCard].CardRank;

            // When the round starts, compare the value of the cards
            if (startRound)
            {
                // If the player card is greater, you win the round
                if (playerHand.ValueOfCard > computerHand.ValueOfCard)
                {
                    playerWins += 1;
                    lblPlayerWinNumber.Text = playerWins.ToString();
                }
                // If the player card is equal, you tie with the important and both you and player gets a point
                else if (playerHand.ValueOfCard == computerHand.ValueOfCard)
                {
                    playerWins += 1;
                    lblPlayerWinNumber.Text = playerWins.ToString();

                    computerWins += 1;
                    lblComputerWinNumber.Text = computerWins.ToString();
                }
                // If computer card is greater, computer wins the round
                else
                {
                    computerWins += 1;
                    lblComputerWinNumber.Text = computerWins.ToString();
                }

            }

            player.NumberOfWins = playerWins;
            computerPlayer.NumberOfWins = computerWins;

        }

        /// <summary>
        /// Determines whether the player has won money or lost money 
        /// </summary>
        /// <returns></returns>
        public bool WinCondition()
        {


            PlayerWar user = (PlayerWar)player;
            PlayerWar computer = (PlayerWar)computerPlayer;
            // If user wins 13 games, they win two times of their money back
            if (user.NumberOfWins == 13)
            {
                money += betAmount * 2;
                MessageBox.Show("You have won $" + betAmount * 2 + " !");

                return true;
            }
            // If computer wins 13 games, you lose two times of your money
            else if (computer.NumberOfWins == 13)
            {
                money -= betAmount;
                MessageBox.Show("You have lost $" + betAmount + " !");

                return true;
            }
            // If both you and the computer win 13 games, neither of you lose money
            else if (player.NumberOfWins == 13 && computer.NumberOfWins == 13)
            {
                MessageBox.Show("It's a tie! You have neither earned nor lost money !");

                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Variables for the background image
            backgroundLocation = new PointF(0, 0);
            backgroundSize = new SizeF(1280, 720);
            backgroundBoundary = new RectangleF(backgroundLocation, backgroundSize);

            // If the user chooses to start the game, display war battle background
            if (gameState == GAME_START)
            {
                e.Graphics.DrawImage(Properties.Resources.WarBackground, backgroundBoundary);
            }
            // If the user chooses to look at the instructions, display war instructions
            else if (gameState == GAME_INSTRUCTIONS)
            {
                e.Graphics.DrawImage(Properties.Resources.war_instructions, backgroundBoundary);
            }
            // If the user goes to the war menu, display war background
            else if (gameState == GAME_MENU)
            {
                e.Graphics.DrawImage(Properties.Resources.WarLogo, backgroundBoundary);
            }
            // When the round starts, card image will appear
            if (startRound)
            {
                e.Graphics.DrawImage(playerCard[currentCard], 620, 400, 68, 91);
                e.Graphics.DrawImage(computerCard[currentCard], 620, 100, 68, 91);
            }
        }


        private void tmr_Tick(object sender, EventArgs e)
        {
            //Round only starts if the user clicks the button to start
            if (drawCard)
            {
                //Countdown timer
                countdown -= 1;
                lblResult.Text = "Round Starts In: " + countdown;

                if (countdown <= 0)
                {
                    //Show the cards and stop the timer
                    lblResult.Hide();
                    startRound = true;
                    Refresh();
                    tmr.Stop();

                }
                if (startRound)
                {
                    //Restart the variables to start the next round
                    Game();
                    currentCard++;
                    drawCard = false;
                }
            }
        }

        #region Buttons 

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            //Makes sure the round isn't already going on

            drawCard = true;
            countdown = 4;
            tmr.Start();
            lblResult.Show();
            Refresh();
        }




        private void btnStart_Click(object sender, EventArgs e)
        {
            // Will not start unless there is money to spend
            if (txtBetAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount to bet");
            }
            // If letters are used, game will not start and an error message will pop up
            else if (!int.TryParse(txtBetAmount.Text, out betAmount))
            {
                MessageBox.Show("Invalid amount");
            }
            else if (money - betAmount < 0)
            {
                MessageBox.Show("Insufficient funds for bet");
            }
            // 
            else
            {
                betAmount = int.Parse(txtBetAmount.Text);
                gameState = GAME_START;
                lblBettingAmount.Hide();
                txtBetAmount.Hide();
                btnInstructions.Hide();
                btnGoBack.Text = "Exit Game";
                btnStart.Hide();
                btnDrawCard.Show();
                lblPlayerWins.Show();
                lblComputerWins.Show();


                Start();
                middleOfGame = true;
                Refresh();
            }
        }
        // Display instructions
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            gameState = GAME_INSTRUCTIONS;
            Refresh();
        }


        // Go back to the session before
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // If you are in the instruction screen, go back to menu
            if (gameState == GAME_INSTRUCTIONS)
            {
                gameState = GAME_MENU;
                Refresh();
            }
            // If you are in the menu and you want to exit, exit game
            else if (gameState == GAME_START)
            {
                {
                    if (middleOfGame)
                    {
                        money -= betAmount * 2;
                    }

                    if (MessageBox.Show("Are you sure you want to exit?", "Leaving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Close();
                        CasinoMap frmMap = new CasinoMap();
                        frmMap.Show();
                    }
                }
            }
            else
            {
                Close();
                CasinoMap frmMap = new CasinoMap();
                frmMap.Show();
            }
        }

        #endregion
    }
}
