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
    public partial class FormDTwenty : Form
    {
        private int roll;
        public FormDTwenty()
        {
            InitializeComponent();
        }

        private void FormDTwenty_Load(object sender, EventArgs e)
        {
            Random cast = new Random();
            int turns = cast.Next(8, 12);
            for(int i = 0; i <= turns; i++)
            {
                roll = cast.Next(1, 20);
                lblDTwenty.Text = roll.ToString();
            }
        }
    }
}
