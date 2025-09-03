using desagotes.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.ob
{
    public class Usuario
    {
        private long id;
        private String nombre;
        private String contrasena;
        private String descripcion;
        private bool activo;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public bool GuardarUsuario()
        {
            bool resultado = false;
            String vSQL = "";
            vSQL = "insert into usuario (nombre,contrasena,activado)";
            vSQL += "values ('" + this.nombre + "',md5('" + contrasena + "'),',true)";
            try
            {
                Sql.ejecutar(vSQL);
                resultado = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return resultado;
        }

        public bool actualizarContrasena(String xContNueva)
        {
            bool resultado = false;
            String vSQL = "";
            vSQL += "update usuario set contrasena=md5('" + xContNueva + "')";
          
            try
            {
                Sql.ejecutar(vSQL);
                vSQL = "select contrasena from usuario";
                vSQL += " where nombre='" + this.nombre + "'";
                System.Data.DataTable vRes = Sql.getConsultar(vSQL);
                if (vRes != null && vRes.Rows.Count > 0)
                {         
                    this.Contrasena = vRes.Rows[0]["contrasena"].ToString();
                    resultado = true;
                }
                else
                    resultado = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return resultado;
        }

        public bool Logueo(String xUsuario,String xContrasena)
        {

            bool resultado = false;
            String vSQL = "";
            vSQL = "select idusuario,nombre,contrasena,descripcion,activado from usuario";
            vSQL +=" where nombre='" + xUsuario + "' and contrasena=md5('" + xContrasena + "') and activado=true";
            try
            {
                System.Data.DataTable vRes = Sql.getConsultar(vSQL);
                if (vRes != null && vRes.Rows.Count > 0)
                {
                    this.Descripcion = vRes.Rows[0]["descripcion"].ToString();
                    this.Nombre= vRes.Rows[0]["nombre"].ToString();
                    this.activo = Boolean.Parse(vRes.Rows[0]["activado"].ToString());
                    this.Contrasena = vRes.Rows[0]["contrasena"].ToString();
                    this.Id = long.Parse(vRes.Rows[0]["idusuario"].ToString());
                    resultado = true;
                }    
                else
                    resultado = false;
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return resultado;
        }
    }
}
