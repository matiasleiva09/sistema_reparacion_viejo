using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desagotes.reportes
{
    public class ReporteServiceDomicilio
    { 
        private Document mDocumento = null;
        private DataTable mDatos = null;
        private String mTituloFiltro = "";
        private String mNroOrden = "";
        private String mFecha = "";
        private String mCliente = "";
        private String mProblema = "";
        private String mSenia = "";
        private String mEmpresa = "";
        private String mCalle = "";
        private String mTelefono = "";
        private String mHorario = "";
        private String mLeyenda = "";
        private String mNombreDocumentoCompleto = "";
        private String mNombreDocumento = "";

        public String ClienteDomicilio { get; set; }

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

        public String Leyenda
        {
            get { return mLeyenda; }
            set { mLeyenda = value; }
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
          
            mDocumento = new Document(PageSize.A4, UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f),
            UtilsPdf.convertirCm(1.0f));

            mNombreDocumentoCompleto = Utils.ObtenerPathDOCS() +"ServiceCasaNro" + NroOrden + ".pdf";
            mNombreDocumento = "ServiceCasaNro" + NroOrden + ".pdf";
            FileStream fs = new FileStream(mNombreDocumentoCompleto, FileMode.Create, FileAccess.Write, FileShare.None);

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
                vLogoFicha = Image.GetInstance(Utils.ObtenerPathDOCS() +"logo.png");
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
            vTablaTitulo.AddCell(UtilsPdf.getParrafo("ORDEN DE SERVICE", FontFactory.GetFont(FontFactory.HELVETICA, 17, Font.BOLDITALIC)));
            // vTablaTitulo.AddCell(UtilsPdf.getParrafo("Fecha: " + Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaTitulo.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(11f), UtilsPdf.convertirCm(28.6f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
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

            //TITULO DATOS DE LA REPARACION-----------------------------------------------------------
            float[] vAnchoTituloReparacion = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaTituloReporte = new PdfPTable(vAnchoTituloReparacion);
            vTablaTituloReporte.DefaultCell.Padding = 1f;
            vTablaTituloReporte.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaTituloReporte.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            UtilsPdf.habilitarArribaAbajo(vTablaTituloReporte.DefaultCell);
            vTablaTituloReporte.AddCell(UtilsPdf.getParrafo("DATOS DEL SERVICE", FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD)));
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
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Nro. de Service:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(NroOrden, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Cliente:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Cliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
             vTablaDatos.AddCell(UtilsPdf.getParrafo("Domicilio:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
             vTablaDatos.AddCell(UtilsPdf.getParrafo(ClienteDomicilio, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            //vTablaDatos.AddCell(UtilsPdf.getParrafo("Accesorios:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            //vTablaDatos.AddCell(UtilsPdf.getParrafo(Accesorios, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Problema:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Problema, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            UtilsPdf.habilitarAbajo(vTablaDatos.DefaultCell);
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Seña:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Senia, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD))); 
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
           /* vWriter.DirectContent.MoveTo(UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(22f));
            vWriter.DirectContent.LineTo(UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(22f));
            vWriter.DirectContent.Stroke();*/

            //LEYENDAS---------------------------------------------------------------------------------
            float[] vAnchoLeyendas = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaLeyendas = new PdfPTable(vAnchoLeyendas);
            vTablaLeyendas.DefaultCell.Padding = 0.1f;
            vTablaLeyendas.TotalWidth = UtilsPdf.convertirCm(19.0f);
            UtilsPdf.deshabilitarBordes(vTablaLeyendas.DefaultCell);
            vTablaLeyendas.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            vTablaLeyendas.AddCell(UtilsPdf.getParrafo(Leyenda, FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLD)));
            vTablaLeyendas.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(21.0f), vWriter.DirectContent);
            //-----------------------------------------------------------------------------------------
            /*  PdfPTable vNombreReporte = new PdfPTable(1);
          UtilsPdf.deshabilitarBordes(vNombreReporte.DefaultCell);
          vNombreReporte.DefaultCell.Padding = 0.0f;
          vNombreReporte.TotalWidth = UtilsPdf.convertirCm(18.0f);
          vNombreReporte.AddCell(UtilsPdf.getParrafo("Orden de Reparación", FontFactory.GetFont(FontFactory.HELVETICA,18, Font.BOLD)));
          vNombreReporte.AddCell(UtilsPdf.getParrafo(TituloFiltro, FontFactory.GetFont(FontFactory.HELVETICA, 15, Font.BOLDITALIC)));
          vNombreReporte.AddCell(UtilsPdf.getParrafo("Fecha: " + Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 15, Font.BOLDITALIC)));

          vNombreReporte.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(7.50f), UtilsPdf.convertirCm(28.70f), vWriter.DirectContent);

          float[] vAnchoCeldasD = { UtilsPdf.convertirCm(4f),UtilsPdf.convertirCm(5f),
                  UtilsPdf.convertirCm(2f), UtilsPdf.convertirCm(5f),  UtilsPdf.convertirCm(4f),UtilsPdf.convertirCm(2f) };
          PdfPTable vDetalle = new PdfPTable(vAnchoCeldasD);

          vDetalle.DefaultCell.MinimumHeight = 0;
          vDetalle.DefaultCell.Border = 1;
          vDetalle.DefaultCell.BackgroundColor = BaseColor.BLACK;


          vDetalle.TotalWidth = UtilsPdf.convertirCm(20f);
          vDetalle.LockedWidth = true;*/
            mDocumento.Add(vLogoFicha);
        mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
        mDocumento.Close();
        return mNombreDocumentoCompleto;
    }
  }
   /* public class PageEventHelper : PdfPageEventHelper
    {


        public override void OnEndPage(PdfWriter writer, Document document)
        {
            PdfPTable vPiePag = new PdfPTable(1);
            UtilsPdf.deshabilitarBordes(vPiePag.DefaultCell);
            vPiePag.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            vPiePag.DefaultCell.Padding = 0.1f;
            vPiePag.TotalWidth = PageSize.A4.Width;
            vPiePag.AddCell(UtilsPdf.getParrafo("Página " + writer.PageNumber, UtilsPdf.getFontMedianoBI()));
            vPiePag.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(8.5f), UtilsPdf.convertirCm(0.8f), writer.DirectContent);

            /*PdfPTable vNumeroDePagina = new PdfPTable(1);
            UtilsPdf.deshabilitarBordes(vNumeroDePagina.DefaultCell);
            vNumeroDePagina.DefaultCell.Padding = 0.0f;
            vNumeroDePagina.TotalWidth=UtilsPdf.convertirCm(18.0f);
            vNumeroDePagina.AddCell(UtilsPdf.getParrafo("REPORTE DE GASTOS", 14f, Font.BOLD));
            if (writer.PageNumber == 1)
                vNumeroDePagina.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(5.5f), UtilsPdf.convertirCm(25.5f), writer.DirectContent);
            else
                vNumeroDePagina.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(3f), UtilsPdf.convertirCm(29f), writer.DirectContent);*/
      //  }


    //}
}
