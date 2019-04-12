using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    /// <summary>
    /// Class with utils to work with MySQL
    /// </summary>
    class DBMySQLUtils
    {
        /// <summary>
        /// Method to set connection with MySQL server
        /// </summary>
        /// <param name="host">Name or IP-adress of host</param>
        /// <param name="port">Using port</param>
        /// <param name="database">Using schema</param>
        /// <param name="username">User's login</param>
        /// <param name="password">User's password</param>
        /// <returns>Setted connection</returns>
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
            catch (Exception ex)
            {
                conn.Close();
            }
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
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                return command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Схоже, з базою даних коїться неладне. Будь ласка, зверніться до системного адміністратора для виправлення неполадок.");
                return null;
            }
        }

        public static void CheckTable(MySqlConnection conn)
        {
            if (!conn.Ping())
                return;
            
            try
            {
                ExecQuery("describe abits;", conn).Close();
            }
            catch
            {
                MySqlDataReader rd1 = ExecQuery("create table abits(id integer primary key auto_increment, "
                    + "name varchar(45), surname varchar(45), mark double, schoolNumber varchar(45));", conn);
                rd1.Close();
            }
            finally
            {
                
            }
        }
    }
}