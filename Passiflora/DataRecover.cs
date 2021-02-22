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
    public partial class DataRecover : Form
    {
        public DataRecover()
        {
            InitializeComponent();
        }

        private void TipLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Секретный ключ - уникальный текстовый код, выданный вам при регистрации");
        }

        /*Обработка действия получения данных по секретному ключу*/
        private void ShowDataButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (!SecretKeyInput.Text.Equals(""))
                {
                    string GetUserdataByKey = "select Логин, Пароль from Пользователи where Ключ = " + "\'" + SecretKeyInput.Text + "\'";
                    DB.SearchValuesQuery(GetUserdataByKey);
                    MessageBox.Show($@"Ваши данные: Логин - {DB.ds.Tables[0].Rows[0][0].ToString()}. Пароль - {DB.ds.Tables[0].Rows[0][1].ToString()} ");
                    SecretKeyInput.Text = "";
                }
                else
                {
                    throw new Exception("Введите секретный ключ для получения данных!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
