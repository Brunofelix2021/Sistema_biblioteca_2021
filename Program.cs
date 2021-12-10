using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaProjeto
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

            Global.LerAppConfig();

         frmLogin ofrmLogin = new frmLogin();
         ofrmLogin.ShowDialog();

         if (ofrmLogin.DialogResult == DialogResult.OK)
         {
            Application.Run(new lblUsuario());
         }
        }
    }
}
