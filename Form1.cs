using desagotes.sql;
using reparaciones2.ob;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text.Trim()!="" && txtcontrasena.Text.Trim()!="")
            {
                Usuario vUsuario = new Usuario();
                bool vRes = vUsuario.Logueo(txtusuario.Text.Trim(), txtcontrasena.Text.Trim());
                if(vRes)
                {
                    Main vFormulario = new reparaciones2.Main();
                    vFormulario.UsuarioSesion = vUsuario;
                    vFormulario.Text = vFormulario.Text + "     INICIADO SESION COMO: " + vUsuario.Descripcion;
                    this.Hide();
                    vFormulario.ShowDialog();
                    //vFormulario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o cotraseña incorrectos", "Atención!");
                }
              
            }
            else
            {
                MessageBox.Show("Ingrese los campos obligatorios", "Atención!");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
