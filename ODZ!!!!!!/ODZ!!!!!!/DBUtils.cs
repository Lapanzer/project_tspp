using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;

namespace ODZ______
{
    /// <summary>
    /// Класс для роботи з базою даних в програмі.
    /// </summary>
    class DBUtils
    {
        private static string host;
        private static int port;
        private static string username;
        private static string password;

        /// <summary>
        /// Метод для створення з'єднання з сервером MySQL на основі заданих параметрів.
        /// </summary>
        /// <returns>Повертає об'єкт для роботи зі з'єднанням.</returns>
        public static MySqlConnection GetDBConnection()
        {
            ReadConfigFile();
            string database = "db_odz";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }

        /// <summary>
        /// Метод для зчитування параметрів з'єднання з файлу конфігурації.
        /// </summary>
        public static void ReadConfigFile()
        {
            StreamReader sr;
            List<string> args = new List<string> {"host", "port", "username", "password"};
            try { sr = new StreamReader("configs.txt"); }
            catch
            {
                CreateConfigFile();
                host = "127.0.0.1";
                port = 3306;
                username = "root";
                password = "xrxrxrxrxrxrxrxrxrxr";
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
            sw.Close();
        }
    }
}