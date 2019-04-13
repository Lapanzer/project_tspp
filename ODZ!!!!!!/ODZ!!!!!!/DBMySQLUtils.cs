using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    /// <summary>
    /// Клас для з'єднання з БД MySQL та виконання запитів.
    /// </summary>
    class DBMySQLUtils
    {
        /// <summary>
        /// Метод для встановлення з'єднання з MySQL-сервером.
        /// </summary>
        /// <param name="host">Ім'я або адреса хоста MySQL-серверу.</param>
        /// <param name="port">Порт, що прослуховує сервер БД.</param>
        /// <param name="database">Використана схема.</param>
        /// <param name="username">Логін користувача БД.</param>
        /// <param name="password">Пароль користувача БД.</param>
        /// <returns>Повертає об'єкт для роботи з MySQL.</returns>
        public static MySqlConnection GetDBConnection(string host, int port, 
                                                      string database, 
                                                      string username, 
                                                      string password)
        {
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn.Close();
            }
            return conn;
        }

        /// <summary>
        /// Метод для виконання запитів
        /// </summary>
        /// <param name="query">Строка запиту до БД.</param>
        /// <param name="conn">Створене з'єднання</param>
        /// <returns>Об'єкт для читання відповіді серверу на запит.</returns>
        public static MySqlDataReader ExecQuery(string query, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            return command.ExecuteReader();
        }
    }
}