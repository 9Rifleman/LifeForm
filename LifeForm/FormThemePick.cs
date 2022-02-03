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
            ThemeId = 0;
            ClassSounds sound = new ClassSounds(ThemeId);          
            this.Close();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            ThemeId = 1;
            ClassSounds sound = new ClassSounds(ThemeId);
            this.Close();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            ThemeId = 2;
            ClassSounds sound = new ClassSounds(ThemeId);
            this.Close();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ThemeId = 3;
            ClassSounds sound = new ClassSounds(ThemeId);
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ThemeId = 4;
            ClassSounds sound = new ClassSounds(ThemeId);
            this.Close();
        }

       
    }
}
