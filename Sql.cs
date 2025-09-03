using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desagotes.sql
{
    static class Sql
    {
        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable();
        private static NpgsqlConnection conn = null;



        public static void getConectar()
        {
            string connstring = String.Format(Utils.ObtenerPathBase());
            Console.WriteLine(connstring);
            conn = new NpgsqlConnection(connstring);
            conn.Open();
        }

        public static DataTable getConsultar(String xSQL)
        {
            DataSet ds = new DataSet();
            dt = new DataTable();
          //  getConectar();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(xSQL, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            //getCerrar();
            return dt;
        }

        public static DataRow getBuscar(String xSQL)
        {
            DataTable vRes = getConsultar(xSQL);
            if (vRes != null && vRes.Rows.Count > 0)
                return vRes.Rows[0];
            else
                return null;
        }

        public static void ejecutar(String xSQL)
        {
           // getConectar();
            NpgsqlCommand cmd = new NpgsqlCommand(xSQL, conn);
            cmd.ExecuteNonQuery();
            //getCerrar();
        }

        public static void getCerrar()
        {
            conn.Close();
        }

    }
}
