using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passiflora
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();

        }

        private void CheckProdsButton_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            Hide();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            PrivateFontCollection f = new PrivateFontCollection();
            f.AddFontFile("../../Fonts/ElMessiri.ttf");

            MainHeader.Font = new Font(f.Families[0], 36);
        }
    }
}
