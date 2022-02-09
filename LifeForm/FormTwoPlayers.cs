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
    public partial class FormTwoPlayers : Form
    {
        private int playerOneTheme;
        private int playerTwoTheme;

        private string playerOneName;
        private string playerTwoName;

        private int PlayerOneLifeTotal;
        private int PlayerTwoLifeTotal;

        private int PlayerOnePoisonTotal;
        private int PlayerTwoPoisonTotal;

        private bool PlayerOneLifeToggled = true;
        private bool PlayerTwoLifeToggled = true;

        private bool TimerEnabled;
        private int TimeSet;
        private int TimeSetDefault;

        public FormTwoPlayers(int playerOneTheme, int playerTwoTheme, string playerOneName, string playerTwoName, bool timerEnabled, int timeSet)
        {
            this.playerOneTheme = playerOneTheme;
            this.playerTwoTheme = playerTwoTheme;
            this.playerOneName = playerOneName;
            this.playerTwoName = playerTwoName;
            this.TimerEnabled = timerEnabled;
            this.TimeSet = timeSet;
            InitializeComponent();
        }

        private void TwoPlayerThemeSetup()
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
                    lblPlayerTwoTotals.ForeColor = Color.Black;
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
        }

        private void TwoPlayerGameSetup()
        {
            PlayerOneLifeTotal = 20;
            PlayerTwoLifeTotal = 20;

            PlayerOnePoisonTotal = 0;
            PlayerTwoPoisonTotal = 0;

            lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
            lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();

            lblPlayerOneName.Text = playerOneName.ToString();
            lblPlayerTwoName.Text = playerTwoName.ToString();

            if(TimerEnabled == true)
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
        private void FormTwoPlayers_Load(object sender, EventArgs e)
        {
            TwoPlayerThemeSetup();
            TwoPlayerGameSetup();
        }

        private void btnPlayerOnePlus_Click(object sender, EventArgs e)
        {
            if (PlayerOneLifeToggled == true)
            {
                PlayerOneLifeTotal++;
                if (PlayerOneLifeTotal > 999)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSet--;
            lblTimeLeft.Text = TimeSet.ToString();
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            if (btnPauseResume.Text == "Pause")
            {
                btnPauseResume.Text = "Resume";
                timer1.Stop();
            }
            else if (btnPauseResume.Text == "Resume")
            {
                btnPauseResume.Text = "Pause";
                timer1.Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            TimeSet = TimeSetDefault;
            TwoPlayerGameSetup();
        }
    }
}
