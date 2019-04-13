using System;
using System.Windows.Forms;

namespace ODZ______
{
    /// <summary>
    /// Форма привітання.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обробник натиснення клавіші "Керування даними".
        /// </summary>
        private void ChangeDataBut_Click(object sender, EventArgs e)
        {
            RedactionForm f2 = new RedactionForm(this);
            f2.Show();
            Hide();
        }

        /// <summary>
        /// Обробник натиснення клавіші "Пошук даних".
        /// </summary>
        private void SelectDataBut_Click(object sender, EventArgs e)
        {
            SearchForm f3 = new SearchForm(this);
            f3.Show();
            Hide();
        }
    }
}
