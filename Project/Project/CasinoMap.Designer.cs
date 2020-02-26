namespace Project
{
    partial class CasinoMap
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
            this.TmrMovement = new System.Windows.Forms.Timer(this.components);
            this.lblUserMoney = new System.Windows.Forms.Label();
            this.lblBlackjack = new System.Windows.Forms.Label();
            this.lblWar = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TmrMovement
            // 
            this.TmrMovement.Enabled = true;
            this.TmrMovement.Interval = 1;
            this.TmrMovement.Tick += new System.EventHandler(this.TmrMovement_Tick);
            // 
            // lblUserMoney
            // 
            this.lblUserMoney.AutoSize = true;
            this.lblUserMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblUserMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMoney.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserMoney.Location = new System.Drawing.Point(12, 20);
            this.lblUserMoney.Name = "lblUserMoney";
            this.lblUserMoney.Size = new System.Drawing.Size(70, 25);
            this.lblUserMoney.TabIndex = 0;
            this.lblUserMoney.Text = "label1";
            // 
            // lblBlackjack
            // 
            this.lblBlackjack.AutoSize = true;
            this.lblBlackjack.BackColor = System.Drawing.Color.Transparent;
            this.lblBlackjack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackjack.ForeColor = System.Drawing.Color.Transparent;
            this.lblBlackjack.Location = new System.Drawing.Point(374, 152);
            this.lblBlackjack.Name = "lblBlackjack";
            this.lblBlackjack.Size = new System.Drawing.Size(152, 25);
            this.lblBlackjack.TabIndex = 1;
            this.lblBlackjack.Text = "Play Blackjack";
            this.lblBlackjack.Visible = false;
            // 
            // lblWar
            // 
            this.lblWar.AutoSize = true;
            this.lblWar.BackColor = System.Drawing.Color.Transparent;
            this.lblWar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWar.ForeColor = System.Drawing.Color.Transparent;
            this.lblWar.Location = new System.Drawing.Point(374, 92);
            this.lblWar.Name = "lblWar";
            this.lblWar.Size = new System.Drawing.Size(99, 25);
            this.lblWar.TabIndex = 2;
            this.lblWar.Text = "Play War";
            this.lblWar.Visible = false;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Gold;
            this.lblExit.Location = new System.Drawing.Point(374, 43);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(58, 25);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "EXIT";
            this.lblExit.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.Gold;
            this.lblTip.Location = new System.Drawing.Point(660, 63);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(459, 66);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Touch the game you want to play! \r\nOr touch the exit to leave!\r\n";
            // 
            // CasinoMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblWar);
            this.Controls.Add(this.lblBlackjack);
            this.Controls.Add(this.lblUserMoney);
            this.DoubleBuffered = true;
            this.Name = "CasinoMap";
            this.Text = "CasinoMap";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CasinoMap_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CasinoMap_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TmrMovement;
        private System.Windows.Forms.Label lblUserMoney;
        private System.Windows.Forms.Label lblBlackjack;
        private System.Windows.Forms.Label lblWar;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblTip;
    }
}