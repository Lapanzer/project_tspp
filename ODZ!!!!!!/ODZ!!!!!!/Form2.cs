using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ODZ______
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dGV1.AllowUserToAddRows = false;

            MySqlConnection conn = DBUtils.GetDBConnection();
            ;
        }
    }
}
