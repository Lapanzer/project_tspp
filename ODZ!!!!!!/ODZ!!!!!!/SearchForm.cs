using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Win32;

using Word =  Microsoft.Office.Interop.Word;

namespace ODZ______
{
    public partial class SearchForm : Form
    {
        private MainForm root;
        private MySqlConnection conn;

        public SearchForm(MainForm r)
        {
            InitializeComponent();
            root = r;
            dGVX.AllowUserToAddRows = false;
            dGVXY.AllowUserToAddRows = false;
            SampleAbit sa = new SampleAbit();
            DBConnect();
        }

        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
        }

        private void SelectXData(float mark)
        {
            abitResultX.Clear();
            MySqlDataReader reader = DBMySQLUtils.ExecQuery("SELECT surname, name, mark FROM abits where mark>=" 
                                                           + mark.ToString().Replace(',', '.') + ";", conn);
            while (reader.Read())
            {
                abitResultX.Add(new AbitResult(reader["surname"].ToString(),
                                               reader["name"].ToString(),
                                               float.Parse(reader["mark"].ToString())));
            }
            reader.Close();
        }

        private void SelectXYData(float mark, string schoolNum)
        {
            abitResultXY.Clear();
            MySqlDataReader reader = DBMySQLUtils.ExecQuery("SELECT surname, name, mark FROM abits where mark>=" 
                           + mark.ToString().Replace(',','.') + " and schoolNumber='" + schoolNum +"';", conn);
            while (reader.Read())
            {
                abitResultXY.Add(new AbitResult(reader["surname"].ToString(),
                                               reader["name"].ToString(),
                                               float.Parse(reader["mark"].ToString())));
            }
            reader.Close();
        }

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

            SelectXYData(minMark, schoolNum);
        }

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
                 {
                    MessageBox.Show("Немає даних для запису!", "Помилка");
                 }


        }

        /// <summary>
        /// Show main form before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            root.Show();
            conn.Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
