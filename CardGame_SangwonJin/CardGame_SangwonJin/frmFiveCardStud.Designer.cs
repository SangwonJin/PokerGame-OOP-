namespace CardGame_SangwonJin
{
    partial class frmFiveCardStud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiveCardStud));
            this.lblComRanking = new System.Windows.Forms.Label();
            this.lblYourRanking = new System.Windows.Forms.Label();
            this.lblYourAction = new System.Windows.Forms.Label();
            this.lblComAction = new System.Windows.Forms.Label();
            this.btnFold = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblPot = new System.Windows.Forms.Label();
            this.picPot = new System.Windows.Forms.PictureBox();
            this.lblYourMoney = new System.Windows.Forms.Label();
            this.lblYourName = new System.Windows.Forms.Label();
            this.lblComMoney = new System.Windows.Forms.Label();
            this.lblComName = new System.Windows.Forms.Label();
            this.picYou = new System.Windows.Forms.PictureBox();
            this.pnlCom = new System.Windows.Forms.Panel();
            this.pnlYou = new System.Windows.Forms.Panel();
            this.picCom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComRanking
            // 
            this.lblComRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblComRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComRanking.ForeColor = System.Drawing.Color.White;
            this.lblComRanking.Location = new System.Drawing.Point(619, 42);
            this.lblComRanking.Name = "lblComRanking";
            this.lblComRanking.Size = new System.Drawing.Size(147, 41);
            this.lblComRanking.TabIndex = 59;
            this.lblComRanking.Text = "Com\'s Ranking";
            this.lblComRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourRanking
            // 
            this.lblYourRanking.BackColor = System.Drawing.Color.Transparent;
            this.lblYourRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRanking.ForeColor = System.Drawing.Color.White;
            this.lblYourRanking.Location = new System.Drawing.Point(619, 306);
            this.lblYourRanking.Name = "lblYourRanking";
            this.lblYourRanking.Size = new System.Drawing.Size(147, 30);
            this.lblYourRanking.TabIndex = 58;
            this.lblYourRanking.Text = "Your Ranking";
            this.lblYourRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYourAction
            // 
            this.lblYourAction.BackColor = System.Drawing.Color.Transparent;
            this.lblYourAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourAction.ForeColor = System.Drawing.Color.Yellow;
            this.lblYourAction.Location = new System.Drawing.Point(350, 221);
            this.lblYourAction.Name = "lblYourAction";
            this.lblYourAction.Size = new System.Drawing.Size(233, 35);
            this.lblYourAction.TabIndex = 57;
            this.lblYourAction.Text = "Your Action";
            this.lblYourAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComAction
            // 
            this.lblComAction.BackColor = System.Drawing.Color.Transparent;
            this.lblComAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComAction.ForeColor = System.Drawing.Color.Yellow;
            this.lblComAction.Location = new System.Drawing.Point(350, 132);
            this.lblComAction.Name = "lblComAction";
            this.lblComAction.Size = new System.Drawing.Size(233, 35);
            this.lblComAction.TabIndex = 56;
            this.lblComAction.Text = "Com\'s Action";
            this.lblComAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFold
            // 
            this.btnFold.Location = new System.Drawing.Point(493, 404);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(90, 32);
            this.btnFold.TabIndex = 55;
            this.btnFold.Text = "&Fold";
            this.btnFold.UseVisualStyleBackColor = true;
            this.btnFold.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(391, 404);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(90, 32);
            this.btnCall.TabIndex = 54;
            this.btnCall.Text = "&Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(289, 404);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(90, 32);
            this.btnBet.TabIndex = 53;
            this.btnBet.Text = "&Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.Control;
            this.btnCheck.Location = new System.Drawing.Point(187, 404);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 32);
            this.btnCheck.TabIndex = 52;
            this.btnCheck.Text = "Chec&k";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnActions_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(640, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 32);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(640, 142);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(126, 32);
            this.btnNewGame.TabIndex = 50;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblPot
            // 
            this.lblPot.BackColor = System.Drawing.Color.Transparent;
            this.lblPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPot.ForeColor = System.Drawing.Color.White;
            this.lblPot.Location = new System.Drawing.Point(365, 167);
            this.lblPot.Name = "lblPot";
            this.lblPot.Size = new System.Drawing.Size(218, 54);
            this.lblPot.TabIndex = 49;
            this.lblPot.Text = "Pot";
            this.lblPot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picPot
            // 
            this.picPot.BackColor = System.Drawing.Color.Transparent;
            this.picPot.Location = new System.Drawing.Point(244, 142);
            this.picPot.Name = "picPot";
            this.picPot.Size = new System.Drawing.Size(100, 100);
            this.picPot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPot.TabIndex = 48;
            this.picPot.TabStop = false;
            // 
            // lblYourMoney
            // 
            this.lblYourMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblYourMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourMoney.ForeColor = System.Drawing.Color.Black;
            this.lblYourMoney.Location = new System.Drawing.Point(53, 359);
            this.lblYourMoney.Name = "lblYourMoney";
            this.lblYourMoney.Size = new System.Drawing.Size(147, 15);
            this.lblYourMoney.TabIndex = 47;
            this.lblYourMoney.Text = "Your Money";
            this.lblYourMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblYourName
            // 
            this.lblYourName.BackColor = System.Drawing.Color.Transparent;
            this.lblYourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourName.ForeColor = System.Drawing.Color.Black;
            this.lblYourName.Location = new System.Drawing.Point(50, 339);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(153, 20);
            this.lblYourName.TabIndex = 46;
            this.lblYourName.Text = "Your Name";
            this.lblYourName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblComMoney
            // 
            this.lblComMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblComMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComMoney.ForeColor = System.Drawing.Color.Black;
            this.lblComMoney.Location = new System.Drawing.Point(65, 142);
            this.lblComMoney.Name = "lblComMoney";
            this.lblComMoney.Size = new System.Drawing.Size(153, 21);
            this.lblComMoney.TabIndex = 45;
            this.lblComMoney.Text = "Com\'s Money";
            this.lblComMoney.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblComName
            // 
            this.lblComName.BackColor = System.Drawing.Color.Transparent;
            this.lblComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComName.ForeColor = System.Drawing.Color.Black;
            this.lblComName.Location = new System.Drawing.Point(62, 118);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(156, 24);
            this.lblComName.TabIndex = 44;
            this.lblComName.Text = "Com\'s Name";
            this.lblComName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picYou
            // 
            this.picYou.BackColor = System.Drawing.Color.Transparent;
            this.picYou.Location = new System.Drawing.Point(81, 236);
            this.picYou.Name = "picYou";
            this.picYou.Size = new System.Drawing.Size(100, 100);
            this.picYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYou.TabIndex = 41;
            this.picYou.TabStop = false;
            // 
            // pnlCom
            // 
            this.pnlCom.BackColor = System.Drawing.Color.Transparent;
            this.pnlCom.Location = new System.Drawing.Point(187, 15);
            this.pnlCom.Name = "pnlCom";
            this.pnlCom.Size = new System.Drawing.Size(396, 100);
            this.pnlCom.TabIndex = 43;
            // 
            // pnlYou
            // 
            this.pnlYou.BackColor = System.Drawing.Color.Transparent;
            this.pnlYou.Location = new System.Drawing.Point(217, 274);
            this.pnlYou.Name = "pnlYou";
            this.pnlYou.Size = new System.Drawing.Size(396, 100);
            this.pnlYou.TabIndex = 42;
            // 
            // picCom
            // 
            this.picCom.BackColor = System.Drawing.Color.Transparent;
            this.picCom.Location = new System.Drawing.Point(68, 15);
            this.picCom.Name = "picCom";
            this.picCom.Size = new System.Drawing.Size(100, 100);
            this.picCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCom.TabIndex = 40;
            this.picCom.TabStop = false;
            // 
            // frmFiveCardStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblComRanking);
            this.Controls.Add(this.lblYourRanking);
            this.Controls.Add(this.lblYourAction);
            this.Controls.Add(this.lblComAction);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblPot);
            this.Controls.Add(this.picPot);
            this.Controls.Add(this.lblYourMoney);
            this.Controls.Add(this.lblYourName);
            this.Controls.Add(this.lblComMoney);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.picYou);
            this.Controls.Add(this.pnlCom);
            this.Controls.Add(this.pnlYou);
            this.Controls.Add(this.picCom);
            this.Name = "frmFiveCardStud";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFiveCardStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblComRanking;
        internal System.Windows.Forms.Label lblYourRanking;
        internal System.Windows.Forms.Label lblYourAction;
        internal System.Windows.Forms.Label lblComAction;
        internal System.Windows.Forms.Button btnFold;
        internal System.Windows.Forms.Button btnCall;
        internal System.Windows.Forms.Button btnBet;
        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnNewGame;
        internal System.Windows.Forms.Label lblPot;
        internal System.Windows.Forms.PictureBox picPot;
        internal System.Windows.Forms.Label lblYourMoney;
        internal System.Windows.Forms.Label lblYourName;
        internal System.Windows.Forms.Label lblComMoney;
        internal System.Windows.Forms.Label lblComName;
        internal System.Windows.Forms.PictureBox picYou;
        internal System.Windows.Forms.Panel pnlCom;
        internal System.Windows.Forms.Panel pnlYou;
        internal System.Windows.Forms.PictureBox picCom;
    }
}

