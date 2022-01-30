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
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Rifleman\Desktop\WhiteFX.wav");
            soundPlayer.Play();
            ThemeId = 0;
            this.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Rifleman\Desktop\BlackFX.wav");
            soundPlayer.Play();
            ThemeId = 1;
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Rifleman\Desktop\BlueFX.wav");
            soundPlayer.Play();
            ThemeId = 2;
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Rifleman\Desktop\RedFX.wav");
            soundPlayer.Play();
            ThemeId = 3;
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\Rifleman\Desktop\GreenFX.wav");
            soundPlayer.Play();
            ThemeId = 4;
            this.Close();
        }

       
    }
}
