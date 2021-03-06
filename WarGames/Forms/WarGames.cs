﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace WarGames
{
    public partial class WarGames : Form
    {
        WOPR warRoom = new WOPR();

        private List<Point> Points = new List<Point>();
        private List<PointF> curvePointList;
        private PointF curveStart;
        private PointF curveEnd;

        private bool _IsOn;
        private bool _IsPause;

        private int drawLoop = 0;

        public WarGames()
        {    
            InitializeComponent();

            EnduranceListBox.DataSource = warRoom.countriesAtWar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntroMenu introMenu = new IntroMenu();
            if (introMenu.ShowDialog(this) == DialogResult.OK)
            {
                MediaPlayer.IntroMusic.Stop();
                MediaPlayer.BackgroundMusic.PlayLooping();
            }
            else
            {
                Close();
            }
            introMenu.Close();
            introMenu.Dispose();

            OptionButton.Font = warRoom.myFont1;
            StartButton.Font = warRoom.myFont1;
            PauseButton.Font = warRoom.myFont1;
            CustomizeGameBtn.Font = warRoom.myFont1;
        }

        public static float GetRandomNumber(float minimum, float maximum)
        {
            Random random = new Random();
            return Convert.ToSingle(random.NextDouble() * (maximum - minimum) + minimum);
        }

        public void CreateCurve(PointF curveStart, PointF curveEnd)
        {
            curvePointList = new List<PointF>();
            curvePointList.Clear();
            curvePointList.Add(curveStart);

            PointF midPoint = CreateMidPoint(curveStart, curveEnd);
            curvePointList.Add(midPoint);
            curvePointList.Add(curveEnd);
        }

        private PointF CreateMidPoint(PointF controlPoint1, PointF controlPoint2)
        {
            if (curveEnd.X == 223 && curveStart.X >= 1006 && curveStart.X <= 1291)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.2f, 0.3f));
            }
            if (curveEnd.X == 223 && curveStart.X >= 654 && curveStart.X <= 721)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.4f, 0.6f));
            }
            if (curveStart.X > curveEnd.X && curveStart.X >= 654 && curveStart.X <= 721 && curveEnd.X >= 654 && curveEnd.X <= 721)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(0.97f, 0.99f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.91f, 0.97f));
            }
            else if (curveStart.X >= 654 && curveStart.X <= 721 && curveEnd.X >= 654 && curveEnd.X <= 721)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(1.01f, 1.03f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.90f, 0.96f));
            }
            else if (curveStart.X > curveEnd.X && curveStart.X >= 1028 && curveStart.X <= 1105 && curveEnd.X >= 1028 && curveEnd.X <= 1105)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(0.96f, 0.98f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.95f, 0.98f));
            }
            else if (curveStart.X >= 1028 && curveStart.X <= 1105 && curveEnd.X >= 1028 && curveEnd.X <= 1105)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(0.96f, 0.98f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.95f, 0.98f));
            }
            else if (curveStart.X >= 1028 && curveStart.X <= 1105 && curveEnd.X >= 1028 && curveEnd.X <= 1105)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(0.96f, 0.98f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.95f, 0.98f));
            }
            else if (curveStart.X > curveEnd.X && curveStart.X >= 1226 && curveStart.X <= 1291 && curveEnd.X >= 1226 && curveEnd.X <= 1291)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(1.0f, 1.01f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.95f, 0.98f));
            }
            else if (curveStart.X >= 1006 && curveStart.X <= 1291 && curveEnd.X >= 1006 && curveEnd.X <= 1291)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * GetRandomNumber(1.0f, 1.02f),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.75f, 0.81f));
            }
            else if (curveStart.X == 223 && curveEnd.X >= 1006 && curveEnd.X <= 1291)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.3f, 0.5f));
            }
            else if (curveStart.X == 223 && curveEnd.X >= 654 && curveEnd.X <= 721)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.5f, 0.7f));
            }
            else
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2),
                ((controlPoint1.Y + controlPoint2.Y) / 2) * GetRandomNumber(0.65f, 0.71f));
            }
        }

        private void AttackMethod()
        {
            if (warRoom.countriesAtWar.Count > 1)
            {
                var countryWars = warRoom.RandomCountries();

                PointF attackPoint = new PointF(countryWars.x1, countryWars.y1);
                PointF defendPoint = new PointF(countryWars.x2, countryWars.y2);

                curveStart = attackPoint;
                curveEnd = defendPoint;
                CreateCurve(curveStart, curveEnd);

                float x = countryWars.x2 - 20;
                float y = countryWars.y2 - 20;

                var g = Graphics.FromImage(Background.BackgroundImage);
                
                if (ClearLinesCheckBox.Checked && drawLoop >= 1)
                {
                    g.Clear(Color.Transparent);
                    drawLoop = 0;
                }
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.Red, 2);
                g.DrawCurve(pen, curvePointList.ToArray());
                ExplosionPictureBox.Hide();
                ExplosionPictureBox.Show();
                ExplosionPictureBox.Location = new Point((int)x, (int)y);
                Background.Refresh();
                drawLoop++;

                Thread ES = new Thread(() => MediaPlayer.ExplosionSound());
                ES.Start();
            }
            else
            {
                warTimer.Stop();               
                ExplosionPictureBox.Hide();

                EndCredits endPage = new EndCredits();
                endPage.GetWinCountry(warRoom.countriesAtWar[0].CountryName);
                
                if (endPage.ShowDialog(this) == DialogResult.OK)
                {
                    Graphics.FromImage(Background.BackgroundImage).Clear(Color.Transparent);
                    Background.Refresh();
                    PauseButton.Enabled = false;
                    CustomizeGameBtn.Enabled = true;
                    warRoom.countriesAtWar.Clear();

                    IsOn = !IsOn;
                }
                else
                {
                    EnduranceListBox.DataSource = null;
                    Close();
                }
            }
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            gameOptionBox.Show();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            IsPause = !IsPause;
            if (IsPause)
            {
                warTimer.Stop();
                ExplosionPictureBox.Hide();
            }
            if (!IsPause)
            {
                warTimer.Start();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                //if the user havent visited the "customize" section the when pressed it will create a list of countries with default stats
                if (warRoom.countriesAtWar.Count == 0)
                {
                    warRoom.CountryList();
                    PauseButton.Enabled = true;
                    CustomizeGameBtn.Enabled = false;
                }
                //start the program using the list with stats from the "customize" section
                else
                {
                    PauseButton.Enabled = true;
                    CustomizeGameBtn.Enabled = false;
                }
                warTimer.Start();
            }
            if (!IsOn)
            {
                //stops the war, when it says Stop also works as and reset the list
                warRoom.countriesAtWar.Clear();
                ExplosionPictureBox.Hide();
                PauseButton.Enabled = false;
                CustomizeGameBtn.Enabled = true;
                warTimer.Stop();
                ExplosionPictureBox.Hide();
                if (IsPause)
                {
                    IsPause = !IsPause;
                }
                IsPause = IsPause;
            }
            Graphics.FromImage(Background.BackgroundImage).Clear(Color.Transparent);
            Background.Refresh();
            warRoom.countriesAtWar.Sort();
            ((CurrencyManager)EnduranceListBox.BindingContext[warRoom.countriesAtWar]).Refresh();
        }

        //gets the stats from the "customize" section and updates all country stat labels and add the stats to a list
        private void CustomizeGameBtn_Click(object sender, EventArgs e)
        {
            CustomSettingsScreen css = new CustomSettingsScreen();

            if (css.ShowDialog(this) == DialogResult.OK)
            {
                USADurLabel.Text = "Durability: " + css.USADurability.ToString();
                USAStrengthLabel.Text = "Strength: " + css.USAStrength.ToString();
                USARepLabel.Text = "Reputation: " + css.USARep.ToString();
                warRoom.countriesAtWar.Add(new Land("USA", css.USADurability, css.USAStrength, css.USARep, 223, 239));
                
                RussiaDurLabel.Text = "Durability: " + css.RussiaDurability.ToString();
                RussiaStrengthLabel.Text = "Strength: " + css.RussiaStrength.ToString();
                RussiaRepLabel.Text = "Reputation: " + css.RussiaRep.ToString();
                warRoom.countriesAtWar.Add(new Land("Russia", css.RussiaDurability, css.RussiaStrength, css.RussiaRep, 1006, 121));
                
                UkDurLabel.Text = "Durability: " + css.UkDurability.ToString();
                UkStrengthLabel.Text = "Strength: " + css.UkStrength.ToString();
                UkRepLabel.Text = "Reputation: " + css.UkRep.ToString();
                warRoom.countriesAtWar.Add(new Land("UK", css.UkDurability, css.UkStrength, css.UkRep, 654, 156));

                ChinaDurLabel.Text = "Durability: " + css.ChinaDurability.ToString();
                ChinaStrengthLabel.Text = "Strength: " + css.ChinaStrength.ToString();
                ChinaRepLabel.Text = "Reputation: " + css.ChinaRep.ToString();
                warRoom.countriesAtWar.Add(new Land("China", css.ChinaDurability, css.ChinaStrength, css.ChinaRep, 1105, 255));
                
                FranceDurLabel.Text = "Durability: " + css.FranceDurability.ToString();
                FranceStrengthLabel.Text = "Strength: " + css.FranceStrength.ToString();
                FranceRepLabel.Text = "Reputation: " + css.FranceRep.ToString();
                warRoom.countriesAtWar.Add(new Land("France", css.FranceDurability, css.FranceStrength, css.FranceRep, 667, 189));

                IndiaDurLabel.Text = "Durability: " + css.IndiaDurability.ToString();
                IndiaStrengthLabel.Text = "Strength: " + css.IndiaStrength.ToString();
                IndiaRepLabel.Text = "Reputation: " + css.IndiaRep.ToString();
                warRoom.countriesAtWar.Add(new Land("India", css.IndiaDurability, css.IndiaStrength, css.IndiaRep, 1028, 322));

                GermanyDurLabel.Text = "Durability: " + css.GermanyDurability.ToString();
                GermanyStrengthLabel.Text = "Strength: " + css.GermanyStrength.ToString();
                GermanyRepLabel.Text = "Reputation: " + css.GermanyRep.ToString();
                warRoom.countriesAtWar.Add(new Land("Germany", css.GermanyDurability, css.GermanyStrength, css.GermanyRep, 699, 164));

                JapanDurLabel.Text = "Durability: " + css.JPDurability.ToString();
                JapanStrengthLabel.Text = "Strength: " + css.JPStrength.ToString();
                JapanRepLabel.Text = "Reputation: " + css.JPRep.ToString();
                warRoom.countriesAtWar.Add(new Land("Japan", css.JPDurability, css.JPStrength, css.JPRep, 1291, 240));

                SwedenDurLabel.Text = "Durability: " + css.SwedenDurability.ToString();
                SwedenStrengthLabel.Text = "Strength: " + css.SwedenStrength.ToString();
                SwedenRepLabel.Text = "Reputation: " + css.SwedenRep.ToString();
                warRoom.countriesAtWar.Add(new Land("Sweden", css.SwedenDurability, css.SwedenStrength, css.SwedenRep, 721, 114));

                NKDurLabel.Text = "Durability: " + css.NorthKoreaDurability.ToString();
                NKStrengthLabel.Text = "Strength: " + css.NorthKoreaStrength.ToString();
                NKRepLabel.Text = "Reputation: " + css.NorthKoreaRep.ToString();
                warRoom.countriesAtWar.Add(new Land("North Korea", css.NorthKoreaDurability, css.NorthKoreaStrength, css.NorthKoreaRep, 1226, 223));
            }
            css.Close();
            css.Dispose();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void warTimer_Tick(object sender, EventArgs e)
        {
            AttackMethod();
            warRoom.countriesAtWar.Sort();
            if (EnduranceListBox.DataSource == null)
            {
                return;
            }
            else
            {
                ((CurrencyManager)EnduranceListBox.BindingContext[warRoom.countriesAtWar]).Refresh();
            }          
        }

        #region OptionWindow
        private void BgMusicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BgMusicCheckBox.Checked == true)
            {
                MediaPlayer.BackgroundMusic.Stop();
            }
            else
            {
                MediaPlayer.BackgroundMusic.PlayLooping();
            }
        }

        private void HideStatsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HideStatsCheckBox.Checked == true)
            {
                StatsBox.Hide();
            }
            else
            {
                StatsBox.Show();
            }
        }

        private void HideEnduranceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HideEnduranceCheckBox.Checked == true)
            {
                EnduranceBox.Hide();
            }
            else
            {
                EnduranceBox.Show();
            }
        }

        private void speedTrackBar_Scroll(object sender, EventArgs e)
        {
            warTimer.Interval = speedTrackBar.Value;
        }

        private void optionBtnOk_Click(object sender, EventArgs e)
        {
            gameOptionBox.Hide();
        }

        private void resetOptionsButton_Click(object sender, EventArgs e)
        {
            speedTrackBar.Value = 1400;
            warTimer.Interval = 1400;
            ClearLinesCheckBox.Checked = false;
        }
        #endregion

        #region ButtonTextChanger
        //Dont really need to touch these two bools
        public bool IsOn
        {
            get
            {
                return _IsOn;
            }
            set
            {
                _IsOn = value;
                StartButton.Text = _IsOn ? "Reset" : "Start";
            }
        }
        public bool IsPause
        {
            get
            {
                return _IsPause;
            }
            set
            {
                _IsPause = value;
                PauseButton.Text = _IsPause ? "Unpause" : "Pause";
            }
        }

        #endregion
    }
}
