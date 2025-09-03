using desagotes;
using desagotes.reportes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using reparaciones2.ob.caja;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reparaciones2.reportes
{
    public class ReciboPDF
    {
        private Document mDocumento = null;
        private DataTable mDatos = null;
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
        public Tarjeta MedioTarjeta { get; set; }
        public DepositoBancario MedioDeposito { get; set; }
        public Cheque MedioCheque { get; set; }
        public Efectivo MedioEfectivo { get; set; }

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

        public DataTable Datos
        {
            get { return mDatos; }
            set { mDatos = value; }
        }



        public String crearPdf()
        {
            Rectangle vTamañoHoja = PageSize.A4;
            mDocumento = new Document(PageSize.A4, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(1f),
            UtilsPdf.convertirCm(1f));
            mNombreDocumento = "RB" + mNroRecibo + ".pdf";
            mNombreDocumentoCompleto = Utils.ObtenerPathDOCS() + "RB" + mNroRecibo + ".pdf";
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Error nro: " + e);
            }
            PdfPTable vTablaImagen = new PdfPTable(1);
            vTablaImagen.DefaultCell.Padding = 0f;
            vTablaImagen.TotalWidth = 40f;
            vTablaImagen.LockedWidth = true;
            UtilsPdf.formatearCeldaAlinNormal(vTablaImagen.DefaultCell);
            UtilsPdf.deshabilitarBordes(vTablaImagen.DefaultCell);
            vTablaImagen.AddCell(vLogoFicha);
            //--------------------------------------------------------------------------------------
            //DATOS DE LA EMPRESA-------------------------------------------------------------------
            float[] vAnchoParametrosEmpresa = { UtilsPdf.convertirCm(3.0f) };
            PdfPTable vTablaParametrosEmpresa = new PdfPTable(vAnchoParametrosEmpresa);
            vTablaParametrosEmpresa.DefaultCell.Padding = 0f;
            vTablaParametrosEmpresa.TotalWidth = UtilsPdf.convertirCm(3.0f);
            UtilsPdf.deshabilitarBordes(vTablaParametrosEmpresa.DefaultCell);
            vTablaParametrosEmpresa.DefaultCell.HorizontalAlignment = 1;
            // vTablaParametrosEmpresa.AddCell(vTablaImagen);
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo(Empresa, FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Dirección: " + Calle, FontFactory.GetFont(FontFactory.HELVETICA, 6, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Teléfono: " + Telefono, FontFactory.GetFont(FontFactory.HELVETICA, 6, Font.BOLDITALIC)));
            vTablaParametrosEmpresa.AddCell(UtilsPdf.getParrafo("Horario de atención: " + Horario, FontFactory.GetFont(FontFactory.HELVETICA, 6, Font.BOLDITALIC)));
            //vTablaParametrosEmpresa.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(2.5f), UtilsPdf.convertirCm(28.9f), vWriter.DirectContent);
            //----------------------------------------------------------------------------------------
            //AHORA CREO EL CONTENEDOR DE LA PRIMERA COLUMNA-------------------------------------------
            float[] vColumnas = { UtilsPdf.convertirCm(10f) };
            PdfPTable vTablaContenedorDatos = new PdfPTable(vColumnas);
            UtilsPdf.deshabilitarBordes(vTablaContenedorDatos.DefaultCell);
            vTablaContenedorDatos.DefaultCell.Padding = 0f;
            vTablaContenedorDatos.TotalWidth = UtilsPdf.convertirCm(10f);
            UtilsPdf.formatearCeldaAlinNormal(vTablaContenedorDatos.DefaultCell);
            vTablaContenedorDatos.AddCell(vTablaImagen);
            vTablaContenedorDatos.AddCell(vTablaParametrosEmpresa);
            //------------------------------------------------------------------------------------------
            //TABLA CON LOS DATOS DE NUMERO DE RECIBO Y FECHA--------------------------------------------
            float[] vColumnaNro = { UtilsPdf.convertirCm(14f) };
            PdfPTable vTablaNroFecha = new PdfPTable(vColumnaNro);
            vTablaNroFecha.TotalWidth = UtilsPdf.convertirCm(10f);
            UtilsPdf.deshabilitarBordes(vTablaNroFecha.DefaultCell);
            //------------------------------------------------------------------------------------------
            //CREO LA PARTE EN SI DE LOS NROS DE RECIBO Y FECHA-----------------------------------------
            DateTime vFechaActual = DateTime.Now;
            String vFechaActualS = vFechaActual.Day + "/" + vFechaActual.Month + "/" + vFechaActual.Year;
            float[] vColumnaDatosNroFecha = { UtilsPdf.convertirCm(5f), UtilsPdf.convertirCm(14f) };
            PdfPTable vTablaDatosNroFecha = new PdfPTable(vColumnaDatosNroFecha);
            vTablaDatosNroFecha.DefaultCell.Padding = 0f;
            vTablaDatosNroFecha.TotalWidth = UtilsPdf.convertirCm(19f);
            UtilsPdf.formatearCeldayFondoGris(vTablaDatosNroFecha.DefaultCell);
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo("RECIBO N°", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            UtilsPdf.formatearCelda(vTablaDatosNroFecha.DefaultCell);
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo(UtilsPdf.agregarCerosIzquierda(NroRecibo, 8), FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            UtilsPdf.formatearCeldayFondoGris(vTablaDatosNroFecha.DefaultCell);
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo("FECHA", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            UtilsPdf.formatearCelda(vTablaDatosNroFecha.DefaultCell);
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo(vFechaActualS, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            UtilsPdf.deshabilitarBordes(vTablaDatosNroFecha.DefaultCell);
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosNroFecha.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaNroFecha.AddCell(vTablaDatosNroFecha);
            //------------------------------------------------------------------------------------------
            //AGREGAMOS EL CONTENIDO DE LAS DOS COLUMNAS A LA PRINCIPAL----------------------------------
            vTablaCabezera.AddCell(vTablaContenedorDatos);
            vTablaCabezera.AddCell(vTablaNroFecha);
            vTablaCabezera.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(28.9f), vWriter.DirectContent);
            vTablaCabezera.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(14.5f), vWriter.DirectContent);
            //------------------------------------------------------------------------------------------
            //DATOS EN SI DEL RECIBO--------------------------------------------------------------------
            PdfPTable vTablaDatosContenedor = new PdfPTable(1);
            vTablaDatosContenedor.TotalWidth = UtilsPdf.convertirCm(19f);

            float vMontoTotal = 0.0f;
            if (MedioEfectivo != null)
                vMontoTotal += MedioEfectivo.Monto;
            if (MedioCheque != null)
                vMontoTotal += MedioCheque.Monto;
            if (MedioDeposito != null)
                vMontoTotal += MedioDeposito.Monto;
            if (MedioTarjeta != null)
                vMontoTotal += MedioTarjeta.Monto;
            PdfPTable vTablaDatos = new PdfPTable(1);
            UtilsPdf.deshabilitarBordes(vTablaDatos.DefaultCell);
            vTablaDatos.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("Recibimos de Parte de:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            //UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatos.DefaultCell);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Cliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            //UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            vTablaDatos.AddCell(UtilsPdf.getParrafo("La Suma de: $" + vMontoTotal + ".- (" + UtilsPdf.NumeroALetras(vMontoTotal + "") + ")", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
           // UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatos.DefaultCell);

            if (MedioEfectivo != null && MedioEfectivo.Monto > 0)
            {
                vTablaDatos.AddCell(UtilsPdf.getParrafo("$" + MedioEfectivo.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioEfectivo.Monto + "") + ") abonandose en EFECTIVO", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
             //   UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if(MedioTarjeta!=null)
            {
                vTablaDatos.AddCell(UtilsPdf.getParrafo("$" + MedioTarjeta.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioTarjeta.Monto + "") + ") abonandose en TARJETA", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
               // UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if (MedioCheque != null)
            {
                vTablaDatos.AddCell(UtilsPdf.getParrafo("$" + MedioCheque.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioCheque.Monto + "") + ") abonandose en CHEQUE", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
               // UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if (MedioDeposito != null)
            {
                vTablaDatos.AddCell(UtilsPdf.getParrafo("$" + MedioDeposito.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioDeposito.Monto + "") + ") abonandose por DEPOSITO BANCARIO", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
               // UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            vTablaDatos.AddCell(UtilsPdf.getParrafo("En concepto de:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
          //  UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatos.DefaultCell);
            vTablaDatos.AddCell(UtilsPdf.getParrafo(Concepto, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            UtilsPdf.formatearCelda(vTablaDatos.DefaultCell);
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("              ---------------------------------", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                 Firma Responsable", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatos.AddCell(UtilsPdf.getParrafo("                  Talón para el cliente", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatosContenedor.AddCell(vTablaDatos);
            vTablaDatosContenedor.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(26.0f), vWriter.DirectContent);

            PdfPTable vTablaDatosContenedorDuplicado = new PdfPTable(1);
            vTablaDatosContenedorDuplicado.TotalWidth = UtilsPdf.convertirCm(19f);
            PdfPTable vTablaDatosDuplicado = new PdfPTable(1);
            UtilsPdf.deshabilitarBordes(vTablaDatosDuplicado.DefaultCell);
            vTablaDatosDuplicado.TotalWidth = UtilsPdf.convertirCm(19f);
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo(" ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("Recibimos de Parte de:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
          //  UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatosDuplicado.DefaultCell);
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo(Cliente, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
          //  UtilsPdf.formatearCeldaAlinNormal(vTablaDatosDuplicado.DefaultCell);
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("La Suma de:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            //UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatosDuplicado.DefaultCell);
            if (MedioEfectivo != null)
            {
                vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("$" + MedioEfectivo.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioEfectivo.Monto + "") + ") abonandose en EFECTIVO", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
              //  UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if (MedioTarjeta != null)
            {
                vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("$" + MedioTarjeta.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioTarjeta.Monto + "") + ") abonandose en TARJETA", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
              //  UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if (MedioCheque != null)
            {
                vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("$" + MedioCheque.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioCheque.Monto + "") + ") abonandose en CHEQUE", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
              //  UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            if (MedioDeposito != null)
            {
                vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("$" + MedioDeposito.Monto + ".- (" + UtilsPdf.NumeroALetras(MedioDeposito.Monto + "") + ") abonandose por DEPOSITO BANCARIO", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
                UtilsPdf.formatearCeldaAlinNormal(vTablaDatos.DefaultCell);
            }
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("En concepto de:", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
           // UtilsPdf.formatearCeldayFondoGrisAlinNormal(vTablaDatosDuplicado.DefaultCell);
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo(Concepto, FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
             UtilsPdf.formatearCelda(vTablaDatosDuplicado.DefaultCell);
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("              ---------------------------------", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                   Firma Cliente", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                         ", FontFactory.GetFont(FontFactory.HELVETICA, 12, Font.BOLDITALIC)));
            vTablaDatosDuplicado.AddCell(UtilsPdf.getParrafo("                  Talón para el comercio", FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLDITALIC)));
            vTablaDatosContenedorDuplicado.AddCell(vTablaDatosDuplicado);
            vTablaDatosContenedorDuplicado.WriteSelectedRows(0, -1, UtilsPdf.convertirCm(1f), UtilsPdf.convertirCm(11.577f), vWriter.DirectContent);
            //------------------------------------------------------------------------------------------

            // mDocumento.Add(vLogoFicha);
            // Linea de corte de recibo
            vWriter.DirectContent.SetLineDash(3, 3, 0);
            vWriter.DirectContent.MoveTo(0, UtilsPdf.convertirCm(15.5f));
            vWriter.DirectContent.LineTo(vTamañoHoja.Width, UtilsPdf.convertirCm(15.5f));
            vWriter.DirectContent.Stroke();
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Add(UtilsPdf.getParrafo(" ", 14f, Font.BOLD));
            mDocumento.Close();
            return mNombreDocumentoCompleto;
        }
    }
}
