using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    /// <summary>
    /// Form that provide modification data
    /// </summary>
    public partial class RedactionForm : Form
    {
        private List<SampleAbit> sa = new List<SampleAbit>();
        private MySqlConnection conn;

        public RedactionForm()
        {
            InitializeComponent();
            dGV1.AllowUserToAddRows = false;
            DBConnect();
            SelectAllData();
        }

        /// <summary>
        /// Method of conection to MySQL Server
        /// </summary>
        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
        }

        /// <summary>
        /// Methot to read all data from table abits
        /// </summary>
        private void SelectAllData()
        {
            sampleAbitBindingSource.Clear();
            MySqlDataReader reader = DBMySQLUtils.ExecQuery("SELECT * FROM abits;", conn);
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
        private void AddBut_Click(object sender, System.EventArgs e)
        {
            string surname = addSurnameTxt.Text;
            string name = addNameTxt.Text;
            string mark = addMarkTxt.Text;
            string schoolNum = addSchoolNumTxt.Text;

        }

        /// <summary>
        /// Method to change the abiturient
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ChBut_Click(object sender, System.EventArgs e)
        {
            //..
        }

        /// <summary>
        /// Method to come back to main form
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ComeBackBut_Click(object sender, System.EventArgs e)
        {
            //..
        }
    }
}