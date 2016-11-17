using System;
using System.Drawing;
using System.Drawing.Text;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WarGames
{
    public partial class IntroMenu : Form
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;

        SoundPlayer introMusic = new SoundPlayer(Properties.Resources.TitleMusicMenuTheme);

        public IntroMenu()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.WarGames;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.WarGames.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.WarGames.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 40.0F);
        }

        private void IntroMenu_Load(object sender, EventArgs e)
        {
            PlayGameBtn.Font = myFont;
            ExitGameBtn.Font = myFont;
            introMusic.PlayLooping();
        }

        private void PlayGameBtn_Click(object sender, EventArgs e)
        {
            introMusic.Stop();
        }

        private void ExitGameBtn_Click(object sender, EventArgs e)
        {
            introMusic.Stop();
        }
    }
}
