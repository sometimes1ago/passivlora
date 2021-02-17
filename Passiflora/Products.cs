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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            CheckAuthorizedUser();
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Метод, проверяющий какой пользователь авторизовался
        /// </summary>
        private void CheckAuthorizedUser()
        {
            if (DB.AuthorizedUser == null)
            {
                AuthLink.Text = "Авторизация";
                LoginIcon.Visible = true;
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            if (DB.AuthorizedUser == null)
            {
                AuthLink.Text = "Авторизация";
                LoginIcon.Visible = Visible;
                LogoutLink.Visible = false;
                CabinetLink.Visible = false;
            }
            else
            {
                DB.SearchValuesQuery("select Имя, Фамилия from Клиенты inner join Пользователи on Клиенты.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин =" + "\'" + DB.AuthorizedUser + "\'");
                LoginIcon.Visible = false;
                AuthLink.Margin = new Padding(0, 0, 0, 100);
                AuthLink.Text = "Здравствуйте, " + DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
                LogoutLink.Visible = true;
                CabinetLink.Visible = true;
            }
        }

        private void AuthLink_Click(object sender, EventArgs e)
        {
            if (AuthLink.Text == "Авторизация")
            {
                Authorizaion auth = new Authorizaion();
                auth.Show();
                Hide();
            }
        }

        private void ShowBouquets_Click(object sender, EventArgs e)
        {
            Bouquets bq = new Bouquets();
            Hide();
            bq.Show();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DB.AuthorizedUser = null;
            Hide();
            Authorizaion auth = new Authorizaion();
            auth.Show();
        }

        private void ShowFlowers_Click(object sender, EventArgs e)
        {
            Flowers fl = new Flowers();
            Hide();
            fl.Show();
        }

        private void ShowPots_Click(object sender, EventArgs e)
        {
            Pots pt = new Pots();
            Hide();
            pt.Show();
        }

        private void ShowGardenPlants_Click(object sender, EventArgs e)
        {
            GardenFlowers gf = new GardenFlowers();
            Hide();
            gf.Show();
        }

        private void ShowRoomPlants_Click(object sender, EventArgs e)
        {
            RoomPlants rp = new RoomPlants();
            Hide();
            rp.Show();
        }

        private void ShowPlantCareProds_Click(object sender, EventArgs e)
        {
            PlantCare pc = new PlantCare();
            Hide();
            pc.Show();
        }

        private void CabinetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cabinet cb = new Cabinet(this);
            Hide();
            cb.Show();
        }
    }
}
