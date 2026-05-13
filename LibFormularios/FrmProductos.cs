using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;
namespace LibFormularios
{
    public partial class FrmProductos : LibFormularios.FrmPadre
    {
        public FrmProductos()
        {
            InitializeComponent();
            IniciarEntidad(new CProducto());
            RdbSiSerie.Checked = true;
        }
        //======REDEFINICION DE LOS METODOS VIRTUAL =================
        //-----Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodProducto.Text,TxtProducto.Text,TxtDescripcion.Text,
                TxtMarca.Text, TxtModelo.Text,TxtStock.Text, TxtPrecio.Text};
        }
        //-------------------------------------------------------------------
        //---Mostrar los datos de un registro -------------------------------
        public override void MostrarDatos()
        {   //---muestra la infromacion contenida en  el dataset del CProducto
            TxtProducto.Text = aEntidad.ValorAtributo("Producto");
            TxtDescripcion.Text = aEntidad.ValorAtributo("Descripcion");
            TxtMarca.Text = aEntidad.ValorAtributo("Marca");
            TxtModelo.Text = aEntidad.ValorAtributo("Modelo");
            CargarSeries(TxtCodProducto.Text);
            TxtStock.Text = aEntidad.ValorAtributo("Stock");
            TxtPrecio.Text = aEntidad.ValorAtributo("PrecioUnitario");
        }
        public void CargarSeries(string CodProducto)
        {
            CSerie S = new CSerie();
            CboSeries.DataSource = S.ListarPorCodigo(CodProducto);
            CboSeries.DisplayMember = "Serie";
            CboSeries.ValueMember = "CodProducto";
            CboSeries.SelectedIndex = -1;
        }
        //-------------------------------------------------------------------
        //----Iniciar los atributps clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodProducto.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtProducto.Text ="";
            TxtDescripcion.Text = "";
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            CboSeries.SelectedIndex = -1;
            TxtStock.Text = "0";
            TxtPrecio.Text = "";
        }
        //-------------------------------------------
        //---Listar los registros y mostrarlos en el datagrid
        public override void ListaRegistros()
        {   //--Mostrar todos loslibros de la tabla en el grid
            DgvProductos.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------
        //---Verificar los campos obligatorios(codigo y titulo)
        //---Esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodProducto.Text.Trim() != "" && TxtDescripcion.Text.Trim() != "" && TxtStock.Text.Trim() != "" && TxtPrecio.Text.Trim() != "")
                return true;
            else
                return false;
        }
        //=========================EVENTOS ==================
        private void TxtCodProducto_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }
        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListaRegistros();
        }
        private void LimpiarTodo()
        {
            //CboSeries.Text = "";
        }
        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-----Recuperar atributos,el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //----Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                        if (aEntidad.ValorAtributo("CodError") == "0")
                        {
                            if(CboSeries.Text!="") BtnAgregarSerie.PerformClick();
                            //---Inicializar el formulario
                            MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION");
                        }
                        else
                            MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "ERROR");
                    }


                    InicializarAtributos();
                    ListaRegistros();
                }
                else MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        public void ActualizarStock(string CodProducto, int Cantidad)
        {
            CProducto aProducto = new CProducto();
            if (aProducto.ExisteClavePrimaria(CodProducto))
            {
                int NuevoValor = int.Parse(aProducto.ValorAtributo("Stock"));
                NuevoValor += Cantidad;
                string[] A = new string[] {  TxtCodProducto.Text,TxtProducto.Text,TxtDescripcion.Text,
                TxtMarca.Text, TxtModelo.Text,NuevoValor.ToString(), TxtPrecio.Text};
                aProducto.Actualizar(A);
            }
        }
        private void BtnAgregarSerie_Click(object sender, EventArgs e)
        {
            if (TxtCodProducto.Text != "P")
            {
                if (CboSeries.Text != "")
                {
                    CSerie Serie = new CSerie();
                    Serie.Insertar(new string[] { TxtCodProducto.Text, CboSeries.Text });
                    if (Serie.ValorAtributo("CodError") == "0" && Serie.ValorAtributo("CodError") == "0")
                    {
                        //---Inicializar el formulario
                        ActualizarStock(TxtCodProducto.Text,1);
                        if (aEntidad.ExisteClavePrimaria(TxtCodProducto.Text))
                        {
                            TxtStock.Text = aEntidad.ValorAtributo("Stock");
                            CargarSeries(TxtCodProducto.Text);
                        }
                        MessageBox.Show(Serie.ValorAtributo("Mensaje"), "CONFIRMACION");
                        //Limpiar el formulario
                        //LimpiarTodo();
                    }
                    else
                        MessageBox.Show(Serie.ValorAtributo("Mensaje"), "ERROR");
                }
                else
                {
                    MessageBox.Show("La serie no puede ser vacia");
                }
            }
            else
            {
                MessageBox.Show("Tiene que ingresar un producto");
            }

        }

        private void CboSeries_Leave(object sender, EventArgs e)
        {
            if (CboSeries.Text != "") TxtStock.Enabled = false;
            else TxtStock.Enabled = true;
        }

        private void TxtPrecio_Leave(object sender, EventArgs e)
        {
            if (CboSeries.Text != "") TxtStock.Enabled = false;
            else TxtStock.Enabled = true;
        }

        private void RdbNoSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbNoSerie.Checked == true)
            {
                CboSeries.Enabled = false;
                BtnAgregarSerie.Enabled = false;
                TxtStock.Enabled = true;
            }
        }

        private void RdbSiSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSiSerie.Enabled == true)
            {
                CboSeries.Enabled = true;
                BtnAgregarSerie.Enabled = true;
                TxtStock.Enabled = false;
            }
        }

        private void TxtCodProducto_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.StartsWith("P"))
            {
                textBox.Text = "P";
                textBox.Select(textBox.Text.Length, 0);
            }
        }
    }
}
