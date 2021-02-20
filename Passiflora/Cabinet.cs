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
            //Получение общей стоимости всех заказов пользователя
            string GetUserAmount = "select sum(Заказы.Сумма_заказа) from Заказы inner join Заказы_клиентов on Заказы_клиентов.Заказ = Заказы.ID_Заказа inner join Клиенты on Заказы_клиентов.Клиент = Клиенты.ID_Клиента inner join Пользователи on Клиенты.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин = " + "\'" + DB.AuthorizedUser + "\'";
            DB.SearchValuesQuery(GetUserAmount);
            UserOrdersAmount.Text += DB.ds.Tables[0].Rows[0][0].ToString();

            OrderData.DataSource = DB.SearchValuesQuery("execute GetOrdersByUsername " + "\'" + DB.AuthorizedUser + "\'");

            
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FormToOpen.Show();
        }

        private void Cabinet_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
