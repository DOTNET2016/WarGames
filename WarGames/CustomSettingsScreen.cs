using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarGames
{
    public partial class CustomSettingsScreen : Form
    {
        static CustomSettingsScreen newScreen;
        private Timer _CountDownTimer;

        private int _counter = 5;
        private int _hours = 00;

        public CustomSettingsScreen()
        {
            InitializeComponent();
        }

        public static void ShowCustomMenu()
        {
            newScreen = new CustomSettingsScreen();
            newScreen.ShowDialog();
        }

        private void BigRedButton_Click(object sender, EventArgs e)
        {
            CountdownClock.Enabled = true;
            _CountDownTimer = new Timer();
            _CountDownTimer.Tick += _CountDownTimer_Tick;
            _CountDownTimer.Interval = 1000;
            _CountDownTimer.Start();
            CountdownClock.Text = _hours.ToString("00") + ":" + _counter.ToString("00");
        }

        private void _CountDownTimer_Tick(object sender, EventArgs e)
        {
            _counter--;
            CountdownClock.Text = _hours.ToString("00") + ":" + _counter.ToString("00");
            CountdownClock.Refresh();
            if (_counter == 0)
            {
                _CountDownTimer.Stop();
                CountdownClock.Text = _hours.ToString("00") + ":" + _counter.ToString("00");
                newScreen.Dispose();
                IntroMenu.CloseIntroScreen();
            }
        }
        #region CountiresSettingsChanged
        //USA
        private void USA_Durability_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void USA_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void USA_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //Russia
        private void Russia_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Russia_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Russia_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //UK
        private void UK_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UK_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UK_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //China
        private void China_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void China_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void China_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //France
        private void France_Durablity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void France_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void France_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //India
        private void India_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void India_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void India_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //Germany
        private void Germany_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Germany_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Germany_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //Japan
        private void Japan_Durability_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void Japan_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Japan_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //Sweden
        private void Sweden_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sweden_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sweden_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        //North Korea
        private void NorthKorea_Durability_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NorthKorea_Strength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NorthKorea_Rep_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
       

    }
}
