using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.ob.SMTP
{
    class AdjuntoLabel
    {
        private String mNombreArchivo = "";
        private LinkLabel mLink;
        private Label mLabelBorrar;
        private String mPathcompleto = "";

        public String PathCompleto
        {
            get { return mPathcompleto;}
            set { mPathcompleto = value;}
        }


        public Label LabelBorrar
        {
            get { return mLabelBorrar; }
            set { mLabelBorrar = value; }
        }
        
        public String NombreArchivo
        {
            get { return mNombreArchivo; }
            set { mNombreArchivo = value; }
        }

        public LinkLabel LinkForm
        {
            get { return mLink; }
            set { mLink = value; }
        }

        public void NoVisible()
        {
            mLink.Visible = false;
            mLabelBorrar.Visible = false;
        }

        public void Visible()
        {
            mLink.Visible = true;
            mLabelBorrar.Visible = true;
        }

        public bool TieneAlgo()
        {
            if (mLink.Visible == true)
                return true;
            else
                return false;
        }
    }
}
