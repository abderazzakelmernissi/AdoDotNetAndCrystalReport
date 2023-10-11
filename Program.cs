using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    static class Program
    {

        public static SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=TPADOEFM ;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTableCroise());
        }
    }
}
