using FINAL_GSCPMS_OOP_PROJECT.Forms.Accounts;
using FINAL_GSCPMS_OOP_PROJECT.Forms.Admin;
using FINAL_GSCPMS_OOP_PROJECT.Forms.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_GSCPMS_OOP_PROJECT
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
