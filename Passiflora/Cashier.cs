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

        private void SortButton_Click(object sender, EventArgs e)
        {
            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            string Query = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(Query);
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            SortOptions.SelectedItem = "Номеру";
            OrderOptions.SelectedItem = "Возрастанию";

            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());

            string Query = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(Query);

            DB.SearchValuesQuery("select Имя, Отчество from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин =" + "\'" + DB.AuthorizedUser + "\'");
            GreetingLabel.Text = "Здравствуйте, " + DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DB.AuthorizedUser = null;
            Hide();
            Authorizaion auth = new Authorizaion();
            auth.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string SearchBy = DB.GetSortMode(SearchOpt.SelectedItem.ToString());
                string SearchQuery = "select * from GetAllUsersOrders where " + SearchBy + " = " + "\'" + SearchValueInput.Text + "\'";
                OrdersData.DataSource = DB.SearchValuesQuery(SearchQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ChangeStatusQuery = "update Заказы set Статус_заказа = " + "\'" + OrderStatusOptions.SelectedItem.ToString() + "\'" +
                "where ID_Заказа = " + "\'" + OrderNumberInput.Text + "\'";
                DB.Execute(ChangeStatusQuery);
                MessageBox.Show($@"Статус заказа под номером {OrderNumberInput.Text} успешно обновлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
