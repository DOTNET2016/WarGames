using System.Media;
using System.Threading;
using WMPLib;

namespace WarGames
{
    public class MediaPlayer
    {
        public static SoundPlayer IntroMusic = new SoundPlayer(Properties.Resources.TitleMusicMenuTheme);
        public static SoundPlayer BackgroundMusic = new SoundPlayer(Properties.Resources.MenuMusic);
        public static string TempFile = WOPR.TempFile();
        public static void ExplosionSound()
        {

            Thread Sound;
            Sound = new Thread(() =>
            {
                var c = new WindowsMediaPlayer();
                c.URL = TempFile;
                c.controls.play();
            });
            Sound.Start();
        }
    }
}
