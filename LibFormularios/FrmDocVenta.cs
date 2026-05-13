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
    public partial class FrmDocVenta : LibFormularios.FrmDocPadre
    {
        CDetalleVenta aDetalle = new CDetalleVenta();
        CCliente aCliente = new CCliente();
        CProducto aProducto = new CProducto();
        public string aCodUsuario="";
        public FrmDocVenta()
        {
            InitializeComponent();
            IniciarEntidad(new CDocVenta());
            GenerarNroDoc("BOLETA");
            FormatearGridProductos();
        }
        public void FormatearGridProductos()
        {
            //-----Columna de Codigo Producto
            DataGridViewTextBoxColumn TxtCodProducto = new DataGridViewTextBoxColumn
            {
                Name = "ColCodProducto",
                HeaderText = "CodProducto",
                Width = 80
            };
            DgvDetalleVentas.Columns.Add(TxtCodProducto);
            //-----Columna de Cantidad
            DataGridViewTextBoxColumn Cantidad = new DataGridViewTextBoxColumn
            {
                Name = "ColCantidad",
                HeaderText = "Cantidad",
                Width = 60
            };
            DgvDetalleVentas.Columns.Add(Cantidad);
            //-----Columna de Unidad
            DataGridViewTextBoxColumn Producto = new DataGridViewTextBoxColumn
            {
                Name = "ColProducto",
                HeaderText = "Producto",
                Width = 60
            };
            DgvDetalleVentas.Columns.Add(Producto);
            //-----Columna de Marca
            DataGridViewTextBoxColumn Marca = new DataGridViewTextBoxColumn
            {
                Name = "ColMarca",
                HeaderText = "Marca",
                Width = 80
            };
            DgvDetalleVentas.Columns.Add(Marca);
            //-----Columna de Modelo
            DataGridViewTextBoxColumn Modelo = new DataGridViewTextBoxColumn
            {
                Name = "ColModelo",
                HeaderText = "Modelo",
                Width = 80
            };
            DgvDetalleVentas.Columns.Add(Modelo);
            //-----Columna de Series
            DataGridViewTextBoxColumn Series = new DataGridViewTextBoxColumn
            {
                Name = "ColSerie",
                HeaderText = "Serie",
                Width = 100
            };
            DgvDetalleVentas.Columns.Add(Series);
            //-----Columna de Precio
            DataGridViewTextBoxColumn Precio = new DataGridViewTextBoxColumn
            {
                Name = "ColPrecio",
                HeaderText = "P.U",
                Width = 60
            };
            DgvDetalleVentas.Columns.Add(Precio);
            //-----Columna de Subtotal
            DataGridViewTextBoxColumn SubTotal = new DataGridViewTextBoxColumn
            {
                Name = "ColSubTotal",
                HeaderText = "SubTotal",
                Width = 60
            };
            DgvDetalleVentas.Columns.Add(SubTotal);
            //-------Columna con boton de borrado
            DataGridViewButtonColumn BtnBorrar = new DataGridViewButtonColumn
            {
                Name = "BtnBorrar",
                HeaderText = "",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 40
            };
            DgvDetalleVentas.Columns.Add(BtnBorrar);

        }
        //======REDEFINICION DE LOS METODOS VIRTUAL =================
        //-----Establecer los valores que iran a la tabla
        public override void GenerarNroDoc(string Tipo)
        {
            if (Tipo == "BOLETA")
            {
                TxtNroDoc.Text = (aEntidad as CDocVenta).UltimoNroDocVenta("BOLETA");
            }
            else
                TxtNroDoc.Text = (aEntidad as CDocVenta).UltimoNroDocVenta("FACTURA");
        }
        public override string[] AsignarValoresAtributos()
        {
            if (RdbBoleta.Checked == true)
            {
                if (RdbContado.Checked == true) return new string[] { TxtNroDoc.Text, TxtFecha.Text.Substring(0, 10), "BOLETA","CONTADO",TxtCodCliente.Text,aCodUsuario};
                else return new string[] { TxtNroDoc.Text, TxtFecha.Text.Substring(0, 10), "BOLETA","CREDITO", TxtCodCliente.Text,aCodUsuario};
            }
            else
            {
                if (RdbContado.Checked == true) return new string[] { TxtNroDoc.Text, TxtFecha.Text.Substring(0, 10), "FACTURA","CONTADO", TxtCodCliente.Text,aCodUsuario};
                else return new string[] { TxtNroDoc.Text, TxtFecha.Text.Substring(0, 10), "FACTURA","CREDITO",TxtCodCliente.Text,aCodUsuario};
            }
                
        }
        //-------------------------------------------------------------------
        //---Mostrar los datos de un registro -------------------------------
        public override void MostrarDatos()
        {   //---muestra la infromacion contenida en  el dataset del CDocVenta
            Timer1.Enabled = false;
            TxtFecha.Text = aEntidad.ValorAtributo("Fecha");
            if (aEntidad.ValorAtributo("Tipo") == "BOLETA")
                RdbBoleta.Checked = true;
            else RdbFactura.Checked = true;
            TxtCodCliente.Text = aEntidad.ValorAtributo("CodCliente");
            MostrarDatosCliente(TxtCodCliente.Text);
            MostrarDetalleVenta(TxtNroDoc.Text);
            CalcularTotales();
        }
        //------------------------------------------------------------------------
        //----Mostrar datos del cliente--------------------------------
        public void MostrarDatosCliente(string CodCliente)
        {
            if (aCliente.ExisteClavePrimaria(CodCliente))
            {
                TxtDNI.Text = aCliente.ValorAtributo("DNI");
                TxtNombre.Text = aCliente.ValorAtributo("Nombres");
                TxtDireccion.Text = aCliente.ValorAtributo("Direccion");
                TxtEmail.Text = aCliente.ValorAtributo("Email");
                TxtTelefono.Text = aCliente.ValorAtributo("Telefono");
            }
            else
            {
                MessageBox.Show("Cliente no registrado");
            }
        }
        //------------------------------------------------------------------------
        //-----------Mostrar Datos del Producto-----------------------------------
        public void CargarSeries(string CodProducto)
        {
            CSerie S = new CSerie();
            CboSeries.DataSource = S.ListarPorCodigo(CodProducto);
            CboSeries.DisplayMember = "Serie";
            CboSeries.ValueMember = "CodProducto";
            CboSeries.SelectedIndex = -1;
        }
        public void MostrarDatosProducto(string CodProducto)
        {
            if (aProducto.ExisteClavePrimaria(CodProducto))
            {
                TxtProducto.Text = aProducto.ValorAtributo("Producto");
                TxtDescripcion.Text = aProducto.ValorAtributo("Descripcion");
                TxtMarca.Text = aProducto.ValorAtributo("Marca");
                TxtModelo.Text = aProducto.ValorAtributo("Modelo");
                CargarSeries(TxtCodProducto.Text);
                TxtStock.Text = aProducto.ValorAtributo("Stock");
                TxtPrecio.Text = aProducto.ValorAtributo("PrecioUnitario");
                if (CboSeries.Items.Count > 0)
                {
                    TxtCantidad.Enabled = false;
                    CboSeries.Enabled = true;
                }
                else
                {
                    TxtCantidad.Enabled = true;
                    CboSeries.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El producto no existe");
            }
        }
        //-------------------------------------------------------------------------
        //-------Mostrar Detalle venta -------------------------------------------
        public void MostrarDetalleVenta(string NroDocVenta)
        {
            if (aDetalle.ExisteClavePrimaria(NroDocVenta))
            {
                DgvDetalleVentas.DataSource = aDetalle.ListarPorCodigo(NroDocVenta);
                for(int i = 0; i < DgvDetalleVentas.Columns.Count; i++)
                {
                    DgvDetalleVentas.Columns[i].Width = 78;
                }
            }
        }
        //-------------------------------------------------------------------
        //----Iniciar los atributps clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            GenerarNroDoc("BOLETA");
        }
        public override void InicializarAtributosNoClave()
        {
            RdbBoleta.Checked = true;
            TxtCodCliente.Text = "";
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
            if (TxtCodCliente.Text.Trim() != "" && TxtDNI.Text.Trim() != ""
                    && DgvDetalleVentas.RowCount > 0 && TxtNroDoc.Text.Trim() != " ")
                return true;
            else
                return false;
        }
        //=========================EVENTOS ==================
        private void TxtCodCliente_Leave(object sender, EventArgs e)
        {
            MostrarDatosCliente(TxtCodCliente.Text);
        }
        public override void CalcularTotales()
        {
            TxtTotal.Text = CalcularTotalDgv().ToString();
            TxtSubTotal.Text = (double.Parse(TxtTotal.Text) / 1.18).ToString();
            TxtIGV.Text = (double.Parse(TxtTotal.Text) - double.Parse(TxtSubTotal.Text)).ToString();
            TxtTotalLetra.Text = ConvertirALetra(TxtTotal.Text);
        }
        public string CalcularTotalDgv()
        {
            double Suma = 0;
            for (int i = 0; i < DgvDetalleVentas.Rows.Count; i++)
            {
                double Aux = double.Parse(DgvDetalleVentas.Rows[i].Cells[6].Value.ToString());
                Suma += Aux;
            }
            return Suma.ToString();
        }
        private void TxtCodProducto_Leave(object sender, EventArgs e)
        {
            MostrarDatosProducto(TxtCodProducto.Text);
        }
        private int BuscarCodigoGrid(string CodeProducto)
        {
            int Fila = -1;
            for (int i = 0; i < DgvDetalleVentas.RowCount; i++)
            {
                if (CodeProducto.Equals(DgvDetalleVentas.Rows[i].Cells[0].Value.ToString()))
                {
                    Fila = i;
                    break;
                }
            }
            return Fila;
        }
        public void EliminarSerie(string CodProducto, string Serie)
        {
            CSerie S = new CSerie();
            if (S.ExisteClavePrimaria(CodProducto))
            {
                S.Eliminar(CodProducto, Serie);
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodProducto.Text != "P" && ValidarCantidad() && TxtStock.Text != "0")
            {
                if (CboSeries.Items.Count > 0)
                {
                    if (CboSeries.SelectedIndex != -1)
                    {
                        double AuxSubtotal = int.Parse(TxtCantidad.Text) * double.Parse(TxtPrecio.Text);
                        DgvDetalleVentas.Rows.Add(TxtCodProducto.Text, TxtCantidad.Text, TxtProducto.Text, TxtMarca.Text, TxtModelo.Text, CboSeries.Text, TxtPrecio.Text, AuxSubtotal);
                        CalcularTotales();
                        EliminarSerie(TxtCodProducto.Text, CboSeries.Text);
                        ActualizarStock(TxtCodProducto.Text, int.Parse(TxtCantidad.Text), false);
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una serie");
                    }
                }
                else
                {
                    int Fila = BuscarCodigoGrid(TxtCodProducto.Text);
                    if (Fila == -1)
                    {
                        double AuxSubtotal = int.Parse(TxtCantidad.Text) * double.Parse(TxtPrecio.Text);
                        DgvDetalleVentas.Rows.Add(TxtCodProducto.Text, TxtCantidad.Text, TxtProducto.Text, TxtMarca.Text, TxtModelo.Text, CboSeries.Text, TxtPrecio.Text, AuxSubtotal);
                        CalcularTotales();
                        ActualizarStock(TxtCodProducto.Text, int.Parse(TxtCantidad.Text), false);
                    }
                    else
                    {
                        int NuevaCantidad = int.Parse(DgvDetalleVentas.Rows[Fila].Cells[1].Value.ToString()) + int.Parse(TxtCantidad.Text);
                        DgvDetalleVentas.Rows[Fila].Cells[1].Value = NuevaCantidad.ToString();
                        double AuxSubtotal = int.Parse(DgvDetalleVentas.Rows[Fila].Cells[7].Value.ToString()) * double.Parse(TxtPrecio.Text);
                        DgvDetalleVentas.Rows[Fila].Cells[7].Value = AuxSubtotal.ToString();
                        DgvDetalleVentas.Rows[Fila].Cells[5].Value = " ";
                        CalcularTotales();
                        ActualizarStock(TxtCodProducto.Text, int.Parse(TxtCantidad.Text), false);
                    }
                    
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
        }
        private void LimpiarTxtsProducto()
        {
            TxtProducto.Text = "";
            TxtDescripcion.Text = "";
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            CboSeries.SelectedIndex = -1;
            TxtStock.Text = "";
            TxtPrecio.Text = "";
        }
        public Boolean ValidarCantidad()
        {
            if (TxtCantidad.Text != "")
            {
                if (TxtCantidad.Text != "" && int.Parse(TxtCantidad.Text) > 0 &&
                int.Parse(TxtCantidad.Text) <= int.Parse(TxtStock.Text))
                {
                    return true;
                }
                else return false;
            }
            else return false;

        }
        public void ActualizarStock(string CodProducto, int Cantidad, Boolean Aumento)
        {
            if (aProducto.ExisteClavePrimaria(CodProducto))
            {
                int NuevoValor = int.Parse(aProducto.ValorAtributo("Stock"));
                if (Aumento) NuevoValor += Cantidad;
                else NuevoValor -= Cantidad;
                string[] A = new string[] {  TxtCodProducto.Text,TxtProducto.Text,TxtDescripcion.Text,
                TxtMarca.Text, TxtModelo.Text,NuevoValor.ToString(), TxtPrecio.Text};
                aProducto.Actualizar(A);
            }
        }

        private void DgvDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //----Determinar las coordenadas de la celda que cambio
            int Fila = e.RowIndex;
            int Col = e.ColumnIndex;
            if (Col == 7)
            {
                // Como se elimina un producto se aumenta el stock de dicho producto
                string CodigoEliminado = DgvDetalleVentas[0, Fila].Value.ToString();
                int CantidadAumentada = int.Parse(DgvDetalleVentas[1, Fila].Value.ToString());
                ActualizarStock(CodigoEliminado, CantidadAumentada, true);
                if (DgvDetalleVentas.Rows[Fila].Cells[5].Value.ToString() != "") {
                    CSerie Serie = new CSerie();
                    Serie.Insertar(new string[] { DgvDetalleVentas.Rows[Fila].Cells[0].Value.ToString(), DgvDetalleVentas.Rows[Fila].Cells[5].Value.ToString() });
                }
                DgvDetalleVentas.Rows.RemoveAt(Fila);
                CalcularTotales();
            }
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
                    CDetalleVenta Detalle = new CDetalleVenta();
                    for (int i = 0; i < DgvDetalleVentas.RowCount; i++)
                    {
                        Atributos = new string[] {TxtNroDoc.Text,DgvDetalleVentas.Rows[i].Cells[0].Value.ToString(),
                                                    DgvDetalleVentas.Rows[i].Cells[5].Value.ToString(),
                                                    DgvDetalleVentas.Rows[i].Cells[1].Value.ToString(),
                                                    DgvDetalleVentas.Rows[i].Cells[6].Value.ToString()};
                        Detalle.Insertar(Atributos);
                    }
                    if (aEntidad.ValorAtributo("CodError") == "0")
                    {
                        //---Inicializar el formulario
                        MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION");
                        //Limpiar el formulario
                        LimpiarTodo();
                        //Limpiar el datagridview
                        DgvDetalleVentas.Rows.Clear();
                    }
                    else
                        MessageBox.Show(Detalle.ValorAtributo("Mensaje"), "ERROR");
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
        private void BtnNuevo_Click(object sender, EventArgs e)
        {

            LimpiarTodo();
            BloqueoFormulario(true);
            GenerarNroDoc("BOLETA");
            FormatearGridProductos();
            FechaActual();
            BtnNuevo.Enabled = false;
        }
        public void LimpiarTodo()
        {
            //Limpiar todo el formulario 
            LimpiarTxtsProducto();
            TxtCodCliente.Text = "";
            TxtDNI.Text = "";
            TxtDireccion.Text = "";
            TxtEmail.Text = "";
            TxtNombre.Text = "";
            TxtTelefono.Text = "";
            TxtCantidad.Text = "";
            TxtSubTotal.Text = "";
            TxtTotalLetra.Text = "";
            TxtTotal.Text = "";
            TxtIGV.Text = "";
            RestituirDatos();
            DgvDetalleVentas.DataSource = null;
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
            GroupTipo.Enabled = Tipo;
            //PanDetalleProductos.Enabled = Tipo;
            PanCliente.Enabled = Tipo;
            PanProductos.Enabled = Tipo;
            PanBotones.Enabled = Tipo;
        }
        public void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            if (aEntidad.ExisteClavePrimaria(TxtNroDoc.Text))
            {
                DgvDetalleVentas.Columns.Clear();
                BloqueoFormulario(false);
                ProcesarClave();
                BtnNuevo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No Existe Documento Venta");
            }
        }

        private void RdbBoleta_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBoleta.Checked == true)
            {
                GenerarNroDoc("BOLETA");
            }
        }
        private void RdbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbFactura.Checked)
            {
                GenerarNroDoc("FACTURA");
            }
        }

        private void CboSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCantidad.Text = "1";
        }

        private void BtnPagoLetras_Click(object sender, EventArgs e)
        {
            FrmPagoLetras Raioz = new FrmPagoLetras();
            double mitad = double.Parse(TxtTotal.Text)/2;
            Raioz.IniciarDocPagoLetras(TxtNroDoc.Text, mitad.ToString()
                , string.Format(DateTime.Now.ToString()), TxtTotal.Text);
            BtnGuardar.PerformClick();
            Raioz.ShowDialog();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.ShowDialog();
        }

        private void BtnBuscarDoc_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnBuscarDNI_Click(object sender, EventArgs e)
        {
            if (TxtDNIBusqueda.Text == "")
            {
                MessageBox.Show("Cuadro de Busqueda Vacio");
            }
            else
            {
                if (aCliente.BuscarDNI(TxtDNIBusqueda.Text) != "")
                {
                    TxtCodCliente.Text = aCliente.BuscarDNI(TxtDNIBusqueda.Text);
                }
                else
                {
                    BtnAgregarNuevoCliente.Enabled = true;
                    MessageBox.Show("El Cliente no existe si desea puede agregarlo");
                }
            }
        }

        private void BtnAgregarNuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente Cliente = new FrmCliente();
            Cliente.HabilitarVendedor();
            Cliente.ShowDialog();
            TxtCodCliente.Text= Cliente.CodCliente;
            BtnAgregarNuevoCliente.Enabled = false;
        }

        private void TxtFecha_TextChanged(object sender, EventArgs e)
        {

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



        /*private void BtnImprimir_Click(object sender, EventArgs e)
        {
            FrmReporteVenta Form = new FrmReporteVenta();
            Form.IniciarDocVenta(TxtNroDoc.Text);
            BtnGuardar.PerformClick();
            Form.ShowDialog();
        }*/
    }
}
