using ManagerStudentApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerStudentApp
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
            frmLogin frmLg = new frmLogin();
            while(frmLg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
            
        }
    }
}
