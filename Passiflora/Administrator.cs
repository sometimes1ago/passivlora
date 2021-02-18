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

        

        private void Administrator_Load(object sender, EventArgs e)
        {
            SortOptions.SelectedItem = "Номеру";
            OrderOptions.SelectedItem = "Возрастанию";
            SearchEmp.SelectedItem = "Фамилии";

            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());

            string GetQuery = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(GetQuery);

            string GetEmployeesQuery = "select * from GetAllEmployees";
            EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);

            DB.SearchValuesQuery("select Имя, Отчество from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин =" + "\'" + DB.AuthorizedUser + "\'");
            GreetingLabel.Text = "Здравствуйте, " + DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Обработка действий на странице с заказами

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(OrderDeletableInput.Text,out int OrderNumber))
                {
                    //Запрос на удаление заказа клиентов
                    string DropFromUserOrders = "delete from Заказы_клиентов where Заказ = " + "\'" + OrderNumber + "\'";
                    DB.Execute(DropFromUserOrders);

                    //Запрос на удаление конкретно заказа
                    string DeleteQuery = "delete from Заказы where ID_Заказа = " + "\'" + OrderNumber + "\'";
                    DB.Execute(DeleteQuery);

                    var result = MessageBox.Show($@"Заказ с номером {OrderNumber} успешно удален!", "Отчет об операции", MessageBoxButtons.OK);

                    //Получение параметров сортировки
                    string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
                    string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());

                    //Обновление данных в таблице согласно сортировочным параметрам
                    string GetQuery = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
                    OrdersData.DataSource = DB.SearchValuesQuery(GetQuery);
                }
                else
                {
                    throw new Exception("Номер заказа должен быть целочисленым значением!");
                }
                OrderDeletableInput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            string Query = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(Query);
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

        #endregion

        #region Обработка действий на странице с сотрудниками
        private void SearchEmpButton_Click(object sender, EventArgs e)
        {
            //Запрос на поиск определенного сотрудника по фамилии
            string GetEmployeesQuery = "select * from GetAllEmployees where Фамилия = " + "\'" + SearchEmpValue.Text + "\'";
            EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);
        }

        /// <summary>
        /// Метод очищающий введенные поля при добавлении сотрудника
        /// </summary>
        private void ClearAllTextBoxes()
        {
            SurnameInput.Text = "";
            NameInput.Text = "";
            PhoneInput.Text = "";
            LoginInput.Text = "";
            PasswordInput.Text = "";
            LastNameInput.Text = "";
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            //Генерация секретного ключа
            string SecretKey = DB.GenerateSecretKey("QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890", 10);
            //Идентификатор назначаемой роли
            int SwitchedRole = 0;

            //Проверка назначаемой роли
            switch (EmpRole.SelectedItem)
            {
                case "Кассир":
                    SwitchedRole = 2;
                    break;
                case "Администратор":
                    SwitchedRole = 3;
                    break;
            }

            try
            {
                if (SurnameInput.Text != "" && NameInput.Text != "" && PhoneInput.Text != "" && LoginInput.Text != "" &&
                    PasswordInput.Text != "")
                {
                    if (LoginInput.Text.Length > 5 && PasswordInput.Text.Length > 5)
                    {
                        //Запрос на регистрацию включая вставку уже созданного секретного ключа
                        string RegisterQuery =
                        "insert into Пользователи(Логин, Пароль, Роль, Ключ) values(" + "\'" + LoginInput.Text + "\'" + "," +
                        "\'" + PasswordInput.Text + "\'" + "," + "\'" + SwitchedRole + "\'" + "," + "\'" + SecretKey + "\')";
                        DB.Execute(RegisterQuery);

                        //Получение максимального ID среди сотрудников согласно выбранной роли
                        string GetMaxUserID = "select max(ID_Пользователя) from Пользователи inner join Роли_Пользователей on Пользователи.Роль = Роли_Пользователей.ID_Роли  where Роли_Пользователей.Наименование = " + "\'" + EmpRole.SelectedItem + "\'";
                        
                        //Получение максимального ID среди пользователей
                        DB.SearchValuesQuery(GetMaxUserID);
                        string MaxUserID = DB.ds.Tables[0].Rows[0][0].ToString();

                        //Запрос связывающий данные нового сотрудника с данными для его авторизации
                        string GiveEmpAuthData = "insert into Сотрудники(Фамилия, Имя, Отчество, Телефон, Данные_для_входа) values(" + "\'" +
                            SurnameInput.Text + "\'" + "," + "\'" + NameInput.Text + "\'" + "," + "\'" + LastNameInput.Text + "\'" + "," + "\'" + PhoneInput.Text + "\'" +
                            "," + "\'" + MaxUserID + "\'" + ")";
                        DB.Execute(GiveEmpAuthData);

                        MessageBox.Show($@"Вы успешно добавили сотрудника! Секретный ключ для восстановления пароля: {SecretKey}. Пожалуйста, запишите его!");
                        ClearAllTextBoxes();

                        //Обновление данных в таблице
                        string GetEmployeesQuery = "select * from GetAllEmployees";
                        EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);
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

        private void DeleteEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Получение ID данных для авторизации сотрудника согласно его имени и фамилии
                string GetEmpUserdata = "select ID_Пользователя from Пользователи " +
                "inner join Сотрудники on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя " +
                "where Сотрудники.Фамилия = " + "\'" + DeletableSurnameInput.Text + "\'" + " and " + "Сотрудники.Имя = " +
                "\'" + DeletableNameInput.Text + "\'";
                DB.SearchValuesQuery(GetEmpUserdata);
                string EmpUserdataID = DB.ds.Tables[0].Rows[0][0].ToString();

                //Удаление данных сотрудника
                string DeleteEmp = "delete from Сотрудники where Сотрудники.Фамилия = " + "\'" + DeletableSurnameInput.Text + "\'" + " and " + "Сотрудники.Имя = " +
                    "\'" + DeletableNameInput.Text + "\'";
                DB.Execute(DeleteEmp);

                //Удаление данных для авторизации сотрудника
                string DeleteEmpFromUsers = "delete from Пользователи where ID_Пользователя = " + "\'" + EmpUserdataID + "\'";
                DB.Execute(DeleteEmpFromUsers);

                MessageBox.Show($@"Сотрудник с фамилией { DeletableSurnameInput.Text} и именем {DeletableNameInput.Text} успешно удален");

                //Обновление данных в таблице
                string GetEmployeesQuery = "select * from GetAllEmployees";
                EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void UpdateEmpData_Click(object sender, EventArgs e)
        {
            //Обновление данных в таблице
            string GetEmployeesQuery = "select * from GetAllEmployees";
            EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);
        }

    }
}
