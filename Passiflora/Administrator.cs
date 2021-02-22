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

        #region Автоматические действия при загрузке формы

        private void Administrator_Load(object sender, EventArgs e)
        {
            //Установка сортировочных параметров по умолчанию
            SortOptions.SelectedItem = "Номеру";
            OrderOptions.SelectedItem = "Возрастанию";
            SearchEmp.SelectedItem = "Фамилии";
            SuppliersOptions.SelectedItem = "Florist.ru";
            SelectProduct.SelectedItem = "Букет Весеннее настроение";
            ProdTypeOptions.SelectedItem = "Цветы";

            //Получение установленных параметров сортировки
            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());

            //Получение данных всех заказов на странице с заказами
            string GetQuery = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(GetQuery);

            //Получение всех данных о сотрудниках на странице с сотрудниками
            string GetEmployeesQuery = "select * from GetAllEmployees";
            EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);

            //Получение всех данных о поставках и товарах в поставке на странице с поставками
            string GetShipmentsQuery = "select * from GetAllShipments";
            ShipmentData.DataSource = DB.SearchValuesQuery(GetShipmentsQuery);

            //Заполнение поставщиками и товарами списки на странице с поставками
            string GetSuppliersNames = "select Название_компании from Поставщики";
            DB.SearchValuesQuery(GetSuppliersNames);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                SuppliersOptions.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }

            string GetProductsNames = "select Наименование from Товары";
            DB.SearchValuesQuery(GetProductsNames);

            for(int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                SelectProduct.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }

            //Получение списка всех товаров
            string GetAllProds = "select * from GetAllProds";
            ProductsData.DataSource = DB.SearchValuesQuery(GetAllProds);

            //Заполнение списка типов товаров
            string GetProdTypes = "select Наименование from Типы_Товаров";
            DB.SearchValuesQuery(GetProdTypes);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                ProdTypeOptions.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }

            ProdTypeOptions.SelectedItem = "Букеты";
            SearchByProdOptions.SelectedItem = "Имени";

            //Получение данных обо всех клиентах
            string GetAllClients = "select * from GetAllClients";
            ClientsData.DataSource = DB.SearchValuesQuery(GetAllClients);

            DB.SearchValuesQuery("select Имя, Отчество from Сотрудники inner join Пользователи on Сотрудники.Данные_для_входа = Пользователи.ID_Пользователя where Пользователи.Логин =" + "\'" + DB.AuthorizedUser + "\'");
            GreetingLabel.Text = "Здравствуйте, " + DB.ds.Tables[0].Rows[0][0].ToString() + " " + DB.ds.Tables[0].Rows[0][1].ToString();
        }

        #endregion

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

        /// <summary>
        /// Метод, обрабатывающий событие удаление заказа
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(OrderDeletableInput.Text, out int OrderNumber))
                {
                    string SelectDeletableOrder = "select ID_Заказа from Заказы where ID_Заказа = " + "\'" + OrderNumber + "\'";
                    DB.SearchValuesQuery(SelectDeletableOrder);
                    string DeletableOrder = DB.ds.Tables[0].Rows[0][0].ToString();

                    if (!DeletableOrder.Equals("") && DeletableOrder != null)
                    {
                        //Запрос на удаление заказа клиентов
                        string DropFromUserOrders = "delete from Заказы_клиентов where Заказ = " + "\'" + DeletableOrder + "\'";
                        DB.Execute(DropFromUserOrders);

                        //Запрос на удаление конкретно заказа
                        string DeleteQuery = "delete from Заказы where ID_Заказа = " + "\'" + DeletableOrder + "\'";
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
                        throw new Exception("Заказа с данным номером не существует!");
                    }
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

        /// <summary>
        /// Метод, обрабатывающий событие сортировки заказа
        /// </summary>
        private void SortButton_Click(object sender, EventArgs e)
        {
            string SortOpt = DB.GetSortMode(SortOptions.SelectedItem.ToString());
            string OrderOpt = DB.GetOrderBy(OrderOptions.SelectedItem.ToString());
            string Query = "select * from GetAllUsersOrders order by " + SortOpt + " " + OrderOpt;
            OrdersData.DataSource = DB.SearchValuesQuery(Query);
        }

        /// <summary>
        /// Метод, обрабатывающий событие поиска заказа по определенным параметрам
        /// </summary>
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

        /// <summary>
        /// Метод, обрабатывающий событие поиска сотрудника по его фамилии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод, обрабатывающий добавление нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод, обрабатывающий событие при удалении сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Метод, обрабатывающий событие обновления данных о сотрудниках
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateEmpData_Click(object sender, EventArgs e)
        {
            //Обновление данных в таблице
            string GetEmployeesQuery = "select * from GetAllEmployees";
            EmployeesData.DataSource = DB.SearchValuesQuery(GetEmployeesQuery);
        }

        #endregion

        #region Обработка действий на странице с поставками

        /// <summary>
        /// Метод, обрабатывающий событие при добавлении товаров в поставку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddShipmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SuppliersOptions.SelectedItem != null && SelectProduct.SelectedItem != null && DateInput.Text != "" && CountInput.Text != "")
                {
                    //Получение ID выбранного поставщика
                    string GetSupplierID = "select ID_Поставщика from Поставщики where Название_компании = " + "\'" + SuppliersOptions.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetSupplierID);
                    string SupplierID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Добавление данных о новой поставке
                    string AddShipmentQuery = "insert into Поставки(Поставщик, Дата_поставки) values(" + "\'" + SupplierID + "\'" + "," + "\'" + Convert.ToDateTime(DateInput.Text) + "\'" + ")";
                    DB.Execute(AddShipmentQuery);

                    //Получение ID новой поставки
                    string GetShpipmentIDQuery = "select max(ID_Поставки) from Поставки";
                    DB.SearchValuesQuery(GetShpipmentIDQuery);
                    string ShipmentID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Получение ID выбранного товара
                    string GetProdID = "select ID_Товара from Товары where Наименование = " + "\'" + SelectProduct.SelectedItem.ToString() + "\'";
                    DB.SearchValuesQuery(GetProdID);
                    string ProdID = DB.ds.Tables[0].Rows[0][0].ToString();

                    if (!DateInput.Text.Contains("-"))
                    {
                        throw new Exception("Неправильный формат даты!");
                    }

                    if (int.TryParse(CountInput.Text, out int Count))
                    {
                        //Связка товаров с поставкой
                        string AddProdsInShipmentQuery = "insert into Товары_в_поставках(Поставка, Товар, Количество) values (" +
                            "\'" + ShipmentID + "\'" + "," + "\'" + ProdID + "\'" + "," + "\'" + Count + "\'" + ")";
                        DB.Execute(AddProdsInShipmentQuery);

                        MessageBox.Show("Поставка успешно добавлена. Нажмите Обновить данные для обновления информации");

                    }
                    else
                    {
                        throw new Exception("Количество товара может быть только целым числом!");
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

        /// <summary>
        /// Метод, обрабатывающий удаление поставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteShimpentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ( int.TryParse(ShipmentNumber.Text, out int ShipNum))
                {
                    //Удаление записи из таблицы Товары в поставках по номеру поставки
                    string DeleteFromProdsInShip = "delete from Товары_в_поставках where Поставка = " + "\'" + ShipNum + "\'";
                    DB.Execute(DeleteFromProdsInShip);

                    //Удаление записи из поставок по номеру поставки
                    string DeleteFromShipments = "delete from Поставки where ID_Поставки = " + "\'" + ShipNum + "\'";
                    DB.Execute(DeleteFromShipments);

                    MessageBox.Show($@"Поставка под номером {ShipNum} успешно удалена");
                    ShipmentNumber.Text = "";
                }
                else
                {
                    throw new Exception("Номер поставки может быть только целочисленным значением!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, обрабатывающий обновление информации о поставках
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateShipmentsDataButton_Click(object sender, EventArgs e)
        {
            //Получение всех данных о поставках и товарах в поставке на странице с поставками
            string GetShipmentsQuery = "select * from GetAllShipments";
            ShipmentData.DataSource = DB.SearchValuesQuery(GetShipmentsQuery);
        }

        #endregion

        #region Обработка действий на странице с товарами

        /// <summary>
        /// Метод, получающий ID выбранного в Combobox'e типа товара
        /// </summary>
        /// <param name="SelectedProd"></param>
        /// <returns></returns>
        private string GetSelectedProdTypeID(string SelectedProd)
        {
            switch (SelectedProd)
            {
                case "Букеты":
                    SelectedProd = "1";
                    break;
                case "Цветы":
                    SelectedProd = "2";
                    break;
                case "Горшки":
                    SelectedProd = "3";
                    break;
                case "Комнатные растения":
                    SelectedProd = "4";
                    break;
                case "Садовые растения":
                    SelectedProd = "5";
                    break;
                case "Уход за растениями":
                    SelectedProd = "6";
                    break;
            }

            return SelectedProd;
        }

        /// <summary>
        /// Метод, обрабатывающий добавление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                string SwitchedProdType = GetSelectedProdTypeID(ProdTypeOptions.SelectedItem.ToString());

                if (ProdNameInput.Text != "" && LengthInput.Text != "" &&
                    WidthInput.Text != "" && HeightInput.Text != "" && PriceInput.Text != "")
                {
                    if (int.TryParse(LengthInput.Text, out int Length) && int.TryParse(WidthInput.Text, out int Width)
                    && int.TryParse(HeightInput.Text, out int Height) && int.TryParse(PriceInput.Text, out int Price))
                    {
                        string AddNewProd = "insert into Товары(Наименование, Тип_Товара, Длина_см, Ширина_см, Высота_см, Стоимость) values (" +
                           "\'" + ProdNameInput.Text + "\'" + "," + "\'" + SwitchedProdType + "\'" + "," + "\'" + Length + "\'" + "," + "\'" +
                           Width + "\'" + "," + "\'" + Height + "\'" + "," + "\'" + Price + "\')";
                        DB.Execute(AddNewProd);

                        MessageBox.Show("Новый товар успешно добавлен!");
                    }
                    else
                    {
                        throw new Exception("Длина, ширина, высота и цена может быть только целочисленным значением!");
                    }
                }
                else
                {
                    throw new Exception("Все поля обязательны для заполнения! Проверьте правильность вводимых данных!");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, обновляющий данные о продуктах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProdDataButton_Click(object sender, EventArgs e)
        {
            //Получение списка всех товаров
            string GetAllProds = "select * from GetAllProds";
            ProductsData.DataSource = DB.SearchValuesQuery(GetAllProds);
        }

        /// <summary>
        /// Метод, обрабатывающий удаление товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProdButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(DeleteProdInput.Text, out int DeleteProdNumber))
                {
                    string DeleteProdQuery = "delete from Товары where ID_Товара = " + "\'" + DeleteProdNumber + "\'";
                    DB.Execute(DeleteProdQuery);
                    MessageBox.Show($@"Товар с номером {DeleteProdNumber} успешно удален");
                }
                else
                {
                    throw new Exception("Номер товара может быть только целочисленным значением");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, обрабатывающий сортировку товаров, согласно выбранному пункту сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchByButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchByProdValue.Text != "")
                {
                    switch (SearchByProdOptions.SelectedItem)
                    {
                        case "Имени":
                            ProductsData.DataSource = DB.SearchValuesQuery("select * from GetAllProds where Наименование = " + "\'" + SearchByProdValue.Text + "\'");
                            break;
                        case "Длине":
                            ProductsData.DataSource = DB.SearchValuesQuery("select * from GetAllProds where Длина_см = " + "\'" + SearchByProdValue.Text + "\'");
                            break;
                        case "Ширине":
                            ProductsData.DataSource = DB.SearchValuesQuery("select * from GetAllProds where Ширина_см = " + "\'" + SearchByProdValue.Text + "\'");
                            break;
                        case "Высоте":
                            ProductsData.DataSource = DB.SearchValuesQuery("select * from GetAllProds where Высота_см = " + "\'" + SearchByProdValue.Text + "\'");
                            break;
                        case "Стоимости":
                            ProductsData.DataSource = DB.SearchValuesQuery("select * from GetAllProds where Стоимость = " + "\'" + SearchByProdValue.Text + "\'");
                            break;
                    }
                }
                else
                {
                    throw new Exception("Введите значение для поиска!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #region Обработка действий на странице с клиентами

        /// <summary>
        /// Метод, получающий параметр сортировки для БД исходя из выбранного значения в Combobox'e
        /// </summary>
        /// <param name="SearchBy">Выбранный пункт в Cobmobox'e</param>
        /// <returns></returns>
        private string SwitchClietnsSearchBy(string SearchBy)
        {
            switch (SearchBy)
            {
                case "Фамилии":
                    SearchBy = "Фамилия";
                    break;
                case "Телефону":
                    SearchBy = "Телефон";
                    break;
                case "Логину":
                    SearchBy = "Логин";
                    break;
                case "Секретному ключу":
                    SearchBy = "Секретный_ключ";
                    break;
            }

            return SearchBy;
        }

        /// <summary>
        /// Метод, обрабатывающий поиск клиента по определенному параметру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                string SearchBy = SwitchClietnsSearchBy(SearchClientByOptions.SelectedItem.ToString());
                string SearchClientsBy = "select * from GetAllClients where " + SearchBy + " = " + "\'" + SearchClientValueInput.Text + "\'";
                ClientsData.DataSource = DB.SearchValuesQuery(SearchClientsBy);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Метод, обрабатывающий удаление клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (RemovableClientLogin.Text != "")
                {
                    //Получение ID пользователя с введенным логином
                    string GetUserID = "select ID_Пользователя from Пользователи where Логин = " + "\'" + RemovableClientLogin.Text + "\'";
                    DB.SearchValuesQuery(GetUserID);
                    string UserID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Получение ID клиента согласно его данным для входа
                    string GetClientID = "select ID_Клиента from Клиенты where Данные_для_входа = " + "\'" + UserID + "\'";
                    DB.SearchValuesQuery(GetClientID);
                    string ClientID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Удаление заказа клиента
                    string DeleteFromClientOrders = "delete from Заказы_клиентов where Клиент = " + "\'" + ClientID + "\'";
                    DB.Execute(DeleteFromClientOrders);

                    //Удаление клиента
                    string DeleteClient = "delete from Клиенты where ID_Клиента = " + "\'" + ClientID + "\'";
                    DB.Execute(DeleteClient);

                    //Удаление данных для авторизации
                    string DeleteAuthClientData = "delete from Пользователи where ID_Пользователя = " + "\'" + UserID + "\'";
                    DB.Execute(DeleteAuthClientData);
                    MessageBox.Show($@"Клиент с логином: {RemovableClientLogin.Text} успешно удален!");
                }
                else
                {
                    throw new Exception("Для удаление необходимо ввести логин пользователя!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCLientsData_Click(object sender, EventArgs e)
        {
            string GetAllClients = "select * from GetAllClients";
            ClientsData.DataSource = DB.SearchValuesQuery(GetAllClients);
        }

        #endregion
    }
}
