﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace WarGames
{
    public partial class Form1 : Form
    {
        WOPR wop = new WOPR();
        List<Countries> countriesAtWar = new List<Countries>();

        public Form1()
        {
            Application.Run(new IntroMenu());

            InitializeComponent();
            EnduranceListBox.DataSource = countriesAtWar;
        }

        public bool SplashScreen()
        {
            IntroMenu splash = new IntroMenu();
            if (splash.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            //only visible while the game is running, does not effect the start/stop button
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //"Start" text turns to Stop while the game is running
            PauseButton.Enabled = true;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            //Popup.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
