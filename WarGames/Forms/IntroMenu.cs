using System;
using System.Windows.Forms;

namespace WarGames
{
    public partial class IntroMenu : Form
    {
        WOPR warRoom = new WOPR();

        public IntroMenu()
        {
            InitializeComponent();
        }

        private void IntroMenu_Load(object sender, EventArgs e)
        {
            PlayGameBtn.Font = warRoom.myFont3;
            ExitGameBtn.Font = warRoom.myFont3;
            MediaPlayer.IntroMusic.PlayLooping();
        }
    }
}
