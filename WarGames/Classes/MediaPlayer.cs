using System.IO;
using System.Media;
using WMPLib;

namespace WarGames
{
    public class MediaPlayer
    {
        public static SoundPlayer IntroMusic = new SoundPlayer(Properties.Resources.TitleMusicMenuTheme);
        public static SoundPlayer BackgroundMusic = new SoundPlayer(Properties.Resources.MenuMusic);

        public static void ExplosionSound()
        {
            var strTempFile = Path.GetTempFileName();
            File.WriteAllBytes(strTempFile, Properties.Resources.ExplosionSound);

            new System.Threading.Thread(() => {
                var c = new WindowsMediaPlayer();
                c.URL = strTempFile;
                c.controls.play();
            }).Start();
        }
    }
}
