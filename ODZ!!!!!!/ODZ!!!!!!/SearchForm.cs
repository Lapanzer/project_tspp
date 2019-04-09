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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            dGVX.AllowUserToAddRows = false;
            dGVXY.AllowUserToAddRows = false;
        }
    }
}
