using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ODZ______
{
    /// <summary>
    /// Форма пошуку даних.
    /// </summary>
    public partial class SearchForm : Form
    {
        private MainForm root;
        private MySqlConnection conn;

        /// <summary>
        /// Конструктор форми.
        /// </summary>
        /// <param name="r">Батьківська форма.</param>
        public SearchForm(MainForm r)
        {
            InitializeComponent();
            root = r;
            dGVX.AllowUserToAddRows = false;
            dGVXY.AllowUserToAddRows = false;
            SampleAbit sa = new SampleAbit();
            DBConnect();
        }

        /// <summary>
        /// Метод для з'єднання з БД.
        /// </summary>
        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
        }

        /// <summary>
        /// Обробник натиснення клавіші "Пошук" по параметру оцінки.
        /// </summary>
        /// <param name="mark">Оцінка за іспити.</param>
        private void SelectXData(float mark)
        {
            abitResultX.Clear();
            if (!conn.Ping())
            {
                MessageBox.Show("Співчуваємо, але схоже, що ви не під\'єднані до серверу MySQL. Будь ласка, зверніться до системного адміністратора для виправлення неполадок.");
                return;
            }
            DBUtils.CheckTable(conn);

            MySqlDataReader reader = DBUtils.ExecQuery("SELECT surname, name, mark FROM abits where mark>=" 
                                                           + mark.ToString().Replace(',', '.') + ";", conn);
            while (reader.Read())
            {
                abitResultX.Add(new AbitResult(reader["surname"].ToString(),
                                               reader["name"].ToString(),
                                               float.Parse(reader["mark"].ToString())));
            }
            reader.Close();
        }

        /// <summary>
        /// Обробник натиснення клавіші "Пошук" по параметру оцінки та номеру школи.
        /// </summary>
        /// <param name="mark">Оцінка за іспити.</param>
        /// <param name="schoolNum">Номер школи.</param>
        private void SelectXYData(float mark, string schoolNum)
        {
            abitResultXY.Clear();
            if (!conn.Ping())
            {
                MessageBox.Show("Співчуваємо, але схоже, що ви не під\'єднані до серверу MySQL.\n Будь ласка, зверніться до системного адміністратора для виправлення неполадок.");
                return;
            }
            DBUtils.CheckTable(conn);

            MySqlDataReader reader = DBUtils.ExecQuery("SELECT surname, name, mark FROM abits where mark>=" 
                           + mark.ToString().Replace(',','.') + " and schoolNumber='" + schoolNum +"';", conn);
            while (reader.Read())
            {
                abitResultXY.Add(new AbitResult(reader["surname"].ToString(),
                                               reader["name"].ToString(),
                                               float.Parse(reader["mark"].ToString())));
            }
            reader.Close();
        }

        /// <summary>
        /// Обробник клавіші "Пошук" (що ліворуч).
        /// </summary>
        private void SearchXBut_Click(object sender, EventArgs e)
        {
            float minMark;
            if (!float.TryParse(minMarkXTxt.Text, out minMark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                return;
            }
            if (minMark > 200 || minMark < 0)
            {
                MessageBox.Show("Оцінка повинна бути в діапазоні 0-200! Спробуйте знову.", "Помилка");
                minMarkXTxt.Focus();
                minMarkXTxt.SelectAll();
                return;
            }
            SelectXData(minMark);
        }

        /// <summary>
        /// Обробник клавіші "Пошук" (що праворуч).
        /// </summary>
        private void SearchXYBut_Click(object sender, EventArgs e)
        {
            float minMark;
            if (!float.TryParse(minMarkXYTxt.Text, out minMark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                return;
            }
            if (minMark > 200 || minMark < 0)
            {
                MessageBox.Show("Оцінка повинна бути в діапазоні 0-200! Спробуйте знову.", "Помилка");
                minMarkXYTxt.Focus();
                minMarkXYTxt.SelectAll();
                return;
            }
            string schoolNum = schoolNumXYTxt.Text;
            schoolNum = schoolNum.Replace("'", " ");
            schoolNum = schoolNum.Trim();
            if (schoolNum == "")
            {
                MessageBox.Show("Вы не ввели номер школи. Спробуйте знову.", "Помилка");
                schoolNumXYTxt.Focus();
                schoolNumXYTxt.SelectAll();
                return;
            }
            if (!Regex.Match(schoolNum, @"^[0-9А-Яа-яёЁЇїІіЄєҐґ -№]+$").Success)
            {
                MessageBox.Show("Було введено некоректний номер школи! Спробуйте знову.", "Помилка");
                schoolNumXYTxt.Focus();
                schoolNumXYTxt.SelectAll();
                return;
            }
            SelectXYData(minMark, schoolNum);
        }

        /// <summary>
        /// Обробник клавіші "Зберегти дані"
        /// </summary>
        private void SaveDataBut_Click(object sender, EventArgs e)
        {
            if (abitResultXY.Count > 0 || abitResultX.Count > 0)
            {
                WordTable writeToWord = new WordTable();
                writeToWord.AddHeader();
                writeToWord.AddParagraphs("\n");
                if ( abitResultXY.Count == 0 && abitResultX.Count > 0 )
                {
                    writeToWord.AddParagraphs("Список зарахованих.");
                    writeToWord.AddTable(abitResultX);
                }
                else if ( abitResultXY.Count > 0 && abitResultX.Count == 0 )
                {
                    writeToWord.AddParagraphs("Список зарахованих по школі.");
                    writeToWord.AddTable(abitResultXY);
                }
                else if (abitResultXY.Count > 0 && abitResultX.Count > 0)
                {
                    writeToWord.AddParagraphs("Список зарахованих.");
                    writeToWord.AddTable(abitResultX);
                    writeToWord.AddParagraphs("\n\n");
                    writeToWord.AddParagraphs("Список зарахованих по школі.");
                    writeToWord.AddTable(abitResultXY);
                }
                  
                writeToWord.Save();
                writeToWord.Close();
            }
            else
                MessageBox.Show("Немає даних для запису!", "Помилка");
        }

        /// <summary>
        /// Обробник події зачинення форми.
        /// Закриває з'єднання з БД та показує батьківську форму.
        /// </summary>
        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            root.Show();
            conn.Close();
        }
    }
}
