using System;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>s
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SalaryUI());
        }
    }
}
