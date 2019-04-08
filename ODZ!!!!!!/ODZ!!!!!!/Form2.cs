using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            List<SampleAbit> sa = new List<SampleAbit>();
            string commandString = "SELECT * FROM abits;";
            dGV1.AllowUserToAddRows = false;
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand command = new MySqlCommand();
            MySqlDataReader reader;
            command.CommandText = commandString;
            command.Connection = conn;
            command.Connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                sa.Add(new SampleAbit(int.Parse(reader["id"].ToString()), 
                                      reader["surname"].ToString(), 
                                      reader["name"].ToString(), 
                                      float.Parse(reader["mark"].ToString()), 
                                      reader["schoolNumber"].ToString()));
                
            }
            reader.Close();
            PutRows(sa);
        }

        private void PutRows(List<SampleAbit> sa)
        {
            foreach (SampleAbit sas in sa)
            {
                dGV1.Rows.Add();
                dGV1["AId", dGV1.Rows.Count - 1].Value = sas.Id;
                dGV1["ASurname", dGV1.Rows.Count - 1].Value = sas.Surname;
                dGV1["AName", dGV1.Rows.Count - 1].Value = sas.Name;
                dGV1["AMark", dGV1.Rows.Count - 1].Value = sas.Mark;
                dGV1["ASchoolNum", dGV1.Rows.Count - 1].Value = sas.NumberOfSchool;
            }
        }
    }
}
