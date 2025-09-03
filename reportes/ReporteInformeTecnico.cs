using desagotes;
using desagotes.reportes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.reportes
{
    public class ReporteInformeTecnico
    {
        public string NombreCliente { get; set; }
        public string Equipo { get; set; }
        public string NroOrden { get; set; }
        public string Fecha { get; set; }
        public string Escrito { get; set; }
        public Dictionary<string,string> DatosEmpresa { get; set; }
      

        public string crearPDF() 
        {
            Document mDocumento = null;
             mDocumento = new Document(PageSize.A4, UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f), UtilsPdf.convertirCm(1.0f),
           UtilsPdf.convertirCm(1.0f));

            string vNombreDocumento = Utils.ObtenerPathDOCS() + "InformeTecnico" + NroOrden + ".pdf";
            FileStream fs = new FileStream(vNombreDocumento, FileMode.Create, FileAccess.Write, FileShare.None);

            PdfWriter vWriter = PdfWriter.GetInstance(mDocumento, fs);
            mDocumento.Open();

            PageEventHelper pageEventHelper = new PageEventHelper();
            vWriter.PageEvent = pageEventHelper;
            vWriter.DirectContent.RoundRectangle(UtilsPdf.convertirCm(0.5f), UtilsPdf.convertirCm(0.2f), UtilsPdf.convertirCm(20f), UtilsPdf.convertirCm(29.1f), 3.0f);
            vWriter.DirectContent.Stroke();
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
                vLogoFicha.ScaleAbsolute(50f, 50f);
            }
            catch (Exception e)
            {
                vLogo.AddCell("");
                Console.WriteLine("Error nro: " + e);
            }

            //DATOS DE LA EMPRESA-------------------------------------------------------------------
            float[] vAnchoParametrosEmpresa = { UtilsPdf.convertirCm(10.0f) };
            PdfPTable vTablaParametrosEmpresa = new PdfPTable(vAnchoParametrosEmpresa);
            vTablaParametrosEmpresa.DefaultCell.Padding = 0.1f;
            vTablaParametrosEmpresa.TotalWidth = UtilsPdf.convertirCm(10.0f);
            UtilsPdf.deshabilitarBordes(vTablaParametrosEmpresa.DefaultCell);
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo(DatosEmpresa["EMPRESA"], FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Dirección: " + DatosEmpresa["DIRECCION"], FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Teléfono: " + DatosEmpresa["TELEFONO"], FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Horario de atención: " + DatosEmpresa["HORARIO"], FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(3f), UtilsPdf.convertirCm(28.9f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
            float[] vAnchoTitulo = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaTitulo = new PdfPTable(vAnchoTitulo);
            vTablaTitulo.DefaultCell.Padding = 0.2f;
            vTablaTitulo.TotalWidth = UtilsPdf.convertirCm(19.0f);
            UtilsPdf.deshabilitarBordes(vTablaTitulo.DefaultCell);
            vTablaTitulo.DefaultCell.BackgroundColor = new BaseColor(0, 0, 0);
            vTablaTitulo.AddCell(UtilsPdf.getParrafo("                     INFORME TECNICO DEL EQUIPO                                                 ", FontFactory.GetFont(FontFactory.HELVETICA, 18, Font.BOLDITALIC, new BaseColor(255, 255, 255))));
            // vTablaTitulo.AddCell(UtilsPdf.getParrafo("Fecha: " + Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaTitulo.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(25.6f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //TITULO-----------------------------------------------------------
            float[] vAnchoFecha = { UtilsPdf.convertirCm(2f), UtilsPdf.convertirCm(3.5f) };
            PdfPTable vTablaFecha = new PdfPTable(vAnchoFecha);
            vTablaFecha.DefaultCell.Padding = 0.0f;
            vTablaFecha.TotalWidth = UtilsPdf.convertirCm(5.5f);
            //UtilsPdf.deshabilitarBordes(vTablaFecha.DefaultCell);
            vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            UtilsPdf.formatearCeldayFondoGris(vTablaFecha.DefaultCell);
            vTablaFecha.AddCell(UtilsPdf.getParrafo("Fecha: ", FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD)));
          //  vTablaFecha.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            UtilsPdf.formatearCeldayFondoBlanco(vTablaFecha.DefaultCell);
            vTablaFecha.AddCell(UtilsPdf.getParrafo(Fecha, FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.NORMAL)));
            vTablaFecha.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(14.3f), UtilsPdf.convertirCm(29.0f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------

            //TITULO DATOS DE LA REPARACION-----------------------------------------------------------
            float[] vAnchoTituloReparacion = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaTituloReporte = new PdfPTable(vAnchoTituloReparacion);
            vTablaTituloReporte.DefaultCell.Padding = 1f;
            vTablaTituloReporte.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaTituloReporte.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            UtilsPdf.habilitarArribaAbajo(vTablaTituloReporte.DefaultCell);
            vTablaTituloReporte.AddCell(UtilsPdf.getParrafo("DATOS DEL CLIENTE Y EQUIPO", FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD)));
            vTablaTituloReporte.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(23.5f), vWriter.DirectContent);

            //DATOS DEL CLIENTE Y EL EQUIPO REGISTRADO
            float[] vAnchoTablaDR = { UtilsPdf.convertirCm(4f), UtilsPdf.convertirCm(15f) };
            PdfPTable vTablaDatos = new PdfPTable(vAnchoTablaDR);
            vTablaDatos.DefaultCell.Padding = 2f;
            vTablaDatos.TotalWidth = UtilsPdf.convertirCm(19.0f);
            UtilsPdf.deshabilitarBordes(vTablaDatos.DefaultCell);
            vTablaDatos.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Nro. de Orden:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(NroOrden, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Cliente:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(NombreCliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Equipo:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Equipo, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.NORMAL)));
            vTablaDatos.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(23f), vWriter.DirectContent);


            //TITULO DEL INFORME-----------------------------------------------------------
            float[] vAnchoTituloInforme = { UtilsPdf.convertirCm(19f) };
            PdfPTable vTablaTituloInforme = new PdfPTable(vAnchoTituloReparacion);
            vTablaTituloInforme.DefaultCell.Padding = 1f;
            vTablaTituloInforme.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaTituloInforme.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            UtilsPdf.habilitarArribaAbajo(vTablaTituloInforme.DefaultCell);
            vTablaTituloInforme.AddCell(UtilsPdf.getParrafo("DETALLE TECNICO", FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLD)));
            vTablaTituloInforme.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(19f), vWriter.DirectContent);


            //DATOS DEL ESCRITO
            float[] vAnchoTablaEscrito = { UtilsPdf.convertirCm(19f)};
            PdfPTable vTablaDatosEscrito = new PdfPTable(vAnchoTablaEscrito);
            vTablaDatosEscrito.DefaultCell.Padding = 2f;
            vTablaDatosEscrito.TotalWidth = UtilsPdf.convertirCm(19f);
            UtilsPdf.deshabilitarBordes(vTablaDatosEscrito.DefaultCell);
            vTablaDatosEscrito.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;
            vTablaDatosEscrito.AddCell(UtilsPdf.getParrafo(Escrito, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatosEscrito.DefaultCell.BackgroundColor = new BaseColor(203, 203, 203);
            vTablaDatosEscrito.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLD)));
            vTablaDatosEscrito.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(18.5f), vWriter.DirectContent);

            mDocumento.Add(vLogoFicha);
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Close();
            return vNombreDocumento;

           
        }
    }
}
