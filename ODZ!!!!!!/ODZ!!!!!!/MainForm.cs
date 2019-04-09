using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ODZ______
{
    /// <summary>
    /// Start form with greeting
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RedactionForm f2 = new RedactionForm();
            f2.Show();
            SearchForm f3 = new SearchForm();
            f3.Show();
        }
    }
}
