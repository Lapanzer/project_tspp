using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    public partial class Form2 : Form
    {
        private List<SampleAbit> sa = new List<SampleAbit>();
        private MySqlConnection conn;

        public Form2()
        {
            InitializeComponent();
            dGV1.AllowUserToAddRows = false;
            DBConnect();
        }

        /// <summary>
        /// Method of conection to MySQL Server
        /// </summary>
        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
            MySqlDataReader reader;
            reader = DBMySQLUtils.ExecQuery("SELECT * FROM abits;", conn);
            while (reader.Read())
            {
                sampleAbitBindingSource.Add(new SampleAbit(int.Parse(reader["id"].ToString()),
                                      reader["surname"].ToString(),
                                      reader["name"].ToString(),
                                      float.Parse(reader["mark"].ToString()),
                                      reader["schoolNumber"].ToString()));
            }
            reader.Close();
        }

        /// <summary>
        /// Method to adding new abitudient
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addBut_Click(object sender, System.EventArgs e)
        {
            string surname = addSurnameTxt.Text;
            string name = addNameTxt.Text;
            //..
        }

        /// <summary>
        /// Method to change the abiturient
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void chBut_Click(object sender, System.EventArgs e)
        {
            //..
        }

        /// <summary>
        /// Method to come back to main form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void comeBackBut_Click(object sender, System.EventArgs e)
        {
            //..
        }
    }
}