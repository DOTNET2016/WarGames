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
            SetDefaultStats();
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
            PauseButton.Enabled = true;
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

        //private void UpdateUSAGroupBox()
        //{
        //    //USADurLabel.Text = ("Durability: ") + css.getUSADurability().ToString("");           
        //    USADurLabel.Text = ("Durability: ") + css.getUSADurability().ToString();
        //    USADurLabel.Refresh();

        //}

        public void SetDefaultStats()
        {
            Countries USA = new Countries("USA", 20, 5, 4);
            Countries Russia = new Countries("Russia", 20, 5, 4);
            Countries UK = new Countries("UK", 10, 3, 7);
            Countries China = new Countries("China", 20, 5, 5);
            Countries France = new Countries("France", 15, 3, 7);
            Countries India = new Countries("India", 17, 4, 7);
            Countries Germany = new Countries("Germany", 15, 4, 8);
            Countries Japan = new Countries("Japan", 10, 3, 7);
            Countries Sweden = new Countries("Sweden", 13, 2, 10);
            Countries NorthKorea = new Countries("North Korea", 3, 2, 1);

            USADurLabel.Text = ("Durability: ") + USA.Durability;
            USAStrengthLabel.Text = ("Strength: ") + USA.Strength;
            USARepLabel.Text = ("Reputation: ") + USA.Rep;

            RussiaDurLabel.Text = ("Durability: ") + Russia.Durability;
            RussiaStrengthLabel.Text = ("Strength: ") + Russia.Strength;
            RussiaRepLabel.Text = ("Reputation: ") + Russia.Rep;

        }

        private void CustomizeGameBtn_Click(object sender, EventArgs e)
        {
            CustomSettingsScreen css = new CustomSettingsScreen();
            if (css.ShowDialog(this) == DialogResult.OK)
            {
                USADurLabel.Text = ("Durability: ") + css.getUSADurability().ToString();
                USAStrengthLabel.Text = ("Strength: ") + css.getUSAStrength().ToString();
                USARepLabel.Text = ("Reputation: ") + css.getUSARep().ToString();
            }
            css.Close();
            css.Dispose();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
