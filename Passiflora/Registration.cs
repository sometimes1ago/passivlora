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
    public partial class Registration : Form
    {
        private Form FormToOpen;
        public Registration(Authorizaion auth)
        {
            InitializeComponent();
            FormToOpen = auth;
        }

        private void ClearAllTextBoxes()
        {
            SurnameInput.Text = "";
            NameInput.Text = "";
            PhoneInput.Text = "";
            LoginInput.Text = "";
            PasswordInput.Text = "";
            PasswordConfirmInput.Text = "";
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartRegistration_Click(object sender, EventArgs e)
        {
            //Генерация секретного ключа
            string SecretKey = DB.GenerateSecretKey("QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890", 10);

            //Запрос на регистрацию включая вставку уже созданного секретного ключа
            string RegisterQuery =
            "insert into Пользователи(Логин, Пароль, Роль, Ключ) values(" + "\'" + LoginInput.Text + "\'" + "," +
            "\'" + PasswordInput.Text + "\'" + "," + "'1', " + "\'" + SecretKey + "\')";

            //Получение максимального ID среди пользователей
            string GetMaxUserID = "select max(ID_Пользователя) from Пользователи inner join Роли_Пользователей on Пользователи.Роль = Роли_Пользователей.ID_Роли  where Роли_Пользователей.Наименование = 'Пользователь'";

            try
            {
                if (SurnameInput.Text != "" && NameInput.Text != "" && PhoneInput.Text != "" && LoginInput.Text != "" &&
                    PasswordInput.Text != "" && PasswordConfirmInput.Text != "")
                {
                    if (LoginInput.Text.Length > 5 && PasswordInput.Text.Length > 5)
                    {
                        if (PasswordInput.Text == PasswordConfirmInput.Text)
                        {
                            //Выполнение регистрации пользователя
                            DB.Execute(RegisterQuery);
                            //Получение максимального ID среди пользователей
                            DB.SearchValuesQuery(GetMaxUserID);
                            string MaxUserID = DB.ds.Tables[0].Rows[0][0].ToString();

                            //Запрос связывающий данные нового клиента с данными для его авторизации
                            string GiveClientAuthData = "insert into Клиенты(Фамилия, Имя, Телефон, Данные_для_входа) values(" + "\'" +
                                SurnameInput.Text + "\'" + "," + "\'" + NameInput.Text + "\'" + "," + "\'" + PhoneInput.Text + "\'" +
                                "," + "\'" + MaxUserID + "\'" + ")";

                            DB.Execute(GiveClientAuthData);

                            MessageBox.Show($@"Вы успешно зарегистрировались! Ваш секретный ключ для восстановления пароля: {SecretKey}. Пожалуйста, запишите его!");

                            Hide();
                            ClearAllTextBoxes();
                            FormToOpen.Show();
                        }
                        else
                        {
                            throw new Exception("Пароли не совпадают!");
                        }
                    }
                    else
                    {
                        throw new Exception("Логин и пароль не могут быть короче 5 символов!");
                    }
                }
                else
                {
                    throw new Exception("Все поля обязательны для заполнения! Проверьте правильность ввода данных!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormToOpen.Show();
            Hide();
            ClearAllTextBoxes();
        }

    }
}
