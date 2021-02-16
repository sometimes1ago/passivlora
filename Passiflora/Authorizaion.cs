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
    public partial class Authorizaion : Form
    {
        private bool IsCorrect = false;
        private string UserRole;
        private string GetLoginData = "select Пользователи.Логин, Пользователи.Пароль, Роли_Пользователей.Наименование from Пользователи inner join Роли_Пользователей on Пользователи.Роль = Роли_Пользователей.ID_Роли";

        public Authorizaion()
        {
            InitializeComponent();
            ShowPass();
        }

        private void Authorizaion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработка события при нажатии на кнопку авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPots_Click(object sender, EventArgs e)
        {
            try
            {
                /*Данный код получает данные всех пользователей и сравнивает с введенными.
                 * Если такой пользователь существует, то проверяется его роль и ему открывается форма
                 с соответствующим уровнем доступа*/
                DB.SearchValuesQuery(GetLoginData);

                for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
                {
                    if (LoginInput.Text == DB.ds.Tables[0].Rows[i][0].ToString() && PasswordInput.Text == DB.ds.Tables[0].Rows[i][1].ToString())
                    {
                        UserRole = DB.ds.Tables[0].Rows[i][2].ToString();
                        //Вызов метода на установку авторизованного пользователя
                        DB.SetAuthorizedUser(DB.ds.Tables[0].Rows[i][0].ToString());
                        IsCorrect = true;

                        switch (UserRole)
                        {
                            case "Пользователь":
                                Hide();
                                //Обновляем форму продуктов чтобы взялись данные для авторизованного юзера
                                Products products = new Products();
                                products.Show();
                                break;
                            case "Кассир":
                                Hide();
                                Cashier cash = new Cashier(this);
                                cash.Show();
                                break;
                            case "Администратор":
                                Hide();
                                Administrator admin = new Administrator(this);
                                admin.Show();
                                break;
                        }
                    }
                }
                if (!IsCorrect)
                {
                    throw new Exception("Неправильный логин или пароль");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод показывающий и скрывающий пароль в зависимости от чекбокса Показать пароль
        /// </summary>
        private void ShowPass()
        {
            if (ShowPassword.Checked)
            {
                PasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            ShowPass();
        }

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration reg = new Registration(this);
            reg.Show();
            Hide();
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Products prods = new Products();
            prods.Show();
            Hide();
        }

        private void DataRecoverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataRecover dr = new DataRecover();
            dr.Show();
        }
    }
}
