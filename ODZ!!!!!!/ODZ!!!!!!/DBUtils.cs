﻿using MySql.Data.MySqlClient;

namespace ODZ______
{
    class DBUtils
    {
        /// <summary>
        /// Method of setting conection parameters
        /// </summary>
        /// <returns>MySQLConection</returns>
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "DB_odz";
            string username = "editor";
            string password = "xrxrxrxrxrxrxrxrxrxr";// "xCdr7zNDpNYHNXcr";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}