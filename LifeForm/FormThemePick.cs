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
        public int ThemeId;
        public int SoundsEnabled;
        public FormThemePick(int SoundsEnabled)
        {
            this.SoundsEnabled = SoundsEnabled;
            InitializeComponent();
        }
        
        private void btnWhite_Click(object sender, EventArgs e)
        {
            ThemeId = 0;
            ThemeSounds sound = new ThemeSounds(ThemeId, SoundsEnabled);          
            this.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ThemeId = 1;
            ThemeSounds sound = new ThemeSounds(ThemeId, SoundsEnabled);
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ThemeId = 2;
            ThemeSounds sound = new ThemeSounds(ThemeId, SoundsEnabled);
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ThemeId = 3;
            ThemeSounds sound = new ThemeSounds(ThemeId, SoundsEnabled);
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ThemeId = 4;
            ThemeSounds sound = new ThemeSounds(ThemeId, SoundsEnabled);
            this.Close();
        }

       
    }
}
