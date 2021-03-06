using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace LifeForm
{
    internal class ThemeSounds
    {
        public ThemeSounds (int ThemeId, int SoundsEnabled)
        {
            if (SoundsEnabled == 1)
            {
                switch (ThemeId)
                {
                    case 0:
                        SoundPlayer a = new SoundPlayer(Properties.Resources.WhiteFX);
                        a.Play();
                        break;

                    case 1:
                        SoundPlayer b = new SoundPlayer(Properties.Resources.BlackFX);
                        b.Play();
                        break;

                    case 2:
                        SoundPlayer c = new SoundPlayer(Properties.Resources.BlueFX);
                        c.Play();
                        break;

                    case 3:
                        SoundPlayer d = new SoundPlayer(Properties.Resources.RedFX);
                        d.Play();
                        break;

                    case 4:
                        SoundPlayer e = new SoundPlayer(Properties.Resources.GreenFX);
                        e.Play();
                        break;
                }
            }
        }
    }
}
