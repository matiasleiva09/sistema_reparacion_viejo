using desagotes.sql;
using reparaciones2.ob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DAOUsuario
    {
        public static DataTable getUsuariosCombo()
        {
            String vSQL = "";
            vSQL = "select descripcion from usuario where activado=true order by 1 asc";
            return Sql.getConsultar(vSQL);
        }

        public static void GuardarUsuario(string xNombre,string xContrasena,string xDescripcion,bool xHab,
            long xIdGrupo)
        {
            string vSQL = "insert into usuario (nombre,contrasena,descripcion,activado,token)";
            vSQL += " values ('" + xNombre + "','" + xContrasena + "','" + xDescripcion + "'," + xHab + ",'')";
            Sql.ejecutar(vSQL);
            vSQL = "";
            vSQL = "select idusuario from usuario where nombre='" + xNombre + "'";
            DataRow vUsuario = Sql.getBuscar(vSQL);
            if(vUsuario!=null)
            {
                vSQL = "insert into grupo_usuario_usuario (guuidgrupo,guuidusuario)";
                vSQL += " values (" + xIdGrupo + "," + vUsuario["idusuario"] + ")";
                Sql.ejecutar(vSQL);
            }
            
        }

        public static DataTable getGruposDeUsuario()
        {
            string vSQL = "select guidgrupo as id, gudescripcion as descripcion";
            vSQL+=" from grupo_usuario order by 2 asc";
            return Sql.getConsultar(vSQL);
        }

        public static bool ExisteUsuario(string xUsuario)
        {
            bool vRes = false;
            string vSQL = "select idusuario from usuario where nombre='" + xUsuario.Trim() + "'";
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null && vDato["idusuario"].ToString() != "")
                vRes = true;
            return vRes;
        }

        public static void GuardarGrupo(string xNombre)
        {
            string vSQL = "insert into grupo_usuario"; ;
            vSQL += " (gudescripcion) ";
            vSQL += " values ('"+xNombre + "')";
            Sql.ejecutar(vSQL);
        }

        public static void EditarGrupo(long xId,string xNombre)
        {
            string vSQL = "update grupo_usuario";
            vSQL += " set ";
            vSQL += " gudescripcion='" + xNombre + "'";
            vSQL += " where guidgrupo=" + xId;
            Sql.ejecutar(vSQL);
        }

        public static DataTable BuscarGrupo(string xDescripcion)
        {
            string vSQL = "select guidgrupo as id, gudescripcion as descripcion";
            vSQL += " from grupo_usuario";
            if (xDescripcion.Trim() != "")
                vSQL += " where descripcion like '%" + xDescripcion + "%'";
            vSQL +=" order by 2 asc";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable CmbGrupos()
        {
            string vSQL = "select guidgrupo as id, gudescripcion as value";
            vSQL += " from grupo_usuario";
            vSQL += " order by 2 asc";
            return Sql.getConsultar(vSQL);
        }

        public static void CambiarGrupo(string xNombreUsuario,long xIdGrupo)
        {
            string vSQL = "select idusuario from usuario where nombre='" + xNombreUsuario + "'";
            DataRow vIdUsuario = Sql.getBuscar(vSQL);
            if(vIdUsuario!=null && vIdUsuario["idusuario"].ToString()!="")
            {
                vSQL = "";
                vSQL = "update grupo_usuario_usuario";
                vSQL += " set";
                vSQL += " guuidgrupo=" + xIdGrupo;
                vSQL += " where guuidusuario=" +vIdUsuario["idusuario"].ToString();
                Sql.ejecutar(vSQL);
            }
        }

        public static bool PerteneceGrupo(long xId, String xGrupo)
        {
            bool vPertenece = false;
            String vSQL = "select * from grupo_usuario_usuario as guu";
            vSQL += " inner join grupo_usuario as gu on guu.guuidgrupo = guidgrupo";
            vSQL += " where gu.gudescripcion = '" + xGrupo + "'  and guuidusuario =" + xId;
            DataRow vResultado = Sql.getBuscar(vSQL);
            Console.WriteLine(vSQL);
            vSQL = null;
            if (vResultado != null)
                vPertenece = true;
            vResultado = null;
            return vPertenece;
        }

        public static DataTable ObtenerUsuariosTabla()
        {
            String vSQL = "";
            vSQL = "select idusuario as \"Id\", nombre as \"Usuario\",";
            vSQL += " descripcion as \"Descripcion\", activado as \"Activo\",";
            vSQL += " guidgrupo as \"Id Grupo\", gudescripcion as \"Grupo\"";
            vSQL += " from usuario as u";
            vSQL += " left join grupo_usuario_usuario as guu on guuidusuario=idusuario";
            vSQL += " left join grupo_usuario as gu on guu.guuidgrupo = gu.guidgrupo";
            vSQL +=" order by nombre asc;";
            return Sql.getConsultar(vSQL);
        }

        public static DataTable ObtenerUsuariosTabla(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select idusuario as \"Id\", nombre as \"Usuario\",";
            vSQL += " descripcion as \"Descripcion\", activado as \"Activo\",";
            vSQL += " guidgrupo as \"Id Grupo\", gudescripcion as \"Grupo\"";
            vSQL += " from usuario as u";
            vSQL += " left join grupo_usuario_usuario as guu on guuidusuario=idusuario";
            vSQL += " left join grupo_usuario as gu on guu.guuidgrupo = gu.guidgrupo";
            vSQL += " where";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " nombre like '%" + xFiltro + "%'";
                vSQL += " or descripcion like '%" + xFiltro + "%'";
            }
            vSQL +=" order by nombre asc;";
            return Sql.getConsultar(vSQL);
        }

        public static Usuario getUsuario(String xUsuario)
        {
            Usuario vUsuario = null;
            string vSQL = "select * from usuario";
            vSQL += " where nombre='" + xUsuario + "'";
            DataRow vQuery = Sql.getBuscar(vSQL);
            if(vQuery!=null)
            {
                vUsuario = new Usuario();
                vUsuario.Descripcion = vQuery["descripcion"].ToString();
                vUsuario.Nombre = vQuery["nombre"].ToString();
                vUsuario.Contrasena = vQuery["contrasena"].ToString();
            }
            return vUsuario;
        }

        public static bool DarDeAltaoBaja(String xUsuario,bool xEstado)
        {
            String vSQL = "";
            bool vRes = true;
            vSQL = "update usuario set";
            if (xEstado)
                vSQL += " activado =false";
            else
                vSQL += " activado=true";
            vSQL += " where nombre='" + xUsuario + "'";
            try
            {
                Sql.ejecutar(vSQL);
            }
            catch(Exception e)
            {
                vRes = false;
            }
            return vRes;
        }
    }
}
