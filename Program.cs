using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
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
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("EN-US");
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.DateSeparator = "/";
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            bool vErrorSql = false;
            string vPrimeraInstalacion = desagotes.Utils.ObtenerPrimeraInstalacion();
            Console.WriteLine(vPrimeraInstalacion);
            if(vPrimeraInstalacion=="0")
            {
                Application.Run(new FrmPrimerEjecucion());
            }
            else
            {
                try
                {
                    Sql.getConectar();
                }
                catch (Exception e)
                {
                    vErrorSql = true;
                    Console.WriteLine(e);

                }
                if (vErrorSql)
                    Application.Run(new Errores.FrmErrorInicio());
                else
                    Application.Run(new Form1());
            }
           
         
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            Sql.getCerrar();
        }
    }
}
