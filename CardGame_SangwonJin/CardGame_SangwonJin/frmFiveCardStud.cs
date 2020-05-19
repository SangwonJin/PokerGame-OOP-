using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardClass;
using Microsoft.VisualBasic;
using static CardClass.PokerGame;

namespace CardGame_SangwonJin
{
    public partial class frmFiveCardStud : Form
    {
        PokerGame objPokerGame;
        Player objPlayerYou;
        Player objPlayerCom;
        Player objBetterHandPlayer;
        public frmFiveCardStud()
        {
            InitializeComponent();
        }

        private void frmFiveCardStud_Load(object sender, EventArgs e)
        {

            frmPlayerInfo fPInfor = new frmPlayerInfo();
            DialogResult dr = new DialogResult();
            dr = fPInfor.ShowDialog();
            try
            {
                if (dr == DialogResult.OK)
                {
                    objPlayerYou = frmPlayerInfo.objPlayerYou;
                    objPlayerCom = frmPlayerInfo.objPlayerCom;
                    setNewGame();
                }
                else
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setNewGame()
        {
            try
            {
                objBetterHandPlayer = null;
                lblYourRanking.ResetText();
                lblComRanking.ResetText();

                pnlYou.Controls.Clear();
                pnlCom.Controls.Clear();


                objPokerGame = new PokerGame();

                objPokerGame.BettingDone += Player_BettingDone;
                objPokerGame.FoldDone += objPokerGame_FoldDone;
                objPokerGame.BettingTurnFinished += objPokerGame_BettingTurnFinished;
                objPokerGame.GameEnd += objPokerGame_GameEnd;
                objPokerGame.PuAnteFailed += objPokerGame_PuAnteFailed;

                objPlayerYou.NoMoreMoney += Player_NoMoreMoney;
                objPlayerCom.NoMoreMoney += Player_NoMoreMoney;

                objPokerGame.AddPlayer(objPlayerYou);
                objPokerGame.AddPlayer(objPlayerCom);

                ShowPlayerImages();
                SetControls(false);

                foreach (Player player in objPokerGame.Players)
                    objPokerGame.PutAnte(player);

                foreach (Player player in objPokerGame.Players)
                {
                    Card theCard = objPokerGame.Deck.DrawOneCard();
                    theCard.ChangeStatus(Status.FaceDown);
                    player.Hand.AddCard(theCard);
                }
                ShowCard(pnlYou, objPlayerYou.Hand, objPlayerYou.Hand.Count - 1);
                ShowCard(pnlCom, objPlayerCom.Hand, objPlayerCom.Hand.Count - 1);

                DrawACardToEachPlayers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawACardToEachPlayers()
        {
            try
            {
                foreach (Player player in objPokerGame.Players)
                {
                    Card theCard = objPokerGame.Deck.DrawOneCard();
                    player.Hand.AddCard(theCard);
                }
                ShowCard(pnlYou, objPlayerYou.Hand, objPlayerYou.Hand.Count - 1);
                ShowCard(pnlCom, objPlayerCom.Hand, objPlayerCom.Hand.Count - 1);
                DecideBetterHand();
                DisplayGameStatus();
                System.Threading.Thread.Sleep(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPlayerImages()
        {
            string fileImageYou = @"images\bear.png";
            string fileImageCom = @"images\penguin.png";

            if ((objPlayerYou.Image != ""))
                fileImageYou = @"images\" + objPlayerYou.Image + ".png";
            if ((objPlayerCom.Image != ""))
                fileImageCom = @"images\" + objPlayerCom.Image + ".png";
            picYou.Image = Image.FromFile(fileImageYou);
            picCom.Image = Image.FromFile(fileImageCom);
        }

        private void DisplayGameStatus()
        {
            lblYourName.Text = objPlayerYou.Name;
            lblYourMoney.Text = objPlayerYou.Money.ToString("C");
            lblComName.Text = objPlayerCom.Name;
            lblComMoney.Text = objPlayerCom.Money.ToString("C");
            lblYourRanking.Text = objPlayerYou.Hand.ToString();
            lblComRanking.Text = objPlayerCom.Hand.ToString();

            if (objBetterHandPlayer == objPlayerYou)
            {
                lblYourRanking.ForeColor = Color.Yellow;
                lblComRanking.ForeColor = Color.White;
            }
            else if (objBetterHandPlayer == objPlayerCom)
            {
                lblComRanking.ForeColor = Color.Yellow;
                lblYourRanking.ForeColor = Color.White;
            }
            else
            {
                lblComRanking.ForeColor = Color.White;
                lblYourRanking.ForeColor = Color.White;
            }


            if (objPokerGame.Pot > 0)
            {
                string potImage = @"images\poker-chips.png";
                picPot.Image = Image.FromFile(potImage);
                lblPot.Text = "Pot: " + objPokerGame.Pot.ToString("C");
            }
            else
            {
                picPot.Image = null;
                lblPot.ResetText();
            }

            SetButtonColor();
        }

        private void ShowCard(Panel thePanel, Hand theHand, int i)
        {
            PictureBox objPic;
            objPic = new PictureBox();
            thePanel.Controls.Add(objPic);

            string facename = theHand.Card(i).FaceValue.ToString();
            string suitname = theHand.Card(i).Suit.ToString();

            string x = "";
            if (theHand.Card(i).Status == Status.FaceUp || theHand == objPlayerYou.Hand)
                x = @"images\" + facename + suitname + ".jpg";
            else
                x = @"images\cardback.gif";

            {
                var withBlock = objPic;
                withBlock.Image = Image.FromFile(x);
                withBlock.Width = 70;
                withBlock.Height = 100;
                withBlock.Left = 75 * i;
                withBlock.Tag = theHand.Card(i);
            }
        }

        private void ShowHand(Panel thePanel, Hand theHand)
        {
            thePanel.Controls.Clear();
            PictureBox objPic;
            for (int i = 0; i <= theHand.Count - 1; i++)
            {
                objPic = new PictureBox();
                thePanel.Controls.Add(objPic);

                string facename = theHand.Card(i).FaceValue.ToString();
                string suitname = theHand.Card(i).Suit.ToString();

                string x = "";
                if (theHand.Card(i).Status == Status.FaceUp)
                    x = @"images\" + facename + suitname + ".jpg";
                else
                    x = @"images\cardback.gif";

                {
                    var withBlock = objPic;
                    withBlock.Image = Image.FromFile(x);
                    withBlock.Width = 70;
                    withBlock.Height = 100;
                    withBlock.Left = 75 * i;
                    withBlock.Tag = theHand.Card(i);
                }
            }
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender == btnCheck)
                {
                    objPokerGame.Check(objPlayerYou);
                    WaitUntilComBet();
                }
                else if (sender == btnBet)
                {
                
                    float sngAmt = Convert.ToInt32(Interaction.InputBox("Enter amount you want to bet:","Type the amount","",-1,-1));
                    
                    objPokerGame.Bet(objPlayerYou, sngAmt);
                    WaitUntilComBet();
                }
                else if (sender == btnCall)
                {
                    objPokerGame.DoCall(objPlayerYou);
                    WaitUntilComBet();
                }
                else
                    objPokerGame.Fold(objPlayerYou);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show("Please enter a numeric value.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WaitUntilComBet()
        {
            try
            {
                if (objPlayerCom.BetStatus == false)
                {
                    if (objBetterHandPlayer == objPlayerCom)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Random rndNum = new Random();
                        int i = rndNum.Next(0, 10);
                        if (i < 1)
                            objPokerGame.Check(objPlayerCom);
                        else
                        {
                            float sngBettingAmt = System.Convert.ToSingle(objPokerGame.Pot * ((i + 1) / (double)10));
                            if (sngBettingAmt <= objPlayerCom.Money)
                                objPokerGame.Bet(objPlayerCom, sngBettingAmt);
                            else
                                objPokerGame.Fold(objPlayerCom);
                        }
                    }
                    else if (objPlayerYou.Action == CardClass.Action.Check)
                    {
                        objPokerGame.DoCall(objPlayerCom);
                    }   
                    else
                    {
                        Random rndNum = new Random();
                        int i = rndNum.Next(0, 10);
                        if (i < 1)
                            objPokerGame.Fold(objPlayerCom);
                        else
                            objPokerGame.DoCall(objPlayerCom);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                objPokerGame.Fold(objPlayerCom);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DecideBetterHand()
        {
            try
            {
                objBetterHandPlayer = objPokerGame.DecideBetterHandPlayer();
                switch (true)
                {
                    case object _ when objBetterHandPlayer == objPlayerYou:
                        {
                            btnCheck.Enabled = true;
                            btnBet.Enabled = true;
                            btnCall.Enabled = false;
                            btnFold.Enabled = true;
                            break;
                        }

                    case object _ when objBetterHandPlayer == objPlayerCom:
                        {
                            WaitUntilComBet();
                            if (objPokerGame.Players.Count == 2)
                            {
                                btnCheck.Enabled = false;
                                btnBet.Enabled = false;
                                btnCall.Enabled = true;
                                btnFold.Enabled = true;
                            }

                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            setNewGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave the game?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void SetControls(bool setting)
        {
            btnNewGame.Enabled = setting;
            btnCheck.Enabled = !setting;
            btnBet.Enabled = !setting;
            btnCall.Enabled = !setting;
            btnFold.Enabled = !setting;
            lblYourAction.ResetText();
            lblComAction.ResetText();
        }

        private void SetButtonColor()
        {
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.Enabled)
                    {
                        btn.BackColor = Color.Yellow;
                        btn.Cursor = Cursors.Hand;
                    }
                    else
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.Cursor = Cursors.Default;
                    }
                }
            }
        }



        private void Player_BettingDone(object sender, EventArgs e)
        {
            Player thePlayer = (Player)sender;
            string strAction = "";

            switch (thePlayer.Action)
            {
                case CardClass.Action.PutAnte:
                    {
                        strAction = "Put ante.";
                        break;
                    }

                case CardClass.Action.Check:
                    {
                        strAction = "Check.";
                        break;
                    }

                case CardClass.Action.DoCall:
                    {
                        strAction = "Call.";
                        break;
                    }

                case CardClass.Action.Bet:
                    {
                        strAction = "Bet: " + thePlayer.BettingAmount.ToString("C");
                        break;
                    }
            }
            lblPot.Text = "Pot: " + objPokerGame.Pot.ToString("C");
            if (sender == objPlayerYou)
                lblYourAction.Text = strAction;
            else
                lblComAction.Text = strAction;
        }

        private void objPokerGame_BettingTurnFinished(object sender, EventArgs e)
        {
            if (objPokerGame.Winner == null && objPokerGame.Players.Count == 2)
                DrawACardToEachPlayers();
        }

        private void objPokerGame_GameEnd(object sender, EventArgs e)
        {
            Player winner = objPokerGame.Winner;
            if (objPokerGame.Players.Count == 2)
            {
                ShowHand(pnlYou, objPlayerYou.Hand);
                ShowHand(pnlCom, objPlayerCom.Hand);
                DisplayGameStatus();
            }
            lblPot.Text = winner.Name + " won.";
            SetControls(true);
            SetButtonColor();
        }

        private void Player_NoMoreMoney(object sender, EventArgs e)
        {
            Player thePlayer = (Player)sender;
            MessageBox.Show(thePlayer.Name + " lost all the money. It's time to say goodbye. Don't play card game too much. :)");
            btnBet.Enabled = false;
            btnCall.Enabled = false;
            btnCheck.Enabled = false;
            btnFold.Enabled = false;
            btnNewGame.Enabled = false;
        }

        private void objPokerGame_PuAnteFailed(object sender, EventArgs e)
        {
            Player thePlayer = (Player)sender;
            MessageBox.Show(thePlayer.Name + " can't put ante. It's time to say goodbye.");
            this.Close();
        }

        private void objPokerGame_FoldDone(object sender, EventArgs e)
        {
            Player thePlayer = (Player)sender;
            for (int i = 0; i <= thePlayer.Hand.Count - 1; i++)
                thePlayer.Hand.Card(i).ChangeStatus(Status.FaceDown);
            if (thePlayer == objPlayerYou)
                ShowHand(pnlYou, thePlayer.Hand);
            else
                ShowHand(pnlCom, thePlayer.Hand);
            MessageBox.Show(thePlayer.Name + " fold the hand.");
        }

    }
}
