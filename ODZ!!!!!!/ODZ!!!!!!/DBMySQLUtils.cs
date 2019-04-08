using MySql.Data.MySqlClient;

namespace ODZ______
{
    class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, int port, 
                                                      string database, 
                                                      string username, 
                                                      string password)
        {
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        /// <summary>
        /// Method to execute DB query
        /// </summary>
        /// <param name="query">Query of DB</param>
        /// <param name="conn">MySQLConection</param>
        /// <returns>MySqlDataReader</returns>
        public static MySqlDataReader ExecQuery(string query, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            command.Connection.Open();
            return command.ExecuteReader();
        }
    }
}