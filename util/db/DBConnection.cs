using MySql.Data.MySqlClient;

namespace Bookful.util.db
{
    /// <summary>
    /// Класс подключения к базе данных
    /// </summary>
    public class DBConnection
    {
        private DBConnection()
        {
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public MySqlConnection Connection { get; private set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection()
                {
                    Server = "127.0.0.1",
                    DatabaseName = "tmp",
                    UserName = "root",
                    Password = "root"
                };
            }

            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                {
                    return false;
                }

                string connectionString = string.Format("server={0};database={1};uid={2};password={3}", Server, DatabaseName, UserName, Password);
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }

            return true;
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
