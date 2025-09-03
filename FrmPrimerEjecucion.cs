using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmPrimerEjecucion : Form
    {
        public FrmPrimerEjecucion()
        {
            InitializeComponent();
        }

        private void FrmPrimerEjecucion_Load(object sender, EventArgs e)
        {
           
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
            vFormularioProgreso.Texto = "INSTALANDO LA BASE DE DATOS, POR FAVOR ESPERE";
            vFormularioProgreso.Show();
            vFormularioProgreso.Barra.Value = 10;

          Process p = new Process();

           ProcessStartInfo psi = new ProcessStartInfo(Application.StartupPath + "\\INSTALARBASE\\postgres.exe");
           psi.Arguments = " --unattendedmodeui minimal --mode unattended --superpassword \"1234\" --servicename \"postgreSQL\" --servicepassword \"1234\" --serverport 5432";
           p.StartInfo = psi;
           p.Start();
           p.WaitForExit();
            p.Close();
           vFormularioProgreso.Texto = "ARMANDO LA ESTRUCTURA DE LA BASE DE DATOS";
           vFormularioProgreso.Barra.Value = 30;

            try
            {
                var arg = "/c cd  \"C:\\Program Files (x86)\\PostgreSQL\\10\\bin\" && SET PGPASSWORD=1234&& psql.exe -U postgres -d postgres -a -f  \"" + Application.StartupPath + "\\INSTALARBASE\\crearbase.sql\" && ";
                arg += "pg_restore.exe --host localhost --port 5432 --username postgres --dbname reparaciones --verbose  \"" + Application.StartupPath + "\\INSTALARBASE\\sistema.backup\" ";
                Process.Start("cmd.exe", arg);
                Console.WriteLine(arg);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                var arg = "/c cd  \"C:\\Program Files\\PostgreSQL\\10\\bin\" && SET PGPASSWORD=1234&& psql.exe -U postgres -d postgres -a -f  \"" + Application.StartupPath + "\\INSTALARBASE\\crearbase.sql\" && ";
                arg += "pg_restore.exe --host localhost --port 5432 --username postgres --dbname reparaciones --verbose  \"" + Application.StartupPath + "\\INSTALARBASE\\sistema.backup\" ";
                Process.Start("cmd.exe", arg);
                Console.WriteLine(arg);
            }
            
            vFormularioProgreso.Texto = "COPIANDO LA BASE DE DOCUMENTOS";
            vFormularioProgreso.Barra.Value = 70;
            try
            {
                DirectoryCopy(Application.StartupPath + "\\DOCS", "C:\\DOCS", true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            vFormularioProgreso.Barra.Value = 100;
            vFormularioProgreso.Close();
            desagotes.Utils.GuardarConfiguraciones("", "", "");
            this.Close();
        }

        static void ExecuteCommand(string command)
        {
            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true; //Esta propiedad oculta la consola
            processInfo.UseShellExecute = false;

            process = Process.Start(processInfo);
            process.WaitForExit();

            exitCode = process.ExitCode; //Si tu bat tiene exit code lo obtendrá aquí

            process.Close();
        }

    }
}
