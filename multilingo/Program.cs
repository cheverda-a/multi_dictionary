using System;
using System.Web.Services.Description;
using System.Windows.Forms;
using Multilingo.SQL;

namespace Multilingo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormInitial());
        }

    }
}
