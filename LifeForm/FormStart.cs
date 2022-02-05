using System.Media;

namespace LifeForm
{
    public partial class FormStart : Form
    {
        public int PlayerOneTheme;              // vars required for theme selection on the life screen
        public int PlayerTwoTheme;
        public int PlayerThreeTheme;
        public int PlayerFourTheme;
        public int PlayerNumber;

        public int SoundsEnabled;               // vars required for the start form checkboxes
        public bool NamesEnabled = true;
        public bool TimerEnabled;
        public int TimeSet;

        public string PlayerOneName = "";       // vars required for nameplates on the life screen 
        public string PlayerTwoName = "";
        public string PlayerThreeName = "";
        public string PlayerFourName = "";

        public FormStart()
        {
            InitializeComponent();
        }

        private void PlayerThemeSelect()
        {

            for (int PlayerCount = 1; PlayerCount <= PlayerNumber; PlayerCount++)
            {
                FormThemePick formThemePick = new FormThemePick(SoundsEnabled);
                switch(PlayerCount)
                {
                    case 1:
                        formThemePick.Text = Convert.ToString("Select the theme for " + PlayerOneName + ".");
                        break;
                    case 2:
                        formThemePick.Text = Convert.ToString("Select the theme for " + PlayerTwoName + ".");
                        break;
                    case 3:
                        formThemePick.Text = Convert.ToString("Select the theme for " + PlayerThreeName + ".");
                        break;
                    case 4:
                        formThemePick.Text = Convert.ToString("Select the theme for " + PlayerFourName + ".");
                        break;
                }             
                formThemePick.ShowDialog();
                switch(PlayerCount)
                {
                    case 1:
                        PlayerOneTheme = Convert.ToInt32(formThemePick.ThemeId);
                        break;
                    case 2:
                        PlayerTwoTheme = Convert.ToInt32(formThemePick.ThemeId);
                        break;
                    case 3:
                        PlayerThreeTheme = Convert.ToInt32(formThemePick.ThemeId);
                        break;
                    case 4:
                        PlayerFourTheme = Convert.ToInt32(formThemePick.ThemeId);
                        break;
                }
            }
        }

        private void GameSetup()
        {
            FormGamePick gamepick = new(PlayerNumber, NamesEnabled, TimerEnabled);
            gamepick.ShowDialog();
            PlayerOneName = gamepick.PlayerOneName;
            PlayerTwoName = gamepick.PlayerTwoName;
            PlayerThreeName = gamepick.PlayerThreeName;
            PlayerFourName = gamepick.PlayerFourName;
            TimeSet = gamepick.TimeSet;
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 2;
            GameSetup();
            PlayerThemeSelect();
            FormTwoPlayers formTwoPlayers = new FormTwoPlayers(PlayerOneTheme, PlayerTwoTheme, PlayerOneName, PlayerTwoName, TimerEnabled, TimeSet);
            formTwoPlayers.ShowDialog();
            //this.Close();
        }

        private void btnThreePlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 3;
            GameSetup();
            PlayerThemeSelect();
            FormThreePlayers formTwoPlayers = new FormThreePlayers(PlayerOneTheme, PlayerTwoTheme, PlayerThreeTheme, PlayerOneName, PlayerTwoName, PlayerThreeName, TimerEnabled, TimeSet);
            formTwoPlayers.ShowDialog();
        }

        private void btnFourPlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 4;
            GameSetup();
            PlayerThemeSelect();
            FormFourPlayers formFourPlayers = new FormFourPlayers(PlayerOneTheme, PlayerTwoTheme, PlayerThreeTheme, PlayerFourTheme, PlayerOneName, PlayerTwoName, PlayerThreeName, PlayerFourName, TimerEnabled, TimeSet);
            formFourPlayers.ShowDialog();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new(Properties.Resources.StartFX);
            soundPlayer.Play();
            SoundsEnabled = 1;
        }

        private void cboxSounds_Click(object sender, EventArgs e)
        {
            cboxSounds_Click(sender, e, cboxSounds);
        }

        private void cboxSounds_Click(object sender, EventArgs e, CheckBox cboxSounds)
        {
            switch(SoundsEnabled)
            {
                case 1:
                    cboxSounds.Checked = false;
                    cboxSounds.CheckState = CheckState.Unchecked;
                    SoundsEnabled = 0;
                    break;

                case 0:
                    cboxSounds.Checked = true;
                    cboxSounds.CheckState = CheckState.Checked;
                    SoundsEnabled = 1;
                    break;
            }
        }

        private void cboxNames_Click(object sender, EventArgs e)
        {
            switch(NamesEnabled)
            {
                case(true):
                    cboxNames.Checked = false;
                    NamesEnabled = false;
                    break;

                case(false):
                    cboxNames.Checked = true;
                    NamesEnabled = true;
                    break;
            }
        }

        private void cboxTimer_Click(object sender, EventArgs e)
        {
            switch (TimerEnabled)
            {
                case (true):
                    cboxTimer.Checked = false;
                    TimerEnabled = false;
                    break;

                case (false):
                    cboxTimer.Checked = true;
                    TimerEnabled = true;
                    break;
            }
        }
    }
}