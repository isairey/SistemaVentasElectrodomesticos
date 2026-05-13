using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class FrmCliente : LibFormularios.FrmPadre
    {
        public FrmCliente()
        {
            InitializeComponent();
            IniciarEntidad(new CCliente());
        }
        //======REDEFINICION DE LOS METODOS VIRTUAL =================
        //-----Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodCliente.Text, TxtDNI.Text, TxtNombre.Text,TxtDireccion.Text,TxtEmail.Text,TxtTelefono.Text};
        }
        //-------------------------------------------------------------------
        //---Mostrar los datos de un registro -------------------------------
        public override void MostrarDatos()
        {   //---muestra la infromacion contenida en  el dataset del CLibro
            TxtDNI.Text = aEntidad.ValorAtributo("DNI");
            TxtNombre.Text = aEntidad.ValorAtributo("Nombres");
            TxtDireccion.Text = aEntidad.ValorAtributo("Direccion");
            TxtEmail.Text = aEntidad.ValorAtributo("Email");
            TxtTelefono.Text = aEntidad.ValorAtributo("Telefono");
        }
        //-------------------------------------------------------------------
        //----Iniciar los atributps clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodCliente.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtDNI.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtEmail.Text = "";
            TxtTelefono.Text = "";
        }
        //-------------------------------------------
        //---Listar los registros y mostrarlos en el datagrid
        public override void ListaRegistros()
        {   //--Mostrar todos loslibros de la tabla en el grid
            DgvClientes.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------
        //---Verificar los campos obligatorios(codigo y titulo)
        //---Esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodCliente.Text.Trim() != "" && TxtDNI.Text.Trim() != "" && TxtDireccion.Text.Trim() != "")
                return true;
            else
                return false;
        }
        //=========================EVENTOS ==================

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ListaRegistros();
        }

        private void TxtCodCliente_Leave_1(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        //Metodo que inhabilita las opciones de eliminar y modificar un cliente
        //a un Vendedor
        public void HabilitarVendedor()
        {
            BtnEliminar.Visible = false;
            BtnNuevo.Visible = false;
        }
        //Propiedad que retorna el codcliente
        public string CodCliente
        {
            get { return TxtCodCliente.Text; }
        }

        private void TxtCodCliente_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.StartsWith("C"))
            {
                textBox.Text = "C";
                textBox.Select(textBox.Text.Length, 0);
            }
        }
    }
}
