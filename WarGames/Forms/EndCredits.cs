using System;
using System.Windows.Forms;

namespace WarGames
{
    public partial class EndCredits : Form
    {
        WOPR warRoom = new WOPR();

        public EndCredits()
        {
            InitializeComponent();
        }

        private void EndCredits_Load(object sender, EventArgs e)
        {
            PlayAgainButton.Font = warRoom.myFont2;
            ExitGameBtn.Font = warRoom.myFont2;
        }

        public void GetWinCountry(string winningCountry)
        {
            string winCountry;
            winCountry = winningCountry;
            winningCountryLabel.Text = "Winner: " + winCountry;
        }
    }
}
