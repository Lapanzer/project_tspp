using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ODZ______
{
    /// <summary>
    /// Класс для роботи з базою даних в програмі.
    /// </summary>
    class DBUtils
    {
        private static string host = "127.0.0.1";
        private static int port = 3306;
        private static string username = "root";
        private static string password = "";
        private static string database = "db_odz";

        /// <summary>
        /// Метод для створення з'єднання з сервером MySQL на основі заданих параметрів.
        /// </summary>
        /// <returns>Повертає об'єкт для роботи зі з'єднанням.</returns>
        public static MySqlConnection GetDBConnection()
        {
            ReadConfigFile();
            return GetDBConnection(host, port, database, username, password);
        }

        /// <summary>
        /// Перевірка існування таблиці з абітурієнтами.
        /// Якщо відсутня, то створює.
        /// </summary>
        /// <param name="conn">Створене з'єднання</param>
        public static void CheckTable(MySqlConnection conn)
        {
            if (!conn.Ping())
                return;

            try { ExecQuery("describe abits;", conn).Close(); }
            catch
            {
                MySqlDataReader rd1 = ExecQuery("create table abits(id integer primary key auto_increment, "
                    + "name varchar(45), surname varchar(45), mark double, schoolNumber varchar(45));", conn);
                rd1.Close();
            }
        }

        /// <summary>
        /// Метод для встановлення з'єднання з MySQL-сервером.
        /// </summary>
        /// <param name="host">Ім'я або адреса хоста MySQL-серверу.</param>
        /// <param name="port">Порт, що прослуховує сервер.</param>
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
            try { conn.Open(); }
            catch (Exception) { conn.Close(); }
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
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                return command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Схоже, з базою даних коїться неладне.\n Будь ласка, зверніться до системного адміністратора для виправлення неполадок.");
                return null;
            }
        }

        /// <summary>
        /// Метод для зчитування параметрів з'єднання з файлу конфігурації.
        /// </summary>
        public static void ReadConfigFile()
        {
            StreamReader sr;
            List<string> args = new List<string> {"host", "port", "username", "password", "table"};
            try { sr = new StreamReader("configs.txt"); }
            catch
            {
                CreateConfigFile();
                return;
            }
            string line;
            string arg = "";
            while ((line = sr.ReadLine()) != null)
            {
                foreach (string l in args)
                {
                    if (line.Contains(l))
                    {
                        arg = l;
                        line = line.Replace(l, " ");
                        line = line.Trim();
                        break;
                    }
                }
                switch (args.IndexOf(arg))
                {
                    case 0:
                        host = line;
                        break;
                    case 1:
                        if (!int.TryParse(line, out port))
                            port = 3306;
                        break;
                    case 2:
                        username = line;
                        break;
                    case 3:
                        password = line;
                        break;
                    case 4:
                        database = line;
                        break;
                }
            }
            sr.Close();
        }

        /// <summary>
        /// Метод для створення файлу конфігурації зі стандартними параметрами.
        /// </summary>
        public static void CreateConfigFile()
        {
            StreamWriter sw = new StreamWriter("configs.txt");
            sw.WriteLine("host 127.0.0.1");
            sw.WriteLine("port 3306");
            sw.WriteLine("username root");
            sw.WriteLine("password ");
            sw.WriteLine("table db_odz");
            sw.Close();
        }
    }
}