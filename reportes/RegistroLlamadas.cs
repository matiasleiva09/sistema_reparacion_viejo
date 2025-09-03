using desagotes;
using desagotes.reportes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.reportes
{
    class RegistroLlamadas
    {
        private Document mDocumento = null;
        private DataTable mDatos = null;
        private String mTituloFiltro = "";
        private String mNroOrden = "";
        private String mFecha = "";
        private String mCliente = "";
        private String mEquipo = "";
        private String mAccesorios = "";
        private String mProblema = "";
        private String mSenia = "";
        private String mEmpresa = "";
        private String mCalle = "";
        private String mTelefono = "";
        private String mHorario = "";
     

       
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

        public String Equipo
        {
            get { return mEquipo; }
            set { mEquipo = value; }
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


        public String TituloFiltro
        {
            get { return mTituloFiltro; }
            set { mTituloFiltro = value; }
        }

        public DataTable Datos
        {
            get { return mDatos; }
            set { mDatos = value; }
        }

        public String crearPdf()
        {
            String vNombreDocumento = "";
            mDocumento = new Document(PageSize.A4, UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f),
            UtilsPdf.convertirCm(1.0f));

            vNombreDocumento = Utils.ObtenerPathDOCS() + "ReporteEntrega" + NroOrden + ".pdf";
            FileStream fs = new FileStream(vNombreDocumento, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter vWriter = PdfWriter.GetInstance(mDocumento, fs);
            mDocumento.Open();

            PageEventHelper pageEventHelper = new PageEventHelper();
            vWriter.PageEvent = pageEventHelper;
            /* vWriter.DirectContent.RoundRectangle(UtilsPdf.convertirCm(0.5f), UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(20f), 3.0f);
             vWriter.DirectContent.Stroke();*/
            PdfPTable vCodigoBarra = new PdfPTable(1);
            UtilsPdf.deshabilitarBordes(vCodigoBarra.DefaultCell);
            vCodigoBarra.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            float[] vColumnasTitulo = { UtilsPdf.convertirCm(5f), UtilsPdf.convertirCm(15f) };
            PdfPTable vLogo = new PdfPTable(vColumnasTitulo);
            UtilsPdf.deshabilitarBordes(vLogo.DefaultCell);
            Image vLogoFicha = null;
            try
            {
                vLogoFicha = Image.GetInstance(Utils.ObtenerPathDOCS() + "logo.png");
                vLogoFicha.ScaleAbsolute(35f, 35f);
            }
            catch (Exception e)
            {
                vLogo.AddCell("");
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
            vTablaParametrosEmpresa.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(2.5f), UtilsPdf.convertirCm(28.9f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
            float[] vAnchoTitulo = { UtilsPdf.convertirCm(20f) };
            PdfPTable vTablaTitulo = new PdfPTable(vAnchoTitulo);
            vTablaTitulo.DefaultCell.Padding = 0.1f;
            vTablaTitulo.TotalWidth = UtilsPdf.convertirCm(20.0f);
            UtilsPdf.deshabilitarBordes(vTablaTitulo.DefaultCell);
            vTablaTitulo.AddCell(UtilsPdf.getParrafo("REGISTRO DE LLAMADAS", FontFactory.GetFont(FontFactory.HELVETICA, 17, Font.BOLDITALIC)));
            // vTablaTitulo.AddCell(UtilsPdf.getParrafo("Fecha: " + Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaTitulo.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(11f), UtilsPdf.convertirCm(28.6f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //FECHA-----------------------------------------------------------
            float[] vAnchoFecha = { UtilsPdf.convertirCm(3f), UtilsPdf.convertirCm(2f) };
            PdfPTable vTablaFecha = new PdfPTable(vAnchoFecha);
            vTablaFecha.DefaultCell.Padding = 0.0f;
            vTablaFecha.TotalWidth = UtilsPdf.convertirCm(5.0f);
            UtilsPdf.deshabilitarBordes(vTablaFecha.DefaultCell);
            vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            vTablaFecha.AddCell(UtilsPdf.getParrafo("Fecha: ", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
            vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            vTablaFecha.AddCell(UtilsPdf.getParrafo(Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaFecha.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(11f), UtilsPdf.convertirCm(28.0f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------

            //----------------------------------------------------------------------------------------
            // vWriter.DirectContent.MoveTo(UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26.5f));
            //vWriter.DirectContent.LineTo(UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(26.5f));
            //vWriter.DirectContent.Stroke();
            //DATOS DE LA MISMA REPARACION------------------------------------------------------------
            float[] vAnchoTablaDR = { UtilsPdf.convertirCm(4f), UtilsPdf.convertirCm(4f), UtilsPdf.convertirCm(12f) };
            PdfPTable vTablaDatos = new PdfPTable(vAnchoTablaDR);
            vTablaDatos.DefaultCell.Padding = 1f;
            vTablaDatos.TotalWidth = UtilsPdf.convertirCm(19.0f);
            //UtilsPdf.deshabilitarBordes(vTablaDatos.DefaultCell);
            UtilsPdf.habilitarArribaAbajo(vTablaDatos.DefaultCell);
            vTablaDatos.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Fecha", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Llamado Por", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Informe de Llamada", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
            vTablaDatos.DefaultCell.BackgroundColor = BaseColor.WHITE;
            UtilsPdf.habilitarArribaAbajo(vTablaDatos.DefaultCell);
            foreach (DataRow vLlamada in Datos.Rows)
            {
                vTablaDatos.AddCell(UtilsPdf.getParrafo(vLlamada["Fecha"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
                vTablaDatos.AddCell(UtilsPdf.getParrafo(vLlamada["Llamado Por"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
                vTablaDatos.AddCell(UtilsPdf.getParrafo(vLlamada["Descripcion"].ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            }
            vTablaDatos.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26f), vWriter.DirectContent);

            mDocumento.Add(vLogoFicha);
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
          //  mDocumento.Add(vTablaDatos);
            mDocumento.Close();
            return vNombreDocumento;
        }
    }
}

