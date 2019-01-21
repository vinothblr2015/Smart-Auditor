using System;
using System.Windows.Forms;
using Auditor.Views;

namespace Auditor
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
            new FrmLogin().Show();
            Application.Run();                                   
        }
    }
}
