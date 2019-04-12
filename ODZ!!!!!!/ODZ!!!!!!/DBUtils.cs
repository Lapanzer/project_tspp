using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;

namespace ODZ______
{
    class DBUtils
    {
        private static string host = "127.0.0.1";
        private static int port = 3306;
        private static string username = "root";
        private static string password = "";

        /// <summary>
        /// Method of setting conection parameters
        /// </summary>
        /// <returns>MySQLConection</returns>
        public static MySqlConnection GetDBConnection()
        {
            ReadConfigFile();
            string database = "db_odz";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
        public static void ReadConfigFile()
        {
            StreamReader sr;
            List<string> args = new List<string> {"host", "port", "username", "password"};
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
                }
            }
            sr.Close();
        }
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