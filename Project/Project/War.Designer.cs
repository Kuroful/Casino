namespace Project
{
    partial class War
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
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblComputerWins = new System.Windows.Forms.Label();
            this.lblComputerWinNumber = new System.Windows.Forms.Label();
            this.lblPlayerWinNumber = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.lblBettingAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(560, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 68);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Location = new System.Drawing.Point(1129, 12);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(123, 68);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(123, 68);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawCard.Location = new System.Drawing.Point(363, 245);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(123, 68);
            this.btnDrawCard.TabIndex = 3;
            this.btnDrawCard.Text = "Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Visible = false;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(519, 83);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(202, 27);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Round Starts In: ";
            this.lblResult.Visible = false;
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWins.ForeColor = System.Drawing.Color.Transparent;
            this.lblPlayerWins.Location = new System.Drawing.Point(44, 429);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(203, 39);
            this.lblPlayerWins.TabIndex = 5;
            this.lblPlayerWins.Text = "Player Wins";
            this.lblPlayerWins.Visible = false;
            // 
            // lblComputerWins
            // 
            this.lblComputerWins.AutoSize = true;
            this.lblComputerWins.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWins.ForeColor = System.Drawing.Color.Transparent;
            this.lblComputerWins.Location = new System.Drawing.Point(32, 104);
            this.lblComputerWins.Name = "lblComputerWins";
            this.lblComputerWins.Size = new System.Drawing.Size(257, 39);
            this.lblComputerWins.TabIndex = 6;
            this.lblComputerWins.Text = "Computer Wins";
            this.lblComputerWins.Visible = false;
            // 
            // lblComputerWinNumber
            // 
            this.lblComputerWinNumber.AutoSize = true;
            this.lblComputerWinNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerWinNumber.ForeColor = System.Drawing.Color.Red;
            this.lblComputerWinNumber.Location = new System.Drawing.Point(102, 156);
            this.lblComputerWinNumber.Name = "lblComputerWinNumber";
            this.lblComputerWinNumber.Size = new System.Drawing.Size(0, 39);
            this.lblComputerWinNumber.TabIndex = 7;
            // 
            // lblPlayerWinNumber
            // 
            this.lblPlayerWinNumber.AutoSize = true;
            this.lblPlayerWinNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWinNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinNumber.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPlayerWinNumber.Location = new System.Drawing.Point(114, 490);
            this.lblPlayerWinNumber.Name = "lblPlayerWinNumber";
            this.lblPlayerWinNumber.Size = new System.Drawing.Size(0, 37);
            this.lblPlayerWinNumber.TabIndex = 8;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetAmount.Location = new System.Drawing.Point(51, 567);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(100, 26);
            this.txtBetAmount.TabIndex = 9;
            this.txtBetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBettingAmount
            // 
            this.lblBettingAmount.AutoSize = true;
            this.lblBettingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblBettingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettingAmount.ForeColor = System.Drawing.Color.Transparent;
            this.lblBettingAmount.Location = new System.Drawing.Point(47, 503);
            this.lblBettingAmount.Name = "lblBettingAmount";
            this.lblBettingAmount.Size = new System.Drawing.Size(36, 24);
            this.lblBettingAmount.TabIndex = 10;
            this.lblBettingAmount.Text = "bet";
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblBettingAmount);
            this.Controls.Add(this.txtBetAmount);
            this.Controls.Add(this.lblPlayerWinNumber);
            this.Controls.Add(this.lblComputerWinNumber);
            this.Controls.Add(this.lblComputerWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnStart);
            this.Name = "War";
            this.Text = "War";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblComputerWins;
        private System.Windows.Forms.Label lblComputerWinNumber;
        private System.Windows.Forms.Label lblPlayerWinNumber;
        private System.Windows.Forms.TextBox txtBetAmount;
        private System.Windows.Forms.Label lblBettingAmount;
    }
}