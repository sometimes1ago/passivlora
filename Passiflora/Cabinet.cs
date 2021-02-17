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
    public partial class Cabinet : Form
    {
        private Form FormToOpen;
        public Cabinet(Products prods)
        {
            InitializeComponent();
            FormToOpen = prods;
        }

        private void Cabinet_Load(object sender, EventArgs e)
        {
            OrderData.DataSource = DB.SearchValuesQuery("execute GetOrdersByUsername " + "\'" + DB.AuthorizedUser + "\'");
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToOpen.Show();
        }
    }
}
