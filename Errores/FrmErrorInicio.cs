using desagotes.sql;
using reparaciones2.Configuracion;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace reparaciones2.Errores
{
    public partial class FrmErrorInicio : Form
    {
        private String mError = "";
        private String mTipo = "";

        public String Error
        {
            get { return mError; }
            set { mError = value; }
        }

        public String Tipo
        {
            get { return mTipo; }
            set { mTipo = value; }
        }


        public FrmErrorInicio()
        {
            InitializeComponent();
        }

        private void FrmErrorInicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool vErrorSql = false;
            try
            {
                Sql.getConectar();
            }
            catch (Exception ex)
            {
                vErrorSql = true;
                MessageBox.Show(ex.Message);

            }
            if (vErrorSql)
                MessageBox.Show("SEGUIMOS CON ERROR!","ERROR!");
            else
            {
                Form1 vFormulario = new Form1();
                this.Hide();
                vFormulario.ShowDialog();
                this.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConfiguracionDatos vFormulario = new FrmConfiguracionDatos();
            vFormulario.Show();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstalarServicios_Click(object sender, EventArgs e)
        {
            FrmProcesoGeneral vFormularioProgreso = new FrmProcesoGeneral();
            vFormularioProgreso.Texto = "GUARDANDO INFORMACION, POR FAVOR ESPERE";
            vFormularioProgreso.Show();
            vFormularioProgreso.Barra.Value = 10;

            Process p = new Process();
            
            ProcessStartInfo psi = new ProcessStartInfo(Application.StartupPath + "\\INSTALARBASE\\postgres.exe");
            psi.Arguments = " --unattendedmodeui minimal --mode unattended --superpassword \"1234\" --servicename \"postgreSQL\" --servicepassword \"1234\" --serverport 5432";
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
            p.Close();

            psi = new ProcessStartInfo(Application.StartupPath + "\\INSTALARBASE\\instalarbase.bat");
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
            p.Close();
            /*   Process p = new Process();
           ProcessStartInfo info = new ProcessStartInfo();
           info.FileName = "cmd.exe";
           info.RedirectStandardInput = true;
           info.UseShellExecute = false;
           info.CreateNoWindow = false;

           p.StartInfo = info;
           p.StartInfo.UseShellExecute = false;
           p.Start();

          using (StreamWriter sw = p.StandardInput)
           {
               if (sw.BaseStream.CanWrite)
               {


               string vPath = Application.StartupPath;
                  sw.WriteLine((vPath.Split(':')[0]) + ":");
                    MessageBox.Show("cd " + (vPath.Split(':')[1]).Substring(1) + "\\INSTALARBASE");
                  sw.WriteLine("cd " + (vPath.Split(':')[1]).Substring(1) + "\\INSTALARBASE");
                  sw.WriteLine("instalarbase.bat");
                   Console.WriteLine(vPath.Split(':')[0]);
       }
        }*/

            /*System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();


          info.FileName = Application.StartupPath + "\\INSTALARBASE\\instalarbase.bat";
           MessageBox.Show(Application.StartupPath + "\\INSTALARBASE\\instalarbase.bat");
           info.CreateNoWindow = false;
           info.UseShellExecute = false;

           info.RedirectStandardInput = true;
           System.Diagnostics.Process proc = new System.Diagnostics.Process();
          
           proc.StartInfo = info;
           proc.Start();
           proc.WaitForExit();
           proc.Close();*/

            vFormularioProgreso.Barra.Value = 100;
           vFormularioProgreso.Close();
        }
    }
}
