using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OKF_Jelenetes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OKF_Jelentes_Iro());
        }
    }
}
