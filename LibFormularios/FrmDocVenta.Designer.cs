namespace LibFormularios
{
    partial class FrmDocVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.CboSeries = new System.Windows.Forms.ComboBox();
            this.BtnPagoLetras = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.GroupBox();
            this.RdbContado = new System.Windows.Forms.RadioButton();
            this.RdbCredito = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtDNIBusqueda = new System.Windows.Forms.TextBox();
            this.BtnBuscarDNI = new System.Windows.Forms.Button();
            this.BtnAgregarNuevoCliente = new System.Windows.Forms.Button();
            this.PanDetalleProductos.SuspendLayout();
            this.PanProductos.SuspendLayout();
            this.PanCliente.SuspendLayout();
            this.PanDetalleDoc.SuspendLayout();
            this.PanBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVentas)).BeginInit();
            this.T.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanDetalleProductos
            // 
            this.PanDetalleProductos.Controls.Add(this.DgvDetalleVentas);
            this.PanDetalleProductos.Location = new System.Drawing.Point(7, 427);
            this.PanDetalleProductos.Size = new System.Drawing.Size(680, 160);
            // 
            // PanProductos
            // 
            this.PanProductos.Controls.Add(this.TxtStock);
            this.PanProductos.Controls.Add(this.label22);
            this.PanProductos.Controls.Add(this.CboSeries);
            this.PanProductos.Controls.Add(this.BtnAgregar);
            this.PanProductos.Controls.Add(this.TxtCantidad);
            this.PanProductos.Controls.Add(this.label21);
            this.PanProductos.Controls.Add(this.label20);
            this.PanProductos.Controls.Add(this.TxtDescripcion);
            this.PanProductos.Controls.Add(this.label10);
            this.PanProductos.Controls.Add(this.TxtModelo);
            this.PanProductos.Controls.Add(this.TxtMarca);
            this.PanProductos.Controls.Add(this.label11);
            this.PanProductos.Controls.Add(this.TxtPrecio);
            this.PanProductos.Controls.Add(this.TxtProducto);
            this.PanProductos.Controls.Add(this.label12);
            this.PanProductos.Controls.Add(this.label13);
            this.PanProductos.Controls.Add(this.label19);
            this.PanProductos.Controls.Add(this.TxtCodProducto);
            this.PanProductos.Controls.Add(this.label9);
            this.PanProductos.Location = new System.Drawing.Point(7, 263);
            this.PanProductos.Size = new System.Drawing.Size(681, 158);
            // 
            // PanCliente
            // 
            this.PanCliente.Controls.Add(this.BtnAgregarNuevoCliente);
            this.PanCliente.Controls.Add(this.BtnBuscarDNI);
            this.PanCliente.Controls.Add(this.TxtDNIBusqueda);
            this.PanCliente.Controls.Add(this.label17);
            this.PanCliente.Controls.Add(this.TxtTelefono);
            this.PanCliente.Controls.Add(this.label8);
            this.PanCliente.Controls.Add(this.TxtEmail);
            this.PanCliente.Controls.Add(this.label7);
            this.PanCliente.Controls.Add(this.TxtDireccion);
            this.PanCliente.Controls.Add(this.label6);
            this.PanCliente.Controls.Add(this.TxtNombre);
            this.PanCliente.Controls.Add(this.label5);
            this.PanCliente.Controls.Add(this.TxtDNI);
            this.PanCliente.Controls.Add(this.label4);
            this.PanCliente.Controls.Add(this.TxtCodCliente);
            this.PanCliente.Controls.Add(this.label3);
            this.PanCliente.Location = new System.Drawing.Point(5, 144);
            this.PanCliente.Size = new System.Drawing.Size(681, 113);
            // 
            // PanDetalleDoc
            // 
            this.PanDetalleDoc.Controls.Add(this.T);
            this.PanDetalleDoc.Size = new System.Drawing.Size(681, 137);
            this.PanDetalleDoc.Controls.SetChildIndex(this.TxtNroDoc, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.TxtFecha, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.BtnBuscarDoc, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.GroupTipo, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.pictureBox1, 0);
            this.PanDetalleDoc.Controls.SetChildIndex(this.T, 0);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(369, 51);
            this.TxtFecha.Text = "20/02/2019 14:48:31";
            this.TxtFecha.TextChanged += new System.EventHandler(this.TxtFecha_TextChanged);
            // 
            // PanBotones
            // 
            this.PanBotones.Controls.Add(this.BtnPagoLetras);
            this.PanBotones.Location = new System.Drawing.Point(6, 593);
            this.PanBotones.Controls.SetChildIndex(this.LblIGV, 0);
            this.PanBotones.Controls.SetChildIndex(this.TxtTotalLetra, 0);
            this.PanBotones.Controls.SetChildIndex(this.TxtSubTotal, 0);
            this.PanBotones.Controls.SetChildIndex(this.TxtIGV, 0);
            this.PanBotones.Controls.SetChildIndex(this.TxtTotal, 0);
            this.PanBotones.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.PanBotones.Controls.SetChildIndex(this.BtnPagoLetras, 0);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(7, 29);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 8);
            // 
            // GroupTipo
            // 
            this.GroupTipo.Size = new System.Drawing.Size(134, 39);
            // 
            // RdbFactura
            // 
            this.RdbFactura.Location = new System.Drawing.Point(69, 16);
            this.RdbFactura.CheckedChanged += new System.EventHandler(this.RdbFactura_CheckedChanged);
            // 
            // RdbBoleta
            // 
            this.RdbBoleta.Location = new System.Drawing.Point(8, 16);
            this.RdbBoleta.CheckedChanged += new System.EventHandler(this.RdbBoleta_CheckedChanged);
            // 
            // DgvDetalleVentas
            // 
            this.DgvDetalleVentas.AllowUserToAddRows = false;
            this.DgvDetalleVentas.AllowUserToDeleteRows = false;
            this.DgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleVentas.Location = new System.Drawing.Point(7, 10);
            this.DgvDetalleVentas.Name = "DgvDetalleVentas";
            this.DgvDetalleVentas.ReadOnly = true;
            this.DgvDetalleVentas.Size = new System.Drawing.Size(661, 147);
            this.DgvDetalleVentas.TabIndex = 0;
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.BackColor = System.Drawing.Color.SandyBrown;
            this.TxtCodCliente.Location = new System.Drawing.Point(123, 32);
            this.TxtCodCliente.MaxLength = 6;
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(217, 20);
            this.TxtCodCliente.TabIndex = 10;
            this.TxtCodCliente.Leave += new System.EventHandler(this.TxtCodCliente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Codigo de Cliente :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "DNI:";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Enabled = false;
            this.TxtDNI.Location = new System.Drawing.Point(123, 58);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(217, 20);
            this.TxtDNI.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nombre Completo:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(123, 84);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(217, 20);
            this.TxtNombre.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Direccion:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Enabled = false;
            this.TxtDireccion.Location = new System.Drawing.Point(440, 32);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(217, 20);
            this.TxtDireccion.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(440, 58);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 20);
            this.TxtEmail.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefono:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Enabled = false;
            this.TxtTelefono.Location = new System.Drawing.Point(440, 84);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(217, 20);
            this.TxtTelefono.TabIndex = 21;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.BackColor = System.Drawing.Color.SandyBrown;
            this.TxtCodProducto.Location = new System.Drawing.Point(125, 13);
            this.TxtCodProducto.MaxLength = 5;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(213, 20);
            this.TxtCodProducto.TabIndex = 12;
            this.TxtCodProducto.Text = "P";
            this.TxtCodProducto.TextChanged += new System.EventHandler(this.TxtCodProducto_TextChanged);
            this.TxtCodProducto.Leave += new System.EventHandler(this.TxtCodProducto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Codigo de Producto :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Serie:";
            // 
            // TxtModelo
            // 
            this.TxtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtModelo.Enabled = false;
            this.TxtModelo.Location = new System.Drawing.Point(126, 105);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(213, 20);
            this.TxtModelo.TabIndex = 88;
            // 
            // TxtMarca
            // 
            this.TxtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Location = new System.Drawing.Point(125, 72);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(213, 20);
            this.TxtMarca.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Modelo:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(438, 13);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(217, 20);
            this.TxtPrecio.TabIndex = 85;
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProducto.Enabled = false;
            this.TxtProducto.Location = new System.Drawing.Point(125, 43);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(214, 20);
            this.TxtProducto.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Producto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 82;
            this.label13.Text = "Marca:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(366, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 81;
            this.label19.Text = "Precio: ";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.Location = new System.Drawing.Point(438, 42);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(217, 20);
            this.TxtDescripcion.TabIndex = 91;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(364, 46);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 92;
            this.label20.Text = "Descripcion: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(364, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 93;
            this.label21.Text = "Cantidad:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCantidad.Location = new System.Drawing.Point(438, 92);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(217, 20);
            this.TxtCantidad.TabIndex = 94;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(438, 118);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(215, 34);
            this.BtnAgregar.TabIndex = 95;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // CboSeries
            // 
            this.CboSeries.FormattingEnabled = true;
            this.CboSeries.Location = new System.Drawing.Point(126, 131);
            this.CboSeries.Name = "CboSeries";
            this.CboSeries.Size = new System.Drawing.Size(213, 21);
            this.CboSeries.TabIndex = 96;
            this.CboSeries.SelectedIndexChanged += new System.EventHandler(this.CboSeries_SelectedIndexChanged);
            // 
            // BtnPagoLetras
            // 
            this.BtnPagoLetras.Location = new System.Drawing.Point(249, 29);
            this.BtnPagoLetras.Name = "BtnPagoLetras";
            this.BtnPagoLetras.Size = new System.Drawing.Size(171, 49);
            this.BtnPagoLetras.TabIndex = 20;
            this.BtnPagoLetras.Text = "Pago en Letras";
            this.BtnPagoLetras.UseVisualStyleBackColor = true;
            this.BtnPagoLetras.Click += new System.EventHandler(this.BtnPagoLetras_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(364, 72);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 97;
            this.label22.Text = "Stock:";
            // 
            // TxtStock
            // 
            this.TxtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(438, 66);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(217, 20);
            this.TxtStock.TabIndex = 98;
            // 
            // T
            // 
            this.T.Controls.Add(this.RdbContado);
            this.T.Controls.Add(this.RdbCredito);
            this.T.Location = new System.Drawing.Point(484, 89);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(161, 39);
            this.T.TabIndex = 28;
            this.T.TabStop = false;
            this.T.Text = "Tipo de Pago";
            // 
            // RdbContado
            // 
            this.RdbContado.AutoSize = true;
            this.RdbContado.Checked = true;
            this.RdbContado.Location = new System.Drawing.Point(70, 16);
            this.RdbContado.Name = "RdbContado";
            this.RdbContado.Size = new System.Drawing.Size(65, 17);
            this.RdbContado.TabIndex = 1;
            this.RdbContado.TabStop = true;
            this.RdbContado.Text = "Contado";
            this.RdbContado.UseVisualStyleBackColor = true;
            // 
            // RdbCredito
            // 
            this.RdbCredito.AutoSize = true;
            this.RdbCredito.Location = new System.Drawing.Point(6, 16);
            this.RdbCredito.Name = "RdbCredito";
            this.RdbCredito.Size = new System.Drawing.Size(58, 17);
            this.RdbCredito.TabIndex = 0;
            this.RdbCredito.Text = "Credito";
            this.RdbCredito.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Buscar por DNI:";
            // 
            // TxtDNIBusqueda
            // 
            this.TxtDNIBusqueda.Location = new System.Drawing.Point(123, 6);
            this.TxtDNIBusqueda.Name = "TxtDNIBusqueda";
            this.TxtDNIBusqueda.Size = new System.Drawing.Size(177, 20);
            this.TxtDNIBusqueda.TabIndex = 24;
            // 
            // BtnBuscarDNI
            // 
            this.BtnBuscarDNI.Location = new System.Drawing.Point(306, 6);
            this.BtnBuscarDNI.Name = "BtnBuscarDNI";
            this.BtnBuscarDNI.Size = new System.Drawing.Size(35, 21);
            this.BtnBuscarDNI.TabIndex = 25;
            this.BtnBuscarDNI.Text = "IR";
            this.BtnBuscarDNI.UseVisualStyleBackColor = true;
            this.BtnBuscarDNI.Click += new System.EventHandler(this.BtnBuscarDNI_Click);
            // 
            // BtnAgregarNuevoCliente
            // 
            this.BtnAgregarNuevoCliente.Enabled = false;
            this.BtnAgregarNuevoCliente.Location = new System.Drawing.Point(440, 2);
            this.BtnAgregarNuevoCliente.Name = "BtnAgregarNuevoCliente";
            this.BtnAgregarNuevoCliente.Size = new System.Drawing.Size(217, 26);
            this.BtnAgregarNuevoCliente.TabIndex = 26;
            this.BtnAgregarNuevoCliente.Text = "Agregar Cliente Nuevo";
            this.BtnAgregarNuevoCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarNuevoCliente.Click += new System.EventHandler(this.BtnAgregarNuevoCliente_Click);
            // 
            // FrmDocVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(690, 682);
            this.Name = "FrmDocVenta";
            this.Text = "FrmDocVenta";
            this.PanDetalleProductos.ResumeLayout(false);
            this.PanProductos.ResumeLayout(false);
            this.PanProductos.PerformLayout();
            this.PanCliente.ResumeLayout(false);
            this.PanCliente.PerformLayout();
            this.PanDetalleDoc.ResumeLayout(false);
            this.PanDetalleDoc.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupTipo.ResumeLayout(false);
            this.GroupTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVentas)).EndInit();
            this.T.ResumeLayout(false);
            this.T.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetalleVentas;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox CboSeries;
        private System.Windows.Forms.Button BtnPagoLetras;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox T;
        private System.Windows.Forms.RadioButton RdbContado;
        private System.Windows.Forms.RadioButton RdbCredito;
        private System.Windows.Forms.Button BtnAgregarNuevoCliente;
        private System.Windows.Forms.Button BtnBuscarDNI;
        private System.Windows.Forms.TextBox TxtDNIBusqueda;
        private System.Windows.Forms.Label label17;
    }
}
