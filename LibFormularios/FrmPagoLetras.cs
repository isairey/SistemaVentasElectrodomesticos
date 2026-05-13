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
    public partial class FrmPagoLetras : LibFormularios.FrmPadre
    {
        CCliente aCliente = new CCliente();
        CDetalleVentaCredito aDetalleCredito = new CDetalleVentaCredito();
        public FrmPagoLetras()
        {
            InitializeComponent();
            IniciarEntidad(new CDocVentaCredito());
            GenerarNroDoc();
            TxtFecha.Text = string.Format(DateTime.Now.ToString());
        }
        //======REDEFINICION DE LOS METODOS VIRTUAL =================
        //-----Establecer los valores que iran a la tabla
        public void GenerarNroDoc()
        {
            TxtNroDocCredito.Text = (aEntidad as CDocVentaCredito).UltimoNroDocCredito();
        }
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtNroDocCredito.Text,TxtDocVenta.Text,TxtNroCuotas.Text
                ,dtpFechaFinalPago.Value.ToShortDateString().ToString(),TxtObservaciones.Text,TxtEstado.Text};
        }
        //-------------------------------------------------------------------
        //---Mostrar los datos de un registro -------------------------------
        public override void MostrarDatos()
        {   //---muestra la infromacion contenida en  el dataset del CDocVenta
            TxtNroDocCredito.Text = aEntidad.ValorAtributo("NroDocVentaCredito");
            TxtDocVenta.Text = aEntidad.ValorAtributo("NroDocVenta");
            TxtNroCuotas.Text = aEntidad.ValorAtributo("NroCuotas");
            dtpFechaFinalPago.Text = aEntidad.ValorAtributo("FechaPago");
            TxtObservaciones.Text = aEntidad.ValorAtributo("Observaciones");
            TxtEstado.Text = aEntidad.ValorAtributo("Estado");
            MostrarDatosCalculables();
            MostrarDetalleVentaCredito(TxtNroDocCredito.Text);
        }

        public void MostrarDatosCalculables()
        {
            TxtMonto.Text = (CalcularMora() + CalcularMontoAPagar()).ToString();
            TxtMontoTotal.Text = CalcularMontoTotal().ToString();
            CalcularTotales();
            TxtSaldo.Text = (CalcularMontoTotal() - float.Parse(TxtTotal.Text)).ToString();
        }
        public float CalcularMora()
        {
            return 0;
        }
        public float CalcularMontoAPagar()
        {
            return 0;
        }
        public float CalcularMontoTotal()
        {
            return 0;
        }
        //-------------------------------------------------------------------------
        //-------Mostrar Detalle venta -------------------------------------------
        public void MostrarDetalleVentaCredito(string NroDocVenta)
        {
            if (aDetalleCredito.ExisteClavePrimaria(NroDocVenta))
            {
                DgvDetalleLetras.DataSource = aDetalleCredito.ListarPorCodigo(NroDocVenta);
            }
        }
        //-------------------------------------------------------------------
        //----Iniciar los atributps clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            GenerarNroDoc();
        }
        public override void InicializarAtributosNoClave()
        {
            TxtDocVenta.Text = "";
            TxtNroCuotas.Text = "";
            TxtObservaciones.Text = "";
            TxtEstado.Text = "";
            MostrarDetalleVentaCredito(TxtNroDocCredito.Text);
        }
        //-------------------------------------------
        //---Listar los registros y mostrarlos en el datagrid
        public override void ListaRegistros()
        {   //--Mostrar todos loslibros de la tabla en el grid
            //DgvClientes.DataSource = aEntidad.ListaGeneral();
        }
        //----------------------------------------
        //---Verificar los campos obligatorios(codigo y titulo)
        //---Esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtNroDocCredito.Text.Trim() != ""
                   && TxtDocVenta.Text.Trim() != " ")
                return true;
            else
                return false;
        }
        //=========================EVENTOS ==================
        public void CalcularTotales()
        {
            TxtTotal.Text = CalcularTotalDgv().ToString();
        }
        public string CalcularTotalDgv()
        {
            double Suma = 0;
            for (int i = 0; i < DgvDetalleLetras.Rows.Count; i++)
            {
                double Aux = double.Parse(DgvDetalleLetras.Rows[i].Cells[6].Value.ToString());
                Suma += Aux;
            }
            return Suma.ToString();
        }
        /*private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodProducto.Text != "P" && ValidarCantidad() && TxtStock.Text != "0")
            {
                if (BuscarCodigoGrid(TxtCodProducto.Text) == -1)
                {
                    double AuxSubtotal = int.Parse(TxtCantidad.Text) * double.Parse(TxtPrecio.Text);
                    DgvDetalleVentas.Rows.Add(TxtCodProducto.Text, TxtCantidad.Text, TxtMarca.Text, TxtDescripcion.Text, TxtPrecio.Text, AuxSubtotal);
                    CalcularTotales();
                    ActualizarStock(TxtCodProducto.Text, int.Parse(TxtCantidad.Text), false);
                }
                else
                {
                    int Fila = BuscarCodigoGrid(TxtCodProducto.Text);
                    int NuevaCantidad = int.Parse(DgvDetalleVentas.Rows[Fila].Cells[1].Value.ToString()) + int.Parse(TxtCantidad.Text);
                    DgvDetalleVentas.Rows[Fila].Cells[1].Value = NuevaCantidad.ToString();
                    double AuxSubtotal = int.Parse(DgvDetalleVentas.Rows[Fila].Cells[1].Value.ToString()) * double.Parse(TxtPrecio.Text);
                    DgvDetalleVentas.Rows[Fila].Cells[6].Value = AuxSubtotal.ToString();
                    CalcularTotales();
                    ActualizarStock(TxtCodProducto.Text, int.Parse(TxtCantidad.Text), false);
                }
                TxtCodProducto.Enabled = true;
                LimpiarTxtsProducto();
                TxtCodProducto.Text = "P";
            }
            else
            {
                if (TxtCodProducto.Text == "P")
                {
                    MessageBox.Show("Ningun producto a sido seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!ValidarCantidad())
                    {
                        TxtCantidad.Focus();
                        TxtCantidad.SelectAll();
                        MessageBox.Show("Debe ingresar una cantidad menor o igual al stock del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }*/
        private void LimpiarTxts()
        {
            TxtMonto.Text = "";
            TxtMontoTotal.Text = "";
            TxtTotal.Text = "";
            TxtSaldo.Text = "";
        }
        public override void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-----Recuperar atributos,el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //----Verificar si existe clave primaria
                    aEntidad.Insertar(Atributos);
                    if (aEntidad.ValorAtributo("CodError") == "0" && aEntidad.ValorAtributo("CodError") == "0")
                    {
                        //---Inicializar el formulario
                        MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION");
                        //Limpiar el formulario
                        LimpiarTodo();
                        //Limpiar el datagridview
                        DgvDetalleLetras.Rows.Clear();
                    }
                    else
                        MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "ERROR");
                    InicializarAtributos();
                    //ListaRegistros();
                }
                else MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        public void FechaActual()
        {
            TxtFecha.Text = string.Format(DateTime.Now.ToString());
        }
        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarTodo();
            BloqueoFormulario(true);
            GenerarNroDoc();
            FechaActual();
        }
        public void IniciarDocPagoLetras(string DocVenta,string Monto,string Fecha,string Total)
        {
            GenerarNroDoc();
            TxtDocVenta.Text = DocVenta;
            TxtMonto.Text = Monto;
            TxtMontoTotal.Text = Total;
            TxtFecha.Text = Fecha;
        }

        public void LimpiarTodo()
        {
            //Limpiar todo el formulario 
            
        }
        public void RestituirDatos()
        {
            //Modulo que restituye el stock de todos los productos
            //que se encuentran en el datagridview para evitar que el stock sea incorrecto


        }
        /// <summary>
        /// Metodo que bloquea y desbloquea  los controles del formulario 
        /// </summary>
        /// <param name="Tipo"></param>false si es para bloquear y true para desbloquear
        public void BloqueoFormulario(Boolean Tipo)
        {
            TxtFecha.Enabled = Tipo;
        }

        private void BtnVerDocVenta_Click(object sender, EventArgs e)
        {
            FrmPagoLetras Letras = new FrmPagoLetras();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            TxtFecha.Text = string.Format(DateTime.Now.ToString());
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CDocVenta DV = new CDocVenta();
            DV.Insertar();
            this.Close();
        }

        private void TxtNroCuotas_Leave(object sender, EventArgs e)
        {
            double MontoTotal = double.Parse(TxtMontoTotal.Text);

            TxtMontoTotal.Text = (MontoTotal + int.Parse(TxtNroCuotas.Text)*MontoTotal*0.1).ToString();
        }

        private void TxtNroCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            CDetalleVentaCredito DVC = new CDetalleVentaCredito();
            string[] InsertarDEt;
            DVC.Insertar();
        }
    }
}
