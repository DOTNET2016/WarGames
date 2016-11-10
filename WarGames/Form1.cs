using System;
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
using System.Drawing.Drawing2D;

namespace WarGames
{
    public partial class Form1 : Form
    {
        WOPR wop = new WOPR();
        List<Countries> countriesAtWar = new List<Countries>();
        private List<Point> Points = new List<Point>();

        public Form1()
        {
            Application.Run(new IntroMenu());       
            InitializeComponent();
            EnduranceListBox.DataSource = countriesAtWar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Paint += new PaintEventHandler(Background_Paint);
        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            foreach (Point point in Points)
                e.Graphics.FillEllipse(Brushes.Black,
                    point.X - 3, point.Y - 3, 5, 5);
            if (Points.Count < 3) return;

            e.Graphics.DrawCurve(Pens.Red, Points.ToArray());
        }

        private void Background_MouseClick(object sender, MouseEventArgs e)
        {
            Points.Add(e.Location);
            Refresh();
        }
        
        private void mnuCurveNew_Click(object sender, EventArgs e)
        {
            Points = new List<Point>();
            Refresh();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            //"Start" text turns to Stop while the game is running
            ((CurrencyManager)EnduranceListBox.BindingContext[countriesAtWar]).Refresh();
            //UpdateUSAGroupBox();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            //Popup.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomizeGameBtn_Click(object sender, EventArgs e)
        {
            CustomSettingsScreen css = new CustomSettingsScreen();
            if (css.ShowDialog(this) == DialogResult.OK)
            {
                //USA
                USADurLabel.Text = "Durability: " + css.USADurability.ToString();
                USAStrengthLabel.Text = "Strength: " + css.USAStrength.ToString();
                USARepLabel.Text = "Reputation: " + css.USARep.ToString();
                countriesAtWar.Add(new Countries("USA", css.USADurability, css.USAStrength, css.USARep));
                
                //Russia
                RussiaDurLabel.Text = "Durability: " + css.RussiaDurability.ToString();
                RussiaStrengthLabel.Text = "Strength: " + css.RussiaStrength.ToString();
                RussiaRepLabel.Text = "Reputation: " + css.RussiaRep.ToString();
                countriesAtWar.Add(new Countries("Russia", css.RussiaDurability, css.RussiaStrength, css.RussiaRep));
                
                //UK
                UkDurLabel.Text = "Durability: " + css.UkDurability.ToString();
                UkStrengthLabel.Text = "Strength: " + css.UkStrength.ToString();
                UkRepLabel.Text = "Reputation: " + css.UkRep.ToString();
                countriesAtWar.Add(new Countries("UK", css.UkDurability, css.UkStrength, css.UkRep));
                
                //China
                ChinaDurLabel.Text = "Durability: " + css.ChinaDurability.ToString();
                ChinaStrengthLabel.Text = "Strength: " + css.ChinaStrength.ToString();
                ChinaRepLabel.Text = "Reputation: " + css.ChinaRep.ToString();
                countriesAtWar.Add(new Countries("China", css.ChinaDurability, css.ChinaStrength, css.ChinaRep));
                
                //France
                FranceDurLabel.Text = "Durability: " + css.FranceDurability.ToString();
                FranceStrengthLabel.Text = "Strength: " + css.FranceStrength.ToString();
                FranceRepLabel.Text = "Reputation: " + css.FranceRep.ToString();
                countriesAtWar.Add(new Countries("France", css.FranceDurability, css.FranceStrength, css.FranceRep));
                
                //India
                IndiaDurLabel.Text = "Durability: " + css.IndiaDurability.ToString();
                IndiaStrengthLabel.Text = "Strength: " + css.IndiaStrength.ToString();
                IndiaRepLabel.Text = "Reputation: " + css.IndiaRep.ToString();
                countriesAtWar.Add(new Countries("India", css.IndiaDurability, css.IndiaStrength, css.IndiaRep));

                //Germany
                GermanyDurLabel.Text = "Durability: " + css.GermanyDurability.ToString();
                GermanyStrengthLabel.Text = "Strength: " + css.GermanyStrength.ToString();
                GermanyRepLabel.Text = "Reputation: " + css.GermanyRep.ToString();
                countriesAtWar.Add(new Countries("Germany", css.GermanyDurability, css.GermanyStrength, css.GermanyRep));

                //Japan
                JapanDurLabel.Text = "Durability: " + css.JPDurability.ToString();
                JapanStrengthLabel.Text = "Strength: " + css.JPStrength.ToString();
                JapanRepLabel.Text = "Reputation: " + css.JPRep.ToString();
                countriesAtWar.Add(new Countries("Japan", css.JPDurability, css.JPStrength, css.JPRep));
            }
            css.Close();
            css.Dispose();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (countriesAtWar.Count == 0)
            {
                countriesAtWar.Add(new Countries("USA", 20, 5, 4));
                countriesAtWar.Add(new Countries("Russia", 20, 5, 4));
                countriesAtWar.Add(new Countries("UK", 10, 3, 7));
                countriesAtWar.Add(new Countries("China", 20, 5, 5));
                countriesAtWar.Add(new Countries("France", 15, 3, 7));
                countriesAtWar.Add(new Countries("India", 17, 4, 7));
                countriesAtWar.Add(new Countries("Germany", 15, 4, 8));
                countriesAtWar.Add(new Countries("Japan", 10, 3, 7));
                countriesAtWar.Add(new Countries("Sweden", 13, 2, 10));
                countriesAtWar.Add(new Countries("North Korea", 14, 6, 1));
                PauseButton.Enabled = true;
                CustomizeGameBtn.Enabled = false;
            }
            else
            {
                PauseButton.Enabled = true;
                CustomizeGameBtn.Enabled = false;
            }
        }
    }
}
