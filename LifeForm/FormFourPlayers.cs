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
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.CornflowerBlue;
                    break;

                case 3:
                    pnlPlayerOne.BackColor = Color.Tomato;
                    break;

                case 4:
                    pnlPlayerOne.BackColor = Color.ForestGreen;
                    break;

            }

            switch (playerTwoTheme)
            {
                case 0:
                    pnlPlayerTwo.BackColor = Color.Ivory;
                    break;

                case 1:
                    pnlPlayerTwo.BackColor = Color.Black;
                    break;

                case 2:
                    pnlPlayerTwo.BackColor = Color.CornflowerBlue;
                    break;

                case 3:
                    pnlPlayerTwo.BackColor = Color.Tomato;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.ForestGreen;
                    break;

            }

            switch (playerThreeTheme)
            {
                case 0:
                    pnlPlayerThree.BackColor = Color.Ivory;
                    break;

                case 1:
                    pnlPlayerThree.BackColor = Color.Black;
                    break;

                case 2:
                    pnlPlayerThree.BackColor = Color.CornflowerBlue;
                    break;

                case 3:
                    pnlPlayerThree.BackColor = Color.Tomato;
                    break;

                case 4:
                    pnlPlayerThree.BackColor = Color.ForestGreen;
                    break;

            }

            switch (playerFourTheme)
            {
                case 0:
                    pnlPlayerFour.BackColor = Color.Ivory;
                    break;

                case 1:
                    pnlPlayerFour.BackColor = Color.Black;
                    break;

                case 2:
                    pnlPlayerFour.BackColor = Color.CornflowerBlue;
                    break;

                case 3:
                    pnlPlayerFour.BackColor = Color.Tomato;
                    break;

                case 4:
                    pnlPlayerFour.BackColor = Color.ForestGreen;
                    break;

            }
        }

        private void FormFourPlayers_Load(object sender, EventArgs e)
        {
            FourPlayerSetup();
        }
    }
}
