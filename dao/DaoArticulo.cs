using desagotes.sql;
using reparaciones2.ob.insumos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.dao
{
    public static class DaoArticulo
    {
        public static bool ExisteCodigo(String xCodigo, long xId)
        {
            bool vRes = false;
            String vSQL = "";
            vSQL = "select idproducto, codigobarra";
            vSQL += " from producto";
            vSQL += " where codigobarra='" + xCodigo + "'";
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                long vIdEncontrado = long.Parse(vDato["idproducto"].ToString());
                if (xId > 0 && vIdEncontrado != xId)
                    vRes = true;
            }
            vDato = null;
            return vRes;
        }

        public static void Guardar(Articulo xArticulo)
        {
            string vIdProveedor = "null";
            string vIdModelo = "null";
            string vIdMarca = "null";
            if (xArticulo.Proveedor != null)
                vIdProveedor = xArticulo.Proveedor.Id + "";
            if (xArticulo.Marca != null)
                vIdMarca = xArticulo.Marca.Id + "";
            if (xArticulo.Modelo != null)
                vIdModelo = xArticulo.Modelo.Id + "";
            String vSQL = "";
            vSQL = "insert into producto";
            vSQL += " (codigobarra,nombre,idproveedor,marca,tipo,costo";
            vSQL += ",iva,ganancia,monto,stockminimo,stockmaximo,stockactual,unidad)";
            vSQL += " values";
            vSQL += " ('" + xArticulo.Codigo + "','" + xArticulo.Nombre + "'," + vIdProveedor + ",";
            vSQL += "" + vIdMarca + "," + vIdModelo + "," + xArticulo.Costo + ",";
            vSQL += xArticulo.Iva + "," + xArticulo.Ganancia + "," + xArticulo.Monto;
            vSQL += "," + xArticulo.StockMinimo + "," + xArticulo.StockMaximo + "," + xArticulo.StockActual + ",'" + xArticulo.Unidad + "')";
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static Articulo ObtenerPorId(long xId)
        {
            String vSQL = "";
            Articulo vArticulo = new ob.insumos.Articulo();
            vSQL = "select idproducto,codigobarra,nombre,idproveedor,marca,tipo,costo";
            vSQL += ",iva,ganancia,monto,stockminimo,stockmaximo,stockactual,unidad";
            vSQL += " from producto";
            vSQL += " where idproducto=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vArticulo.Id = long.Parse(vDato["idproducto"].ToString());
                vArticulo.Nombre = vDato["nombre"].ToString();
                vArticulo.Codigo = vDato["codigobarra"].ToString();
                vArticulo.Unidad = vDato["unidad"].ToString();
                Proveedor vProveedor = null;
                if (vDato["idproveedor"].ToString() != null && vDato["idproveedor"].ToString() != "")
                    vProveedor = DaoProveedor.ObtenerProveedor(long.Parse(vDato["idproveedor"].ToString()));
                vArticulo.Proveedor = vProveedor;
                if (vDato["marca"].ToString() != null && vDato["marca"].ToString() != "")
                    vArticulo.Marca = DaoMarcaDiccionario.ObtenerPorId(long.Parse(vDato["marca"].ToString()));

                if (vDato["tipo"].ToString() != null && vDato["tipo"].ToString() != "")
                    vArticulo.Modelo = DaoTipo.ObtenerPorId(long.Parse(vDato["tipo"].ToString()));
                vArticulo.Costo = float.Parse(vDato["costo"].ToString());
                vArticulo.Iva = float.Parse(vDato["iva"].ToString());
                vArticulo.Ganancia = float.Parse(vDato["ganancia"].ToString());
                vArticulo.Monto = float.Parse(vDato["monto"].ToString());
                vArticulo.StockMinimo = long.Parse(vDato["stockminimo"].ToString());
                vArticulo.StockMaximo = long.Parse(vDato["stockmaximo"].ToString());
                vArticulo.StockActual = long.Parse(vDato["stockactual"].ToString());
            }
            return vArticulo;
        }

        public static DataRow ObtenerMontoNetoIVA(String xCodigo)
        {
            DataRow vResultado;
            String vSQL = "select costo,iva,monto from producto";
            vSQL += " where codigobarra='" + xCodigo + "'";
            vResultado = Sql.getBuscar(vSQL);
            Console.WriteLine(vSQL);
            return vResultado;
        }

        public static double ObtenerMontoPublico(string xId)
        {
            double vResultado = 0.00;
            String vSQL = "select monto from producto where idproducto=" + xId;
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
                vResultado = double.Parse(vDato["monto"].ToString());
            return vResultado;
        }

        public static double ObtenerMontoPublicCodigo(string xCodigo)
        {
            double vResultado = 0.00;
            string vSQL = "select monto from producto where codigobarra='" + xCodigo + "'";
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
                vResultado = double.Parse(vDato["monto"].ToString());
            return vResultado;
        }

        public static Articulo BuscarPorCodigo(String xCodigo)
        {
            Articulo vArticulo = null;
            String vSQL = "";
            vSQL = "select idproducto,codigobarra,nombre,idproveedor,marca,tipo,costo";
            vSQL += ",iva,ganancia,monto,stockminimo,stockmaximo,stockactual,unidad";
            vSQL += " from producto as prod";
            vSQL += " where codigobarra='" + xCodigo + "'";
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vArticulo = new Articulo();
                vArticulo.Id = long.Parse(vDato["idproducto"].ToString());
                vArticulo.Nombre = vDato["nombre"].ToString();
                vArticulo.Codigo = vDato["codigobarra"].ToString();
                vArticulo.Unidad = vDato["unidad"].ToString();
                if (vDato["idproveedor"] != null && vDato["idproveedor"].ToString() != "")
                    vArticulo.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(vDato["idproveedor"].ToString()));

                if (vDato["marca"] != null && vDato["marca"].ToString() != "")
                    vArticulo.Marca = DaoMarcaDiccionario.ObtenerPorId(long.Parse(vDato["marca"].ToString()));

                if (vDato["tipo"] != null && vDato["tipo"].ToString() != "")
                    vArticulo.Modelo = DaoTipo.ObtenerPorId(long.Parse(vDato["tipo"].ToString()));
                vArticulo.Costo = float.Parse(vDato["costo"].ToString());
                vArticulo.Iva = float.Parse(vDato["iva"].ToString());
                vArticulo.Ganancia = float.Parse(vDato["ganancia"].ToString());
                vArticulo.Monto = float.Parse(vDato["monto"].ToString());
                vArticulo.StockMinimo = long.Parse(vDato["stockminimo"].ToString());
                vArticulo.StockMaximo = long.Parse(vDato["stockmaximo"].ToString());
                vArticulo.StockActual = long.Parse(vDato["stockactual"].ToString());

            }
            return vArticulo;
        }

        public static Articulo BuscarPorId(long xId)
        {
            Articulo vArticulo = null;
            String vSQL = "";
            vSQL = "select idproducto,codigobarra,nombre,idproveedor,marca,tipo,costo";
            vSQL += ",iva,ganancia,monto,stockminimo,stockmaximo,stockactual,unidad";
            vSQL += " from producto as prod";
            vSQL += " where idproducto='" + xId + "'";
            DataRow vDato = Sql.getBuscar(vSQL);
            if (vDato != null)
            {
                vArticulo = new Articulo();
                vArticulo.Id = long.Parse(vDato["idproducto"].ToString());
                vArticulo.Nombre = vDato["nombre"].ToString();
                vArticulo.Codigo = vDato["codigobarra"].ToString();
                vArticulo.Unidad = vDato["unidad"].ToString();
                if (vDato["idproveedor"] != null && vDato["idproveedor"].ToString() != "")
                    vArticulo.Proveedor = DaoProveedor.ObtenerProveedor(long.Parse(vDato["idproveedor"].ToString()));

                if (vDato["marca"] != null && vDato["marca"].ToString() != "")
                    vArticulo.Marca = DaoMarcaDiccionario.ObtenerPorId(long.Parse(vDato["marca"].ToString()));

                if (vDato["tipo"] != null && vDato["tipo"].ToString() != "")
                    vArticulo.Modelo = DaoTipo.ObtenerPorId(long.Parse(vDato["tipo"].ToString()));
                vArticulo.Costo = float.Parse(vDato["costo"].ToString());
                vArticulo.Iva = float.Parse(vDato["iva"].ToString());
                vArticulo.Ganancia = float.Parse(vDato["ganancia"].ToString());
                vArticulo.Monto = float.Parse(vDato["monto"].ToString());
                vArticulo.StockMinimo = long.Parse(vDato["stockminimo"].ToString());
                vArticulo.StockMaximo = long.Parse(vDato["stockmaximo"].ToString());
                vArticulo.StockActual = long.Parse(vDato["stockactual"].ToString());

            }
            return vArticulo;
        }

        public static DataTable ListarArticulos(String xFiltro)
        {
            String vSQL = "";
            vSQL = "select  idproducto as \"Id\",unidad as \"Unidad\", codigobarra  as \"Codigo\",prod.nombre as  \"Nombre\",";
            vSQL += "prov.nombre as \"Proveedor\",ma.descripcion as \"Marca\",tp.descripcion as \"Tipo\", ";
            vSQL += " costo as \"Costo\",iva as \"IVA\",ganancia as \"Ganancia\", ";
            vSQL += " monto as \"Monto Pub.\",stockminimo as \"Stock Min.\",stockmaximo as \"Stock Max.\", ";
            vSQL += " stockactual as \"Stock Actual\"";
            vSQL += " from producto as prod";
            vSQL += " left join proveedor prov on prov.idproveedor=prod.idproveedor";
            vSQL += " left join tipo_producto tp on tp.idtipo_producto=prod.tipo";
            vSQL += " left join marca ma on ma.idmarca=prod.marca";
            if (xFiltro != null && xFiltro.Trim() != "")
            {
                vSQL += " where codigobarra='" + xFiltro + "'";
                vSQL += " or prod.nombre like '%" + xFiltro + "%'";
                vSQL += " or prov.nombre like '%" + xFiltro + "%'";
                vSQL += " or ma.descripcion like '%" + xFiltro + "%'";
                vSQL += " or tp.descripcion like '%" + xFiltro + "%'";
            }
            vSQL += " order by prod.nombre asc";
            return Sql.getConsultar(vSQL);
        }

        public static void Editar(Articulo xArticulo)
        {
            String vSQL = "";
            vSQL = "update producto";
            vSQL += " set";
            vSQL += " codigobarra='" + xArticulo.Codigo + "',";
            vSQL += " unidad='" + xArticulo.Unidad + "',";
            vSQL += " nombre='" + xArticulo.Nombre + "',";
            if (xArticulo.Proveedor != null)
                vSQL += " idproveedor=" + xArticulo.Proveedor.Id + ",";
            else
                vSQL += " idproveedor=null,";
            if (xArticulo.Marca != null)
                vSQL += " marca='" + xArticulo.Marca.Id + "',";
            else
                vSQL += " marca=null,";
            if (xArticulo.Modelo != null)
                vSQL += " tipo='" + xArticulo.Modelo.Id + "',";
            else
                vSQL += " tipo=null,";
            vSQL += " costo=" + xArticulo.Costo + ",";
            vSQL += " iva=" + xArticulo.Iva + ",";
            vSQL += " ganancia=" + xArticulo.Ganancia + ",";
            vSQL += " monto=" + xArticulo.Monto + ",";
            vSQL += " stockminimo=" + xArticulo.StockMinimo + ",";
            vSQL += " stockactual=" + xArticulo.StockActual + ",";
            vSQL += " stockmaximo=" + xArticulo.StockMaximo;
            vSQL += " where idproducto=" + xArticulo.Id;
            Sql.ejecutar(vSQL);
            vSQL = null;
        }

        public static void Borrar(long xId)
        {
            String vSQL = "";
            vSQL = "delete from producto where idproducto=" + xId;
            Sql.ejecutar(vSQL);
            Console.WriteLine(vSQL);

            vSQL = null;
        }

        public static bool ExisteItem(string Id, string Codigo)
        {
            bool vRes = false;

            string vSQL = "select * from item_pedido where codigo = '" + Codigo + "' order by 1 desc limit 1";
            DataRow vItem = Sql.getBuscar(vSQL);
            if (vItem != null)
                vRes = true;
            vSQL = "  select * from item_presupuesto where codigo = '" + Codigo + "' order by 1 desc limit 1";
            vItem = Sql.getBuscar(vSQL);
            if (vItem != null)
                vRes = true;

            vSQL = "select * from item_factura where ifiditem =" + Id + " order by 1 desc limit 1";
            vItem = Sql.getBuscar(vSQL);
            if (vItem != null)
                vRes = true;

            vSQL = "select * from itemfactura where idarticulo =" + Id + " order by 1 desc limit 1";
            vItem = Sql.getBuscar(vSQL);
            if (vItem != null)
                vRes = true;

            return vRes;
        }

        public static void ActualizarStock(string xCodigo,long xCantidad, long xCantidadAnterior)
        {
            var vArticulo = BuscarPorCodigo(xCodigo);
            if (vArticulo != null)
            {
                if (xCantidadAnterior <= xCantidad)
                    Sql.ejecutar("update producto set stockactual=stockactual -" + xCantidad + " where idproducto=" + vArticulo.Id);
                else if (xCantidadAnterior > xCantidad)
                    Sql.ejecutar("update producto set stockactual=stockactual +" + (xCantidadAnterior - xCantidad) + " where idproducto=" + vArticulo.Id);
            }
        }

        public static void ActualizarStock(long xId, long xCantidad,long xCantidadAnterior)
        {
            var vArticulo = BuscarPorId(xId);
            if (vArticulo != null)
            {
                if (xCantidadAnterior <= xCantidad)
                    Sql.ejecutar("update producto set stockactual=stockactual -" + xCantidad + " where idproducto=" + vArticulo.Id);
                else if (xCantidadAnterior > xCantidad)
                    Sql.ejecutar("update producto set stockactual=stockactual +" + (xCantidadAnterior - xCantidad) + " where idproducto=" + vArticulo.Id);
            }
        }
    }
}
