using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passiflora
{
    /// <summary>
    /// Класс для работы с базой данных
    /// </summary>
    class DB
    {
        private static string ConnStr = @"Data Source=localhost; Initial Catalog = Цветочный_Салон; Integrated Security=true";
        public static DataSet ds;
        public static string AuthorizedUser;
        
        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        /// <summary>
        /// Метод устанвливающий какой именно пользователь авторизовался
        /// </summary>
        /// <param name="UserLogin">Логин пользователя</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            AuthorizedUser = UserLogin;
        }

        /// <summary>
        /// Метод генерирующий секретный ключ используемый при регистрации или добавлении пользователей
        /// </summary>
        /// <param name="alphabet">Алфавит из которого будет сгенерирована строка</param>
        /// <param name="length">Длина генерируемой строки</param>
        /// <returns></returns>
        public static string GenerateSecretKey(string alphabet, int length)
        {
            int position;
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(length - 1);

            for (int i = 0; i < length; i++)
            {
                position = rnd.Next(0, alphabet.Length - 1);
                sb.Append(alphabet[position]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Метод получающий поле по которому будет производиться сортировка
        /// </summary>
        /// <param name="sortby">Поле сортировки</param>
        /// <returns></returns>
        public static string GetSortMode(string sortBy)
        {
            switch (sortBy)
            {
                case "Имени":
                    sortBy = "Наименование";
                    break;
                case "Длине":
                    sortBy = "Длина_см";
                    break;
                case "Ширине":
                    sortBy = "Ширина_см";
                    break;
                case "Высоте":
                    sortBy = "Высота_см";
                    break;
                case "Стоимости":
                    sortBy = "Стоимость";
                    break;
                case "Номеру":
                    sortBy = "Номер_заказа";
                    break;
                case "Дате":
                    sortBy = "Дата_заказа";
                    break;
                case "Статусу":
                    sortBy = "Статус_заказа";
                    break;
                case "Фамилии_клиента":
                    sortBy = "Фамилия_клиента";
                    break;
                case "Адресу_доставки":
                    sortBy = "Адрес_доставки";
                    break;
                case "Сумме_заказа":
                    sortBy = "Сумма_заказа";
                    break;
                case "Коду_выдачи":
                    sortBy = "Код_выдачи";
                    break;
                case "Телефону":
                    sortBy = "Телефон_клиента";
                    break;
                case "Фамилии":
                    sortBy = "Фамилия";
                    break;
            }

            return sortBy;
        }

        /// <summary>
        /// Метод получающий порядок сортировки
        /// </summary>
        /// <param name="orderby">Порядок сортировки</param>
        /// <returns></returns>
        public static string GetOrderBy(string orderBy)
        {
            switch (orderBy)
            {
                case "Убыванию":
                    orderBy = "desc";
                    break;
                case "Возрастанию":
                    orderBy = "asc";
                    break;
            }

            return orderBy;
        }

        public static object GetAuthorizedUserID()
        {
            string Query = "select ID_Пользователя from Пользователи where Логин = " + "\'" + AuthorizedUser + "\'";
            return SearchValuesQuery(Query);
        }

        /// <summary>
        /// Метод получающий все названия товаров согласно типу товара
        /// </summary>
        /// <param name="prodType"></param>
        public static object GetAllProdNames(string prodType)
        {
            string GetProdsNamesQuery = "select Товары.Наименование From Товары inner join Типы_Товаров on Товары.Тип_товара = Типы_Товаров.ID_Типа where Типы_Товаров.Наименование = " + "\'" + prodType + "\'";
            return SearchValuesQuery(GetProdsNamesQuery);
        }

        /// <summary>
        /// Метод получающий таблицу всех товаров согласно типу товаров и параметру сортировки
        /// </summary>
        /// <param name="prodType">Тип товара</param>
        /// <param name="sortBy">Поле сортировки</param>
        /// <param name="orderBy">Порядок сортировки</param>
        /// <returns></returns>
        public static object GetAllProds(string prodType, string sortBy, string orderBy, int priceProm, int priceTo)
        {
            string GetProdsQuery = "select ID_Товара as Артикул, Товары.Наименование, Товары.Длина_см, Товары.Ширина_см, Товары.Высота_см, Товары.Стоимость From Товары " +
                "inner join Типы_Товаров on Товары.Тип_товара = Типы_Товаров.ID_Типа where Типы_Товаров.Наименование = " + "\'" + prodType + "\'" + "and Стоимость between " + priceProm + 
                " and " + priceTo + "order by " + "\'" + sortBy + "\'" + " " + orderBy;
            return SearchValuesQuery(GetProdsQuery);
        }

        /// <summary>
        /// Метод выполняющий запрос к базе данных
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        public static void Execute(string QueryString)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                sqlad = new SqlDataAdapter(QueryString, ConnStr);
                ds = new DataSet();
                comnd = new SqlCommand(QueryString, sqlconn);
                comnd.ExecuteNonQuery();
                sqlconn.Close();
            }
        }

        /// <summary>
        /// Модифицированный метод выполнения запроса к БД, возвращающий результат в виде таблицы
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <returns>Результат выполнения запроса</returns>
        public static object SearchValuesQuery(string QueryString)
        {
            Execute(QueryString);
            sqlad.Fill(ds);
            return ds.Tables[0];
        }

    }
}
