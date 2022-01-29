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
        public FormTwoPlayers()
        {
            InitializeComponent();
        }

        private void TwoPlayerSetup()
        {
            FormStart formStart = new();
            int a = formStart.PlayerOneTheme;
            switch(a)
            {
                case 0:
                    pnlPlayerOne.BackColor = Color.White;
                    break;

                case 1:
                    pnlPlayerOne.BackColor = Color.Black;
                    break;

                case 2:
                    pnlPlayerOne.BackColor = Color.Blue;
                    break;

            }
        }
        private void FormTwoPlayers_Load(object sender, EventArgs e)
        {
            TwoPlayerSetup();
        }
    }
}
