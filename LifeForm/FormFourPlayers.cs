using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeForm
{
    public partial class FormFourPlayers : Form
    {
        private int playerOneTheme;
        private int playerTwoTheme;
        private int playerThreeTheme;
        private int playerFourTheme;

        private string playerOneName;
        private string playerTwoName;
        private string playerThreeName;
        private string playerFourName;

        private int PlayerOneLifeTotal;
        private int PlayerTwoLifeTotal;
        private int PlayerThreeLifeTotal;
        private int PlayerFourLifeTotal;

        private int PlayerOnePoisonTotal;
        private int PlayerTwoPoisonTotal;
        private int PlayerThreePoisonTotal;
        private int PlayerFourPoisonTotal;

        private bool PlayerOneLifeToggled = true;
        private bool PlayerTwoLifeToggled = true;
        private bool PlayerThreeLifeToggled = true;
        private bool PlayerFourLifeToggled = true;

        private bool TimerEnabled;
        private int TimeSet;
        private int TimeSetDefault;


        public FormFourPlayers(int playerOneTheme, int playerTwoTheme, int playerThreeTheme, int playerFourTheme, string playerOneName, string playerTwoName, string playerThreeName, string playerFourName, bool timerEnabled, int timeSet)
        {
            this.playerOneTheme = playerOneTheme;
            this.playerTwoTheme = playerTwoTheme;
            this.playerThreeTheme = playerThreeTheme;
            this.playerFourTheme = playerFourTheme;
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
            this.playerThreeName = playerThreeName;
            this.playerFourName = playerFourName;
            this.TimerEnabled = timerEnabled;
            this.TimeSet = timeSet;

            InitializeComponent();
        }

        private void FourPlayerThemeSetup()
        {
            switch (playerOneTheme)
            {
                case 0:
                    pnlPlayerOne.BackColor = Color.Ivory;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.WhiteTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red; 
                    btnPlayerOnePlus.ForeColor = Color.Black;
                    btnPlayerOneMinus.ForeColor = Color.Black;
                    btnPlayerOneLife.ForeColor = Color.Black;
                    lblPlayerOneName.ForeColor = Color.Black;
                    lblPlayerOneTotals.ForeColor = Color.Black;
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerOneTotals.ForeColor = Color.LightGray;
                    lblPlayerOneName.ForeColor = Color.LightGray;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOnePlus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerOnePlus.ForeColor = Color.LightGray;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOneMinus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerOneMinus.ForeColor = Color.LightGray;
                    //btnPlayerOneLife.BackColor = Color.Black;
                    btnPlayerOneLife.ForeColor = Color.LightGray;
                    btnPlayerOneLife.FlatAppearance.BorderColor = Color.LightGray;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.MidnightBlue;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOnePlus.ForeColor = Color.MidnightBlue;
                    btnPlayerOneMinus.ForeColor = Color.MidnightBlue;
                    btnPlayerOneLife.ForeColor = Color.MidnightBlue;
                    lblPlayerOneName.ForeColor = Color.LightBlue;
                    lblPlayerOneTotals.ForeColor = Color.LightBlue;
                    break;

                case 3:
                    pnlPlayerOne.BackColor = Color.LightSalmon;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOnePlus.ForeColor = Color.LightSalmon;
                    btnPlayerOneMinus.ForeColor = Color.LightSalmon;
                    btnPlayerOneLife.ForeColor = Color.LightSalmon;
                    lblPlayerOneName.ForeColor = Color.LightSalmon;
                    lblPlayerOneTotals.ForeColor = Color.LightSalmon;
                    break;

                case 4:
                    pnlPlayerOne.BackColor = Color.LightGreen;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOnePlus.ForeColor = Color.LightGreen;
                    btnPlayerOneMinus.ForeColor = Color.LightGreen;
                    btnPlayerOneLife.ForeColor = Color.LightGreen;
                    lblPlayerOneName.ForeColor = Color.LightGreen;
                    lblPlayerOneTotals.ForeColor = Color.LightGreen;
                    break;

            }

            switch (playerTwoTheme)
            {
                case 0:
                    pnlPlayerTwo.BackColor = Color.Ivory;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.WhiteTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoPlus.ForeColor = Color.Black;
                    btnPlayerTwoMinus.ForeColor = Color.Black;
                    btnPlayerTwoLife.ForeColor = Color.Black;
                    lblPlayerTwoName.ForeColor = Color.Black;
                    lblPlayerThreeTotals.ForeColor = Color.Black;
                    break;

                case 1:
                    pnlPlayerTwo.BackColor = Color.Black;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerTwoTotals.ForeColor = Color.LightGray;
                    lblPlayerTwoName.ForeColor = Color.LightGray;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoPlus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerTwoPlus.ForeColor = Color.LightGray;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoMinus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerTwoMinus.ForeColor = Color.LightGray;
                    //btnPlayerOneLife.BackColor = Color.Black;
                    btnPlayerTwoLife.ForeColor = Color.LightGray;
                    btnPlayerTwoLife.FlatAppearance.BorderColor = Color.LightGray;
                    break;

                case 2:
                    pnlPlayerTwo.BackColor = Color.CornflowerBlue;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoPlus.ForeColor = Color.MidnightBlue;
                    btnPlayerTwoMinus.ForeColor = Color.MidnightBlue;
                    btnPlayerTwoLife.ForeColor = Color.MidnightBlue;
                    lblPlayerTwoName.ForeColor = Color.LightBlue;
                    lblPlayerTwoTotals.ForeColor = Color.LightBlue;
                    break;

                case 3:
                    pnlPlayerTwo.BackColor = Color.LightSalmon;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoPlus.ForeColor = Color.LightSalmon;
                    btnPlayerTwoMinus.ForeColor = Color.LightSalmon;
                    btnPlayerTwoLife.ForeColor = Color.LightSalmon;
                    lblPlayerTwoName.ForeColor = Color.LightSalmon;
                    lblPlayerTwoTotals.ForeColor = Color.LightSalmon;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.LightGreen;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoPlus.ForeColor = Color.LightGreen;
                    btnPlayerTwoMinus.ForeColor = Color.LightGreen;
                    btnPlayerTwoLife.ForeColor = Color.LightGreen;
                    lblPlayerTwoName.ForeColor = Color.LightGreen;
                    lblPlayerTwoTotals.ForeColor = Color.LightGreen;
                    break;
            }

            switch (playerThreeTheme)
            {
                case 0:
                    pnlPlayerThree.BackColor = Color.Ivory;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.WhiteTheme;
                    pnlPlayerThree.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreePlus.ForeColor = Color.Black;
                    btnPlayerThreeMinus.ForeColor = Color.Black;
                    btnPlayerThreeLife.ForeColor = Color.Black;
                    lblPlayerThreeName.ForeColor = Color.Black;
                    lblPlayerThreeTotals.ForeColor = Color.Black;
                    break;

                case 1:
                    pnlPlayerThree.BackColor = Color.Black;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerThree.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerThreeTotals.ForeColor = Color.LightGray;
                    lblPlayerThreeName.ForeColor = Color.LightGray;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreePlus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerThreePlus.ForeColor = Color.LightGray;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreeMinus.FlatAppearance.BorderColor = Color.LightGray;
                    btnPlayerThreeMinus.ForeColor = Color.LightGray;
                    //btnPlayerThreeLife.BackColor = Color.Black;
                    btnPlayerThreeLife.ForeColor = Color.LightGray;
                    btnPlayerThreeLife.FlatAppearance.BorderColor = Color.LightGray;
                    break;

                case 2:
                    pnlPlayerThree.BackColor = Color.CornflowerBlue;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerThree.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreePlus.ForeColor = Color.MidnightBlue;
                    btnPlayerThreeMinus.ForeColor = Color.MidnightBlue;
                    btnPlayerThreeLife.ForeColor = Color.MidnightBlue;
                    lblPlayerThreeName.ForeColor = Color.LightBlue;
                    lblPlayerThreeTotals.ForeColor = Color.LightBlue;
                    break;

                case 3:
                    pnlPlayerThree.BackColor = Color.Tomato;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerThree.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreePlus.ForeColor = Color.LightSalmon;
                    btnPlayerThreeMinus.ForeColor = Color.LightSalmon;
                    btnPlayerThreeLife.ForeColor = Color.LightSalmon;
                    lblPlayerThreeName.ForeColor = Color.LightSalmon;
                    lblPlayerThreeTotals.ForeColor = Color.LightSalmon;
                    break;

                case 4:
                    pnlPlayerThree.BackColor = Color.ForestGreen;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerThree.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreePlus.ForeColor = Color.LightGreen;
                    btnPlayerThreeMinus.ForeColor = Color.LightGreen;
                    btnPlayerThreeLife.ForeColor = Color.LightGreen;
                    lblPlayerThreeName.ForeColor = Color.LightGreen;
                    lblPlayerThreeTotals.ForeColor = Color.LightGreen;
                    break;

            }

            switch (playerFourTheme)
            {
                case 0:
                    pnlPlayerFour.BackColor = Color.Ivory;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.WhiteTheme;
                    pnlPlayerFour.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourPlus.ForeColor = Color.Black;
                    btnPlayerFourMinus.ForeColor = Color.Black;
                    btnPlayerFourLife.ForeColor = Color.Black;
                    lblPlayerFourName.ForeColor = Color.Black;
                    lblPlayerFourTotals.ForeColor = Color.Black;
                    break;

                case 1:
                    pnlPlayerFour.BackColor = Color.Black;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerFour.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerFourTotals.ForeColor = Color.White;
                    lblPlayerFourName.ForeColor = Color.White;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourPlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerFourPlus.ForeColor = Color.White;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerFourMinus.ForeColor = Color.White;
                    //btnPlayerFourLife.BackColor = Color.Black;
                    btnPlayerFourLife.ForeColor = Color.White;
                    btnPlayerFourLife.FlatAppearance.BorderColor = Color.White;
                    break;

                case 2:
                    pnlPlayerFour.BackColor = Color.CornflowerBlue;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerFour.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourPlus.ForeColor = Color.MidnightBlue;
                    btnPlayerFourMinus.ForeColor = Color.MidnightBlue;
                    btnPlayerFourLife.ForeColor = Color.MidnightBlue;
                    lblPlayerFourName.ForeColor = Color.LightBlue;
                    lblPlayerFourTotals.ForeColor = Color.LightBlue;
                    break;

                case 3:
                    pnlPlayerFour.BackColor = Color.Tomato;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerFour.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourPlus.ForeColor = Color.LightSalmon;
                    btnPlayerFourMinus.ForeColor = Color.LightSalmon;
                    btnPlayerFourLife.ForeColor = Color.LightSalmon;
                    lblPlayerFourName.ForeColor = Color.LightSalmon;
                    lblPlayerFourTotals.ForeColor = Color.LightSalmon;
                    break;

                case 4:
                    pnlPlayerFour.BackColor = Color.ForestGreen;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerFour.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourPlus.ForeColor = Color.LightGreen;
                    btnPlayerFourMinus.ForeColor = Color.LightGreen;
                    btnPlayerFourLife.ForeColor = Color.LightGreen;
                    lblPlayerFourName.ForeColor = Color.LightGreen;
                    lblPlayerFourTotals.ForeColor = Color.LightGreen;
                    break;

            }
        }

        private void FourPlayerGameSetup()
        {
            PlayerOneLifeTotal = 20;
            PlayerTwoLifeTotal = 20;
            PlayerThreeLifeTotal = 20;
            PlayerFourLifeTotal = 20;

            PlayerOnePoisonTotal = 0;
            PlayerTwoPoisonTotal = 0;
            PlayerThreePoisonTotal = 0;
            PlayerFourPoisonTotal = 0;

            lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
            lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();
            lblPlayerThreeTotals.Text = PlayerThreeLifeTotal.ToString();
            lblPlayerFourTotals.Text = PlayerFourLifeTotal.ToString();

            lblPlayerOneName.Text = playerOneName.ToString();
            lblPlayerTwoName.Text = playerTwoName.ToString();
            lblPlayerThreeName.Text = playerThreeName.ToString();
            lblPlayerFourName.Text = playerFourName.ToString();

            if (TimerEnabled == true)
            {
                lblTimeLeft.Text = TimeSet.ToString();
                TimeSetDefault = TimeSet;
                timer1.Start();
            }
            else
            {
                lblTimeLeft.Text = "0";
                lblTimeLeft.Enabled = false;
            }

        }
        private void FormFourPlayers_Load(object sender, EventArgs e)
        {
            FourPlayerThemeSetup();
            FourPlayerGameSetup();
        }

        private void btnPlayerOnePlus_Click(object sender, EventArgs e)
        {
            if(PlayerOneLifeToggled == true)
            {
                PlayerOneLifeTotal++;
                if(PlayerOneLifeTotal > 999)
                {
                    PlayerOneLifeTotal = 999;
                }
                lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
            }
            else
            {
                PlayerOnePoisonTotal++;
                if (PlayerOnePoisonTotal > 10)
                {
                    PlayerOnePoisonTotal = 10;
                }
                lblPlayerOneTotals.Text = PlayerOnePoisonTotal.ToString();
            }
        }

        private void btnPlayerOneMinus_Click(object sender, EventArgs e)
        {
            if (PlayerOneLifeToggled == true)
            {
                PlayerOneLifeTotal--;
                if (PlayerOneLifeTotal < -99)
                {
                    PlayerOneLifeTotal = -99;
                }
                lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
            }
            else
            {
                PlayerOnePoisonTotal--;
                if (PlayerOnePoisonTotal < 0)
                {
                    PlayerOnePoisonTotal = 0;
                }
                lblPlayerOneTotals.Text = PlayerOnePoisonTotal.ToString();
            }
        }

        private void btnPlayerOneLife_Click(object sender, EventArgs e)
        {
            if (PlayerOneLifeToggled == true)
            {
                lblPlayerOneTotals.Text = PlayerOnePoisonTotal.ToString();
                btnPlayerOneLife.Text = "Poison";
                PlayerOneLifeToggled = false;
            }
            else
            {
                lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
                btnPlayerOneLife.Text = "Life";
                PlayerOneLifeToggled = true;
            }
        }

        private void btnPlayerTwoPlus_Click(object sender, EventArgs e)
        {
            if (PlayerTwoLifeToggled == true)
            {
                PlayerTwoLifeTotal++;
                if (PlayerTwoLifeTotal > 999)
                {
                    PlayerTwoLifeTotal = 999;
                }
                lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();
            }
            else
            {
                PlayerTwoPoisonTotal++;
                if (PlayerTwoPoisonTotal > 10)
                {
                    PlayerTwoPoisonTotal = 10;
                }
                lblPlayerTwoTotals.Text = PlayerTwoPoisonTotal.ToString();
            }
        }

        private void btnPlayerTwoMinus_Click(object sender, EventArgs e)
        {
            if (PlayerTwoLifeToggled == true)
            {
                PlayerTwoLifeTotal--;
                if (PlayerTwoLifeTotal < -99)
                {
                    PlayerTwoLifeTotal = -99;
                }
                lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();
            }
            else
            {
                PlayerTwoPoisonTotal--;
                if (PlayerTwoPoisonTotal < 0)
                {
                    PlayerTwoPoisonTotal = 0;
                }
                lblPlayerTwoTotals.Text = PlayerTwoPoisonTotal.ToString();
            }
        }
    

        private void btnPlayerTwoLife_Click(object sender, EventArgs e)
        {
            if (PlayerTwoLifeToggled == true)
            {
                lblPlayerTwoTotals.Text = PlayerTwoPoisonTotal.ToString();
                btnPlayerTwoLife.Text = "Poison";
                PlayerTwoLifeToggled = false;
            }
            else
            {
                lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();
                btnPlayerTwoLife.Text = "Life";
                PlayerTwoLifeToggled = true;
            }
        }

        private void btnPlayerThreePlus_Click(object sender, EventArgs e)
        {
            if (PlayerThreeLifeToggled == true)
            {
                PlayerThreeLifeTotal++;
                if (PlayerThreeLifeTotal > 999)
                {
                    PlayerThreeLifeTotal = 999;
                }
                lblPlayerThreeTotals.Text = PlayerThreeLifeTotal.ToString();
            }
            else
            {
                PlayerThreePoisonTotal++;
                if (PlayerThreePoisonTotal > 10)
                {
                    PlayerThreePoisonTotal = 10;
                }
                lblPlayerThreeTotals.Text = PlayerThreePoisonTotal.ToString();
            }
        }

        private void btnPlayerThreeMinus_Click(object sender, EventArgs e)
        {
            if (PlayerThreeLifeToggled == true)
            {
                PlayerThreeLifeTotal--;
                if (PlayerThreeLifeTotal < -99)
                {
                    PlayerThreeLifeTotal = -99;
                }
                lblPlayerThreeTotals.Text = PlayerThreeLifeTotal.ToString();
            }
            else
            {
                PlayerThreePoisonTotal--;
                if (PlayerThreePoisonTotal < 0)
                {
                    PlayerThreePoisonTotal = 0;
                }
                lblPlayerThreeTotals.Text = PlayerThreePoisonTotal.ToString();
            }
        }

        private void btnPlayerThreeLife_Click(object sender, EventArgs e)
        {
            if (PlayerThreeLifeToggled == true)
            {
                lblPlayerThreeTotals.Text = PlayerThreePoisonTotal.ToString();
                btnPlayerThreeLife.Text = "Poison";
                PlayerThreeLifeToggled = false;
            }
            else
            {
                lblPlayerThreeTotals.Text = PlayerThreeLifeTotal.ToString();
                btnPlayerThreeLife.Text = "Life";
                PlayerThreeLifeToggled = true;
            }
        }

        private void btnPlayerFourPlus_Click(object sender, EventArgs e)
        {
            if (PlayerFourLifeToggled == true)
            {
                PlayerFourLifeTotal++;
                if (PlayerFourLifeTotal > 999)
                {
                    PlayerFourLifeTotal = 999;
                }
                lblPlayerFourTotals.Text = PlayerFourLifeTotal.ToString();
            }
            else
            {
                PlayerFourPoisonTotal++;
                if (PlayerFourPoisonTotal > 10)
                {
                    PlayerFourPoisonTotal = 10;
                }
                lblPlayerFourTotals.Text = PlayerFourPoisonTotal.ToString();
            }
        }

        private void btnPlayerFourMinus_Click(object sender, EventArgs e)
        {
            if (PlayerFourLifeToggled == true)
            {
                PlayerFourLifeTotal--;
                if (PlayerFourLifeTotal < -99)
                {
                    PlayerFourLifeTotal = -99;
                }
                lblPlayerFourTotals.Text = PlayerFourLifeTotal.ToString();
            }
            else
            {
                PlayerFourPoisonTotal--;
                if (PlayerFourPoisonTotal < 0)
                {
                    PlayerFourPoisonTotal = 0;
                }
                lblPlayerFourTotals.Text = PlayerFourPoisonTotal.ToString();
            }
        }

        private void btnPlayerFourLife_Click(object sender, EventArgs e)
        {
            if (PlayerFourLifeToggled == true)
            {
                lblPlayerFourTotals.Text = PlayerFourPoisonTotal.ToString();
                btnPlayerFourLife.Text = "Poison";
                PlayerFourLifeToggled = false;
            }
            else
            {
                lblPlayerFourTotals.Text = PlayerFourLifeTotal.ToString();
                btnPlayerFourLife.Text = "Life";
                PlayerFourLifeToggled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSet--;
            lblTimeLeft.Text = TimeSet.ToString();
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if(btnPauseResume.Text == "Pause")
            {
                btnPauseResume.Text = "Resume";
                timer1.Stop();
            }
            else if(btnPauseResume.Text == "Resume")
            {
                btnPauseResume.Text = "Pause";
                timer1.Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TimeSet = TimeSetDefault;
            FourPlayerGameSetup();
        }

        private void btnCoinToss_Click(object sender, EventArgs e)
        {
            FormCoinToss toss = new FormCoinToss();
            toss.ShowDialog();
        }

        private void btnDTwenty_Click(object sender, EventArgs e)
        {
            FormDTwenty dt = new();
            dt.ShowDialog();
        }
    }
}
