using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace ODZ______
{
    /// <summary>
    /// Форма для керування даними абітурієнтів.
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
        /// Метод для з'єднання з БД.
        /// </summary>
        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
        }

        /// <summary>
        /// Метод для зчитування строк з БД.
        /// </summary>
        private void SelectAllData()
        {
            if (!conn.Ping())
            {
                MessageBox.Show("Співчуваємо, але схоже, що ви не під\'єднані до серверу MySQL. Будь ласка, зверніться до системного адміністратора для виправлення неполадок.");
                return;
            }
            DBMySQLUtils.CheckTable(conn);
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
        /// Обробник клавіші "Додати".
        /// Перевіряє правильність введених даних та додає строку в БД в разі успіху.
        /// </summary>
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
            if (!Regex.Match(schoolNum, @"^[0-9А-Яа-яёЁЇїІіЄєҐґ -]+$").Success)
            {
                MessageBox.Show("Було введено некоректний номер школи! Спробуйте знову.", "Помилка");
                addSchoolNumTxt.Focus();
                addSchoolNumTxt.SelectAll();
                return;
            }

            InsertRow(new SampleAbit(0, surname, name, mark, schoolNum));

            SelectAllData();

            addSurnameTxt.Text = "";
            addNameTxt.Text = "";
            addMarkTxt.Text = "";
            addSchoolNumTxt.Text = "";
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
            if (!Regex.Match(schoolNum, @"^[0-9А-Яа-яёЁЇїІіЄєҐґ -]+$").Success)
            {
                MessageBox.Show("Було введено некоректний номер школи! Спробуйте знову.", "Помилка");
                chSchoolNumTxt.Focus();
                chSchoolNumTxt.SelectAll();
                return;
            }

            UpdateRow(new SampleAbit(0, surname, name, mark, schoolNum));

            SelectAllData();
        }
        
        private void InsertRow(SampleAbit sa)
        {
            if (!conn.Ping())
                return;
            DBMySQLUtils.CheckTable(conn);
            string query = "insert into abits(surname, name, mark, schoolNumber) values('" +
                sa.Surname + "', '" + sa.Name + "', '" 
                + sa.Mark.ToString().Replace(',','.') + "', '" 
                + sa.NumberOfSchool + "');";
            DBMySQLUtils.ExecQuery(query, conn).Close();
        }

        private void UpdateRow(SampleAbit sa)
        {
            if (!conn.Ping())
                return;
            DBMySQLUtils.CheckTable(conn);
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
            conn.Close();
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

        private void dGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}