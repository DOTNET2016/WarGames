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
        WOPR warRoom = new WOPR();
        private List<Point> Points = new List<Point>();


        private bool _IsOn;
        private bool _IsPause;

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        Font myFont;
        private List<PointF> bezierPoints;
        private PointF ctrl1;
        private PointF ctrl2;
        PointF usaPoint = new PointF(223, 239);
        PointF russiaPoint = new PointF(1006, 121);
        PointF ukPoint = new PointF(654, 156);
        PointF chinaPoint = new PointF(1105, 255);
        PointF francePoint = new PointF(667, 189);
        PointF indiaPoint = new PointF(1028, 322);
        PointF germanyPoint = new PointF(699, 164);
        PointF japanPoint = new PointF(1291, 240);
        PointF swedenPoint = new PointF(721, 114);
        PointF northkoreaPoint = new PointF(1226, 223);

        /// <Countries_Coordinates>
        /// USA = X: 223 Y:239
        /// Russia = X:1006 Y:121
        /// UK = X:654 Y:156
        /// China = X:1105 Y:255
        /// France = X:667 Y:189
        /// India = X:1028 Y:322
        /// Germany = X:699 Y:164
        /// Japan = X:1291 Y:240
        /// Sweden = X:721 Y:114
        /// North Korea = X:1226 Y:223
        /// </summary>

        public Form1()
        {
            Application.Run(new IntroMenu());       
            InitializeComponent();
            EnduranceListBox.DataSource = warRoom.countriesAtWar;

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
            Paint += new PaintEventHandler(Background_Paint);
            StartButton.Font = myFont;
            PauseButton.Font = myFont;
            CustomizeGameBtn.Font = myFont;
        }

        public void CreateCurve(PointF ctrl1, PointF ctrl2)
        {
            bezierPoints = new List<PointF>();
            bezierPoints.Clear();
            bezierPoints.Add(ctrl1);
            PointF midPoint1 = MidPoint(ctrl1, ctrl2);
            bezierPoints.Add(midPoint1);
            bezierPoints.Add(ctrl2);
    }

        private PointF MidPoint(PointF controlPoint1, PointF controlPoint2)
        {
            if (ctrl1.Y - ctrl2.Y >= 200 || ctrl2.Y - ctrl1.Y >= 200)
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) * 0.97f,
                ((controlPoint1.Y + controlPoint2.Y) / 2)
                );
            }
            else
            {
                return new PointF(
                ((controlPoint1.X + controlPoint2.X) / 2) ,
                ((controlPoint1.Y + controlPoint2.Y) / 2) * 0.9f
                );
            }
        }

        private void Background_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 2);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            ctrl1 = russiaPoint;
            ctrl2 = indiaPoint;
            CreateCurve(ctrl1, ctrl2);
            e.Graphics.DrawCurve(pen, bezierPoints.ToArray());
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            IsPause = !IsPause;
            if (IsPause)
            {
                //TODO pause the war
                warTimer.Start();
            }
            if (!IsPause)
            {
                //TODO unpause the war
                warTimer.Stop();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //"Start" text turns to Stop while the game is running
            IsOn = !IsOn;
            if (IsOn)
            {
                //if the user havent visited the "customize" section the when pressed it will create a list of countries with default stats
                if (warRoom.countriesAtWar.Count == 0)
                {
                    warRoom.CountryList();
                    warRoom.SortDurability();
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
                PauseButton.Enabled = false;
                CustomizeGameBtn.Enabled = true;
                warTimer.Stop();
                if (IsPause)
                {
                    IsPause = !IsPause;
                }
                IsPause = IsPause;
            }
            warRoom.SortDurability();
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
       
        //Find the coordinates of each country through a textbox on the main form. We can delete this method after we have the coordinates
        private void Background_MouseClick(object sender, MouseEventArgs e)
        {
            MouseClick += new MouseEventHandler(Background_MouseClick);
            int myX = e.X;
            int myY = e.Y;

            textBox1.Text = "X: " + e.X + "" + "\n" + "Y: " + e.Y;
        }

        private void warTimer_Tick(object sender, EventArgs e)
        {
            warRoom.AttackCountry();
            ((CurrencyManager)EnduranceListBox.BindingContext[warRoom.countriesAtWar]).Refresh();
        }
    }
}
