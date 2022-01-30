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
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerOneTotals.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.CornflowerBlue;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.BlueTheme;
                    break;

                case 3:
                    pnlPlayerOne.BackColor = Color.Tomato;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.RedTheme;
                    break;

                case 4:
                    pnlPlayerOne.BackColor = Color.ForestGreen;
                    pnlPlayerOne.BackgroundImage = Properties.Resources.GreenTheme;
                    break;

            }

            switch (playerTwoTheme)
            {
                case 0:
                    pnlPlayerTwo.BackColor = Color.Ivory;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.WhiteTheme;
                    break;

                case 1:
                    pnlPlayerTwo.BackColor = Color.Black;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerTwoTotals.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerTwo.BackColor = Color.CornflowerBlue;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.BlueTheme;
                    break;

                case 3:
                    pnlPlayerTwo.BackColor = Color.Tomato;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.RedTheme;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.ForestGreen;
                    pnlPlayerTwo.BackgroundImage = Properties.Resources.GreenTheme;
                    break;
            }

            switch (playerThreeTheme)
            {
                case 0:
                    pnlPlayerThree.BackColor = Color.Ivory;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.WhiteTheme;
                    break;

                case 1:
                    pnlPlayerThree.BackColor = Color.Black;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerThreeTotals.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerThree.BackColor = Color.CornflowerBlue;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.BlueTheme;
                    break;

                case 3:
                    pnlPlayerThree.BackColor = Color.Tomato;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.RedTheme;
                    break;

                case 4:
                    pnlPlayerThree.BackColor = Color.ForestGreen;
                    pnlPlayerThree.BackgroundImage = Properties.Resources.GreenTheme;
                    break;

            }

            switch (playerFourTheme)
            {
                case 0:
                    pnlPlayerFour.BackColor = Color.Ivory;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.WhiteTheme;
                    break;

                case 1:
                    pnlPlayerFour.BackColor = Color.Black;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlackTheme;
                    lblPlayerFourTotals.ForeColor = Color.White;
                    break;

                case 2:
                    pnlPlayerFour.BackColor = Color.CornflowerBlue;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.BlueTheme;
                    break;

                case 3:
                    pnlPlayerFour.BackColor = Color.Tomato;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.RedTheme;
                    break;

                case 4:
                    pnlPlayerFour.BackColor = Color.ForestGreen;
                    pnlPlayerFour.BackgroundImage = Properties.Resources.GreenTheme;
                    break;

            }
        }

        private void FormFourPlayers_Load(object sender, EventArgs e)
        {
            FourPlayerSetup();
        }
    }
}
