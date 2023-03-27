using Bookful.domain.dto;
using Bookful.util.db;
using MySql.Data.MySqlClient;

namespace Bookful.dao.user
{
    public class UserDaoImpl : UserDao
    {
        /// <summary>
        /// Экземпляр подключения к БД
        /// </summary>
        private DBConnection connection = DBConnection.Instance();

        /// <summary>
        /// Вставка данных пользователя в базу данных
        /// </summary>
        /// <param name="user">Объект данных пользователя</param>
        public void InsertNewUser(User user)
        {
            if (connection.IsConnect())
            {
                string query = string.Format("INSERT INTo user(login, password) VALUES({0},{1})", user.Login, user.Password);
                var cmd = new MySqlCommand(query, connection.Connection);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Проверка существующего логина
        /// </summary>
        /// <param name="login">Логин пользователя</param>
        /// <returns>true если логин существует, иначе false</returns>
        public bool IsExistsLogin(string login)
        {
            if (connection.IsConnect())
            {
                string query = string.Format("SELECT EXISTS (SELECT * FROM user WHERE login = {0})", login);
                var cmd = new MySqlCommand(query, connection.Connection);
                var reader = cmd.ExecuteReader();
                return reader.GetInt32(0) != 0;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
