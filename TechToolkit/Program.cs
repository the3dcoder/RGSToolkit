using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace $safeprojectname$
{
    static class Program
    {
        public static string Server = string.Empty;
        public static string Database = string.Empty;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }

    }

}
