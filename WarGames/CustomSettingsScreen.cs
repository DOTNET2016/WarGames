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

        private int _counter = 10;
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
            }
        }
    }
}
