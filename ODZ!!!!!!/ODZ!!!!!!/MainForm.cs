﻿using System;
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
            
        }

        private void ChangeDataBut_Click(object sender, EventArgs e)
        {
            RedactionForm f2 = new RedactionForm(this);
            f2.Show();
            Hide();
        }

        private void SelectDataBut_Click(object sender, EventArgs e)
        {
            SearchForm f3 = new SearchForm(this);
            f3.Show();
            Hide();
        }
    }
}
