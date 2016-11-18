using System;
using System.Drawing;
using System.Windows.Forms;

namespace WarGames
{
    public partial class CustomSettingsScreen : Form
    {
        WOPR warRoom = new WOPR();

        private Timer _CountDownTimer;

        private int _counter = 5;
        private int _hours = 00;

        #region CountriesProperties&Fields
        private int _usaDurability;
        private int _usaStrength;
        private int _usaRep;

        private int _russiaDurability;
        private int _russiaStrength;
        private int _russiaRep;

        private int _ukDurability;
        private int _ukStrength;
        private int _ukRep;

        private int _chinaDurability;
        private int _chinaStrength;
        private int _chinaRep;

        private int _franceDurability;
        private int _franceStrength;
        private int _franceRep;

        private int _indiaDurability;
        private int _indiaStrength;
        private int _indiaRep;

        private int _germanyDurability;
        private int _germanyStrength;
        private int _germanyRep;

        private int _japanDurability;
        private int _japanStrength;
        private int _japanRep;

        private int _swedenDurability;
        private int _swedenStrength;
        private int _swedenRep;

        private int _northKoreaDurability;
        private int _northKoreaStrength;
        private int _northKoreaRep;

        public int USADurability
        {
            get
            {
                if (_usaDurability == 0)
                {
                    return (int)USA_Durability.Value;
                }
                return _usaDurability;
            }
            set
            {
                _usaDurability = value;
            }
        }
        public int USAStrength
        {
            get
            {
                if (_usaStrength == 0)
                {
                    return (int)USA_Strength.Value;
                }
                return _usaStrength;
            }
            set
            {
                _usaStrength = value;
            }
        }
        public int USARep
        {
            get
            {
                if (_usaRep == 0)
                {
                    return (int)USA_Rep.Value;
                }
                return _usaRep;
            }
            set
            {
                _usaRep = value;
            }
        }

        public int RussiaDurability
        {
            get
            {
                if (_russiaDurability == 0)
                {
                    return (int)Russia_Durability.Value;
                }
                return _russiaDurability;
            }
            set
            {
                _russiaDurability = value;
            }
        }
        public int RussiaStrength
        {
            get
            {
                if (_russiaStrength == 0)
                {
                    return (int)Russia_Strength.Value;
                }
                return _russiaStrength;
            }
            set
            {
                _russiaStrength = value;
            }
        }
        public int RussiaRep
        {
            get
            {
                if (_russiaRep == 0)
                {
                    return (int)Russia_Rep.Value;
                }
                return _russiaRep;
            }
            set
            {
                _russiaRep = value;
            }
        }

        public int UkDurability
        {
            get
            {
                if (_ukDurability == 0)
                {
                    return (int)UK_Durability.Value;
                }
                return _ukDurability;
            }

            set
            {
                _ukDurability = value;
            }
        }
        public int UkStrength
        {
            get
            {
                if (_ukStrength == 0)
                {
                    return (int)UK_Strength.Value;
                }
                return _ukStrength;
            }

            set
            {
                _ukStrength = value;
            }
        }
        public int UkRep
        {
            get
            {
                if (_ukRep == 0)
                {
                    return (int)UK_Rep.Value;
                }
                return _ukRep;
            }

            set
            {
                _ukRep = value;
            }
        }

        public int ChinaDurability
        {
            get
            {
                if (_chinaDurability == 0)
                {
                    return (int)China_Rep.Value;
                }
                return _chinaDurability;
            }

            set
            {
                _chinaDurability = value;
            }
        }
        public int ChinaStrength
        {
            get
            {
                if (_chinaStrength == 0)
                {
                    return (int)China_Strength.Value;
                }
                return _chinaStrength;
            }

            set
            {
                _chinaStrength = value;
            }
        }
        public int ChinaRep
        {
            get
            {
                if (_chinaRep == 0)
                {
                    return (int)China_Rep.Value;
                }
                return _chinaRep;
            }

            set
            {
                _chinaRep = value;
            }
        }

        public int FranceDurability
        {
            get
            {
                if (_franceDurability == 0)
                {
                    return (int)France_Durability.Value;
                }
                return _franceDurability;
            }

            set
            {
                _franceDurability = value;
            }
        }
        public int FranceStrength
        {
            get
            {
                if (_franceStrength == 0)
                {
                    return (int)France_Strength.Value;
                }
                return _franceStrength;
            }

            set
            {
                _franceStrength = value;
            }
        }
        public int FranceRep
        {
            get
            {
                if (_franceRep == 0)
                {
                    return (int)France_Rep.Value;
                }
                return _franceRep;
            }
            set
            {
                _franceRep = value;
            }
        }

        public int IndiaDurability
        {
            get
            {
                if (_indiaDurability == 0)
                {
                    return (int)India_Durability.Value;
                }
                return _indiaDurability;
            }
            set
            {
                _indiaDurability = value;
            }
        }
        public int IndiaStrength
        {
            get
            {
                if (_indiaStrength == 0)
                {
                    return (int)India_Strength.Value;
                }
                return _indiaStrength;
            }
            set
            {
                _indiaStrength = value;
            }
        }
        public int IndiaRep
        {
            get
            {
                if (_indiaRep == 0)
                {
                    return (int)India_Rep.Value;
                }
                return _indiaRep;
            }

            set
            {
                _indiaRep = value;
            }
        }

        public int GermanyDurability
        {
            get
            {
                if (_germanyDurability == 0)
                {
                    return (int)Germany_Durability.Value;
                }
                return _germanyDurability;
            }
            set
            {
                _germanyDurability = value;
            }
        }
        public int GermanyStrength
        {
            get
            {
                if (_germanyStrength == 0)
                {
                    return (int)Germany_Strength.Value;
                }
                return _germanyStrength;
            }
            set
            {
                _germanyStrength = value;
            }
        }
        public int GermanyRep
        {
            get
            {
                if (_germanyRep == 0)
                {
                    return (int)Germany_Rep.Value;
                }
                return _germanyRep;
            }
            set
            {
                _germanyRep = value;
            }
        }

        public int JPDurability
        {
            get
            {
                if (_japanDurability == 0)
                {
                    return (int)Japan_Durability.Value;
                }
                return _japanDurability;
            }
            set
            {
                _japanDurability = value;
            }
        }
        public int JPStrength
        {
            get
            {
                if (_japanStrength == 0)
                {
                    return (int)Japan_Strength.Value;
                }
                return _japanStrength;
            }
            set
            {
                _japanStrength = value;
            }
        }
        public int JPRep
        {
            get
            {
                if (_japanRep == 0)
                {
                    return (int)Japan_Rep.Value;
                }
                return _japanRep;
            }
            set
            {
                _japanRep = value;
            }
        }

        public int SwedenDurability
        {
            get
            {
                if (_swedenDurability == 0)
                {
                    return (int)Sweden_Durability.Value;
                }
                return _swedenDurability;
            }
            set
            {
                _swedenDurability = value;
            }
        }
        public int SwedenStrength
        {
            get
            {
                if (_swedenStrength == 0)
                {
                    return (int)Sweden_Strength.Value;
                }
                return _swedenStrength;
            }

            set
            {
                _swedenStrength = value;
            }
        }
        public int SwedenRep
        {
            get
            {
                if (_swedenRep == 0)
                {
                    return (int)Sweden_Rep.Value;
                }
                return _swedenRep;
            }
            set
            {
                _swedenRep = value;
            }
        }

        public int NorthKoreaDurability
        {
            get
            {
                if (_northKoreaDurability == 0)
                {
                    return (int)Sweden_Rep.Value;
                }
                return _northKoreaDurability;
            }
            set
            {
                _northKoreaDurability = value;
            }
        }
        public int NorthKoreaStrength
        {
            get
            {
                if (_northKoreaStrength == 0)
                {
                    return (int)NorthKorea_Strength.Value;
                }
                return _northKoreaStrength;
            }
            set
            {
                _northKoreaStrength = value;

            }
        }
        public int NorthKoreaRep
        {
            get
            {
                if (_northKoreaRep == 0)
                {
                    return (int)NorthKorea_Rep.Value;
                }
                return _northKoreaRep;
            }
            set
            {
                _northKoreaRep = value;
            }
        }
        #endregion//All 

        public CustomSettingsScreen()
        {
            InitializeComponent();
        }

        private void CustomSettingsScreen_Load(object sender, EventArgs e)
        {
            BigRedButton.Font = warRoom.myFont1;
            GoBackButton.Font = warRoom.myFont1;
        }

        private void BigRedButton_Click(object sender, EventArgs e)
        {
            CountdownClock.Enabled = true;
            _CountDownTimer = new Timer();
            _CountDownTimer.Tick += _CountDownTimer_Tick;
            _CountDownTimer.Interval = 1000;
            _CountDownTimer.Start();
            CountdownClock.Text = _hours.ToString("00") + ":" + _counter.ToString("00");

            BigRedButton.BackColor = Color.DarkRed;
            CountdownClock.ForeColor = Color.Red;
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
                DialogResult = DialogResult.OK;
            }
        }

        #region CountiresSettingsChanged
        //USA
        private void USA_Durability_ValueChanged(object sender, EventArgs e)
        {
            _usaDurability = (int)USA_Durability.Value;
        }

        private void USA_Strength_ValueChanged(object sender, EventArgs e)
        {
            _usaStrength = (int)USA_Strength.Value;

        }

        private void USA_Rep_ValueChanged(object sender, EventArgs e)
        {
            _usaRep = (int)USA_Rep.Value;
        }
        //Russia
        private void Russia_Durability_ValueChanged(object sender, EventArgs e)
        {
            _russiaDurability = (int)Russia_Durability.Value;
        }

        private void Russia_Strength_ValueChanged(object sender, EventArgs e)
        {
            _russiaStrength = (int)Russia_Strength.Value;
        }

        private void Russia_Rep_ValueChanged(object sender, EventArgs e)
        {
            _russiaRep = (int)Russia_Rep.Value;
        }
        //UK
        private void UK_Durability_ValueChanged(object sender, EventArgs e)
        {
            _ukDurability = (int)UK_Durability.Value;
        }

        private void UK_Strength_ValueChanged(object sender, EventArgs e)
        {
            _ukStrength = (int)UK_Strength.Value;
        }

        private void UK_Rep_ValueChanged(object sender, EventArgs e)
        {
            _ukRep = (int)UK_Rep.Value;
        }
        //China
        private void China_Durability_ValueChanged(object sender, EventArgs e)
        {
            _chinaDurability = (int)China_Durability.Value;
        }

        private void China_Strength_ValueChanged(object sender, EventArgs e)
        {
            _chinaStrength = (int)China_Strength.Value;
        }

        private void China_Rep_ValueChanged(object sender, EventArgs e)
        {
            _chinaRep = (int)China_Rep.Value;
        }
        //France
        //TYPO
        private void France_Durablity_ValueChanged(object sender, EventArgs e)
        {
            _franceDurability = (int)France_Durability.Value;
        }

        private void France_Strength_ValueChanged(object sender, EventArgs e)
        {
            _franceStrength = (int)France_Strength.Value;
        }

        private void France_Rep_ValueChanged(object sender, EventArgs e)
        {
            _franceRep = (int)France_Rep.Value;
        }
        //India
        private void India_Durability_ValueChanged(object sender, EventArgs e)
        {
            _indiaDurability = (int)India_Durability.Value;
        }

        private void India_Strength_ValueChanged(object sender, EventArgs e)
        {
            _indiaStrength = (int)India_Strength.Value;
        }

        private void India_Rep_ValueChanged(object sender, EventArgs e)
        {
            _indiaRep = (int)India_Rep.Value;
        }
        //Germany
        private void Germany_Durability_ValueChanged(object sender, EventArgs e)
        {
            _germanyDurability = (int)Germany_Durability.Value;
        }

        private void Germany_Strength_ValueChanged(object sender, EventArgs e)
        {
            _germanyStrength = (int)Germany_Strength.Value;
        }

        private void Germany_Rep_ValueChanged(object sender, EventArgs e)
        {
            _germanyRep = (int)Germany_Rep.Value;
        }
        //Japan
        private void Japan_Durability_ValueChanged(object sender, EventArgs e)
        {
            _japanDurability = (int)Japan_Durability.Value;
        }
        
        private void Japan_Strength_ValueChanged(object sender, EventArgs e)
        {
            _japanStrength = (int)Japan_Strength.Value;
        }

        private void Japan_Rep_ValueChanged(object sender, EventArgs e)
        {
            _japanRep = (int)Japan_Rep.Value;
        }
        //Sweden
        private void Sweden_Durability_ValueChanged(object sender, EventArgs e)
        {
            _swedenDurability = (int)Sweden_Durability.Value;
        }

        private void Sweden_Strength_ValueChanged(object sender, EventArgs e)
        {
            _swedenStrength = (int)Sweden_Strength.Value;
        }

        private void Sweden_Rep_ValueChanged(object sender, EventArgs e)
        {
            _swedenRep = (int)Sweden_Rep.Value;
        }
        //North Korea
        private void NorthKorea_Durability_ValueChanged(object sender, EventArgs e)
        {
            _northKoreaDurability = (int)NorthKorea_Durability.Value;
        }

        private void NorthKorea_Strength_ValueChanged(object sender, EventArgs e)
        {
            _northKoreaStrength = (int)NorthKorea_Strength.Value;
        }

        private void NorthKorea_Rep_ValueChanged(object sender, EventArgs e)
        {
            _northKoreaRep = (int)NorthKorea_Rep.Value;
        }

        #endregion
    }
}
