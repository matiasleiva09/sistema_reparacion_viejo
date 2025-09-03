using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desagotes
{
    class UtilsPdf
    {
        public static float convertirCm(float xCm)
        {
            return xCm * 72f / 2.54f;
        }

        /**
         * Formatea el texto utilizando el font y lo retorna en un párrafo
         * @param xTexto el texto a incluir en el párrafo.
         * @param xFont la letra.
         * @return Un párrafo formateado según los parámetros
         */
        public static Paragraph getParrafo(String xTexto, Font xFont)
        {
            return new Paragraph(xTexto, xFont);
        }

        public static Paragraph getParrafoAfter50(String xTexto, Font xFont)
        {
            Paragraph vParagraph = new Paragraph(xTexto, xFont);
            vParagraph.SpacingAfter=100;
            return vParagraph;
        }

        /**
         * Formatea el texto con los parámetros y lo retorna en un párrafo
         * @param xTexto el texto a incluir en el párrafo.
         * @param xTamaño el tamaño de letra.
         * @param xEstilos el estilo del font, utilizar Font.BOLD, Font.ITALIC, etc	
         * @return Un párrafo formateado según los parámetros
         */
        public static Paragraph getParrafo(String xTexto, float xTamaño, int xEstilos)
        {
            return new Paragraph(xTexto, getFont(xTamaño, xEstilos));
        }

        /**
         * Formatea el texto con el font y lo retorna en un "chunk"
         * @param xTexto el texto a incluir en el párrafo.
         * @param xFont la letra.
         * @return Un "chunk" formateado según los parámetros
         */
        public static Chunk getTexto(String xTexto, Font xFont)
        {
            return new Chunk(xTexto, xFont);
        }

        /**
         * Formatea el texto con los parámetros y lo retorna en un "chunk"
         * @param xTexto el texto a incluir en el párrafo.
         * @param xTamaño el tamaño de letra.
         * @param xEstilos el estilo del font, utilizar Font.BOLD, Font.ITALIC, etc	
         * @return Un "chunk" formateado según los parámetros
         */
        public static Chunk getTexto(String xTexto, float xTamanio, int xEstilos)
        {
            return new Chunk(xTexto, getFont(xTamanio, xEstilos));
        }

        public static PdfPTable getTablaDerecha(int xColumnas)
        {
            PdfPTable vTabla = new PdfPTable(xColumnas);
            deshabilitarBordes(vTabla.DefaultCell);
            vTabla.DefaultCell.HorizontalAlignment=Element.ALIGN_RIGHT;

            return vTabla;
        }

        public static PdfPTable getTablaCentrada(int xColumnas)
        {
            PdfPTable vTabla = new PdfPTable(xColumnas);
            vTabla.DefaultCell.PaddingTop=0.1f;
            deshabilitarBordes(vTabla.DefaultCell);
            vTabla.DefaultCell.HorizontalAlignment=Element.ALIGN_CENTER;

            return vTabla;
        }

        public static PdfPTable getTablaCentradaBordes(int xColumnas)
        {
            PdfPTable vTabla = new PdfPTable(xColumnas);
            vTabla.DefaultCell.PaddingTop=0.1f;
            vTabla.DefaultCell.HorizontalAlignment=Element.ALIGN_CENTER;

            return vTabla;
        }
        public static PdfPTable getTablaCentradaEnCm(float[] xColumnas)
        {
            for (int i = 0; i < xColumnas.Length; i++)
            {
                xColumnas[i] = convertirCm(xColumnas[i]);
            }
            PdfPTable vTabla = new PdfPTable(xColumnas);
            vTabla.DefaultCell.PaddingTop=0.1f;
            deshabilitarBordes(vTabla.DefaultCell);
            vTabla.DefaultCell.HorizontalAlignment= Element.ALIGN_CENTER;

            return vTabla;
        }

        public static PdfPTable getTablaFormateada(int xColumnas)
        {
            PdfPTable vTabla = new PdfPTable(xColumnas);
            formatearCelda(vTabla.DefaultCell);

            return vTabla;
        }

        public static PdfPCell formatearCelda(PdfPCell xCelda)
        {
            xCelda.BorderWidth=0.3f;
            xCelda.HorizontalAlignment= Element.ALIGN_CENTER;
            xCelda.BorderColor=BaseColor.GRAY;
            xCelda.BackgroundColor = BaseColor.WHITE;
            xCelda.PaddingTop=2.0f;
            xCelda.PaddingLeft=1f;
            xCelda.PaddingRight=1.0f;
            xCelda.PaddingBottom=2.0f;

            return xCelda;
        }

        public static PdfPCell formatearCeldaAlinNormal(PdfPCell xCelda)
        {
            xCelda.BorderWidth = 0.3f;
            xCelda.HorizontalAlignment = Element.ALIGN_LEFT;
            xCelda.BorderColor = BaseColor.GRAY;
            xCelda.BackgroundColor = BaseColor.WHITE;
            xCelda.PaddingTop = 2.0f;
            xCelda.PaddingLeft = 1f;
            xCelda.PaddingRight = 1.0f;
            xCelda.PaddingBottom = 2.0f;

            return xCelda;
        }

        public static PdfPCell formatearCeldayFondoGris(PdfPCell xCelda)
        {
            xCelda.BorderWidth = 0.3f;
            xCelda.HorizontalAlignment = Element.ALIGN_CENTER;
            xCelda.BorderColor = BaseColor.GRAY;
            xCelda.BackgroundColor = BaseColor.LIGHT_GRAY;
            xCelda.PaddingTop = 2.0f;
            xCelda.PaddingLeft = 1f;
            xCelda.PaddingRight = 1.0f;
            xCelda.PaddingBottom = 2.0f;
            return xCelda;
        }

        public static PdfPCell formatearCeldayFondoBlanco(PdfPCell xCelda)
        {
            xCelda.BorderWidth = 0.3f;
            xCelda.HorizontalAlignment = Element.ALIGN_CENTER;
            xCelda.BorderColor = BaseColor.GRAY;
            xCelda.BackgroundColor = BaseColor.WHITE;
            xCelda.PaddingTop = 2.0f;
            xCelda.PaddingLeft = 1f;
            xCelda.PaddingRight = 1.0f;
            xCelda.PaddingBottom = 2.0f;
            return xCelda;
        }

        public static PdfPCell formatearCeldayFondoGrisAlinNormal(PdfPCell xCelda)
        {
            xCelda.BorderWidth = 0.3f;
            xCelda.HorizontalAlignment = Element.ALIGN_LEFT;
            xCelda.BorderColor = BaseColor.GRAY;
            xCelda.BackgroundColor = BaseColor.LIGHT_GRAY;
            xCelda.PaddingTop = 2.0f;
            xCelda.PaddingLeft = 1f;
            xCelda.PaddingRight = 1.0f;
            xCelda.PaddingBottom = 2.0f;
            return xCelda;
        }


        public static PdfPCell deshabilitarBordes(PdfPCell xCelda)
        {
            xCelda.DisableBorderSide(Rectangle.LEFT_BORDER);
            xCelda.DisableBorderSide(Rectangle.RIGHT_BORDER);
            xCelda.DisableBorderSide(Rectangle.TOP_BORDER);
            xCelda.DisableBorderSide(Rectangle.BOTTOM_BORDER);
            return xCelda;
        }

        public static PdfPCell habilitarArribaAbajo(PdfPCell xCelda)
        {
            xCelda.DisableBorderSide(Rectangle.LEFT_BORDER);
            xCelda.DisableBorderSide(Rectangle.RIGHT_BORDER);
            return xCelda;
        }

        public static PdfPCell habilitarAbajo(PdfPCell xCelda)
        {
            xCelda.DisableBorderSide(Rectangle.LEFT_BORDER);
            xCelda.DisableBorderSide(Rectangle.RIGHT_BORDER);
            xCelda.DisableBorderSide(Rectangle.TOP_BORDER);
            xCelda.EnableBorderSide(Rectangle.BOTTOM_BORDER);
            return xCelda;
        }

        public static PdfPCell habilitarArriba(PdfPCell xCelda)
        {
            xCelda.DisableBorderSide(Rectangle.LEFT_BORDER);
            xCelda.DisableBorderSide(Rectangle.RIGHT_BORDER);
            xCelda.EnableBorderSide(Rectangle.TOP_BORDER);
            xCelda.DisableBorderSide(Rectangle.BOTTOM_BORDER);
            return xCelda;
        }


        public static Font getFontValorT()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 10);
        }

        public static Font getFontGandeBI()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.BOLDITALIC);
        }

        public static Font getFontGandeB()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.BOLD);
        }

        public static Font getFontGandeB13()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 13, Font.BOLD);
        }

        public static Font getFontMedianoBI()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.BOLDITALIC);
        }

        public static Font getFontMedianoBITam(int xSize)
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, xSize, Font.BOLDITALIC);
        }
        public static Font getFontBI(int xTamano)
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, xTamano, Font.BOLDITALIC);
        }

        public static Font getFontGrandeBI13()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 13, Font.BOLDITALIC);
        }

        public static Font getFontMedianoBI10()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLDITALIC);
        }

        public static Font getFontMediano()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 11);
        }

        public static Font getFontGrande13()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 13);
        }

        public static Font getFontGrande13B()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 13, Font.BOLD);
        }

        public static Font getFontGrande()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 14);
        }

        public static Font getFontGrandeVerde()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.NORMAL, new BaseColor(0, 99, 0));
        }


        public static Font getFontMedianoNegrita()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 10, Font.BOLD);
        }

        public static Font getFontNegritaTamano(int xTamano)
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, xTamano, Font.BOLD);
        }

        public static Font getFontMediano10()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 10);
        }

        public static Font getFontMediano12()
        {

            return FontFactory.GetFont(FontFactory.HELVETICA, 12);
        }

        public static Font getFontMedianoBlanco()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 11, Font.NORMAL, new BaseColor(255, 255, 255));
        }

        public static Font getFontGrandeBlanco()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 15, Font.NORMAL, new BaseColor(255, 255, 255));
        }

        public static Font getFontTituloT()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 8);
        }

        public static Font getFontTituloTB()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 7, Font.BOLD);
        }

        public static Font getFontGrandeBI()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 14, Font.BOLDITALIC);
        }

        public static Font getFontPequenio()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 6, Font.ITALIC);
        }

        public static Font getFontPequenio5()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 5, Font.ITALIC);
        }

        public static Font getFontPequenioB()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 6, Font.BOLDITALIC);
        }

        public static Font getFontValorTB()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 9, Font.BOLD);
        }

        public static Font getFontValorTPB()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 8, Font.BOLD);
        }

        public static Font getFontNro()
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, 17, Font.BOLD);
        }

        public static Font getFont(float xTamanio, int xEstilos)
        {
            return FontFactory.GetFont(FontFactory.HELVETICA, xTamanio, xEstilos);
        }

        public static string NumeroALetras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string NumeroALetras(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }

            return Num2Text;
        }

        public static String agregarCerosIzquierda(long xNro, int xCantidadCeros)
        {
            String vNro = xNro + "";
            for (int i = vNro.Length; i < xCantidadCeros; i++)
            {
                vNro = "0" + vNro;
            }

            return vNro;
        }
    }
}
