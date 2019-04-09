using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    /// <summary>
    /// Form that provide modification data
    /// </summary>
    public partial class RedactionForm : Form
    {
        private MainForm root;
        private MySqlConnection conn;

        public RedactionForm(MainForm r)
        {
            InitializeComponent();
            root = r;
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
            sampleAbitBS.Clear();
            MySqlDataReader reader = DBMySQLUtils.ExecQuery("SELECT * FROM abits;", conn);
            while (reader.Read())
            {
                sampleAbitBS.Add(new SampleAbit(int.Parse(reader["id"].ToString()),
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
            string schoolNum = addSchoolNumTxt.Text;
            
            if (!Regex.Match(surname, @"^[А-Яа-яёЁЇїІіЄєҐґ]+$").Success)
            {
                MessageBox.Show("Було введено некоректне прізвище! Спробуйте знову.", "Помилка");
                addSurnameTxt.Focus();
                addSurnameTxt.SelectAll();
                return;
            }
            if (!Regex.Match(name, @"^[А-Яа-яёЁЇїІіЄєҐґ]+$").Success)
            {
                MessageBox.Show("Було введено некоректне ім\'я! Спробуйте знову.", "Помилка");
                addNameTxt.Focus();
                addNameTxt.SelectAll();
                return;
            }
            if (!float.TryParse(addMarkTxt.Text, out float mark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                addMarkTxt.Focus();
                addMarkTxt.SelectAll();
                return;
            }
            if(mark > 200 || mark < 0)
            {
                MessageBox.Show("Оцінка повинна бути в діапазоні 0-200! Спробуйте знову.", "Помилка");
                addMarkTxt.Focus();
                addMarkTxt.SelectAll();
                return;
            }
            schoolNum = schoolNum.Replace("'", " ");
            schoolNum = schoolNum.Trim();
            InsertRow(new SampleAbit(0, surname, name, mark, schoolNum));
            addSurnameTxt.Text = "";
            addNameTxt.Text = "";
            addMarkTxt.Text = "";
            addSchoolNumTxt.Text = "";
            SelectAllData();
        }

        /// <summary>
        /// Method to change the abiturient
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void ChBut_Click(object sender, System.EventArgs e)
        {
            string surname = chSurnameTxt.Text;
            string name = chNameTxt.Text;
            string schoolNum = chSchoolNumTxt.Text;

            if (!Regex.Match(surname, @"^[А-Яа-яёЁЇїІіЄєҐґ]+$").Success)
            {
                MessageBox.Show("Було введено некоректне прізвище! Спробуйте знову.", "Помилка");
                chSurnameTxt.Focus();
                chSurnameTxt.SelectAll();
                return;
            }
            if (!Regex.Match(name, @"^[А-Яа-яёЁЇїІіЄєҐґ]+$").Success)
            {
                MessageBox.Show("Було введено некоректне ім\'я! Спробуйте знову.", "Помилка");
                chNameTxt.Focus();
                chNameTxt.SelectAll();
                return;
            }
            if (!float.TryParse(chMarkTxt.Text, out float mark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                chMarkTxt.Focus();
                chMarkTxt.SelectAll();
                return;
            }
            if (mark > 200 || mark < 0)
            {
                MessageBox.Show("Оцінка повинна бути в діапазоні 0-200! Спробуйте знову.", "Помилка");
                addMarkTxt.Focus();
                addMarkTxt.SelectAll();
                return;
            }
            schoolNum = schoolNum.Replace("'", " ");
            schoolNum = schoolNum.Trim();
            UpdateRow(new SampleAbit(0, surname, name, mark, schoolNum));
            SelectAllData();
        }
        
        private void InsertRow(SampleAbit sa)
        {
            string query = "insert into abits(surname, name, mark, schoolNumber) values('" +
                sa.Surname + "', '" + sa.Name + "', '" 
                + sa.Mark.ToString().Replace(',','.') + "', '" 
                + sa.NumberOfSchool + "');";
            DBMySQLUtils.ExecQuery(query, conn).Close();
        }

        private void UpdateRow(SampleAbit sa)
        {
            string query = "update abits set surname = '" +
                sa.Surname + "', name = '" + sa.Name 
                + "', mark = '" + sa.Mark.ToString().Replace(',', '.') 
                + "', schoolNumber = '" + sa.NumberOfSchool 
                + "' where id = " + cB1.SelectedValue.ToString() + ";";
            DBMySQLUtils.ExecQuery(query, conn).Close();
        }

        private void RedactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            root.Show();
        }
        
        private void dGV1_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dGV1.SelectedRows.Count < 1)
                return;
            chSurnameTxt.Text = dGV1.SelectedRows[0].Cells[1].Value.ToString();
            chNameTxt.Text = dGV1.SelectedRows[0].Cells[2].Value.ToString();
            chMarkTxt.Text = dGV1.SelectedRows[0].Cells[3].Value.ToString().Replace('.', ',');
            chSchoolNumTxt.Text = dGV1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}