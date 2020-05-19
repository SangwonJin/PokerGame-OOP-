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

namespace CardGame_SangwonJin
{
    public partial class frmPlayerInfo : Form
    {
        public static Player objPlayerYou;
        public static Player objPlayerCom;

        public frmPlayerInfo()
        {
            InitializeComponent();
        }

        private void frmPlayerInfo_Load(object sender, EventArgs e)
        {
            rdoBear.Checked = true;
            picBear.Image = Image.FromFile(@"images\bear.png");
            picBird.Image = Image.FromFile(@"images\bird.png");
            picPig.Image = Image.FromFile(@"images\pig.png");
            picPenguin.Image = Image.FromFile(@"images\penguin.png");
            txtPlayerName.Focus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (isFormValid())
                {
                    string PlayerImage = "";
                    string ComputerImage = "";
                    switch (true)
                    {
                        case object _ when rdoBear.Checked == true:
                            {
                                PlayerImage = "bear";
                                ComputerImage = "bird";
                                break;
                            }

                        case object _ when rdoBird.Checked == true:
                            {
                                PlayerImage = "bird";
                                ComputerImage = "pig";
                                break;
                            }

                        case object _ when rdoPig.Checked == true:
                            {
                                PlayerImage = "pig";
                                ComputerImage = "penguin";
                                break;
                            }

                        case object _ when rdoPenguin.Checked == true:
                            {
                                PlayerImage = "penguin";
                                ComputerImage = "bear";
                                break;
                            }
                    }

                    objPlayerYou = new Player(txtPlayerName.Text,Convert.ToSingle(txtPlayerMoney.Text), PlayerImage);
                    objPlayerCom = new Player("Computer", Convert.ToSingle(txtPlayerMoney.Text), ComputerImage);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Check Name and Money");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool isFormValid()
        {
            if (txtPlayerName.Text == string.Empty || errorProvider1.GetError(txtPlayerName) != string.Empty)
                return false;
            if (txtPlayerMoney.Text == string.Empty || errorProvider1.GetError(txtPlayerMoney) != string.Empty)
                return false;
            if (rdoBear.Checked == false && rdoBird.Checked == false && rdoPig.Checked == false && rdoPenguin.Checked == false)
                return false;
            return true;
        }

        private void txtBoxes_Validating(object sender, CancelEventArgs e)
        {
            switch (true)
            {
                case object _ when sender == txtPlayerName:
                    {
                        if (CardClass.Validate.ValidNotEmpty(txtPlayerName.Text) == false)
                            errorProvider1.SetError(txtPlayerName, "Name cannot be empty.");
                        else
                            errorProvider1.SetError(txtPlayerName, string.Empty);
                        break;
                    }

                case object _ when sender == txtPlayerMoney:
                    {
                        if (CardClass.Validate.ValidWithinRange(txtPlayerMoney.Text, 10, 1000) == false)
                            errorProvider1.SetError(txtPlayerMoney, "Your start money must be between 10 and 1000.");
                        else
                            errorProvider1.SetError(txtPlayerMoney, string.Empty);
                        break;
                    }
            }
        }

    }
}
