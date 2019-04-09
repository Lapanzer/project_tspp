using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        }

        private void DBConnect()
        {
            conn = DBUtils.GetDBConnection();
        }

        private void SearchXBut_Click(object sender, EventArgs e)
        {
            float minMark;
            if (!float.TryParse(minMarkXTxt.Text, out minMark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                return;
            }
        }

        private void SearchXYBut_Click(object sender, EventArgs e)
        {
            float minMark;
            if (!float.TryParse(minMarkXYTxt.Text, out minMark))
            {
                MessageBox.Show("Було введено некоректне число! Спробуйте знову.", "Помилка");
                return;
            }
            string schoolNum = schoolNumXYTxt.Text;
            schoolNum = schoolNum.Replace("'", " ");
            schoolNum = schoolNum.Trim();
            ;
        }

        private void SaveDataBut_Click(object sender, EventArgs e)
        {
            //...
        }

        /// <summary>
        /// Show main form before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            root.Show();
        }
    }
}
