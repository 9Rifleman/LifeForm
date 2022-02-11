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
    public partial class FormCoinToss : Form
    {
        public FormCoinToss()
        {
            InitializeComponent();
        }

        private async void FormCoinToss_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int coin = random.Next(0, 100);
            switch(coin)
            {
                case <= 50:
                    pboxCoinToss.Image = Properties.Resources.Cointoss_Heads;
                    break;

                case >= 51:
                    pboxCoinToss.Image = Properties.Resources.Cointoss_Tails;
                    break;
            }
            SoundPlayer sp = new(Properties.Resources.CointossFX);
            sp.Play();
            await Task.Delay(4150);
            this.Close();
        }
    }
}
