using reparaciones2.dao;
using reparaciones2.ob;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reparaciones2.utils
{
    public static class UtilidadesComunes
    {
        public static void CargarTiposDeComprobante(ComboBox xComboBox)
        {
            xComboBox.Items.Add("A");
            xComboBox.Items.Add("B");
            xComboBox.Items.Add("C");
            xComboBox.Items.Add("X");
        }

        public static void cargarComboEstadosReparacion(ComboBox xComboBox)
        {
            xComboBox.Items.Add("TOMADA");
            xComboBox.Items.Add("EN REPARACION");
            xComboBox.Items.Add("REPARADA");
            xComboBox.Items.Add("ENTREGADA");
        }

        public static void cargarComboUsuario(ComboBox xComboBox)
        {
            DataTable tableUsuario = DAOUsuario.getUsuariosCombo();
            DataRow rowDefaultUsuario = tableUsuario.NewRow();
            rowDefaultUsuario["descripcion"] = "";
            tableUsuario.Rows.InsertAt(rowDefaultUsuario, 0);
            xComboBox.DataSource = tableUsuario;
            xComboBox.DisplayMember = "descripcion";
            xComboBox.ValueMember = "descripcion";
        }

        public static void cargarCondicionIVA(ComboBox xComboBox)
        {
            xComboBox.Items.Add(Cliente.CONSUMIDOR_FINAL);
            xComboBox.Items.Add(Cliente.MONOTRIBUTISTA);
            xComboBox.Items.Add(Cliente.RESPONSABLE_INSCRIPTO);
            xComboBox.Items.Add(Cliente.EXENTO);
        }

        public static void cargarTipoDocumento(ComboBox xComboBox)
        {
            xComboBox.Items.Add(Cliente.DNI);
            xComboBox.Items.Add(Cliente.LE);
            xComboBox.Items.Add(Cliente.LC);
            xComboBox.Items.Add(Cliente.CE);
            xComboBox.Items.Add(Cliente.PASAPORTE);
        }

        public static void CargarComboEstadosService(ComboBox xComboBox)
        {
            xComboBox.Items.Add("TOMADO");
            xComboBox.Items.Add("EN EJECUCION");
            xComboBox.Items.Add("FINALIZADO");
        }

        public static void CargarComboPrioridades(ComboBox xComboBox)
        {
            xComboBox.Items.Add("ALTA");
            xComboBox.Items.Add("MEDIA");
            xComboBox.Items.Add("BAJA");
        }

        public static void CargarComboTipoNota(ComboBox xComboBox)
        {
            xComboBox.Items.Add("NC");
            xComboBox.Items.Add("ND");
        }

        public static void CargarComboGrupoUsuario(ComboBox xComboBox)
        {
            xComboBox.DataSource = DAOUsuario.CmbGrupos();
            xComboBox.DisplayMember = "value";
            xComboBox.ValueMember = "id";
        }

        public static void CargarComboMedioPago(ComboBox xComboBox)
        {
            xComboBox.Items.Add("EFECTIVO");
            xComboBox.Items.Add("TARJETA");
            xComboBox.Items.Add("CHEQUE");
            xComboBox.Items.Add("DEPOSITO BANCARIO");
        }

        public static void CargarTipoTarjeta(ComboBox xComboBox)
        {
            xComboBox.Items.Add("DEBITO");
            xComboBox.Items.Add("CREDITO");
        }
    }
}
