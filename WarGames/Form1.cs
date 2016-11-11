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
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Input;

namespace WarGames
{
    public partial class Form1 : Form
    {
        WOPR wop = new WOPR();
        List<Countries> countriesAtWar = new List<Countries>();
        private List<Point> Points = new List<Point>();

        private bool _IsOn;
        private bool _IsPause;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;

        public Form1()
        {
            Application.Run(new IntroMenu());       
            InitializeComponent();
            EnduranceListBox.DataSource = countriesAtWar;

            byte[] fontData = Properties.Resources.WarGames;
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.WarGames.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.WarGames.Length, IntPtr.Zero, ref dummy);
            Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 20.0F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Paint += new PaintEventHandler(Background_Paint);
            StartButton.Font = myFont;
            PauseButton.Font = myFont;
            CustomizeGameBtn.Font = myFont;
        }

        //private void Background_Paint(object sender, PaintEventArgs e)
        //{

        //    //Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
        //    //pen.StartCap = LineCap.ArrowAnchor;
        //    //pen.EndCap = LineCap.RoundAnchor;
        //    //e.Graphics.DrawLine(pen, 20, 175, 300, 175);

        //    //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        //    //foreach (Point point in Points)
        //    //    e.Graphics.FillEllipse(Brushes.Black,
        //    //        point.X - 3, point.Y - 3, 5, 5);
        //    //if (Points.Count < 3) return;

        //    //e.Graphics.DrawCurve(Pens.Red, Points.ToArray());
        //}

        //private void Background_MouseClick(object sender, MouseEventArgs e)
        //{
        //    Points.Add(e.Location);
        //    Refresh();
        //}
        
        //private void mnuCurveNew_Click(object sender, EventArgs e)
        //{
        //    Points = new List<Point>();
        //    Refresh();
        //}

        private void PauseButton_Click(object sender, EventArgs e)
        {
            IsPause = !IsPause;
            if (IsPause)
            {
                //pause the war
            }
            if (!IsPause)
            {
                //unpause the war
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //"Start" text turns to Stop while the game is running
            IsOn = !IsOn;
            if (IsOn)
            {
                //if the user havent visited the "customize" section the when pressed it will create a list of countries with default stats
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
                //start the program using the list with stats from the "customize" section
                else
                {
                    PauseButton.Enabled = true;
                    CustomizeGameBtn.Enabled = false;
                }
            }
            if (!IsOn)
            {
                //stops the war and reset the list 
                //yes Stop also works as a reset button
                countriesAtWar.Clear();
                PauseButton.Enabled = false;
                CustomizeGameBtn.Enabled = true;
                if (IsPause)
                {
                    IsPause = !IsPause;
                }
                IsPause = IsPause;
            }
        }

        //gets the stats from the "customize" section and updates all country stat labels and add the stats to a list
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

                //Sweden
                SwedenDurLabel.Text = "Durability: " + css.SwedenDurability.ToString();
                SwedenStrengthLabel.Text = "Strength: " + css.SwedenStrength.ToString();
                SwedenRepLabel.Text = "Reputation: " + css.SwedenRep.ToString();
                countriesAtWar.Add(new Countries("Sweden", css.SwedenDurability, css.SwedenStrength, css.SwedenRep));

                //North Korea
                NKDurLabel.Text = "Durability: " + css.NorthKoreaDurability.ToString();
                NKStrengthLabel.Text = "Strength: " + css.NorthKoreaStrength.ToString();
                NKRepLabel.Text = "Reputation: " + css.NorthKoreaRep.ToString();
                countriesAtWar.Add(new Countries("North Korea", css.NorthKoreaDurability, css.NorthKoreaStrength, css.NorthKoreaRep));
            }
            css.Close();
            css.Dispose();
        }

        //Exits the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                StartButton.Text = _IsOn ? "Stop" : "Start";
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
       
        //Find the coordinates of each country through a textbox on the main form.
        private void Background_MouseClick(object sender, MouseEventArgs e)
        {
            MouseClick += new MouseEventHandler(Background_MouseClick);
            int myX = e.X;
            int myY = e.Y;

            textBox1.Text = "X: " + e.X + "" + "\n" + "Y: " + e.Y;

        }
    }
}
