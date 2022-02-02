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

        private int PlayerOneLifeTotal;
        private int PlayerTwoLifeTotal;

        private int PlayerOnePoisonTotal = 0;
        private int PlayerTwoPoisonTotal = 0;

        private bool PlayerOneLifeToggled = true;
        private bool PlayerTwoLifeToggled = true;

        public FormTwoPlayers(int playerOneTheme, int playerTwoTheme)
        {
            this.playerOneTheme = playerOneTheme;
            this.playerTwoTheme = playerTwoTheme;
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
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerOneTotals.ForeColor = Color.White;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOnePlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerOnePlus.ForeColor = Color.White;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOneMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerOneMinus.ForeColor = Color.White;
                    btnPlayerOneLife.BackColor = Color.Black;
                    btnPlayerOneLife.ForeColor = Color.White;
                    btnPlayerOneLife.FlatAppearance.BorderColor = Color.White;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.CornflowerBlue;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerOne.BackColor = Color.Tomato;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerOne.BackColor = Color.ForestGreen;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerOne.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
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
                    break;

                case 1:
                    pnlPlayerTwo.BackColor = Color.Black;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlackTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    lblPlayerTwoTotals.ForeColor = Color.White;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoPlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerTwoPlus.ForeColor = Color.White;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerTwoMinus.ForeColor = Color.White;
                    btnPlayerTwoLife.BackColor = Color.Black;
                    btnPlayerTwoLife.ForeColor = Color.White;
                    btnPlayerTwoLife.FlatAppearance.BorderColor = Color.White;
                    break;

                case 2:
                    pnlPlayerTwo.BackColor = Color.CornflowerBlue;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlueTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerTwo.BackColor = Color.Tomato;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.RedTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.ForestGreen;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.GreenTheme;
                    pnlPlayerTwo.BackgroundImageLayout = ImageLayout.Stretch;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;
            }
        }

        private void TwoPlayerGameSetup()
        {
            PlayerOneLifeTotal = 20;
            PlayerTwoLifeTotal = 20;

            lblPlayerOneTotals.Text = PlayerOneLifeTotal.ToString();
            lblPlayerTwoTotals.Text = PlayerTwoLifeTotal.ToString();     
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
    }
}
