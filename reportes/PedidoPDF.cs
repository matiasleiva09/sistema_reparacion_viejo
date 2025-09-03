using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using desagotes;
using desagotes.reportes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.IO;
using reparaciones2.ob.presupuestos;
using stocksires.ob;

namespace reparaciones2.reportes
{
    class PedidoPDF
    {
        private Document mDocumento = null;
        private IList<ItemPedido> mDatos = new List<ItemPedido>();
        private String mNroOrden = "";
        private long mNroRecibo = 1;
        private String mFecha = "";
        private String mIdCliente = "";
        private String mCliente = "";
        private String mAccesorios = "";
        private String mConcepto = "";
        private String mProblema = "";
        private String mSenia = "";
        private String mEmpresa = "";
        private String mCalle = "";
        private String mTelefono = "";
        private String mHorario = "";
        private Double mMonto = 0.00;
        private String mMedioPago = "";
        private String mNombreDocumentoCompleto = "";
        private String mNombreDocumento = "";

        public string DireccionCliente
        {
            get;set;
        }

        public String NombreDocumentoCompleto
        {
            get { return mNombreDocumentoCompleto; }
            set { mNombreDocumentoCompleto = value; }
        }

        public String NombreDocumento
        {
            get { return mNombreDocumento; }
            set { mNombreDocumento = value; }
        }

        public String IdCliente
        {
            get { return mIdCliente; }
            set { mIdCliente = value; }
        }

        public long NroRecibo
        {
            get { return mNroRecibo; }
            set { mNroRecibo = value; }
        }

        public String MedioDePago
        {
            get { return mMedioPago; }
            set { mMedioPago = value; }
        }

        public String Concepto
        {
            get { return mConcepto; }
            set { mConcepto = value; }
        }

        public Double Monto
        {
            get { return mMonto; }
            set { mMonto = value; }
        }

        public String Horario
        {
            get { return mHorario; }
            set { mHorario = value; }
        }

        public String Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }


        public String Calle
        {
            get { return mCalle; }
            set { mCalle = value; }
        }

        public String Empresa
        {
            get { return mEmpresa; }
            set { mEmpresa = value; }
        }
        public String Senia
        {
            get { return mSenia; }
            set { mSenia = value; }
        }
        public String Problema
        {
            get { return mProblema; }
            set { mProblema = value; }
        }

        public String Accesorios
        {
            get { return mAccesorios; }
            set { mAccesorios = value; }
        }

        public String Cliente
        {
            get { return mCliente; }
            set { mCliente = value; }
        }

        public String Fecha
        {
            get { return mFecha; }
            set { mFecha = value; }
        }
        public String NroOrden
        {
            get { return mNroOrden; }
            set { mNroOrden = value; }
        }

        public IList<ItemPedido> Datos
        {
            get { return mDatos; }
            set { mDatos = value; }
        }



        public String crearPdf()
        {
            Rectangle vTamañoHoja = PageSize.A4;
            mDocumento = new Document(PageSize.A4, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(1f),
            UtilsPdf.convertirCm(1f));
            mNombreDocumento = "NOTADEPEDIDO" + mNroRecibo + ".pdf";
            mNombreDocumentoCompleto = Utils.ObtenerPathDOCS() + "NOTADEPEDIDO" + mNroRecibo + ".pdf";
            FileStream fs = new FileStream(mNombreDocumentoCompleto, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter vWriter = PdfWriter.GetInstance(mDocumento, fs);
            mDocumento.Open();
            PageEventHelper pageEventHelper = new PageEventHelper();
            vWriter.PageEvent = pageEventHelper;
            //DECLARO EL CONTENTEDOR DE LA CABEZERA ----------------------------------
            float[] vAnchoEncabezados = { UtilsPdf.convertirCm(15f), UtilsPdf.convertirCm(14f) };
            PdfPTable vTablaCabezera = new PdfPTable(vAnchoEncabezados);
            vTablaCabezera.TotalWidth = UtilsPdf.convertirCm(19f);
            //FIN DECLARACION DE LA CABEZERA ------------------------------------
            //TOMO LA IMAGEN DE LOS DOCUMENTOS
            Image vLogoFicha = null;
            try
            {
                vLogoFicha = Image.GetInstance(Utils.ObtenerPathDOCS() + "logo.png");
                vLogoFicha.ScaleAbsolute(45f, 45f);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error nro: " + e);
            }
          
            //DATOS DE LA EMPRESA-------------------------------------------------------------------
            float[] vAnchoParametrosEmpresa = { UtilsPdf.convertirCm(8.0f) };
            PdfPTable vTablaParametrosEmpresa = new PdfPTable(vAnchoParametrosEmpresa);
            vTablaParametrosEmpresa.DefaultCell.Padding = 0.1f;
            vTablaParametrosEmpresa.TotalWidth = UtilsPdf.convertirCm(8.0f);
            UtilsPdf.deshabilitarBordes(vTablaParametrosEmpresa.DefaultCell);
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo(Empresa, FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Dirección: " + Calle, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Teléfono: " + Telefono, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Horario de atención: " + Horario, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(3f), UtilsPdf.convertirCm(28.9f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
            float[] vAnchoTitulo = { UtilsPdf.convertirCm(24f) };
            PdfPTable vTablaTitulo = new PdfPTable(vAnchoTitulo);
            vTablaTitulo.DefaultCell.Padding = 0.1f;
            vTablaTitulo.TotalWidth = UtilsPdf.convertirCm(24.0f);
            UtilsPdf.deshabilitarBordes(vTablaTitulo.DefaultCell);
            vTablaTitulo.AddCell(UtilsPdf.getParrafo("NOTA DE PEDIDO N " +NroOrden, FontFactory.GetFont(FontFactory.HELVETICA, 17, Font.BOLDITALIC)));
            // vTablaTitulo.AddCell(UtilsPdf.getParrafo("Fecha: " + Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaTitulo.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(11.5f), UtilsPdf.convertirCm(28.6f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
            float[] vAnchoFecha = { UtilsPdf.convertirCm(4f), UtilsPdf.convertirCm(4f) };
            PdfPTable vTablaFecha = new PdfPTable(vAnchoFecha);
            vTablaFecha.DefaultCell.Padding = 0.0f;
            vTablaFecha.TotalWidth = UtilsPdf.convertirCm(8.0f);
            UtilsPdf.deshabilitarBordes(vTablaFecha.DefaultCell);
            vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            vTablaFecha.AddCell(UtilsPdf.getParrafo("Fecha: ", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
            vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            vTablaFecha.AddCell(UtilsPdf.getParrafo(Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaFecha.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(10f), UtilsPdf.convertirCm(28.0f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------

            //TITULO DATOS DE LA REPARACION-----------------------------------------------------------
            float[] vAnchoTituloReparacion = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaTituloReporte = new PdfPTable(vAnchoTituloReparacion);
            vTablaTituloReporte.DefaultCell.Padding = 1f;
            vTablaTituloReporte.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaTituloReporte.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            UtilsPdf.habilitarArribaAbajo(vTablaTituloReporte.DefaultCell);
            vTablaTituloReporte.AddCell(UtilsPdf.getParrafo("DATOS DEL PEDIDO", FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD)));
            vTablaTituloReporte.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26.5f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            // vWriter.DirectContent.MoveTo(UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26.5f));
            //vWriter.DirectContent.LineTo(UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(26.5f));
            //vWriter.DirectContent.Stroke();
            //DATOS DE LA MISMA REPARACION------------------------------------------------------------
            float[] vAnchoTablaDR = { UtilsPdf.convertirCm(4f), UtilsPdf.convertirCm(15f) };
            PdfPTable vTablaDatos = new PdfPTable(vAnchoTablaDR);
            vTablaDatos.DefaultCell.Padding = 2f;
            vTablaDatos.TotalWidth = UtilsPdf.convertirCm(19.0f);
            UtilsPdf.deshabilitarBordes(vTablaDatos.DefaultCell);
            vTablaDatos.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            //vTablaDatos.AddCell(UtilsPdf.getParrafo("Fecha:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            //vTablaDatos.AddCell(UtilsPdf.getParrafo(Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Cliente:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Cliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Dirección:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(DireccionCliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            UtilsPdf.habilitarAbajo(vTablaDatos.DefaultCell);
            vTablaDatos.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //DETALLE DEL PRESUPUESTO-----------------------------------------------------------
            PdfPTable vTablaDetalleP = new PdfPTable(vAnchoTituloReparacion);
            vTablaDetalleP.DefaultCell.Padding = 1f;
            vTablaDetalleP.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaDetalleP.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            UtilsPdf.habilitarArribaAbajo(vTablaDetalleP.DefaultCell);
            vTablaDetalleP.AddCell(UtilsPdf.getParrafo("DETALLE DEL PEDIDO", FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD)));
            vTablaDetalleP.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(23.5f), vWriter.DirectContent);

            /* vWriter.DirectContent.MoveTo(UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(22f));
             vWriter.DirectContent.LineTo(UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(22f));
             vWriter.DirectContent.Stroke();*/
            //DATOS EN SI DEL RECIBO--------------------------------------------------------------------
            //float[] vAnchoCeldasD = { UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(8f), UtilsPdf.convertirCm(2f), UtilsPdf.convertirCm(2f), UtilsPdf.convertirCm(2f) };
            float[] vAnchoCeldasD = { UtilsPdf.convertirCm(2f), UtilsPdf.convertirCm(11f), UtilsPdf.convertirCm(3f), UtilsPdf.convertirCm(3f) };
            PdfPTable vDetalle = new PdfPTable(vAnchoCeldasD);

            vDetalle.DefaultCell.MinimumHeight = 0;
            vDetalle.DefaultCell.Border = 1;
            vDetalle.DefaultCell.BackgroundColor = BaseColor.BLACK;

            vDetalle.DefaultCell.BorderColor = BaseColor.LIGHT_GRAY;
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            //vDetalle.AddCell(UtilsPdf.getParrafo("Cliente", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.AddCell(UtilsPdf.getParrafo("Cantidad", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            //vDetalle.AddCell(UtilsPdf.getParrafo("Cliente", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.AddCell(UtilsPdf.getParrafo("Descripción", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            /*vDetalle.AddCell(UtilsPdf.getParrafo("Neto", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            vDetalle.AddCell(UtilsPdf.getParrafo("Iva", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;*/
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            vDetalle.AddCell(UtilsPdf.getParrafo("Monto Unitario", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            vDetalle.AddCell(UtilsPdf.getParrafo("Total", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            int vCantidadDatos = Datos.Count;
            float vTotal = 0.00f;
            //float vTotalNeto = 0.00f;
           // float vTotalIVA = 0.00f;
            float vMontoUnitario = 0.00f;
            for (int i = 0; i < vCantidadDatos; i++)
            {
                vDetalle.DefaultCell.BackgroundColor = BaseColor.WHITE;
                vDetalle.DefaultCell.BorderColor = BaseColor.LIGHT_GRAY;
                vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                // vDetalle.AddCell(UtilsPdf.getParrafo(Datos.Rows[i]["nombre"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                if(Datos[i].Articulo.Unidad!="CANTIDAD")
                    vDetalle.AddCell(UtilsPdf.getParrafo(Datos[i].Cantidad.ToString() + " " + Datos[i].Articulo.Unidad, FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                else
                    vDetalle.AddCell(UtilsPdf.getParrafo(Datos[i].Cantidad.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
                vDetalle.AddCell(UtilsPdf.getParrafo(Datos[i].Articulo.Nombre, FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                //  vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(Datos[i].Neto, 2)).ToString("#,###.00"), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                //  vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(Datos[i].Iva, 2)).ToString("#,###.00"), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(Datos[i].MontoUnitario, 2)).ToString("#,###.00"), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(Datos[i].Total, 2)).ToString("#,###.00"), FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
                vTotal += Datos[i].Total;
                vMontoUnitario += Datos[i].MontoUnitario;
               // vTotalNeto += Datos[i].Neto;
               // vTotalIVA += Datos[i].Iva;
            }
            vDetalle.DefaultCell.BackgroundColor = BaseColor.BLACK;
            vDetalle.DefaultCell.BorderColor = BaseColor.LIGHT_GRAY;
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
           
            vDetalle.AddCell(UtilsPdf.getParrafo("TOTAL", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.AddCell(UtilsPdf.getParrafo(" ", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            //vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(vTotalNeto, 2)).ToString("#,###.00"), UtilsPdf.getFontMedianoBlanco()));
            //vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(vTotalIVA, 2)).ToString("#,###.00"), UtilsPdf.getFontMedianoBlanco()));
            //vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(vMontoUnitario, 2)).ToString("#,###.00"), UtilsPdf.getFontMedianoBlanco()));
            vDetalle.AddCell(UtilsPdf.getParrafo(" ", UtilsPdf.getFontMedianoBlanco()));
            vDetalle.AddCell(UtilsPdf.getParrafo("$" + (Math.Round(vTotal, 2)).ToString("#,###.00"), UtilsPdf.getFontMedianoBlanco()));


            vDetalle.TotalWidth = UtilsPdf.convertirCm(19f);
            vDetalle.LockedWidth = true;
            mDocumento.Add(vLogoFicha);
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(vDetalle);
            mDocumento.Close();
            return mNombreDocumento;
        }
    }
}
