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
    public partial class FormGamePick : Form
    {
        public string PlayerOneName = "Player 1";
        public string PlayerTwoName = "Player 2";
        public string PlayerThreeName = "Player 3";
        public string PlayerFourName = "Player 4";

        private int PlayerCount;

        private bool NamesEnabled;

        private bool TimerEnabled;

        public int TimeSet;

        public FormGamePick(int playerCount,bool namesEnabled, bool timerEnabled)
        {
            PlayerCount = playerCount;
            NamesEnabled = namesEnabled;
            TimerEnabled = timerEnabled;
            InitializeComponent();
        }

        private void PreGameSetup()
        {
            switch(PlayerCount)
            {
                case 3:
                    tboxPlayerFourName.Enabled = false;
                    tboxPlayerFourName.Visible = false;
                    break;

                case 2:
                    tboxPlayerFourName.Enabled = false;
                    tboxPlayerFourName.Visible = false;
                    tboxPlayerThreeName.Enabled = false;
                    tboxPlayerThreeName.Visible = false;
                    break;
            }

            if(NamesEnabled == false)
            {
                tboxPlayerFourName.Enabled = false;
                tboxPlayerThreeName.Enabled = false;
                tboxPlayerTwoName.Enabled = false;
                tboxPlayerOneName.Enabled = false;
            }

            if (TimerEnabled == true)
            {
                tboxGameTime.Enabled = true;
                TimeSet = 50;
            }
            else
            {
                tboxGameTime.Enabled = false;
            }
        }

        private void FormGamePick_Load(object sender, EventArgs e)
        {
            PreGameSetup();
        }

        private void tboxPlayerOneName_TextChanged(object sender, EventArgs e)
        {
            PlayerOneName = tboxPlayerOneName.Text;
            if(tboxPlayerOneName.Text == "")
            {
                PlayerOneName = "Player 1";
            }
        }

        private void tboxPlayerTwoName_TextChanged(object sender, EventArgs e)
        {
            PlayerTwoName = tboxPlayerTwoName.Text;
            if (tboxPlayerTwoName.Text == "")
            {
                PlayerTwoName = "Player 2";
            }
        }

        private void tboxPlayerThreeName_TextChanged(object sender, EventArgs e)
        {
            PlayerThreeName = tboxPlayerThreeName.Text;
            if (tboxPlayerThreeName.Text == "")
            {
                PlayerThreeName = "Player 3";
            }
        }

        private void tboxPlayerFourName_TextChanged(object sender, EventArgs e)
        {
            PlayerFourName = tboxPlayerFourName.Text;
            if (tboxPlayerFourName.Text == "")
            {
                PlayerFourName = "Player 4";
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxGameTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tboxGameTime.Text) < 0)
                {
                    TimeSet = 0;
                }
                else if (Convert.ToInt32(tboxGameTime.Text) > 99)
                {
                    TimeSet = 99;
                }
                TimeSet = Convert.ToInt32(tboxGameTime.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
