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
        public FormFourPlayers(int playerOneTheme, int playerTwoTheme, int playerThreeTheme, int playerFourTheme)
        {
            this.playerOneTheme = playerOneTheme;
            this.playerTwoTheme = playerTwoTheme;
            this.playerThreeTheme = playerThreeTheme;
            this.playerFourTheme = playerFourTheme;
            InitializeComponent();
        }

        private void FourPlayerSetup()
        {
            switch (playerOneTheme)
            {
                case 0:
                    pnlPlayerOne.BackColor = Color.Ivory;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.WhiteTheme;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerOneTotals.ForeColor = Color.White;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOnePlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerOnePlus.ForeColor = Color.White;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerOneMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerOneMinus.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.CornflowerBlue;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlueTheme;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerOne.BackColor = Color.Tomato;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.RedTheme;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerOne.BackColor = Color.ForestGreen;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.GreenTheme;
                    btnPlayerOnePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerOneMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

            }

            switch (playerTwoTheme)
            {
                case 0:
                    pnlPlayerTwo.BackColor = Color.Ivory;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.WhiteTheme;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 1:
                    pnlPlayerTwo.BackColor = Color.Black;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerTwoTotals.ForeColor = Color.White;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoPlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerTwoPlus.ForeColor = Color.White;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerTwoMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerTwoMinus.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerTwo.BackColor = Color.CornflowerBlue;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlueTheme;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerTwo.BackColor = Color.Tomato;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.RedTheme;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.ForestGreen;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.GreenTheme;
                    btnPlayerTwoPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerTwoMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;
            }

            switch (playerThreeTheme)
            {
                case 0:
                    pnlPlayerThree.BackColor = Color.Ivory;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.WhiteTheme;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 1:
                    pnlPlayerThree.BackColor = Color.Black;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerThreeTotals.ForeColor = Color.White;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreePlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerThreePlus.ForeColor = Color.White;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerThreeMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerThreeMinus.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerThree.BackColor = Color.CornflowerBlue;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlueTheme;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerThree.BackColor = Color.Tomato;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.RedTheme;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerThree.BackColor = Color.ForestGreen;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.GreenTheme;
                    btnPlayerThreePlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerThreeMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

            }

            switch (playerFourTheme)
            {
                case 0:
                    pnlPlayerFour.BackColor = Color.Ivory;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.WhiteTheme;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 1:
                    pnlPlayerFour.BackColor = Color.Black;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerFourTotals.ForeColor = Color.White;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourPlus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerFourPlus.ForeColor = Color.White;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    btnPlayerFourMinus.FlatAppearance.BorderColor = Color.White;
                    btnPlayerFourMinus.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerFour.BackColor = Color.CornflowerBlue;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlueTheme;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 3:
                    pnlPlayerFour.BackColor = Color.Tomato;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.RedTheme;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerFour.BackColor = Color.ForestGreen;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.GreenTheme;
                    btnPlayerFourPlus.FlatAppearance.MouseOverBackColor = Color.Green;
                    btnPlayerFourMinus.FlatAppearance.MouseOverBackColor = Color.Red;
                    break;

            }
        }

        private void FormFourPlayers_Load(object sender, EventArgs e)
        {
            FourPlayerSetup();
        }
    }
}
