using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LifeForm
{
    public partial class FormThemePick : Form
    {
        public FormThemePick()
        {
            InitializeComponent();
        }

        public int ThemeId;
        private void btnWhite_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.WhiteFX);
            soundPlayer.Play();
            ThemeId = 0;
            this.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.BlackFX);
            soundPlayer.Play();
            ThemeId = 1;
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.BlueFX);
            soundPlayer.Play();
            ThemeId = 2;
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.RedFX);
            soundPlayer.Play();
            ThemeId = 3;
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.GreenFX);
            soundPlayer.Play();
            ThemeId = 4;
            this.Close();
        }

       
    }
}
