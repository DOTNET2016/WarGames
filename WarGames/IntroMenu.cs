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
    public partial class IntroMenu : Form
    {
        public IntroMenu()
        {
            InitializeComponent();
        }

        private void PlayGameBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomizeGameBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
