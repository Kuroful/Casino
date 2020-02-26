/*
 * Hamza Hussain, Preston Wan and Kevin Ma
 * May 27, 2018
 * Blackjack form used to run the game
 */

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
    public partial class Blackjack : Form
    {
        // constants used to indicate gamestate
        const int GAMESTATE_MENU = 0;
        const int GAMESTATE_BLACKJACK_MENU = 1;
        const int GAMESTATE_PLAYING = 2;
        const int GAMESTATE_INSTRUCTIONS = 3;
        // stores gamestate
        int gamestate = GAMESTATE_BLACKJACK_MENU;

        // declare objects to be used in game
        UserPlayer character;
        PlayerBlackjack user;
        //Player player;
        Player dealer;
        Hand playerHand, dealerHand;
        Image[] userCards, dealerCards;
        Menu menu = new Menu();

        // stores the money of the player
        int money;
        // stores the name of the player
        string name;
        
        //Indicators for various stages in the game 
        bool drawCard = false;
        bool updateCards = false;
        bool isPlaying = true;
        bool exitingGame = false;
        bool middleOfGame = false;

        //Background points
        Point blackjackBackground;
        Size blackjackSize;
        Rectangle blackjackBoundary;

        // stores the amount the player bet
        int betAmount;
        // used to indicate the current turn in the game
        // 0 is player's turn / start, 1 is dealer's turn and 3 is round over
        int turn = 0;

        public Blackjack()
        {
            InitializeComponent();
            Graphics();
            LoadInfo();
        }

        /// <summary>
        /// Loads the player's information
        /// </summary>
        public void LoadInfo()
        {
            try
            {
                // loads the player's information
                character = menu.LoadPlayer();
                // stores the player's information
                money = character.Money;
                name = character.Name;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not Load file.", "Unknown Error");
            }

            // displays the players money 
            lblMoney.Text = "You have $" + money;
        }

        public void Start()
        {
            //Initites the player and their hand 
            user = new PlayerBlackjack(Name);
            playerHand = new HandBlackjack();
            userCards = playerHand.DrawHand();
            lblPlayer.Text = name;            
            //Initiates the dealer and their hand
            dealer = new Dealer();
            dealerHand = new HandBlackjack();
            dealerCards = dealerHand.DrawHand();

            //If the dealer and the player have the same hand, then generate a new hand
            while (playerHand.CalcCardSum() == dealerHand.CalcCardSum())
            {
                // playerHand.GenerateHand();
                playerHand = new HandBlackjack();               
                userCards = playerHand.DrawHand();

            }
            //Draws both of the player's cards when the game starts
            drawCard = true;            
            Refresh();
        }

        /// <summary>
        /// Coordinates for the background
        /// </summary>
        public void Graphics()
        {
            blackjackBackground = new Point(0, 0);
            blackjackSize = new Size(1280, 720);
            blackjackBoundary = new Rectangle(blackjackBackground, blackjackSize);
        }
        
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Display the menu screen if it is on the menu screen
            if (gamestate == GAMESTATE_BLACKJACK_MENU)
            {
                e.Graphics.DrawImage(Properties.Resources.BlackjackBackground, blackjackBoundary);
            }
            //Display the instructions
            else if (gamestate == GAMESTATE_INSTRUCTIONS)
            {
                e.Graphics.DrawImage(Properties.Resources.BlackjackInstructions, blackjackBoundary);
            }
            //Display the actual game
            else if (gamestate == GAMESTATE_PLAYING && drawCard)
            {
                //Draw the background
                e.Graphics.DrawImage(Properties.Resources.WarBackground, blackjackBoundary);
                //Make sure that both hands actually have cards in them
                if (playerHand.HandOfCards.Count() != 0 && dealerHand.HandOfCards.Count() != 0)
                {
                    //Loactions for player and dealer cards
                    int playerCardLocation = 620;
                    int dealerCardLocation = 300;

                    //Draw the player cards
                    for (int i = 0; i < playerHand.HandOfCards.Count(); i++)
                    {
                        e.Graphics.DrawImage(userCards[i], playerCardLocation, 400, 68, 91);
                        //Increment the next card location by the width of a card so they dont intersect
                        playerCardLocation += 68;
                    }
                    //Drawing the dealer's cards
                    for (int j = 0; j < dealerHand.HandOfCards.Count(); j++)
                    {
                        //If it is the dealer's first card, draw it face down
                        if (j == 0)
                        {
                            e.Graphics.DrawImage(Properties.Resources.facedowncard, dealerCardLocation, 100, 68, 91);
                            dealerCardLocation += 68;
                        }
                        //Otherwise draw the rest of the cards normally
                        else
                        {
                            e.Graphics.DrawImage(dealerCards[j], dealerCardLocation, 100, 68, 91);
                            dealerCardLocation += 68;
                        }
                        //If the user Stands, reveal the dealer's first card
                        if (!isPlaying)
                        {
                            e.Graphics.DrawImage(dealerCards[0], 300, 100, 68, 91);
                            dealerCardLocation += 68;

                            
                        }                        
                    }
                }
            }
        }

        /// <summary>
        /// Closes current form and reopens the Casino map
        /// </summary>
        public void ExitGame()
        {
            Close();
            CasinoMap frmOriginalMap = new CasinoMap();
            frmOriginalMap.Show();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            //If the user decides to back out in the middle of the game they lose double thier money ! 
            if (gamestate== GAMESTATE_PLAYING)
            {
                middleOfGame = true;
            }
            //Go back to the menu screen
            if (gamestate == GAMESTATE_INSTRUCTIONS )
            {
                gamestate = GAMESTATE_BLACKJACK_MENU;
                OptionsVisible();
            }
            //Exit the game
            else
            {
                ExitGame();
            }
            Refresh();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // check if text box is empty
            if (txtBettingAmount.Text == "")
            {
                MessageBox.Show("Please enter an amount to bet");
            }
            // check if amount can be converted into an int, used to see if there are letters
            else if (!int.TryParse(txtBettingAmount.Text, out betAmount))
            { 
                MessageBox.Show("Invalid amount");
            }
            // check if the player has enough money for the bet
            else if (money - betAmount < 0)
            {
                MessageBox.Show("Insufficient funds for bet");
            }
            else
            {
                // indicate that the game has started
                gamestate = GAMESTATE_PLAYING;
                OptionsVisible();

                Start();

                // hides player's money
                lblMoney.Visible = false;
                // starts the timer
                tmrGameEnd.Enabled = true;
            }
            Refresh();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //Adds a card to the players current hand
            playerHand.AddCard(playerHand);
            userCards = playerHand.DrawHand();          
            Refresh();
            //Updates the user's hand
            user.Hand.HandOfCards = playerHand.HandOfCards;

            // check if user busted
            if (user.Bust())
            {
                // if user has busted then round is over
                turn = 3;
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            user.Stand();
            isPlaying = false;

            // indicate that the player's turn is over
            turn = 2;

            DealerMove();
        }

        /// <summary>
        /// Dealer's actions
        /// </summary>
        public void DealerMove()
        {
            StopGame();
            
            dealer.Hand.HandOfCards = dealerHand.HandOfCards;

            // dealer continues to hit until their card sum is 17 or more
            while (dealerHand.CalcCardSum() <= 17)
            {
                // 
                dealerHand.AddCard(dealerHand);
                dealerCards = dealerHand.DrawHand();
                dealer.Hand.HandOfCards = dealerHand.HandOfCards;
            }

            // indicate the round is over
            turn = 3;

            Refresh();
        }

        /// <summary>
        /// Check if the player has won
        /// </summary>
        /// <returns></returns>
        public bool WinCheck()
        {
            middleOfGame = false;

            // true if they achieved black jack or had a higher card sum than the dealer
            if (user.GetCardSum() == 21 || user.IsWinner((Dealer)dealer))
            {
                user.Stand();
                return true;
            }
            
            // if not then false
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Stops the player from continuing to play
        /// </summary>
        public void StopGame()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            
        }

        private void tmrGameEnd_Tick(object sender, EventArgs e)
        {
            //middleOfGame = true;

            // check for when the round is over
            if (turn == 3)
            {
                StopGame();
                // stops the timer
                tmrGameEnd.Enabled = false;

                // check if player has won the game
                if (WinCheck())
                {
                    // gives player double their bet
                    money += betAmount * 2;
                    MessageBox.Show("Congratulations! You have won $" + betAmount * 2 + "!");
                }
                // if player has lost the game
                else
                {
                    // subtract their bet
                    money -= betAmount;
                    // makes the players money 0 if it is negative
                    if(money < 0)
                    {
                        money = 0;
                    }

                    // check if they busted
                    if (user.IsBust == true)
                    {
                        MessageBox.Show("Bust! You lost $" + betAmount + "!");
                    }
                    else if (middleOfGame)
                    {
                        if (MessageBox.Show("Are you sure you want to leave the game? You will lose all of your " + betAmount + " betted money x 2 !", "What a coward!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            money -= betAmount * 2;
                        }
                    }
                    // if they didn't bust then the dealer won
                    else
                    {
                        MessageBox.Show("Dealer won! You lost $" + betAmount + "!");
                    }
                }

                // save the user's information
                try
                {
                    UserPlayer character = new Project.UserPlayer(name, money);
                    menu.SavePlayer(character);
                    MessageBox.Show(character.Name + " saved the game");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed to save ");
                }
            }
        }

        private void txtBettingAmount_Click(object sender, EventArgs e)
        {
            // Clears text box when clicked
            txtBettingAmount.Clear();
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Display possible configuration based on gamestate
        /// </summary>
        public void OptionsVisible()
        { 
            if (gamestate == GAMESTATE_INSTRUCTIONS)
            {
                txtBettingAmount.Visible = false;
                btnStartGame.Visible = false;
                lblMoney.Visible = false;
                btnInstructions.Visible = false;
            }
            else if (gamestate == GAMESTATE_BLACKJACK_MENU)
            {
                txtBettingAmount.Visible = true;
                btnStartGame.Visible = true;
                lblMoney.Visible = true;
                btnInstructions.Visible = true;
            }
            else
            {
                btnInstructions.Visible = false;
                btnStartGame.Enabled = false;
                btnStartGame.Visible = false;
                txtBettingAmount.Enabled = false;
                txtBettingAmount.Visible = false;
                btnHit.Enabled = true;
                btnHit.Visible = true;
                btnStand.Enabled = true;
                btnStand.Visible = true;
                lblDealer.Show();
                
                lblPlayer.Show();
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            gamestate = GAMESTATE_INSTRUCTIONS;
            OptionsVisible();

            Refresh();
        }
    }
}
