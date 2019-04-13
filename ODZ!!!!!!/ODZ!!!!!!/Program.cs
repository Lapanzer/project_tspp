using System;
using System.Windows.Forms;

namespace ODZ______
{
    static class Program
    {
        /// <summary>
        /// Точка входу додатку.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
