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
    public partial class Administrator : Form
    {
        private Form FormToOpen;
        public Administrator(Authorizaion auth)
        {
            InitializeComponent();
            FormToOpen = auth;
        }
    }
}
