using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WarGames
{
    public partial class EndCredits : Form
    {
        WOPR warRoom = new WOPR();
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        private string winCountry;

        public EndCredits()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.WarGames;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.WarGames.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.WarGames.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 25.0F);
        }

        private void EndCredits_Load(object sender, EventArgs e)
        {
            PlayAgainButton.Font = myFont;
            ExitGameBtn.Font = myFont;
        }

        public void GetWinCountry(string winningCountry)
        {
            winCountry = winningCountry;
            winningCountryLabel.Text = "Winner: " + winCountry;
        }
    }
}
