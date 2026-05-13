namespace LibFormularios
{
    partial class FrmPagoLetras
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
            this.components = new System.ComponentModel.Container();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNroCuotas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNroDocCredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnVerDocVenta = new System.Windows.Forms.Button();
            this.DgvDetalleLetras = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.dtpFechaFinalPago = new System.Windows.Forms.DateTimePicker();
            this.PanTitulo.SuspendLayout();
            this.PanDataView.SuspendLayout();
            this.PanDatos.SuspendLayout();
            this.PanBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleLetras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "REGISTRO DE PAGO EN LETRAS";
            // 
            // PanDataView
            // 
            this.PanDataView.Controls.Add(this.DgvDetalleLetras);
            this.PanDataView.Dock = System.Windows.Forms.DockStyle.None;
            this.PanDataView.Location = new System.Drawing.Point(0, 385);
            this.PanDataView.Size = new System.Drawing.Size(703, 255);
            // 
            // PanDatos
            // 
            this.PanDatos.Controls.Add(this.dtpFechaFinalPago);
            this.PanDatos.Controls.Add(this.TxtSaldo);
            this.PanDatos.Controls.Add(this.label12);
            this.PanDatos.Controls.Add(this.TxtMontoTotal);
            this.PanDatos.Controls.Add(this.label11);
            this.PanDatos.Controls.Add(this.label10);
            this.PanDatos.Controls.Add(this.TxtMonto);
            this.PanDatos.Controls.Add(this.label9);
            this.PanDatos.Controls.Add(this.BtnVerDocVenta);
            this.PanDatos.Controls.Add(this.label8);
            this.PanDatos.Controls.Add(this.BtnBuscar);
            this.PanDatos.Controls.Add(this.TxtDNI);
            this.PanDatos.Controls.Add(this.TxtEstado);
            this.PanDatos.Controls.Add(this.label7);
            this.PanDatos.Controls.Add(this.TxtObservaciones);
            this.PanDatos.Controls.Add(this.label6);
            this.PanDatos.Controls.Add(this.TxtFecha);
            this.PanDatos.Controls.Add(this.label5);
            this.PanDatos.Controls.Add(this.TxtNroCuotas);
            this.PanDatos.Controls.Add(this.label4);
            this.PanDatos.Controls.Add(this.TxtDocVenta);
            this.PanDatos.Controls.Add(this.label2);
            this.PanDatos.Controls.Add(this.TxtNroDocCredito);
            this.PanDatos.Controls.Add(this.label3);
            this.PanDatos.Location = new System.Drawing.Point(0, 60);
            this.PanDatos.Size = new System.Drawing.Size(703, 228);
            // 
            // PanBotones
            // 
            this.PanBotones.Location = new System.Drawing.Point(0, 294);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(440, 170);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(251, 20);
            this.TxtEstado.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Estado:";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(394, 65);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(297, 82);
            this.TxtObservaciones.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Observaciones:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(500, 20);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(191, 20);
            this.TxtFecha.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fecha:";
            // 
            // TxtNroCuotas
            // 
            this.TxtNroCuotas.Location = new System.Drawing.Point(124, 104);
            this.TxtNroCuotas.MaxLength = 1;
            this.TxtNroCuotas.Name = "TxtNroCuotas";
            this.TxtNroCuotas.Size = new System.Drawing.Size(200, 20);
            this.TxtNroCuotas.TabIndex = 41;
            this.TxtNroCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroCuotas_KeyPress);
            this.TxtNroCuotas.Leave += new System.EventHandler(this.TxtNroCuotas_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "N° Cuotas";
            // 
            // TxtDocVenta
            // 
            this.TxtDocVenta.Location = new System.Drawing.Point(124, 72);
            this.TxtDocVenta.Name = "TxtDocVenta";
            this.TxtDocVenta.Size = new System.Drawing.Size(200, 20);
            this.TxtDocVenta.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "N°  Venta:";
            // 
            // TxtNroDocCredito
            // 
            this.TxtNroDocCredito.BackColor = System.Drawing.Color.SandyBrown;
            this.TxtNroDocCredito.Location = new System.Drawing.Point(124, 46);
            this.TxtNroDocCredito.MaxLength = 11;
            this.TxtNroDocCredito.Name = "TxtNroDocCredito";
            this.TxtNroDocCredito.Size = new System.Drawing.Size(200, 20);
            this.TxtNroDocCredito.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "N° Venta Credito:";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(124, 10);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(200, 20);
            this.TxtDNI.TabIndex = 48;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(347, 4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(140, 30);
            this.BtnBuscar.TabIndex = 49;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "DNI del Cliente:";
            // 
            // BtnVerDocVenta
            // 
            this.BtnVerDocVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerDocVenta.Location = new System.Drawing.Point(330, 72);
            this.BtnVerDocVenta.Name = "BtnVerDocVenta";
            this.BtnVerDocVenta.Size = new System.Drawing.Size(37, 20);
            this.BtnVerDocVenta.TabIndex = 51;
            this.BtnVerDocVenta.Text = "VER";
            this.BtnVerDocVenta.UseVisualStyleBackColor = true;
            this.BtnVerDocVenta.Click += new System.EventHandler(this.BtnVerDocVenta_Click);
            // 
            // DgvDetalleLetras
            // 
            this.DgvDetalleLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleLetras.Location = new System.Drawing.Point(12, 13);
            this.DgvDetalleLetras.Name = "DgvDetalleLetras";
            this.DgvDetalleLetras.Size = new System.Drawing.Size(679, 230);
            this.DgvDetalleLetras.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Monto a Pagar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Fecha de Pago:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Monto Total:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Location = new System.Drawing.Point(124, 197);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.Size = new System.Drawing.Size(200, 20);
            this.TxtMontoTotal.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(374, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Saldo:";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(440, 197);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(251, 20);
            this.TxtSaldo.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(1, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 46);
            this.panel1.TabIndex = 4;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(536, 13);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(145, 20);
            this.TxtTotal.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total:";
            // 
            // Timer2
            // 
            this.Timer2.Enabled = true;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(124, 134);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(200, 20);
            this.TxtMonto.TabIndex = 53;
            // 
            // dtpFechaFinalPago
            // 
            this.dtpFechaFinalPago.Location = new System.Drawing.Point(124, 169);
            this.dtpFechaFinalPago.Name = "dtpFechaFinalPago";
            this.dtpFechaFinalPago.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinalPago.TabIndex = 60;
            // 
            // FrmPagoLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(703, 688);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPagoLetras";
            this.Text = "Pago en letras";
            this.Controls.SetChildIndex(this.PanTitulo, 0);
            this.Controls.SetChildIndex(this.PanDataView, 0);
            this.Controls.SetChildIndex(this.PanDatos, 0);
            this.Controls.SetChildIndex(this.PanBotones, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.PanTitulo.ResumeLayout(false);
            this.PanDataView.ResumeLayout(false);
            this.PanDatos.ResumeLayout(false);
            this.PanDatos.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleLetras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetalleLetras;
        private System.Windows.Forms.Button BtnVerDocVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNroCuotas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNroDocCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalPago;
        private System.Windows.Forms.TextBox TxtMonto;
    }
}
