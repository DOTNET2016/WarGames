using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace WarGames
{
    public class MediaPlayer
    {
        public static SoundPlayer IntroMusic = new SoundPlayer(Properties.Resources.TitleMusicMenuTheme);
        public static SoundPlayer BackgroundMusic = new SoundPlayer(Properties.Resources.MenuMusic);

        public static void ExplosionSound()
        {
            //Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Properties.Resources.ExplosionSound.mp3");
            //using (Stream output = new FileStream("c:/temp/ExplosionSound.mp3", FileMode.Create))
            //{
            //    byte[] buffer = new byte[32 * 1024];
            //    int read;

            //    while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        output.Write(buffer, 0, read);
            //    }
            //}
            new System.Threading.Thread(() => {
                var c = new WindowsMediaPlayer();
                c.URL = ("c:/temp/ExplosionSound.mp3");
                c.controls.play();
            }).Start();
        }
    }
}
