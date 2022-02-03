using System.Media;

namespace LifeForm
{
    public partial class FormStart : Form
    {


        public FormStart()
        {
            InitializeComponent();
        }

        //
        public int PlayerOneTheme;
        public int PlayerTwoTheme;
        public int PlayerThreeTheme;
        public int PlayerFourTheme;
        public int PlayerNumber;

        private void PlayerThemeSelect()
        {

            for (int PlayerCount = 1; PlayerCount <= PlayerNumber; PlayerCount++)
            {
                FormThemePick formThemePick = new FormThemePick();
                formThemePick.Text = Convert.ToString("Select the theme for player " + PlayerCount + ".");
                formThemePick.ShowDialog();
                switch (PlayerCount)
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

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 2;
            PlayerThemeSelect();
            FormTwoPlayers formTwoPlayers = new FormTwoPlayers(PlayerOneTheme, PlayerTwoTheme);
            formTwoPlayers.ShowDialog();
            //this.Close();
        }

        private void btnThreePlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 3;
            PlayerThemeSelect();
            FormThreePlayers formTwoPlayers = new FormThreePlayers(PlayerOneTheme, PlayerTwoTheme, PlayerThreeTheme);
            formTwoPlayers.ShowDialog();
        }

        private void btnFourPlayers_Click(object sender, EventArgs e)
        {
            PlayerNumber = 4;
            PlayerThemeSelect();
            FormFourPlayers formFourPlayers = new FormFourPlayers(PlayerOneTheme, PlayerTwoTheme, PlayerThreeTheme, PlayerFourTheme);
            formFourPlayers.ShowDialog();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new(Properties.Resources.StartFX);
            soundPlayer.Play();
        }
    }
}