﻿using System;
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
    public partial class Bouquets : Form
    {
        public Bouquets()
        {
            InitializeComponent();
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products prods = new Products();
            prods.Show();
            Hide();
            
        }

        private void Bouquets_Load(object sender, EventArgs e)
        {
            //Установка значений по умолчанию для сортировки данных из БД
            SortOptions.SelectedItem = "Имени";
            OrderOptions.SelectedItem = "Возрастанию";
            RangeFrom.Text = "0";
            RangeTo.Text = "5000";

            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            int PriceFrom = Convert.ToInt32(RangeFrom.Text);
            int PriceTo = Convert.ToInt32(RangeTo.Text);

            BqData.DataSource = DB.GetAllProds("Букеты",SortOpt,OrderOpt,PriceFrom, PriceTo);

            if (DB.AuthorizedUser == null)
            {
                OrderButton.Enabled = false;
                AuthRequiredLabel.Text = "Для оформления заказа необходимо авторизоваться!";
            }
            else
            {
                OrderButton.Enabled = true;
                AuthRequiredLabel.Text = "Вы авторизованы! Приятных покупок! :)";
            }

            DB.GetAllProdNames("Букеты");

            for (int i = 0; i <  DB.ds.Tables[0].Rows.Count; i++)
            {
                ProdNames.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }

            ProdNames.SelectedItem = "Букет Весеннее настроение";
        }

        private void Bouquets_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            int PriceFrom = Convert.ToInt32(RangeFrom.Text);
            int PriceTo = Convert.ToInt32(RangeTo.Text);
            BqData.DataSource = DB.GetAllProds("Букеты", SortOpt, OrderOpt, PriceFrom, PriceTo);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Order ord = new Order();

            try
            {
                if (int.TryParse(Count.Text, out int count))
                {
                    ord.SetSelectedProduct(ProdNames.SelectedItem.ToString());
                    ord.SetSelectedProdCount(count);
                    ord.Show();
                    Count.Text = "";
                } 
                else
                {
                    throw new Exception("Вы должны выбрать товар для заказа и указать количество не меньше 1!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
