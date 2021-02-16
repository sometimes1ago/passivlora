using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passiflora
{
    public partial class Cashier : Form
    {
        private Form FormToOpen;
        public Cashier(Authorizaion auth)
        {
            InitializeComponent();
            FormToOpen = auth;
        }
    }
}
