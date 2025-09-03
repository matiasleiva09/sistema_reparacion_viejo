using desagotes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2
{
    public partial class FrmEspera : Form
    {
        public FrmEspera()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnSalir.Enabled = false;
            try
            {
                progressBar.Value = 10;
                System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
                Environment.SetEnvironmentVariable("PGPASSWORD", "1234");
                DateTime vFecha = DateTime.Now;
                String vPath = Utils.ObtenerPathBackups();
                String vArchivoBackup = +vFecha.Day + "_" + vFecha.Month + "_" + vFecha.Year + "_" + vFecha.Hour + vFecha.Minute + vFecha.Second + "reparaciones.backup";
                info.FileName = Utils.ObtenerPathPostgreSQL();
                info.Arguments = "  --host localhost --port 5432 --username \"postgres\" --format custom --blobs --encoding UTF8 --verbose --file \"" + vPath + vArchivoBackup + "\"  \"reparaciones\"";
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = info;
                proc.Start();
                proc.WaitForExit();
                proc.Close();
                progressBar.Value = 50;
                utils.sftp.UploadSFTPFile("200.58.123.121", "matiasleiva", "30SEP1986", vPath + vArchivoBackup, "/home/matiasleiva/backups/maccenter", 22);
                /* Sftp vClienteFTP = new Sftp();
                vClienteFTP.Connect("simeltech.com.ar");
                vClienteFTP.Login("matiasleiva", "30SEP1986");
                vClienteFTP.PutFile(vPath+ vArchivoBackup, "/home/matiasleiva/backups/" + vArchivoBackup);
                vClienteFTP.Disconnect();*/
                progressBar.Value = 100;
                MessageBox.Show("Se ha completado la operación", "Exito!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message,"ERROR!");
                this.Close();
            }
          
           
        }

        private void FrmEspera_Load(object sender, EventArgs e)
        {
         
        }
    }
}
