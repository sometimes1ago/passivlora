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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        //Выбранный товар для заказа
        public string SelectedProduct;
        //Количество товара
        private int ProductCount;
        private string DeliveryMethod;
        private int OrderAmount;
        private string CustomerAddress;
        private string DefaultAddress = "Омск, Добролюбова 19А";

        /// <summary>
        /// Метод получающий стоимость товара по названию
        /// </summary>
        /// <param name="ProductName">Название товара</param>
        /// <returns></returns>
        private object GetProductPrice(string ProductName)
        {
            string Query = "select Стоимость from Товары where Наименование = " + "\'" + ProductName + "\'";
            return DB.SearchValuesQuery(Query);
        }

        /// <summary>
        /// Метод подсчитывающий общую стоимость заказа
        /// </summary>
        private void CalculateAmount()
        {
            GetProductPrice(SelectedProduct);
            int ProdPrice = Convert.ToInt32(DB.ds.Tables[0].Rows[0][0].ToString());
            OrderAmount = ProdPrice * ProductCount;
        }

        /// <summary>
        /// Установка названия выбранного товара для заказа
        /// </summary>
        /// <param name="count"></param>
        public void SetSelectedProdCount(int count)
        {
            ProductCount = count;
        }

        /// <summary>
        /// Метод устанавливающий какой именно продукт был выбран для заказа
        /// </summary>
        /// <param name="prodName"></param>
        public void SetSelectedProduct(string prodName)
        {
            SelectedProduct = prodName;
        }

        /// <summary>
        /// Получение ID выбранного товара для заказа
        /// </summary>
        /// <param name="ProductName">Название товара</param>
        /// <returns></returns>
        public object GetSelectedProductID(string ProductName)
        {
            string Query = "select ID_Товара from Товары where Наименование = " + "\'" + ProductName + "\'";
            return DB.SearchValuesQuery(Query);
        }

        private void Order_Load(object sender, EventArgs e)
        {
            SelectedProdLabel.Text += SelectedProduct;
            SelectedProdCountLabel.Text += Convert.ToString(ProductCount);
            ByCourier.Checked = true;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        { 
            //Адрес покупателя. Если доставка самовывозом, устанавливается адрес магазина
            CustomerAddress = AddressInput.Text;
            string SecretKey = DB.GenerateSecretKey("QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890", 3);

            try
            {
                if (ByCourier.Checked == true && CustomerAddress == "")
                {
                    throw new Exception("При курьерской доставке адрес не может быть пустой!");
                }
                else
                {
                    //Получение ID выбранного товара
                    GetSelectedProductID(SelectedProduct);
                    string ProductID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Подсчет общей стоимости заказа
                    CalculateAmount();

                    //Проверка на способ доставки. Если самовывоз, то присваивается адрес по умолчанию
                    if (BySelf.Checked == true)
                    {
                        CustomerAddress = DefaultAddress;
                    }

                    //Запрос и его выполнение на создание нового заказа
                    string CreateNewOrder = "insert into Заказы(Товар, Количество, Способ_доставки, " +
                        "Адрес_доставки, Дата_заказа, Сумма_заказа, Статус_заказа, Код_выдачи) values(" + "\'" + ProductID + "\'" + "," + "\'" + ProductCount + "\'" +
                         "," + "\'" + DeliveryMethod + "\'" + "," + "\'" + CustomerAddress + "\'" + ", getdate(), " + "\'" + OrderAmount + "\'" + "," +
                         "\'" + "Новый" + "\'" + "," + "\'" + SecretKey + "\'" + ")";
                    DB.Execute(CreateNewOrder);

                    //Выборка максимального(последнего добавленного) заказа
                    DB.SearchValuesQuery("select max(ID_Заказа) from Заказы");
                    string OrderID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Получение ID авторизованного пользователя
                    string Query = "select ID_Пользователя from Пользователи where Логин = " + "\'" + DB.AuthorizedUser + "\'";
                    DB.SearchValuesQuery(Query);
                    string AuthorizedUserID = DB.ds.Tables[0].Rows[0][0].ToString();

                    string GetClientID = "select ID_Клиента from Клиенты where Данные_для_входа = " + "\'" + AuthorizedUserID + "\'";
                    DB.SearchValuesQuery(GetClientID);
                    string ClientID = DB.ds.Tables[0].Rows[0][0].ToString();

                    //Запрос и его выполнение на привязку заказа к пользователю, сделавшему заказ
                    string AddOrderToUser = "insert into Заказы_клиентов(Заказ, Клиент) values(" + "\'" + OrderID + "\'" + "," + "\'" + ClientID + "\'" + ")";
                    DB.Execute(AddOrderToUser);

                    MessageBox.Show($@"Вы успешно сделали заказ! Ваш код выдачи: {SecretKey}. Все ваши заказы отображаются в личном кабинете");
                    Close();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BySelf_CheckedChanged(object sender, EventArgs e)
        {
            if (BySelf.Checked == true)
            {
                AddressInput.Enabled = false;
                DeliveryMethod = "Самовывоз";
            }
        }

        private void ByCourier_CheckedChanged(object sender, EventArgs e)
        {
            if (ByCourier.Checked == true)
            {
                AddressInput.Enabled = true;
                DeliveryMethod = "Курьером";
            }
        }
    }
}
