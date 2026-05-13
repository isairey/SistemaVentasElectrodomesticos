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
    public partial class FrmUsuario : LibFormularios.FrmPadre
    {
        public FrmUsuario()
        {
            InitializeComponent();
            IniciarEntidad(new CUsuario());
        }
        // ==================== REDEFINICION DE LOS METODOS VIRTUAL =====================================00
        //----------------------- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { txtCodigo_Usuario.Text, txtContraseña.Text, txtDNI.Text, txtNombres.Text, txtEdad.Text, txtTelefono.Text, cmbTipo_Usuario.Text, cmbEstado.Text };

        }
        //------------------------------------------------------------------------------------------------------------
        //---- mostrar los datos de un registro
        public override void MostrarDatos()
        {
            //---- muestra la informacion contenida en el dataset de Clibros
            //txtCodigo_Usuario.Text = aEntidad.ValorAtributo("CodUsuario");
            txtContraseña.Text = aEntidad.ValorAtributo("Contraseña");
            txtDNI.Text = aEntidad.ValorAtributo("DNI");
            txtNombres.Text = aEntidad.ValorAtributo("Nombre");
            txtEdad.Text = aEntidad.ValorAtributo("Edad");
            txtTelefono.Text = aEntidad.ValorAtributo("Telefono");
            cmbTipo_Usuario.Text = aEntidad.ValorAtributo("Tipo");
            cmbEstado.Text = aEntidad.ValorAtributo("Estado");
        }
        //---------------------------------------------------------------------------------------------------------
        // -- Iniciar los atributos clave y no clave en Blanco
        public override void InicializarAtributoClave()
        {
            txtCodigo_Usuario.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            txtContraseña.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtEdad.Text = "";
            txtTelefono.Text = "";
            cmbTipo_Usuario.Text = "";
            cmbEstado.Text = "";
        }
        //-------------------------------------------------------------------------------------------------------------
        //---------------- lista los registros y mostrarlos en el datgrid
        public override void ListaRegistros()
        {
            //  Mostrar todos los libros de la tabla en el grid
            Dgv_Usuario.DataSource = aEntidad.ListaGeneral();
        }
        //-------------------------------------------------------------------------------------------------------------
        //-- Verificar los campos obligatorios (codigo y titulo) esten llenos
        //--------------------------------------------------------
        public override bool EsRegistroValido()
        {   //---Verifica que los datos esten completos en el formulario
            if (txtCodigo_Usuario.Text.Trim() != "" && txtContraseña.Text.Trim() != "" && txtDNI.Text.Trim()!="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------
        //=========================EVENTOS ==================
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            ListaRegistros();
        }

        private void txtCodigo_Usuario_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void txtCodigo_Usuario_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.StartsWith("U"))
            {
                textBox.Text = "U";
                textBox.Select(textBox.Text.Length, 0);
            }
        }
    }
}
