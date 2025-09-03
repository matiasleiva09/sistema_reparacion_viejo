using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desagotes
{
    class Utils
    {
        public static bool isNumeric(String s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public static KeyPressEventArgs ValidarNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.') && ! char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            return e;
        }

        public static bool ComprobarFormatoEmail(string xEmail)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(xEmail, sFormato))
            {
                if (Regex.Replace(xEmail, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static String getFormatearFechaYHora(String xBase)
        {
            String[] vFechayHora = xBase.Split(' ');
            String[] vFecha = vFechayHora[0].Split('-');
            return vFecha[2] + "/" + vFecha[1] + "/" + vFecha[0];
        }


        public static String getFormatearFecha(String xBase)
        {
            String[] vFecha = xBase.Split('-');
            return vFecha[2] + "/" + vFecha[1] + "/" + vFecha[0];
        }


        public static String getFechaYHoraBase(String xFecha)
        {
            String[] vFechayHora = xFecha.Split(' ');
            String[] vFecha = vFechayHora[0].Split('/');

            return vFecha[2] + "-" + vFecha[1] + "-" + vFecha[0] + " " + vFechayHora[1];
        }

        public static String getFechaSinHoraBase(String xFecha)
        {
            String[] vFechayHora = xFecha.Split(' ');
            String[] vFecha = vFechayHora[0].Split('/');

            return vFecha[2] + "-" + vFecha[1] + "-" + vFecha[0];
        }

        public static String getFechaBase(String xFecha)
        {
            String[] vFecha = xFecha.Split('/');
            String[] vAnoyHora = vFecha[2].Split(' ');

            return vAnoyHora[0] +"-" + vFecha[1] + "-" + vFecha[0] + " " + vAnoyHora[1];
        }

        public static String getFechaBase(DateTime xFecha)
        {
            string vResultado = "";
            vResultado= xFecha.Year +"-" + xFecha.Month + "-" + xFecha.Day;
            return vResultado;
        }

        public static String getFechaSinHora(String xFecha)
        {
            String[] vFechaSola = xFecha.Split(' ');
            String[] vFecha = vFechaSola[0].Split('/');
            return vFecha[0] + "-" + vFecha[1] + "-" + vFecha[2];
        }

        public static String ObtenerPathDOCS()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            //Read the first line of text
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath=vPath.Replace("Ruta_documentos=", "");
            return vPath;
        }

        public static String ObtenerDatosVersiones()
        {
            StreamReader sr = new StreamReader("Version.txt");
            String vDatos = "";
            vDatos = sr.ReadToEnd();
            sr.Close();
            sr = null;
            return vDatos;
        }

        public static String ObtenerPathBackups()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            //Read the first line of text
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath=vPath.Replace("Ruta_Backups=", "");
            return vPath;
        }

        public static String ObtenerPathPostgreSQL()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            //Read the first line of text
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath = vPath.Replace("Ruta_Postgres=", "");
            return vPath;
        }

        public static String ObtenerPathBase()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            //Read the first line of text
            sr.ReadLine();
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath = vPath.Replace("Base_Datos=", "");
            return vPath;
        }

        public static bool GuardarConfiguraciones(String xPathDoc,String xPathBase,String xPathLogo)
        {
            String vPathDoc = "Ruta_documentos=";
            String vPathBase = "Base_Datos=";
            String vPathLogo = "Ruta_Fondo=";
            String vPathPostreSQL = "Ruta_Postgres=";
            String vPathBackup = "Ruta_Backups=";
            String vPrimeraEjecucion = "Primera_Instalacion=1";
            bool vResultado = true;
            if (xPathDoc == "")
                vPathDoc+= ObtenerPathDOCS();
            else
                vPathDoc+= xPathDoc;

            if (xPathBase == "")
                vPathBase += ObtenerPathBase();
            else
                vPathBase += xPathBase;

            if (xPathLogo == "")
                vPathLogo += ObtenerPathFondo();
            else
                vPathLogo += xPathLogo;
            string vDatosPostgres = ObtenerPathPostgreSQL();
            string vDatosBackup = ObtenerPathBackups();
            try
            {
                StreamWriter sw = new StreamWriter("Configuracion.txt");
                sw.WriteLine(vPathDoc);
                sw.WriteLine(vPathBase);
                sw.WriteLine(vPathLogo);
                sw.WriteLine(vPathPostreSQL + vDatosPostgres);
                sw.WriteLine(vPathBackup + vDatosBackup);
                sw.WriteLine(vPrimeraEjecucion);
                sw.Close();
                sw = null;
            }
            catch(IOException ex)
            {
                vResultado = false;
                Console.WriteLine(ex);
                /*  string oldName = "Configuracion.txt";
                  string newName = "Configuracion2.txt";
                  System.IO.File.Move(oldName, newName);
                  oldName = "ConfiguracionCopia.txt";
                  newName = "Configuracion.txt";
                  System.IO.File.Move(oldName, newName);*/
            }
            return vResultado;

        }

        public static String ObtenerPathFondo()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            sr.ReadLine();
            sr.ReadLine();
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath=vPath.Replace("Ruta_Fondo=", "");
            return vPath;
        }

        public static String ObtenerPrimeraInstalacion()
        {
            StreamReader sr = new StreamReader("Configuracion.txt");
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            String vPath = sr.ReadLine();
            sr.Close();
            sr = null;
            vPath = vPath.Replace("Primera_Instalacion=", "");
            return vPath;
        }

        public static String EvitarCaractereres(String xTexto)
        {
            xTexto = xTexto.Replace("'", " ");
            xTexto = xTexto.Replace("\\"," ");
            return xTexto;
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static void ExportarDataGridViewExcel(System.Windows.Forms.DataGridView grd,String xNombre)
        {
            SaveFileDialog fichero = new SaveFileDialog();
             fichero.Filter = "Excel (*.xls)|*.xls";
             if (fichero.ShowDialog() == DialogResult.OK)
             {
                
                Microsoft.Office.Interop.Excel.Application aplicacion;
                 Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                 Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                 aplicacion = new Microsoft.Office.Interop.Excel.Application();
                 libros_trabajo = aplicacion.Workbooks.Add();
                 hoja_trabajo =
                     (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                int vindiceex = 1;
                for (int j = 0; j < grd.Columns.Count; j++)
                {
                    hoja_trabajo.Cells[vindiceex, j + 1] = grd.Columns[j].HeaderText.ToString();
                    Console.WriteLine(grd.Columns[j].HeaderText.ToString());
                }
                vindiceex = vindiceex+ 1;
                for (int i = 0; i < (grd.Rows.Count -1); i++)
                 {
                     for (int j = 0; j <(grd.Columns.Count); j++)
                     {
                     
                        hoja_trabajo.Cells[vindiceex, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                     }
                    vindiceex = vindiceex+ 1;
                }
                 libros_trabajo.SaveAs(fichero.FileName,
                     Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                 libros_trabajo.Close(true);
                 aplicacion.Quit();
                libros_trabajo = null;
                System.Diagnostics.Process.Start(fichero.FileName);
                
            }
        }

        public static float CalcularMontoFinal(float vNeto,float vIVA)
        {
            return vNeto *(1 + (vIVA / 100));
        }

       /* public static bool EncontradoEnTablaEnteros(DataTable xRes,int xNumero)
        {
            bool vRes = false;
            int i = 0;
            int vItem = 0;
            while(i<xRes.Rows.Count && !vRes)
            {
                vItem = xRes.Rows.
                if(xRes.Rows[i])
            }
            return vRes;
        }*/

    }
}
