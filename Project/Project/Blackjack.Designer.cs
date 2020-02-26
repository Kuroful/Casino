namespace Project
{
    partial class Blackjack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBettingAmount = new System.Windows.Forms.TextBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.tmrGameEnd = new System.Windows.Forms.Timer(this.components);
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBettingAmount
            // 
            this.txtBettingAmount.Location = new System.Drawing.Point(381, 437);
            this.txtBettingAmount.Name = "txtBettingAmount";
            this.txtBettingAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBettingAmount.TabIndex = 0;
            this.txtBettingAmount.TabStop = false;
            this.txtBettingAmount.Text = "Enter bet amount";
            this.txtBettingAmount.Click += new System.EventHandler(this.txtBettingAmount_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Location = new System.Drawing.Point(790, 422);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(92, 49);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToMenu.Location = new System.Drawing.Point(238, 538);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(92, 49);
            this.btnReturnToMenu.TabIndex = 2;
            this.btnReturnToMenu.Text = "Return";
            this.btnReturnToMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Location = new System.Drawing.Point(556, 422);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(92, 49);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start the Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHit.Location = new System.Drawing.Point(749, 538);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(92, 49);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Visible = false;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStand.Location = new System.Drawing.Point(891, 538);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(92, 49);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Visible = false;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // tmrGameEnd
            // 
            this.tmrGameEnd.Tick += new System.EventHandler(this.tmrGameEnd_Tick);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.BackColor = System.Drawing.Color.Transparent;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.Transparent;
            this.lblDealer.Location = new System.Drawing.Point(681, 24);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(75, 25);
            this.lblDealer.TabIndex = 6;
            this.lblDealer.Text = "Dealer";
            this.lblDealer.Visible = false;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayer.Location = new System.Drawing.Point(886, 498);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer.TabIndex = 7;
            this.lblPlayer.Text = "User";
            this.lblPlayer.Visible = false;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Transparent;
            this.lblMoney.Location = new System.Drawing.Point(379, 413);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(50, 17);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "money";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.txtBettingAmount);
            this.DoubleBuffered = true;
            this.Name = "Blackjack";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Blackjack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBettingAmount;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Timer tmrGameEnd;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblMoney;
    }
}