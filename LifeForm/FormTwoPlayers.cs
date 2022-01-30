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

        public FormTwoPlayers(int playerOneTheme, int playerTwoTheme)
        {
            this.playerOneTheme = playerOneTheme;
            this.playerTwoTheme = playerTwoTheme;
            InitializeComponent();
        }

        private void TwoPlayerSetup()
        {
            switch(playerOneTheme)
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
                    pnlPlayerOne.BackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerOne.BackColor= Color.Green;
                    break;

            }

            switch(playerTwoTheme)
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
                    pnlPlayerTwo.BackColor = Color.Red;
                    break;

                case 4:
                    pnlPlayerTwo.BackColor = Color.Green;
                    break;

            }
        }
        private void FormTwoPlayers_Load(object sender, EventArgs e)
        {
            TwoPlayerSetup();
        }
    }
}
